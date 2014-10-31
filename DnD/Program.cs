using System;
using System.Linq;
using System.Xml.Linq;

namespace DnD
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Printout of Chuul.xml");

			XDocument xdoc = XDocument.Load("/Users/ryanhall/Projects/DnD/DnD/MonsterXML/Chuul.xml");

			//todo: create xsd for xml schema verification

			//print out entire doc
			Console.WriteLine (xdoc);

			//grab the monster tag
			XElement xmonster = xdoc.Element("monster");

			//grab monster "name" value
			Console.WriteLine("Name: " + xmonster.Element("name").Value);

			//grab monster "type" value
			Console.WriteLine("Type: " + xmonster.Element ("type").Value);

			//grab alignment
			//this.PrintElement (xmonster, "Alignment", "alignment");

			XmlMonster xmlmonster = new XmlMonster("/Users/ryanhall/Projects/DnD/DnD/MonsterXML/Chuul.xml");
			xmlmonster.PrintElement("alignment", "Alignment");

			xmlmonster.PrintXDoc();


			Console.ReadLine();
		}
	}

	class XmlMonster
	{
		private XDocument _xdoc;
		private XElement _xmonster;

		public XmlMonster(string xmlfile) {
			//load file into XDocuent
			_xdoc = XDocument.Load(xmlfile);

			//load monster element into XElement
			_xmonster = _xdoc.Element("monster");
		}

		public void PrintElement(string element, string label) {

			Console.WriteLine(label + ": " + _xmonster.Element(element).Value);
		}

		public void PrintXDoc() {

			Console.WriteLine(_xdoc);
		}

	}

	/* MONSTER CLASS */
	class Monster
	{
		private int _str;
		private int _dex;
		private int _con;
		private int _int;
		private int _wis;
		private int _cha;

		public int Str { get; set; }
		public int Dex { get; set; }
		public int Con { get; set; }
		public int Int { get; set; }
		public int Wis { get; set; }
		public int Cha { get; set; }

	}
}
