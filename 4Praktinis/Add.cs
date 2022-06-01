using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Praktinis
{
    public partial class Add : Form
    {
        Pagrindinis pgr;
        public Add(Pagrindinis currentForm)
        {
            pgr = currentForm;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_pav.Text) && !String.IsNullOrEmpty(textBox_password.Text) && !String.IsNullOrEmpty(textBox_username.Text) && !String.IsNullOrEmpty(textBox_url.Text) && !String.IsNullOrEmpty(textBox_comment.Text))
            {
                string pass = AES.AES_EncryptString(textBox_password.Text);
                if (pgr.passwordsList == null) pgr.passwordsList = new List<PasswordsData>();
                pgr.passwordsList.Add(new PasswordsData(textBox_pav.Text, textBox_username.Text, pass, textBox_url.Text, textBox_comment.Text));
                pgr.LoadInfo(pgr.passwordsList);
                MessageBox.Show("Slaptažodis Išsaugotas");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ne visi laukai užpildyti!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
