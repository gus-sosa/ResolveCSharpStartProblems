using System;

namespace Pattern8 {
    class Program {
        static void Main(string[] args) {
            int num = 0;
            while (true) {
                Console.Write("Enter the number of rows: ");
                if (!int.TryParse(Console.ReadLine(), out num) && num > 0) {
                    continue;
                }

                Console.WriteLine("1");
                if (num == 1) {
                    continue;
                }
                Console.WriteLine("1 1");
                if (num == 2) {
                    continue;
                }

                int[] arr1 = new int[num + 1];
                arr1[1] = arr1[2] = 1;
                int[] arr2 = new int[num + 1];
                for (int i = 3; i <= num; i++) {
                    arr2[1] = arr2[i] = 1;
                    Console.Write("1 ");
                    for (int j = 2; j < i; j++) {
                        arr2[j] = arr1[j - 1] + arr1[j];
                        Console.Write($"{arr2[j]} ");
                    }
                    Console.WriteLine("1");
                    var tmp = arr1;
                    arr1 = arr2;
                    arr2 = tmp;
                }
            }
        }
    }
}
