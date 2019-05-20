using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace GTL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //FormView view = new FormView();
            //IList list = new ArrayList();
            //FormController controller = new FormController(view, list);
            //Application.Run(new RegexFormView());

            FileStream F = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //for (int i = 1; i <= 20; i++)
            //{
            //    F.WriteByte((byte)i);
            //}
            //F.Position = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.Write(F.ReadByte() + " ");
            //}

            //foreach(char c in "the quick brown fox jumps over the lazy dog")
            //{
            //    F.WriteByte((byte)c);
            //}

            // Question: Should I remove CRLF ??

            F.Position = 0;
            
            // avoid reading clrf
            while(F.Position != F.Length - 2)
            {
                Console.Write((char)F.ReadByte() + " ");
            }

            F.Close();

            Console.WriteLine();
            
            Console.Write("\nWrite something!: ");
            string myinput = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter("test.txt"))
            {
                sw.WriteLine(myinput);
            }
            
            try
            {
                using (StreamReader sr = new StreamReader("test.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Huh? Something wrong happened: ");
                Console.WriteLine($"\t{exc.Message}");
            }

            Console.ReadKey();
        }
        
    }
}
