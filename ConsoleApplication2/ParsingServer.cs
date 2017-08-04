using System.Xml.Linq;

namespace ConsoleApplication2
{
	public class ParsingServer
	{
		private static string User = "admin";
		private static string Password = "admin";
		private static XDocument Xmlmessage;

		public ParsingServer(string StrMessage)
		{
			Xmlmessage = XDocument.Parse(StrMessage);
		}
		public static string Getinfo(string Info)
		{
			return Xmlmessage.Element(Info).Value;
		}
	}
}
