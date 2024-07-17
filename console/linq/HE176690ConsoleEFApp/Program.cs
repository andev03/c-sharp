using HE176690ConsoleEFApp.Models;

namespace HE176690ConsoleEFApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            var _context = new Net1810_212_1_ExchangeContext(new Microsoft.EntityFrameworkCore.DbContextOptions<Net1810_212_1_ExchangeContext>());

            Console.WriteLine("1. Select * From OrderType");
            var customers = _context.OrderTypes.ToArray();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            foreach (var customer in customers) {
                Console.WriteLine(customer.OrderTypeName);
            }

            Console.WriteLine("2. select * from OrderType where OrderTypeId = '1'");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            var item = _context.OrderTypes.FirstOrDefault(c => c.OrderTypeId == 1);
            if (item != null) {
                Console.WriteLine(item.OrderTypeName);
            }

            Console.WriteLine("3. insert into OrderType(OrderTypeName) value('Không tồn tại')");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            item = new OrderType();
            item.OrderTypeName = "Không tồn tại";
            _context.Add(item);
            _context.SaveChanges();
            Console.WriteLine("Insert success: " + item.OrderTypeName);

            Console.WriteLine("4. update OrderType set OrderTypeName = 'Có tồn tại' where OrderTypeName = 'Không tồn tại'");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            item = _context.OrderTypes.FirstOrDefault(c => c.OrderTypeName == "Không tồn tại");
            if (item != null) {
                item.OrderTypeName = "Có tồn tại";
                _context.Update(item);
                _context.SaveChanges();
            }
            Console.WriteLine("After success: " + item.OrderTypeName);

            Console.WriteLine("5. delete OrderType where OrderTypeName = 'Có tồn tại'");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            item = _context.OrderTypes.FirstOrDefault(c => c.OrderTypeName.Equals("Có tồn tại"));

            if (item != null) {
                _context.Remove(item);
                _context.SaveChanges();
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }

}
