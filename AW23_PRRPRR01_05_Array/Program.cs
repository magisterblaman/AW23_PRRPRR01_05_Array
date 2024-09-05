using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_05_Array {
	internal class Program {
		static void Main(string[] args) {
			//string user1Name = "Georg";
			//string user2Name = "Lars";
			//string user3Name = "Annette";
			//string user4Name = "Berit";

			string[] userNames = new string[4];
			userNames[0] = "Georg";
			userNames[1] = "Lars";
			userNames[2] = "Annette";
			userNames[3] = "Berit";

			//Console.WriteLine(userNames[0]);
			//Console.WriteLine(userNames[1]);
			//Console.WriteLine(userNames[2]);
			//Console.WriteLine(userNames[3]);

			for (int i = 0; i < userNames.Length; i++) {
				Console.WriteLine(userNames[i]);
			}
		}
	}
}
