using System;
using System.Linq;
using System.Xml.Linq;

namespace DnD
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//todo: create xsd for xml schema validation

			//load file into xmlmonster
			XmlMonster xmlmonster = new XmlMonster("/Users/ryanhall/Projects/DnD/DnD/MonsterXML/Chuul.xml");

			//print entire xml
			xmlmonster.PrintXDoc();

			//grab name
			xmlmonster.PrintElement("name", "Name");

			//grab type
			xmlmonster.PrintElement("type", "Type");

			//grab alignment
			xmlmonster.PrintElement("alignment", "Alignment");

			//do stat group
			Console.WriteLine("Stats");

			//grab str
			xmlmonster.PrintElement("stats", "str", "Strength");

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

		//print a single element's value
		public void PrintElement(string element, string label) {

			Console.WriteLine(label + ": " + _xmonster.Element(element).Value);
		}

		//print a single child element's value
		public void PrintElement(string parent, string child, string label) {

			Console.WriteLine(label + ": " + _xmonster.Element(parent).Element(child).Value);
		}

		//print the entire xml doc
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
