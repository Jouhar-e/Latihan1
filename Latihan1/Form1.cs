using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string nama = "aku";
            //int a = 6;
            //int b = 5;
            //int c = a * b;
            //MessageBox.Show(nama + c);
            string user = "admin";
            string pass = "123";

            if (user == "admin" && pass == "123")
            {
                MessageBox.Show("Berhasil Login");
            }
            else
            {
                MessageBox.Show("User atau Pass Salah");
            }
        }
    }
}
