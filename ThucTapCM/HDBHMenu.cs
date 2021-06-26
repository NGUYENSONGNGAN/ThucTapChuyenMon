using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCM
{
    public partial class HDBHMenu : Form
    {
        public HDBHMenu()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            CreateCurtomer create = new CreateCurtomer();
            this.Hide();
            create.Show();

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            CurtomerCheck curtomerCheck = new CurtomerCheck();
            this.Hide();
            curtomerCheck.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
