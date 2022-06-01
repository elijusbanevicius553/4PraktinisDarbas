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
    public partial class Delete : Form
    {
        List<PasswordsData> passwordList = new List<PasswordsData>();
        Pagrindinis currentForm;
        public Delete(List<PasswordsData> pList, Pagrindinis form)
        {
            passwordList = pList;
            currentForm = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordsData find = null;
            find = passwordList.FirstOrDefault(x => x.name == textBox_pavadinimas.Text);
            if (find != null)
            {
                currentForm.passwordsList.Remove(find);
                currentForm.LoadInfo(currentForm.passwordsList);
                MessageBox.Show("Removed");
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
