using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FacebookMessengerBot : Form
    {
        public FacebookMessengerBot()
        {
            MessageBox.Show("Please install Node.js 6.9 or newer.");
            Tool.installLibraries(Application.StartupPath);
            Tool.createBotJs();
            Tool.createRunFbChatJsBat();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            User.getInstance().userName = ((TextBox)sender).Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            User.getInstance().password = ((TextBox)sender).Text;
        }

        private void minTimeDelay_TextChanged(object sender, EventArgs e)
        {
            int minTimeDelay;
            if(!int.TryParse(((TextBox)sender).Text, out minTimeDelay))
            {
                if(((TextBox)sender).Text!="")MessageBox.Show("Please input integer");
                ((TextBox)sender).Text = "";
                return;
            }
            User.getInstance().minTimeDelay = minTimeDelay;
        }

        private void maxTimeDelay_TextChanged(object sender, EventArgs e)
        {
            int maxTimeDelay;
            if (!int.TryParse(((TextBox)sender).Text, out maxTimeDelay))
            {
                if (((TextBox)sender).Text != "") MessageBox.Show("Please input integer");
                ((TextBox)sender).Text = "";
                return;
            }
            User.getInstance().maxTimeDelay = maxTimeDelay;
        }

        private void startTime_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length != 5) return;//If the time string has not been completed - does not conform to format HH:MM
            var regex = new Regex(@"\d{2}:\d{2}");
            if (!regex.IsMatch(((TextBox)sender).Text))
            {
                MessageBox.Show("not valid");
                return;
            }
            string[] startTimeParts = ((TextBox)sender).Text.Split(':');
            User.getInstance().startHour = Convert.ToInt32(startTimeParts[0]);
            User.getInstance().startMinute = Convert.ToInt32(startTimeParts[1]);
        }

        private void endTime_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length != 5) return;//If the time string has not been completed - does not conform to format HH:MM
            var regex = new Regex(@"\d{2}:\d{2}");
            if (!regex.IsMatch(((TextBox)sender).Text))
            {
                MessageBox.Show("not valid");
                return;
            }
            string[] endTimeParts = ((TextBox)sender).Text.Split(':');
            User.getInstance().endHour = Convert.ToInt32(endTimeParts[0]);
            User.getInstance().endMinute = Convert.ToInt32(endTimeParts[1]);
        }

        private void text_TextChanged(object sender, EventArgs e)
        {           
            User.getInstance().text = ((TextBox)sender).Text;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //Error checking
            if(userName.Text.Length==0||password.Text.Length == 0 ||
               minTimeDelay.Text.Length == 0 ||maxTimeDelay.Text.Length == 0||
               startTime.Text.Length!=5||endTime.Text.Length!=5||
               fileLoadedLabel.Text=="No loaded file"||text.Text=="")
            {
                MessageBox.Show("Please complete all information before sending!");
                return;
            }

            User user = User.getInstance();
            if (!user.checkTime())
            {
                MessageBox.Show("Not in sent time zone!");
                return;
            }

            summaryBox.Text = "";

            foreach(string _targetID in user.targetID) {
                Thread.Sleep(user.random.Next(user.minTimeDelay*1000,user.maxTimeDelay*1000));
                Process proc = null;
                try
                {
                    string batDir = string.Format(Application.StartupPath);
                    string _userName = user.userName;
                    string _passWord = user.password;
                    string _message = user.spintax();
                    //string _csvAddress = fileLoadedLabel.Text;
                    proc = new Process();
                    proc.StartInfo.WorkingDirectory = batDir;
                    proc.StartInfo.FileName = "RunFBCHAT.bat";
                    proc.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\"", _userName, _passWord, _message, _targetID);
                    proc.StartInfo.CreateNoWindow = false;
                    proc.Start();
                    proc.WaitForExit();
                    summaryBox.AppendText("Time:" + DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "\r\n" + "Sent to:" + _targetID + "\r\n\r\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }

            summaryBox.AppendText("Finished!");
            
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                User.getInstance().readFile(openFileDialog1.FileName);
            }
            fileLoadedLabel.Text = openFileDialog1.FileName;
        }


    }
}
