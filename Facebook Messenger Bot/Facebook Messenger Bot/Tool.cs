using System;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication2
{
    static class Tool
    {
        public static bool installLibraries(string path)
        {
            Process proc = null;
            try
            {
                if(!File.Exists(path+"\\status.txt"))
                {
                    proc = new Process();
                    proc.StartInfo.FileName = "cmd.exe";
                    proc.StartInfo.WorkingDirectory = path + "\\";
                    proc.StartInfo.Arguments = "/c node-v6.10.2-x86.msi";
                    proc.Start();
                    proc.WaitForExit();
                    proc.StartInfo.Arguments = "/c npm install";
                    proc.Start();
                    proc.WaitForExit();
                    proc.StartInfo.Arguments = "/c npm install facebook-chat-api";
                    proc.Start();
                    proc.WaitForExit();
                    File.Create("status.txt");
                    System.IO.StreamWriter file = new System.IO.StreamWriter("status.txt");
                    file.WriteLine("Installed!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
            return File.Exists("node_modules");
        }

        public static bool createBotJs()
        {
            string jsFile = "const login = require('facebook-chat-api');" +
                            "function send(userName, passWord, message, ID) {" +
                            "    login({ email: userName, password: passWord }, (err, api) => {" +
                            "    if (err) return console.error(err);" +
                            "    api.sendMessage(message, ID);" +
                            "    })" +
                            "}" +
                            "var username = process.argv[2];" +
                            "var password = process.argv[3];" +
                            "var msg = process.argv[4];" +
                            "var targetID = process.argv[5];" +
                            "send(username, password, msg, targetID);";

            using (StreamWriter sw = new StreamWriter(File.Create("bot.js")))
            {
                sw.Write(jsFile);
            };
            return File.Exists("bot.js");
        }

        public static bool createRunFbChatJsBat()
        {
            string runFBChatBatchContent = "node bot.js %1 %2 %3 %4";
            using (StreamWriter sw = new StreamWriter(File.Create("RunFBCHAT.bat")))
            {
                sw.Write(runFBChatBatchContent);
            };
            return File.Exists("RunFBCHAT.bat");
        }
    }
}
