namespace Method {
    internal class Program {
        static void Main(string[] args) {
            int x = 1;
            int y = 2;

            Console.WriteLine(y);
            Console.WriteLine(Add2Integer(x, ref y));
            Console.WriteLine(y);
        }

        public static int Add2Integer(int x, ref int y) {
            y = 100;

            return x + y;
        }
    }
}
