using System;
using System.Linq;
using System.Collections.Generic;

namespace NIcknames
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Random rand = new Random();
            int choice = 0;
            string nickName = "----";
            string input2 = "";
            var randomNickname = new List<string>() { "the T-Rex", "the Robot", "the Legendary", "the Crusher", "the Jester", "the Mad Lad Himself", "the Weirdo", "the Sussy", "the Spy", "the Imposter" };
            Console.WriteLine("Enter First Name: ");
            int listLength = randomNickname.Count;
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            int nickIndex = rand.Next(0, listLength);
            do
            {
                Console.Clear();
                Console.WriteLine("Current Name is: " + firstName + " " + nickName + " " + lastName);
                Console.WriteLine("What would you like to do now?");
                Console.WriteLine("1. Change your name (type change nickname or 'change')");
                Console.WriteLine("2. Display a random Nickname (type random nickname or 'random')");
                Console.WriteLine("3. Display all Nicknames (type all nicknames or 'all')");
                Console.WriteLine("4. Add a Nickname (type add nickname or 'add')");
                Console.WriteLine("5. Remove a Nickname (type remove nickname or 'remove')");
                Console.WriteLine("6. Exit (type exit or 'e')");
                Console.WriteLine("Enter Option Here: ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "change name" | userInput.ToLower() == "change")
                {
                    choice = 1;
                }
                else if (userInput.ToLower() == "random nickname" | userInput.ToLower() == "random")
                {
                    choice = 2;
                }
                else if (userInput.ToLower() == "all nicknames" | userInput.ToLower() == "all")
                {
                    choice = 3;
                }
                else if (userInput.ToLower() == "add nickname" | userInput.ToLower() == "add")
                {
                    choice = 4;
                }
                else if (userInput.ToLower() == "remove nickname" | userInput.ToLower() == "remove")
                {
                    choice = 5;
                }
                else if (userInput.ToLower() == "exit" | userInput.ToLower() == "e")
                {
                    choice = 6;
                }
                else
                {
                    choice = 0;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please re-enter your first name: ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Please re-enter your last name: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Name changed to: " + firstName + " " + lastName + ".");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        nickIndex = rand.Next(0, listLength);
                        Console.WriteLine("Your new nickname is " + randomNickname[nickIndex] + ".");
                        nickName = randomNickname[nickIndex];
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Here is a list of all the possible nicknames that could be added to your name: ");
                        for (int i = 0; i < listLength; i++)
                        {
                            Console.WriteLine(firstName + " " + randomNickname[i] + " " +   lastName);
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter the new nickname you would like to add: ");
                        input2 = Console.ReadLine();
                        randomNickname.Add(input2);
                        listLength = randomNickname.Count;
                        Console.WriteLine("New name registered! Now listing all possible names: ");
                        for (int i = 0; i < listLength; i++)
                        {
                            Console.WriteLine(firstName + " " + randomNickname[i] + " " + lastName);
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        int displayListElements = listLength - 1;
                        Console.WriteLine("Enter the number of the nickname that you would like to remove. The list ranges from 0 - " + displayListElements + " (the first name is counted as 0) : ");
                        for (int i = 0; i < listLength; i++)
                        {
                            Console.WriteLine(firstName + " " + randomNickname[i] + " " + lastName);
                        }
                        int input2Integer = Convert.ToInt32(Console.ReadLine());
                        randomNickname.RemoveAt(input2Integer);
                        listLength = randomNickname.Count;
                        Console.WriteLine("Name Removed! Now listing all possible names: ");
                        for (int i2 = 0; i2 < listLength; i2++)
                        {
                            Console.WriteLine(firstName + " " + randomNickname[i2] + " " + lastName);
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Shutting down code now. Press any key to continue...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(firstName + " " + nickName + " " + lastName + "! There's a time and place for everything! But not now.");
                        Console.WriteLine("That isn't an option that you can make.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            while (choice != 6);
        }
    }
}
