using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OdruniaSystem.Components
{
	internal class Value
	{
		public string serverName = "localhost";
		public string serverUser = "root1";
		public string serverPass = "";
		public string serverPort = "3306";
		public string serverDb = "odrunia_db_01";

		public static int genderId;
        public int GenderId { get { return genderId; } set { genderId = value; } }

		public static string gender;
        public string Gender { get { return gender; } set { gender = value; } }

		public static int myId;
        public int MyId { get { return myId; } set { myId = value; } }

		public static string myFirstName;
        public string MyFirstName { get { return myFirstName; } set { myFirstName = value; } }

		public static string myMiddleName;
        public string MyMiddleName { get { return myMiddleName; } set { myMiddleName = value; } }

		public static string myLastName;
        public string MyLastName { get { return myLastName; } set { myLastName = value; } }

		public static string myGender;
        public string MyGender { get { return myGender; } set { myGender = value; } }

		public static int myAge;
        public int MyAge { get { return myAge; } set { myAge = value; } }

		public static DateTime myBirthday;
        public DateTime MyBirthday { get { return myBirthday; } set { myBirthday = value; } }

		public static string myContactNumber;
        public string MyContactNumber { get { return myContactNumber; } set { myContactNumber = value; } }

		public static string myEmail;
        public string MyEmail { get { return myEmail; } set { myEmail = value; } }

		public static string myUsername;
        public string MyUsername { get { return myUsername; } set { myUsername = value; } }

		public string MyFullName
		{
			get
			{
				if(String.IsNullOrWhiteSpace(myMiddleName))
				{
					return string.Format("{0} {1}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myFirstName), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myLastName));
				}
				else
				{
					return string.Format("{0} {1}. {2}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myFirstName), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myMiddleName)[0], CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myLastName));
				}
			}
		}
    }
}
