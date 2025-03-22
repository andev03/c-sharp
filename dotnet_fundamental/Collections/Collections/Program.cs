
namespace Collections {
    internal class Program {
        static void Main(string[] args) {
            var list = new List<string>();

            ReadStrings(list);
            Print(list);
            Sort(list);
            Print(list);
        }

        private static void Sort(List<string> list) {
            for (int i = 0; i < list.Count - 1; i++) {
                for (int j = 1; j < list.Count; j++) {
                    if (list[i].CompareTo(list[j]) > 0) {
                        var s = list[i];
                        list[i] = list[j];
                        list[j] = s;
                    }
                }
            }
        }

        private static void Print(List<string> list) {
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }

        private static void ReadStrings(List<string> list) {
            string? s;
            do {
                s = Console.ReadLine();

                if (!string.IsNullOrEmpty(s)) {
                    list.Add(s);
                }
            } while (!string.IsNullOrEmpty(s));
        }
    }
}
