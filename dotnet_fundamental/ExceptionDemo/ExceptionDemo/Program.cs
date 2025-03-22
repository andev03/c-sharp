namespace ExceptionDemo {
    internal class Program {
        static void Main(string[] args) {
            try {
                int x = 0;
                int y = 10 / x;
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
