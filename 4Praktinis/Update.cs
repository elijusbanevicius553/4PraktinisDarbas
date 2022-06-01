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
    public partial class Update : Form
    {
        List<PasswordsData> passwordList = new List<PasswordsData>();
        Pagrindinis currentForm;
        public Update(List<PasswordsData> pList, Pagrindinis form)
        {
            passwordList = pList;
            currentForm = form;
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var a = passwordList.Where(x => x.name.Contains(textBox_pavadinimas.Text)).ToList();
            string encPass = AES.AES_EncryptString(textBox_newpassword.Text);
            if (a.Count() != 0)
            {
                foreach (PasswordsData pass in passwordList)
                {
                    if (pass.name.Contains(textBox_newpassword.Text))
                    {
                        pass.password = encPass;
                    }
                }
                currentForm.passwordsList = this.passwordList;
                currentForm.LoadInfo(currentForm.passwordsList);

                MessageBox.Show("UPDATED");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nothing found!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
