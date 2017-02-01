using static System.Console;
namespace Pattern9 {
    class Program {
        static void Main(string[] args) {
            int n = 5;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j <= i; j++) {
                    Write(n - j);
                }
                WriteLine();
            }
        }
    }
}
