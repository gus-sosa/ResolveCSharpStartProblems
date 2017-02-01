using static System.Console;
namespace Pattern10 {
    class Program {
        static void Main(string[] args) {
            int n = 9;
            for (int i = 1; i <= n; i++) {
                for (int j = 1; j <= i; j++) {
                    Write(j);
                }
                WriteLine(new string('*', n - i));
            }
        }
    }
}
