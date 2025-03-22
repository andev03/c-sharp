namespace Assignment3 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("withlock");

            var userWantWithLock = new UserWant() {
                ProductUserWantId = 1,
                ProductId = 1,
                Description = "Mô tả sản phẩm",
                Price = 90000,
                GapPrice = 9000,
                Fax = 0123456789,
                Note = "Ghi chú về sản phẩm",
                CreateDate = DateTime.Now,
                Currency = "VND",
                Quantity = 20,
                Status = true
            };

            Thread t1 = new Thread(() => userWantWithLock.changeWithLock(5)) { Name = "thread 1" };
            Thread t2 = new Thread(() => userWantWithLock.changeWithLock(5)) { Name = "thread 2" };
            Thread t3 = new Thread(() => userWantWithLock.changeWithLock(5)) { Name = "thread 3" };
            Thread t4 = new Thread(() => userWantWithLock.changeWithLock(5)) { Name = "thread 4" };
            Thread t5 = new Thread(() => userWantWithLock.changeWithLock(10)) { Name = "thread 5" };
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            Console.ReadLine();
            var userWantWithNoLock = new UserWant() {
                ProductUserWantId = 1,
                ProductId = 1,
                Description = "Mô tả sản phẩm",
                Price = 90000,
                GapPrice = 9000,
                Fax = 0123456789,
                Note = "Ghi chú về sản phẩm",
                CreateDate = DateTime.Now,
                Currency = "VND",
                Quantity = 20,
                Status = true
            };

            Console.WriteLine("without lock");

            Thread t6 = new Thread(() => userWantWithNoLock.changeWithOutLock(5)) { Name = "thread 6" };
            Thread t7 = new Thread(() => userWantWithNoLock.changeWithOutLock(5)) { Name = "thread 7" };
            Thread t8 = new Thread(() => userWantWithNoLock.changeWithOutLock(5)) { Name = "thread 8" };
            Thread t9 = new Thread(() => userWantWithNoLock.changeWithOutLock(5)) { Name = "thread 9" };
            Thread t10 = new Thread(() => userWantWithNoLock.changeWithOutLock(10)) { Name = "thread 10" };
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
            t10.Start();
            t6.Join();
            t7.Join();
            t8.Join();
            t9.Join();
            t10.Join();
            Console.ReadLine();
        }
    }
}
