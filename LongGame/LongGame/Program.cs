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

            File.WriteAllText(name+".txt", scoreString);
            



                
            }

        }
    }

