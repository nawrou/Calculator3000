namespace WindowsFormsApplication4
{
	//string display for users
	public class DisplayNumber
	{
		public static string stringofnumber = "0";
		public static bool number = true;

		public static void Addonstring(string toadd)
		{
			if (stringofnumber == "0" && toadd != "." && toadd != " + " && toadd != " - " && toadd != " x " && toadd != " / ")
				stringofnumber = toadd;
			else
				stringofnumber += toadd;
		}
		public static void Suppstring()
		{
			stringofnumber = "0";
		}
	}
}
