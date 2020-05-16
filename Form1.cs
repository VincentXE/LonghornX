using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace LonghornX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) => Close();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

         // About Longhorn Button
        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Longhorn X is a Windows Debloater made by VincentXII. \nPlease read the included README.md for more information", "Longhorn X Information");
        }

        // Changelog Button
        private void button13_Click(object sender, EventArgs e)
        {
            // Super Janky way of getting the changelog.md file. Maybe clean up in future?
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(_filePath).FullName;
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\CHANGELOG.MD";
            Process.Start("notepad.exe", _filePath);
        }
    }
}
