using System;

using static System.Console;

namespace OverloadedTriples {
    class Program {
        private static void Triple(int num) => WriteLine("{0} times {1} is {2}\n", num, 3, num * 3);
        private static void Triple(string message) => WriteLine("{0}\t{0}\t{0}\n", message);

        static void Main(string[] args) {
            int num = 20;
            string message = "Go team!";
            Triple(num);
            Triple(message);
        }
    }
}
