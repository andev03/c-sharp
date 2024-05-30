namespace OOP {
    internal class Program {
        static void Main(string[] args) {

            Animal animal = new Animal() {
                Weight = 10,
                Height = 10
            };

            Animal animal2 = new Animal();

            animal2.Weight = 1;
            animal2.Height = 100;

            Dog dog = new Dog() {
                Weight = 10,
                Height = 10,
                NameDog = "Picky"
            };

            Console.WriteLine(animal.infor());
            Console.WriteLine(animal2.infor());
            Console.WriteLine(dog.infor());


            IAction action = new ActionImpl();

            Console.WriteLine($"{dog.NameDog} {action.run()}");

        }
    }
}
