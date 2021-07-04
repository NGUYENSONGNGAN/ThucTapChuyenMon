using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;


namespace ChatKhachHang
{
    public partial class Form1 : Form
    {
        int id = FromloginCurtom.id;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            //ip địa chỉ của server


            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1997);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {

                client.Connect(IP);

            }
            catch
            {
                MessageBox.Show("Không thể kết nối sever", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Send()
        {
            if (txtTypeClient.Text != string.Empty)
            {
                string selectname = "select TenKH from KhachHang where  MaKH= '" + id + "' ";
                string Ten = DataProvider.Instance.ExecuteScalar(selectname).ToString();
                client.Send(Serialize(Ten.ToString() + ": " + txtTypeClient.Text));
            }
        }


        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deseriliaze(data);
                    AddMessage(message);
                }
            }
            catch
            {
                client.Close();
            }
        }

        void AddMessage(string s)
        {
            lbmessageClient.Items.Add(new ListViewItem() { Text = s });
            txtTypeClient.Clear();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deseriliaze(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }


        private void txtTypeClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendClient.PerformClick();
                txtTypeClient.Focus();
                txtTypeClient.ResetText();
            }
        }

        private void btnSendClient_Click(object sender, EventArgs e)
        {
            Send();
            string selectname = "select TenKH from KhachHang where  MaKH= '" + id + "' ";
            string Ten = DataProvider.Instance.ExecuteScalar(selectname).ToString();
            AddMessage(Ten.ToString()+": " + txtTypeClient.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* KhachHang KH = dt.KhachHangs.Where(s => s.Ma == Convert.ToInt32(FormDangNhapClient.TTKH.MaKH)).FirstOrDefault();
           lbTitle.Text = KH.Ten;*/
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
