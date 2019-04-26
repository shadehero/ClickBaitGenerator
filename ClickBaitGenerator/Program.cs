using System;
using HtmlAgilityPack;

namespace ClickBaitGenerator
{
	class MainClass
	{
		static string URL = "http://linkbaitgenerator.com/marketing/index.php";

		public static void Main(string[] args)
		{
			for (int i = 0; i < 12; i++)
			{
				Console.WriteLine(ClickBaitGenerator.GetClickBait());			
			}


			Console.ReadKey();
		}
	}
}
