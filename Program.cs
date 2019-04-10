using System;

namespace project {
	class MainClass {
		public static void Main (string[] args) {
			
			Console.WriteLine ("Таблица умножения");

			for (int i = 0; i < 9; i++) {
				for (int j = 0; j < 9; j++) {
					Console.Write ("\t" + ((i + 1) * (j + 1)));
				}
				Console.WriteLine ();
			}

			Console.ReadKey ();

		}
	}
}