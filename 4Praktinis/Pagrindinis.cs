using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _4Praktinis
{
    public partial class Pagrindinis : Form
    {
        public List<PasswordsData> passwordsList = new List<PasswordsData>();
        public List<PasswordsData> nowList = new List<PasswordsData>();
        bool passwordsShown = false;
        string username;
        public Pagrindinis(string name)
        {
            this.username = name;
            CheckCSVFile();
            InitializeComponent();
            LoadInfo(passwordsList);
            nowList = passwordsList;

        }

        private void Pagrindinis_Load(object sender, EventArgs e)
        {

        }

        private void button_atsijungti_Click(object sender, EventArgs e)
        {
            LoadInfo(passwordsList);
            nowList = passwordsList;
            if (passwordsList != null)
            {
                onAppExit();
            }
            AES.AES_EncryptFile($@"passwords_{username}.csv", $@"passwords_{username}.enc");
            File.Delete($@"passwords_{username}.csv");
            this.Close();
            Application.Exit();
        }

        void CheckCSVFile()
        {
            if (!File.Exists($@"passwords_{username}.enc"))
            {
                if (!File.Exists($@"passwords_{username}.csv"))
                {
                    var myFile = File.Create($@"passwords_{username}.csv");
                    myFile.Close();

                }


            }
            else
            {

                AES.AES_DecryptFile($@"passwords_{username}.enc", $@"passwords_{username}.csv");
                File.Delete($@"passwords_{username}.enc");
                if (new FileInfo($@"passwords_{username}.csv").Length != 0)
                {
                    using (var reader = new StreamReader($@"passwords_{username}.csv"))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        while (csv.Read())
                            passwordsList.Add(csv.GetRecord<PasswordsData>());
                    }
                    if (passwordsList[0] == null)
                    {
                        passwordsList = null;
                    }
                }
            }
        }

        public void LoadInfo(List<PasswordsData> passlist)
        {
            listBox_data.Items.Clear();
            if (passlist != null)
            {
                foreach (PasswordsData pass in passlist)
                {

                    listBox_data.Items.Add(pass);
                }
            }
        }

        public void onAppExit()
        {
            LoadInfo(passwordsList);
            nowList = passwordsList;

            if (passwordsShown)
            {
                foreach (PasswordsData pass in nowList)
                {
                    pass.password = AES.AES_EncryptString(pass.password);
                }
            }
            using (var writer = new StreamWriter($@"passwords_{username}.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(passwordsList);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.Show();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(passwordsList, this);
            delete.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Update update = new Update(passwordsList, this);
            update.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!passwordsShown)
            {
                var a = DeepCopy(nowList);
                foreach (var item in a)
                {
                    string v = AES.AES_DecryptString(item.password);
                    item.password = v;
                }
                LoadInfo(a);
                passwordsShown = true;
            }

            else
            {
                var a = DeepCopy(nowList);
                foreach (var item in a)
                {
                    item.password = AES.AES_EncryptString(item.password);
                }
                LoadInfo(nowList);
                passwordsShown = false;


            }
        }
        public static T DeepCopy<T>(T item)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, item);
            stream.Seek(0, SeekOrigin.Begin);
            T result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }

        private void listBox_data_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadInfo(passwordsList);
            nowList = passwordsList;
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = DeepCopy(passwordsList.Where(x => x.name.Equals(textBox1.Text)).ToList());
            if (a.Count() != 0)
            {
                LoadInfo(a);
                nowList = a;
            }
            else
            {
                MessageBox.Show("Nothing found!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string password = "";
            String str = listBox_data.Items[0].ToString();

            string[] stringlist = str.Split('-');

            password = stringlist[2];

            if (!passwordsShown)
                password = AES.AES_DecryptString(password);

            Clipboard.SetText(password);
            MessageBox.Show("Slaptažodis išsaugotas į iškarpinę");
        }
    }
}
