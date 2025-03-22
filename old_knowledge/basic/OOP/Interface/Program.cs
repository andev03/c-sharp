namespace Interface {
    class Program {
        static void Main(string[] args) {
            MyClass obj = new MyClass();
            obj.Display();

            IFirst first = obj;
            first.Print();

            ISecond second = obj;
            second.Print();

            Console.ReadLine();
        }
    }
}
