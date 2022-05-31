using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using BCrypt.Net;

namespace _4Praktinis
{
    public partial class Form1 : Form
    {
        List<Users.UserList> users = new List<Users.UserList>();
        public Form1()
        {
            InitializeComponent();
            panel_Prisijungimas.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Prisijungimas.Visible = true;
            panel_Registracija.Visible = false;
        }

        private void button_REGISTRACIJA_Click(object sender, EventArgs e)
        {
            panel_Prisijungimas.Visible = false;
            panel_Registracija.Visible = true;
        }

        private void button_PRISIJUNGTI_Click(object sender, EventArgs e)
        {
            Users.Root users = null;
            Users.UserList currUser = new Users.UserList();
            using (StreamReader file = File.OpenText(@"Users.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                users = (Users.Root)serializer.Deserialize(file, typeof(Users.Root));
                string name = textBox_pri_username.Text;
                string pwd = textBox_pri_password.Text;

                currUser = users.userInfo.userList.Find(x => x.name == name && BCrypt.Net.BCrypt.Verify(pwd, x.password));
                if (currUser != null)
                {
                    Pagrindinis form = new Pagrindinis(name);
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Toks vartotojas neegzistuoja.");
                }
            }
        }

        private void button_REGISTRUOTIS_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"Users.json"))
            {
                Users.Root root = new Users.Root();
                Users.UserList userList = new Users.UserList();
                Users.UserInfo userInfo = new Users.UserInfo();
                userInfo.totalUsers = 1;
                userList.id = 1;
                userList.name = textBox_reg_username.Text;
                userList.password = BCrypt.Net.BCrypt.HashPassword(textBox_reg_password.Text);
                users.Add(userList);
                userInfo.userList = users;
                root.userInfo = userInfo;

                using (StreamWriter file = File.CreateText(@"Users.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, root);
                }
            }
            else
            {
                Users.Root users;
                using (StreamReader file = File.OpenText(@"Users.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    users = (Users.Root)serializer.Deserialize(file, typeof(Users.Root));
                    users.userInfo.totalUsers++;
                    Users.UserList userList = new Users.UserList();
                    userList.id = users.userInfo.totalUsers;
                    userList.name = textBox_reg_username.Text;
                    userList.password = BCrypt.Net.BCrypt.HashPassword(textBox_reg_password.Text);
                    users.userInfo.userList.Add(userList);
                }

                using (StreamWriter file = File.CreateText(@"Users.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, users);
                }
            }

            MessageBox.Show("Registracija Sėkminga!");
            panel_Prisijungimas.Visible = true;
            panel_Registracija.Visible = false;
        }
    }
}
