using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string urlAddress;
        private bool isGenerated = false;


        public Form1()
        {
            installLibraries();
            InitializeComponent(); 
        }

        private void urlAddressBox_TextChanged(object sender, EventArgs e)
        {
            this.urlAddress = ((TextBox)sender).Text;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (urlAddressBox.Text == "")
            {
                MessageBox.Show("Please enter url first before generating IDs.");
                return;
            }
            Process proc = null;
            statusLabel.Text = "Generating....";
            try
            {
                string batDir = string.Format(Application.StartupPath);
                proc = new Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "run.bat";
                proc.StartInfo.Arguments = string.Format("\"{0}\"", urlAddress);
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
            isGenerated = true;
            statusLabel.Text = "Done!";
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if(urlAddressBox.Text=="")
            {
                MessageBox.Show("Please enter url first before generating IDs.");
                return;
            }
            if(!isGenerated)
            {
                MessageBox.Show("Please generate IDs before opening destination folder.");
            }
            Process.Start(new ProcessStartInfo()
            {
                FileName = string.Format(Application.StartupPath),
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void installLibraries()
        {
            if(Directory.Exists(string.Format(Application.StartupPath)+"/node_modules"))
            {
                return;
            }
            Process proc = null;
            try
            {
                string batDir = string.Format(Application.StartupPath);
                proc = new Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "installLibraries.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }
    }
}
