using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        Console.WriteLine("You are in a dark forest. Choose your path:");
        Console.WriteLine("a) Turn right and go deeper into the forest.");
        Console.WriteLine("b) Turn left and try to go around the forest.");
        Console.WriteLine("c) Head towards the riverbank.");
        Console.WriteLine("d) Go up to the mountains.");

        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "a":
                Console.WriteLine("You go deeper into the forest and find a cave.");
                Console.WriteLine("You enter the cave. What do you want to do?");
                Console.WriteLine("a) Explore the cave.");
                Console.WriteLine("b) Go back to the forest.");

                string caveChoice = Console.ReadLine().ToLower();
                if (caveChoice == "a")
                {
                    Console.WriteLine("You explore the cave and find a hidden treasure chest!");
                    Console.WriteLine("You open the chest and find a magical gem!");
                    Console.WriteLine("What do you want to do with the magical gem?");
                    Console.WriteLine("a) Try to use the magical gem.");
                    Console.WriteLine("b) Put the magical gem back in the chest.");

                    string gemChoice = Console.ReadLine().ToLower();
                    if (gemChoice == "a")
                    {
                        Console.WriteLine("You use the magical gem and a secret door opens in the cave!");
                        Console.WriteLine("You go through the door and find yourself in a whole new world! Congratulations, you won!");
                    }
                    else
                    {
                        Console.WriteLine("You put the magical gem back in the chest and continue your journey in the forest.");
                    }
                }
                else
                {
                    Console.WriteLine("You go back to the forest and continue your journey.");
                }
                break;
            case "b":
                Console.WriteLine("You try to go around the forest, but you get lost in a swamp.");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("a) Try to find a way out of the swamp.");
                Console.WriteLine("b) Try to cross the swamp.");

                string swampChoice = Console.ReadLine().ToLower();
                if (swampChoice == "a")
                {
                    Console.WriteLine("You find a way out of the swamp and continue your journey.");
                }
                else
                {
                    Console.WriteLine("You try to cross the swamp, but you get stuck and can't get out. Unfortunately, you didn't survive.");
                }
                break;
            case "c":
                Console.WriteLine("You head towards the riverbank and find a wide river blocking your way.");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("a) Try to cross the river.");
                Console.WriteLine("b) Go back to the forest.");

                string riverChoice = Console.ReadLine().ToLower();
                if (riverChoice == "a")
                {
                    Console.WriteLine("You try to cross the river, but you can't make it. You have to go back to the forest.");
                }
                else
                {
                    Console.WriteLine("You go back to the forest and continue your journey.");
                }
                break;
            case "d":
                Console.WriteLine("You go up to the mountains and discover ancient ruins.");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("a) Explore the ruins.");
                Console.WriteLine("b) Go back to the forest.");

                string mountainChoice = Console.ReadLine().ToLower();
                if (mountainChoice == "a")
                {
                    Console.WriteLine("You explore the ruins and find an ancient relic!");
                    Console.WriteLine("Congratulations, you won!");
                }
                else
                {
                    Console.WriteLine("You go back to the forest and continue your journey.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        Console.WriteLine("Thank you for playing!");
    }
}