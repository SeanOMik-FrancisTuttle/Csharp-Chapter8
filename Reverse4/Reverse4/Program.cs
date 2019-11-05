using System;

using static System.Console;

namespace Reverse4 {
    class Program {
        private static void reverse(ref object obj1, ref object obj2, ref object obj3, ref object obj4) {
            object temp = obj1;
            obj1 = obj4;
            obj4 = temp;

            temp = obj2;
            obj2 = obj3;
            obj3 = temp;
        }
        static void Main(string[] args) {
            object obj1 = 37;
            object obj2 = 42;
            object obj3 = 59;
            object obj4 = 66;

            WriteLine("Before: obj1: {0, 4} - obj2: {1, 4} - obj3: {2, 4} - obj4: {3, 4}", obj1, obj2, obj3, obj4);
            reverse(ref obj1, ref obj2, ref obj3, ref obj4);
            WriteLine("After: obj1: {0, 4} - obj2: {1, 4} - obj3: {2, 4} - obj4: {3, 4}", obj1, obj2, obj3, obj4);
        }
    }
}
