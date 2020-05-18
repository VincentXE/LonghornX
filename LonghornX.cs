using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Text;

namespace LonghornX
{
    public partial class LonghornX : Form
    {
        public LonghornX()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // "Windows Information" Button
        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("winver.exe");
        }
        // Setup Longhorn Button
        private void button8_Click(object sender, EventArgs e)
        {
            // Run setup.ps1 
             var longhornSetup = new ProcessStartInfo()
             {
                 FileName = "powershell.exe",
                 Arguments = $"-ExecutionPolicy Unrestricted  \"" + Encoding.Default.GetString(Properties.Resources.setup) + "\"",
                 UseShellExecute = false
             };
            // This handles it completing 
            var setupProcess = Process.Start(longhornSetup);
            setupProcess.EnableRaisingEvents = true;
            setupProcess.Exited += (sender, e) => {MessageBox.Show("Setup Complete", "Success" );};
        }

    // Exit Longhorn Button
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

         // "About Longhorn" Button
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
