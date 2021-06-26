using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ThucTapCM
{
    public partial class ForgotPassWord : Form
    {
        String randomCode;
        public static string to;
        public ForgotPassWord()
        {
            InitializeComponent();
        }

        private void notification_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtGmail.Text.Trim() == "" || txtGmail.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thiếu thông tin");
            }
            else
            {
                Regex mRegxExpression;
                if (txtGmail.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]

                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|

                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtGmail.Text.Trim()))
                    {
                        txtGmail.Focus();
                    }
                    else
                    {
                        string from, pass, messageBody;
                        Random random = new Random();
                        randomCode = (random.Next(999999)).ToString();
                        MailMessage mailMessage = new MailMessage();
                        to = (txtGmail.Text).ToString();
                        from = "nguyensongnganthefirst@gmail.com";
                        pass = "ngannganuuuu";
                        messageBody = "Your reset code is : " + randomCode;
                        mailMessage.To.Add(to);
                        mailMessage.From = new MailAddress(from);
                        mailMessage.Body = messageBody;
                        mailMessage.Subject = "password resetting code";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        try
                        {
                            string query = "select ";
                            smtp.Send(mailMessage);
                            notification.Text = "Code send successfully!";

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(randomCode ==(txtCode.Text).ToString())
            {
                to = txtGmail.Text;
                btnReset resetPassword = new btnReset();
                this.Hide();
                resetPassword.Show();

            }
            else
            {
                MessageBox.Show("Wrong code !");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtPassWord form1 = new txtPassWord();
            this.Hide();
            form1.ShowDialog();
            
        }

        private void txtGmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtGmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]
                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|
                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(txtGmail.Text.Trim()))
                {
                    MessageBox.Show("Lỗi định dạng email", "Lỗi");
                    txtGmail.Focus();
                }
            }
        }
    }
}
