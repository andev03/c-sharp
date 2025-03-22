namespace TodoList {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello!");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODOs");
            Console.WriteLine("[R]emove a TODO!");
            Console.WriteLine("[E]xit");
            
            string userInput = "ABC";
            Console.WriteLine(userInput);

            int number = 2;
            number = 7;
            string? input = Console.ReadLine();
            Console.WriteLine(input);

            var result = "abc" + "bce";

            Console.ReadKey();
        }
    }
}
