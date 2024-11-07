using System;
using System.IO;

namespace LongGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("What is your name traveler?");
            String name = Console.ReadLine();
            Console.WriteLine("Well hello there " + name);

            Console.WriteLine("Lets see how many key presses you can make");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                score++;
                Console.WriteLine("\bYour current score is: " + score);

            }
            string scoreString = score.ToString();
            /*File.Create("/" + name + ".txt");*/
            File.WriteAllText(name+".txt", scoreString);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);





        }

        }
    }

