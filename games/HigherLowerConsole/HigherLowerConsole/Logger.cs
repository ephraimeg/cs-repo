using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLowerConsole
{
    /// <summary>
    /// Logger class for writing Console input/outputs to a text file
    /// Original code written by:
    ///   WhoIsNinja and Jhollman, StackOverflow Users
    ///   https://stackoverflow.com/a/54116087
    /// </summary>
    public static class Logger
    {
        public static StringBuilder LogString = new StringBuilder();
        public static void WriteLine(string str)
        {
            Console.WriteLine(str);
            LogString.Append(str).Append(Environment.NewLine);
        }
        public static void Write(string str)
        {
            Console.Write(str);
            LogString.Append(str);

        }
        public static string ReadLine()
        {
            string str = Console.ReadLine();
            LogString.Append(str).Append(Environment.NewLine);
            return str;
        }
        public static string Read()
        {
            string str = Console.ReadLine();
            LogString.Append(str);
            return str;
        }

        public static void SaveLog(bool Append = false, string Path = "./.logs", string Filename = "Log.txt")
        {
            if (LogString != null && LogString.Length > 0)
            {
                LogString.Append($"The log above is dated: {DateTime.Now.ToString()}");
                string file_path = String.Concat(Path,"/", Filename);

                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);

                if (Append)
                {
                    using (StreamWriter file = File.AppendText(file_path))
                    {
                        file.Write(LogString.ToString());
                        file.Close();
                    }
                }
                else
                {
                    using (StreamWriter file = new StreamWriter(Path))
                    {
                        file.Write(LogString.ToString());
                        file.Close();
                    }
                }
            }
        }

    }
}
