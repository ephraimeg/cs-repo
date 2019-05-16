using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;

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

            XDocument d = new XDocument(
                new XComment("This is a comment."),
                new XProcessingInstruction("xml-stylesheet",
                    "href='mystyle.css' title='Compact' type='text/css'"),
                new XElement("Pubs",
                    new XElement("Book",
                        new XElement("Title", "Artifacts of Roman Civilization"),
                        new XElement("Author", "Moreno, Jordao")
                    ),
                    new XElement("Book",
                        new XElement("Title", "Midieval Tools and Implements"),
                        new XElement("Author", "Gazit, Inbar")
                    )
                ),
                new XComment("This is another comment.")
            );

            XNamespace ns = "mynamespace";
            XNamespace sns = "secondnamespace";
            XDocument xD = new XDocument(
                new XComment("This is my first XDocument"),
                new XComment(new XComment("There can only be one root element, it doesnt have to be called root")),
                new XElement("root",
                    new XElement("A", "A content1", new XAttribute("z", "z attribute"),
                        new XElement("AA", "AA content")),
                    new XElement("A", new XAttribute("z", true),
                        new XElement("AB", "AB content")),
                    new XElement(ns+ "A", new XAttribute("x", "yes"),
                        new XElement(sns + "AC", 
                            new XElement("D", "D content"), new XAttribute("y", "not")))
                )
            );


            d.Declaration = new XDeclaration("1.0", "utf-8", "true");
            Console.WriteLine(d);

            Console.WriteLine($"\n\n{xD}");

            d.Save("test.xml");

            Console.ReadKey();
        }
    }
}
