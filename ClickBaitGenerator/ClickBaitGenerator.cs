using System;
using HtmlAgilityPack;
namespace ClickBaitGenerator
{
	public class ClickBaitGenerator
	{
		static readonly string SRC_URL = "http://linkbaitgenerator.com/marketing/index.php";

		public static string GetClickBait()
		{
			var web = new HtmlWeb();
			var doc = web.Load(SRC_URL);

			var node = doc.DocumentNode.SelectSingleNode("//div/div/div/div/h2");
			return node.InnerText;
		}
	}
}
