using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Xml;

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
                new XDeclaration("1.0", "utf-8", "yes")
                //,new XElement("root",
                //    new XElement("child", "x"),
                //    new XElement("child", "x")
                //    )
                );

            //d.Add(new XElement("root", 
            //        new XElement("child", "x"),
            //        new XElement("child","x")
            //        )
            //    );

            //XElement root = new XElement("root");

            //root.Add(new XElement("child", "x"),
            //        new XElement("child", "x")
            //        );

            //d.Add(root);

            //XElement root = new XElement("root");
            //XElement child = new XElement("child", "default");
            //XElement subchild = new XElement("subchild", "default");
            //XElement parent = new XElement("parent", subchild);

            //root.Add(child, parent);
            //child.AddAfterSelf(subchild);
            //subchild.AddBeforeSelf(new XElement("sibling", subchild));
            ////i have no idea whats happening

            //d.Add(root);

            //foreach (XElement node in child.Ancestors())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine();
            //foreach (XElement node in parent.Descendants())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine();

            //IEnumerable<string> xmlLinq = from element in d.Descendants() where element.Name == "child" select element.Value;
            //Console.WriteLine($"{d}\n");

            //foreach (string s in xmlLinq)
            //{
            //    Console.WriteLine(s);
            //}

            //Using XmlDocument

            //XmlDocument xmlD = new XmlDocument();
            //XmlDeclaration xmlDec= xmlD.CreateXmlDeclaration("1.0", "utf-8", "yes");
            //XmlComment xmlCom = xmlD.CreateComment("This is an XMLDocument using C# XML Document");
            //XmlElement xmlRoot = xmlD.CreateElement("root");
            //XmlElement xmlParent = xmlD.CreateElement("parent");
            //XmlElement xmlChild = xmlD.CreateElement("child");

            //xmlD.AppendChild(xmlDec);
            //xmlD.AppendChild(xmlRoot);
            //xmlRoot.AppendChild(xmlParent);
            //xmlParent.AppendChild(xmlChild);
            //xmlChild.InnerText = "miau";
            //xmlD.AppendChild(xmlCom);
            ////Console.WriteLine($"{xmlD.FirstChild.InnerText}");

            //xmlD.Save("test1.xml");

            Console.ReadKey();
        }
    }
}
