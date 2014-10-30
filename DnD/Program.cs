using System;
using System.Xml.Linq;

namespace DnD
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Printout of Chuul.xml");

			XDocument xdoc = XDocument.Load ("/Users/ryanhall/Projects/DnD/DnD/MonsterXML/Chuul.xml");
			
			Console.WriteLine (xdoc);

			Console.ReadLine();
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
