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
    public partial class Pagrindinis : Form
    {
        string username;
        public Pagrindinis(string name)
        {
            InitializeComponent();
            this.username = name;
        }

        private void Pagrindinis_Load(object sender, EventArgs e)
        {

        }
    }
}
