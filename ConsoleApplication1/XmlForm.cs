using System.Net.Cache;
using System.Xml.Linq;

namespace ConsoleApplication1
{
	class XmlForm
	{
		public XDocument NewLog(string login, string password)
		{
			XDocument logxml = new XDocument(
				new XElement("Request-log", 
					new XElement("Login", login),
					new XElement("Password", password)
				)
			);
			logxml.Declaration = new XDeclaration("1.0", "utf-8", "true");
			return logxml;
		}

		public XDocument NewRequest(string session, string request, string result = null)
		{
			XDocument requestxml = new XDocument(
				new XElement("Request-process",
					new XElement("session", session),
					new XElement("process", request),
					new XElement("Result", result)
				)
			);
			requestxml.Declaration = new XDeclaration("1.0", "utf-8", "true");
			return requestxml;
		}

		public XDocument Unlog(string login, string session)
		{
			XDocument unlogxml = new XDocument(
				new XElement("Request-unlog",
					new XElement("login", login),
					new XElement("Session", session)
				)
			);
			unlogxml.Declaration = new XDeclaration("1.0", "utf-8", "true");
			return unlogxml;
		}
	}
}
