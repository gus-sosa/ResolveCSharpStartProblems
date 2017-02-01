using System;

namespace Pattern1 {
    class Program {
        static void PrintPattern(int num) {
            for (int i = 1; i <= num; i++) {
                for (int space = 1; space <= (num - i); space++) {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++) {
                    Console.Write(j);
                }

                for (int k = (i - 1); k >= 1; k--) {
                    Console.Write(k);
                }

                Console.WriteLine();
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
