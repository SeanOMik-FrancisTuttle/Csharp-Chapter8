using System;

using static System.Console;

namespace Movie {
    class Program {
        private static void DisplayMovie(string name, int length) {
            DisplayMovie(name);
            WriteLine("Movie Length: {0}\n", length);
        }

        private static void DisplayMovie(string name) {
            WriteLine("Movie Title:  {0}", name);
        }
        static void Main(string[] args) {
            WriteLine("Name, length:");
            DisplayMovie("Avengers: End Game", 181);

            WriteLine("Name:");
            DisplayMovie("Avengers: End Game");
        }
    }
}
