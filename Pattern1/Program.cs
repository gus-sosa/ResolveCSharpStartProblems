using System;

namespace Pattern1 {
    class Program {
        static void PrintPattern(int num) {
            for (int row = 1; row <= num; row++) {
                string cadStart = "", cadEnd = "";
                for (int col = 1; col < row; col++) {
                    cadStart += col;
                    cadEnd = cadEnd.Insert(0, "" + col);
                }
                var padding = new string(' ', num - row);
                Console.WriteLine($"{padding}{cadStart}{row}{cadEnd}{padding}");
            }
        }

        static void Main(string[] args) {
            int num = 0;
            while (true) {
                Console.Write("Enter a number between 1 to 9: ");
                if (int.TryParse(Console.ReadLine(), out num) && num >= 1 && num <= 9) {
                    PrintPattern(num);
                }
            }
        }
    }
}
