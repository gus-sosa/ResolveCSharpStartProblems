using System;

namespace Pattern3 {
    class Program {
        static void PrintRow(int i) {
            for (int j = 1; j <= i; j++) {
                Console.Write(j);
            }
        }

        static void Main(string[] args) {
            int num = 0;
            while (true) {
                Console.Write("Enter a number: ");
                if (!int.TryParse(Console.ReadLine(),out num)) {
                    continue;
                }

                for (int i = 1; i <= num; i++) {
                    PrintRow(i);
                    Console.WriteLine();
                }

                for (int i = num - 1; i >= 1; i--) {
                    PrintRow(i);
                    Console.WriteLine();
                }
            }
        }
    }
}
