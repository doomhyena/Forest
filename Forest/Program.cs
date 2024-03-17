using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your name (minimum 3 letters, maximum 20 letters): ");
        string name = Console.ReadLine();
        while (name.Length < 3 || name.Length > 20)
        {
            Console.Write("Invalid name. Please enter a name between 3 and 20 letters: ");
            name = Console.ReadLine();
        }

        Console.Write("Please enter your age (two-digit number): ");
        string ageInput = Console.ReadLine();
        while (ageInput.Length != 2 || !int.TryParse(ageInput, out _))
        {
            Console.Write("Invalid age. Please enter a two-digit number: ");
            ageInput = Console.ReadLine();
        }
        int age = int.Parse(ageInput);

        Console.WriteLine("Welcome to the Adventure Game, " + name + "!");
        Console.WriteLine("You are deep in a dark forest. Choose where you want to go:");
        Console.WriteLine("a) Turn right and go deep into the forest.");
        Console.WriteLine("b) Turn left and try to go around the forest.");

        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "a":
                Console.WriteLine("You go deep into the forest and find a cave.");
                Console.WriteLine("You enter the cave. What would you like to do?");
                Console.WriteLine("a) Explore the cave.");
                Console.WriteLine("b) Return to the forest.");

                string caveChoice = Console.ReadLine().ToLower();
                if (caveChoice == "a")
                {
                    Console.WriteLine("You explore the cave and find a hidden treasure chest!");
                    Console.WriteLine("You open the treasure chest and find a magic gem inside.");
                    Console.WriteLine("What would you like to do with the magic gem?");
                    Console.WriteLine("a) Try to use the magic gem.");
                    Console.WriteLine("b) Put the magic gem back into the treasure chest.");

                    string gemChoice = Console.ReadLine().ToLower();
                    if (gemChoice == "a")
                    {
                        Console.WriteLine("You use the magic gem and a secret door opens in the cave!");
                        Console.WriteLine("You enter the door and find yourself in another world. Congratulations, you win!");
                    }
                    else
                    {
                        Console.WriteLine("You put the magic gem back into the treasure chest. You continue your journey in the forest.");
                    }
                }
                else
                {
                    Console.WriteLine("You return to the forest and continue your adventure.");
                }
                break;
            case "b":
                Console.WriteLine("You try to go around the forest, but you wander into a swampy area.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("a) Look for a way to get out of the forest.");
                Console.WriteLine("b) Try to cross the swamp.");

                string swampChoice = Console.ReadLine().ToLower();
                if (swampChoice == "a")
                {
                    Console.WriteLine("You manage to find a way out and escape the forest. Congratulations, you survived!");
                }
                else
                {
                    Console.WriteLine("You try to cross the swamp, but you get stuck. Unfortunately, you didn't make it.");
                }
                break;
            case "c": // New choice
                Console.WriteLine("You head towards the riverbank, but a massive river blocks your path.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("a) Try to cross the river.");
                Console.WriteLine("b) Return to the forest.");

                string riverChoice = Console.ReadLine().ToLower();
                if (riverChoice == "a")
                {
                    Console.WriteLine("You attempt to cross the river, but unfortunately, you fail. You return to the forest.");
                }
                else
                {
                    Console.WriteLine("You return to the forest and continue your adventure.");
                }
                break;
            case "d": // New choice
                Console.WriteLine("You head up into the mountains and stumble upon ancient ruins.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("a) Explore the ruins.");
                Console.WriteLine("b) Return to the forest.");

                string mountainChoice = Console.ReadLine().ToLower();
                if (mountainChoice == "a")
                {
                    Console.WriteLine("You explore the ruins and find a forgotten relic. Congratulations, you win!");
                }
                else
                {
                    Console.WriteLine("You return to the forest and continue your adventure.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again!");
                break;
        }

        Console.WriteLine("Thanks for playing!");
    }
}