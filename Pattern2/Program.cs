using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2 {
    class Program {
        static void Main(string[] args) {
            int num = 5;
            for (int i = 1; i <= num; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
