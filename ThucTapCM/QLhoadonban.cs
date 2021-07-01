using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Threading;
using System.Threading.Tasks;
using ThucTapCM.DAO;

namespace ThucTapCM
{
    public partial class QLhoadonban : Form
    {
        public SpeechRecognitionEngine recognizer;
        public Grammar grammar;
        public Thread RecThead;
        public Boolean RecognizerState = true;
        public static int MaHDX;
        public QLhoadonban()
        {
            InitializeComponent();
        }

        private void btnXCT_Click(object sender, EventArgs e)
        {
            FormXuatHoaDonReport xuatHoaDonReport = new FormXuatHoaDonReport();
            this.Hide();
            xuatHoaDonReport.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            QuetmaQR quetmaQR = new QuetmaQR();
            this.Hide();
            quetmaQR.Show();
        }
        int voice = 0;
        public void RecTheadFuntion()
        {
            //thực hiện nhận diện giọng nói
            while (true)
            {
                try
                {
                    recognizer.Recognize();
                }
                catch
                {

                }
            }
        }
        private void picvoice_Click(object sender, EventArgs e)
        {
            voice++;
            if (voice % 2 == 0)
            {
                RecognizerState = false;
                //btnMute.Image = Image.FromFile("..//..//..//..//image//icons8-mute-unmute-100.png");
            }
            else if (voice % 2 == 1)
            {
                //btnMute.Image = Image.FromFile("..//..//..//..//image//icons8-microphone-100.png");
                RecognizerState = true;
            }
        }

        private void QLhoadonban_Load(object sender, EventArgs e)
        {
            GrammarBuilder builde = new GrammarBuilder();
            builde.AppendDictation();
            grammar = new Grammar(builde);

            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(grammar);
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);


            RecognizerState = false;
            RecThead = new Thread(new ThreadStart(RecTheadFuntion));
            RecThead.Start();

            string hd = "execute QLHDB1";
            DataTable gvql = DataProvider.Instance.ExecuteQuery(hd);
            gvHDBH.DataSource = gvql;
            lbMahd.Visible = false;
        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (!RecognizerState)
                return;
            this.Invoke((MethodInvoker)delegate
            {
                txtseach.Text += ("" + e.Result.Text.ToUpper());
            });
        }

        private void QLhoadonban_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecThead.Abort();
            RecThead = null;
            recognizer.UnloadAllGrammars();
            recognizer.Dispose();
            grammar = null;
        }

        private void gvHDBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvHDBH.CurrentRow.Index;
            lbMahd.Text = gvHDBH.Rows[r].Cells[0].Value.ToString();
            MaHDX = Convert.ToInt32(lbMahd.Text);
        }

        private void txtseach_OnValueChanged(object sender, EventArgs e)
        {
            string seach = "execute SeachHDB @Tenma ";
            DataTable gvseach = DataProvider.Instance.ExecuteQuery(seach , new object[] {txtseach.Text});
            gvHDBH.DataSource = gvseach;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }

}
