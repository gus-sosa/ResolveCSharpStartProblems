using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern5 {
    class Program {
        static void Main(string[] args) {
            int num = 0;
            while (true) {
                Console.Write("Enter the number of rows: ");
                if (!int.TryParse(Console.ReadLine(), out num)) {
                    continue;
                }

                bool flag = true;
                for (int i = 0; i < num; i++) {
                    for (int j = 0; j <= i; j++) {
                        Console.Write(flag ? "1" : "0");
                        flag = !flag;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
