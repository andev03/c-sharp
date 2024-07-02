namespace Default {
    internal class Program {
        static void Main(string[] args) {
            MySample obj = new MySample();
            obj.Display();
            //obj.Print(); //Error
            //Default Implement Method
            ISample.Print();
            ISample sample = obj;
            string str = sample.GetString("Jack");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
