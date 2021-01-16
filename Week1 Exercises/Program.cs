using System;
using System.Collections.Generic;
using System.Linq;

namespace Week1_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------------------------------------------------
            // Exercise: Mask Sensitive Information
            Console.WriteLine("Please enter a secret: ");
            string secret = Console.ReadLine();
            string maskedSecret = "";
            for (int i = 0; i < secret.Count() - 4; i++)
            {
                maskedSecret = maskedSecret + "*";
            }

            string lastFour = secret.Substring(secret.Length - 4);
            Console.WriteLine($"The masked secret is: {maskedSecret}{lastFour}");

            // --------------------------------------------------------------------------------------
            // Exercise: Calculator
            //Console.WriteLine("Please enter a comma separated list of numbers (example: 6,1,5):");
            //string userInput = Console.ReadLine();
            //string[] values = userInput.Split(',');
            //int[] userInts = Array.ConvertAll(values, int.Parse);

            //Console.WriteLine("Enter \"*\" to multiply all values or \"^\" to square each individual value");
            //string mathOp = Console.ReadLine();

            //if (mathOp == "*")
            //{
            //    int total = 1;
            //    foreach (int num in userInts)
            //    {
            //        total = total * num;
            //    }

            //    Console.WriteLine(total);
            //}
            //else if (mathOp == "^")
            //{
            //    string numsSquared = "";
            //    foreach (int num in userInts)
            //    {
            //        int numSquared = num * num;
            //        numsSquared = numsSquared + $"{numSquared},";
            //    }
            //    Console.WriteLine(numsSquared);
            //}
            // --------------------------------------------------------------------------------------
            // Exercise: Calculator 2.0
            //Console.WriteLine("Please enter a mathematical operator (+,-,/,*, or ^) followed by a space and then a list of numbers separated by commas. Ex. + 2,3,4");
            //char [] separators = { ' ', ',' };
            //string userInput2 = Console.ReadLine();
            //List<string> values2 = userInput2.Split(separators).ToList();
            //string mathOperation = values2[0];

            //if (mathOperation == "*")
            //{
            //    int total = 1;
            //    for (int i = 1; i < values2.Count; i++)
            //    {

            //        total = total * int.Parse(values2[i]);
            //    }

            //    Console.WriteLine(total);
            //}
            //else if (mathOperation == "^2")
            //{
            //    string numsSquared = "";
            //    for (int i = 1; i < values2.Count; i++)
            //    {
            //        int numSquared = int.Parse(values2[i]) * int.Parse(values2[i]);
            //        numsSquared = numsSquared + $"{numSquared},";
            //    }
            //    Console.WriteLine(numsSquared);
            //}
            //else if (mathOperation == "+")
            //{
            //    int total = 0;
            //    for (int i = 1; i < values2.Count; i++)
            //    {
            //        total = total + int.Parse(values2[i]);
            //    }

            //    Console.WriteLine(total);
            //}

            // --------------------------------------------------------------------------
            // Exercise: Hello World
            //Console.WriteLine("Howdy Y'all!!");

            //// Exercise: Console Input. Feature: 1.
            //Console.WriteLine("Please enter your name.");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"Hello, {userName}.");

            //// Feature 1
            //var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            //var vowels = new string[] { "a", "e", "i", "o", "u" };
            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal);
            //    // if animal has two or more syllables print
            //    if (animal == "Triceratops")
            //    {
            //        Console.WriteLine("Caught him!");
            //    }
            //}

            //// Feature 2
            //Console.WriteLine("Please pick a greeting: Southern, Eastern, Western.");
            //string greeting = Console.ReadLine();
            //Console.WriteLine($"You selected a {greeting} greeting.");

            //// Exercise: Console Input. Feature: 2.
            //Console.WriteLine("Please enter your favorite color.");
            //string favoriteColor = Console.ReadLine();

            //// Exercise: Console Input. Feature: 2.
            //Random rand = new Random();
            //int index = rand.Next(animals.Length);
            //Console.WriteLine($"Would you like to have a {favoriteColor} {animals[index]}.");

            // --------------------------------------------------------------------------
            // Exercise: Letter Loops
            //Console.WriteLine("Input something:");
            //string userString = Console.ReadLine();
            //string userStringCapitalized = userString.ToUpper();
            //string userStringLowerCase = userString.ToLower();
            //for (int i = 0; i < userStringCapitalized.Length; i++)
            //{
            //    string lowerCaseLetters = "";
            //    if (i > 0)
            //    {
            //        for (int j = 0; j < i; j++)
            //        {
            //            lowerCaseLetters = lowerCaseLetters + userStringLowerCase[i];
            //        }
            //    }
            //    if (i == userStringCapitalized.Length - 1)
            //    {

            //        Console.Write($"{userStringCapitalized[i]}{lowerCaseLetters}");
            //    }
            //    else
            //    {
            //        Console.Write($"{userStringCapitalized[i]}{lowerCaseLetters}-");
            //    }
            //}
            // --------------------------------------------------------------------------

        }
    }
}
