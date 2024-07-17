using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    internal class UserWant {
        public int ProductUserWantId {
            get; set;
        }

        public int ProductId {
            get; set;
        }

        public string? Description {
            get; set;
        }

        public int Price {
            get; set;
        }

        public int GapPrice {
            get; set;
        }

        public int? Fax {
            get; set;
        }

        public string Note {
            get; set;
        }

        public DateTime? CreateDate {
            get; set;
        }

        public string? Currency {
            get; set;
        }

        public int? Quantity {
            get; set;
        }

        public bool? Status {
            get; set;
        }

        private readonly object _Lock = new object();

        public void changeWithLock(int quantityUpdate) {

            Monitor.Enter(_Lock);
            try {
                if (Quantity >= quantityUpdate) {
                    Console.WriteLine($"{Thread.CurrentThread.Name} is trying to minus: {quantityUpdate} quantity");
                    Console.WriteLine($"Successfull: {Thread.CurrentThread.Name} is changed with: {Quantity -= quantityUpdate} quantity");
                } else {
                    Console.WriteLine($"Fail: {Thread.CurrentThread.Name} can't minus with: {quantityUpdate} quantity");
                }
            } catch (Exception ex) {
                Console.WriteLine($"{ex.Message}");
            } finally {
                Monitor.Exit(_Lock);
            }
        }

        public void changeWithOutLock(int quantityUpdate) {
            if (Quantity >= 0) {
                Console.WriteLine($"{Thread.CurrentThread.Name} is trying to minus: {quantityUpdate} quantity");
                Console.WriteLine($"Successfull: {Thread.CurrentThread.Name} is changed with: {Quantity -= quantityUpdate} quantity");
            } else {
                Console.WriteLine($"Fail: {Thread.CurrentThread.Name} can't minus with: {quantityUpdate} quantity");
            }
        }
    }
}
