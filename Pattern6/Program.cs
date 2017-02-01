using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6 {
    class Program {
        static void Main(string[] args) {
            int num = 0;
            while (true) {
                Console.Write("Enter the number of rows: ");
                if (!int.TryParse(Console.ReadLine(),out num) && num>=1) {
                    continue;
                }

                int lastNum = 1;
                for (int i = 1; i <= num; i++) {
                    for (int j = 0; j < i; j++) {
                        Console.Write($"{lastNum++} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
