namespace CTDK {
    internal class Program {
        static void Main(string[] args) {
            var rand = new Random();

            var arr = new int[10];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = rand.Next() % 1000;
            }

            foreach (var i in arr) {
                Console.WriteLine(i);
            }
        }

        static void f1(string[] args) {
            foreach (string arg in args) {
                Console.WriteLine(arg);
            }

            var lists = new List<string>();
            foreach (string arg in args) {
                lists.Add(arg.ToUpper());
            }

            foreach (var s in lists) {
                Console.WriteLine(s);
            }
        }
        static void f0() {
            /*int x = 1;
            int y = 0;

            if (x == 0) {
                Console.WriteLine("x == 0");
            } else {
                Console.WriteLine("x <> 0");
            }

            switch (x) {
                case 0:
                    Console.WriteLine("x == 0");
                    break;
                case 1:
                    Console.WriteLine("x == 1");
                    break;
                default:
                    Console.WriteLine($"x = {x}");
                    break;
            }*/
        }
    }
}
