namespace Basic {
    internal class Program {
        static void Main(string[] args) {

            int myNum = 1;
            double myDoubleNum = 2.99D;  
            char myLetter = 'N';
            bool myBool = true;
            string myText = "Nguyen Hoang An";
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);

            // Math
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Round(9.99));

            // Là 1 biến kiểu object.
            Object objectValue = "Nguyen Hoang An";
            Console.WriteLine(objectValue);

            // var có thể khai bào mọi kiểu biến nhưng lúc khai báo phải có giá trị ngay sau khi khau báo
            var varValueInt = 1;
            var varValueString = 1;

            Console.WriteLine(varValueInt);
            Console.WriteLine(varValueString);

            // giống với var nhưng dynamic thì lúc compile code mới xác định kiểu dữ liệu
            dynamic dynamicValue = 0;

            Console.WriteLine(dynamicValue);
 

        }
    }
}
