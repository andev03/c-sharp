namespace ndir {
    internal class Program {
        static void Main(string[] args) {
            var path = "C:\\";

            var dir = new DirectoryInfo(path);

            var directories = dir.GetDirectories();

            foreach (var directory in directories) { 
                Console.WriteLine(directory.FullName);
            }
        }
    }
}
