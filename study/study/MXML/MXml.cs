﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace GTL.MXML
{
    public class MXml
    {
        public void Main()
        {
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
            //XmlComment xmlCom = xmlD.CreateComment("This is an XMLDocument using C# XML Document");
            //XmlElement xmlRoot = xmlD.CreateElement("root");
            //XmlElement xmlParent = xmlD.CreateElement("parent");
            //XmlElement xmlChild = xmlD.CreateElement("child");

            //xmlD.AppendChild(xmlRoot);
            //xmlRoot.AppendChild(xmlParent);
            //xmlParent.AppendChild(xmlChild);
            //xmlChild.InnerText = "miau";
            //xmlD.AppendChild(xmlCom);
            ////Console.WriteLine($"{xmlD.FirstChild.InnerText}");

            ////xmlD.Save("test1.xml");

            //XmlDocument xmld = new XmlDocument();
            //xmld.Load("test.xml");

            ////using (TextWriter sw = new StreamWriter("output.txt", false, Encoding.UTF8)) //Set encoding
            ////{
            ////    xmld.Save(sw);
            ////}

            //xmlD.Save(Console.Out);

        }
    }
}
