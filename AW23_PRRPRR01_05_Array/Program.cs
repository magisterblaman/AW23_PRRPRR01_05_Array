using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_05_Array {
	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hur gammal är du?");

			string input = Console.ReadLine();
			//int age = int.Parse(input);

			int age;
			while (!int.TryParse(input, out age)) {
				Console.WriteLine("Vänligen ange ett tal.");
				input = Console.ReadLine();
			}

			Console.WriteLine("Du är " + age + " år gammal");
		}
	}
}
