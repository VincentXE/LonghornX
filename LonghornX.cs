using System;
using System.Windows.Forms;
using System.Diagnostics;
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
            MessageBox.Show("Longhorn X is a Windows Debloater made by VincentXII. \nPlease read the included README.md for more information\n View Source Code at github.com/VincentXII/LonghornX", "Longhorn X Information");
        }

        // Changelog Button
        private void button13_Click(object sender, EventArgs e)
        {
            // Shows CHANGELOG.md in a message box
            string changelogShow = Encoding.Default.GetString(Properties.Resources.CHANGELOG);
            MessageBox.Show(changelogShow);
        }
        //Create Restore Point Button
        private void button11_Click(object sender, EventArgs e)
        {
            var longhornRestorePoint = new ProcessStartInfo()
            {
                FileName = "powershell.exe", 
                Arguments = $" \"" + Encoding.Default.GetString(Properties.Resources.createResP) + "\"",
                UseShellExecute = false
            };
            // This handles it completing 
            var setupProcess = Process.Start(longhornRestorePoint);
            setupProcess.EnableRaisingEvents = true; setupProcess.Exited += (sender, e) => { MessageBox.Show("Setup Complete", "Success"); };
        }
        // Removed Onedrive button
        private void button4_Click(object sender, EventArgs e)
        {
            var onedriveRemove = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $" -noexit -ExecutionPolicy Unrestricted  \"" + Encoding.Default.GetString(Properties.Resources.remove_onedrive) + "\"",
                UseShellExecute = false
            };
            // This handles it completing 
            var setupProcess = Process.Start(onedriveRemove);
            setupProcess.EnableRaisingEvents = true; setupProcess.Exited += (sender, e) => { MessageBox.Show("Setup Complete", "Success"); };
        }
    }
}
