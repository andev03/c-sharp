namespace DiceRollGame {
    internal class Program {
        static void Main(string[] args) {
/*            var random = new Random();
            var dice = new Dice(random);
            var guessingGame = new GuessingGame(dice);

            bool xxx = guessingGame.Play();*/

            Season firstSeason = Season.Spring;
            Console.ReadLine();
        }
    }

    public enum Season {
        Spring, 
        Summer,
        Autumn,
        Winter
    }

    class GuessingGame {

        private readonly Dice _dice;
        private readonly ConsoleReader _consoleReader;

        private const int InitialTries = 3;
        public GuessingGame(Dice dice) {
            _dice = dice;
        }

        public bool Play() {
            var diceRoleResult = _dice.Roll();
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

            var triesLeft = InitialTries;
            while (triesLeft > 0) {
                var guess = _consoleReader.ReadInteger("Enter a number: ");

                if (guess == diceRoleResult) {
                    return true;
                }
                --triesLeft;
            }
            return false;
        }
    }

    class ConsoleReader {

        public int ReadInteger(string message) {
            int result;
            do {

            } while (!int.TryParse(Console.ReadLine(), out result));

            return result;
        }
    }

    class Dice {
        private readonly Random _random;
        private readonly int SidesCount = 6;

        public Dice(Random random) {
            _random = random;
        }

        public int Roll() =>
             _random.Next(1, 7);


        public void Describe() =>
            Console.WriteLine($"This is a dice with {SidesCount} sides");
    }
}