namespace IsAndAs {
    internal class Program {
        static void Main(string[] args) {
            Rectangle objRectangle = new Rectangle(10.2F, 20.3F);
            ICalculate calculate;
            if (objRectangle is ICalculate) {
                calculate = objRectangle as ICalculate;
                Console.WriteLine("Area : {0:F2}", calculate.Area());
            } else {
                Console.WriteLine("Interface method not implemented");
            }
        }
    }
}
