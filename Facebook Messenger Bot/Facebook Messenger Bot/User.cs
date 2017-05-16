using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public class User
    {
        string _userName;
        string _password;
        string _text;
        int _minTimeDelay;
        int _maxTimeDelay;
        int _startHour;
        int _endHour;
        int _startMinute;
        int _endMinute;
        int _maxNumMessages;
        static User user;
        static Random _ran;
        List<string> _targetID;

        //Private constructor
        private User()
        {
            userName = "";
            password = "";
            text = "";
            minTimeDelay = 0;
            maxTimeDelay = 3;
            startHour = 0;
            startMinute = 0;
            endHour = 23;
            endMinute = 59;
            maxNumMessages = 1000;
            _ran = new Random();
            _targetID = new List<string>();
        }

        //Singleton
        public static User getInstance()
        {
            if (user == null)
            {
                user = new WindowsFormsApplication2.User();
            }
            return user;
        }

        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        public int minTimeDelay
        {
            get { return _minTimeDelay; }
            set { _minTimeDelay = value; }
        }

        public int maxTimeDelay
        {
            get { return _maxTimeDelay; }
            set { _maxTimeDelay = value; }
        }

        public int startHour
        {
            get { return _startHour; }
            set { _startHour = value; }
        }

        public int endHour
        {
            get { return _endHour; }
            set { _endHour = value; }
        }

        public int startMinute
        {
            get { return _startMinute; }
            set { _startMinute = value; }
        }

        public int endMinute
        {
            get { return _endMinute; }
            set { _endMinute = value; }
        }

        public int maxNumMessages
        {
            get { return _maxNumMessages; }
            set { _maxNumMessages = value; }
        }

        public List<string> targetID
        {
            get { return _targetID; }
        }

        public Random random
        {
            get { return _ran; }
        }

        public string spintax()
        {
            string bracketTemp="";
            string finalSpintax="";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c == '{')
                {
                    int j = i + 1;
                    while (text[j] != '}')
                    {
                        bracketTemp += text[j];
                        j++;
                    }
                    i = j;
                    string[] spintaxes = bracketTemp.Split('|');
                    finalSpintax += spintaxes[random.Next(0, spintaxes.Length)];
                    bracketTemp = "";
                }
                else
                {
                    finalSpintax += c;
                }
            }
            return finalSpintax;
        }

        public void readFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            
            sr.ReadLine();
            string line = "";
            //string[] columns;
            while ((line = sr.ReadLine()) != null)
            {
                //columns = line.Split(',');
                targetID.Add(line);
            }
            sr.Close();

        }

        public bool checkTime()
        {
            string[] currentTimeParts = DateTime.Now.ToString("HH:mm", System.Globalization.DateTimeFormatInfo.InvariantInfo).Split(':');
            int currentHour = Convert.ToInt32(currentTimeParts[0]);
            int currentMinute = Convert.ToInt32(currentTimeParts[1]);
            int currentTimeInMinutes = currentHour * 60 + currentMinute;
            int startTimeInMinutes = startHour * 60 + startMinute;
            int endTimeInMinutes = endHour * 60 + endMinute;
            if(currentTimeInMinutes>=startTimeInMinutes&&currentTimeInMinutes<=endTimeInMinutes)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string s = "";
            s += ("Username = " + userName + "\r\n");
            s += ("Password = " + password + "\r\n");
            s += ("MinTimeDelay = " + minTimeDelay + "\r\n");
            s += ("MaxTimeDelay = " + maxTimeDelay + "\r\n");
            s += ("StartTime = " + startHour+":"+startMinute+ "\r\n");
            s += ("EndTime = " + endHour+":"+endMinute + "\r\n");
            s += ("MaxNumMessages = " + maxNumMessages + "\r\n\r\n\r\n");
            s += ("Facebook message text = " + text + "\r\n");

            return s;
        }
    }
}
