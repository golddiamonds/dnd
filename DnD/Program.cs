using System;
using System.Xml;

namespace DnD
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Printout of Chuul.xml");
			XmlTextReader reader = new XmlTextReader ("/Users/ryanhall/Projects/DnD/DnD/MonsterXML/Chuul.xml");

			while (reader.Read()) 
			{
				switch (reader.NodeType) 
				{
				case XmlNodeType.Element: // The node is an element.
					Console.Write("<" + reader.Name);
					Console.WriteLine(">");
					break;
				case XmlNodeType.Text: //Display the text in each element.
					Console.WriteLine (reader.Value);
					break;
				case XmlNodeType.EndElement: //Display the end of the element.
					Console.Write("</" + reader.Name);
					Console.WriteLine(">");
					break;
				}
			}
			Console.ReadLine();
		}
	}
}
