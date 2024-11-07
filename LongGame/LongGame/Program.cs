using System;
using System.IO;

namespace LongGame
{
    internal class Program
    {

        public static void play()
        {
            int score = 0;

            Console.WriteLine("\nWhat is your name traveler?");
            String name = Console.ReadLine();
            Console.WriteLine("Well hello there " + name);
            if (File.Exists(name + ".txt"))
            {
                string oldScore = File.ReadAllText(name + ".txt");
                int oldScoreNum = int.Parse(oldScore);
                score = oldScoreNum;
                Console.WriteLine("You have played before and your old score is: " + score);
            }

            Console.WriteLine("Lets see how many key presses you can make");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                score++;
                Console.WriteLine("\bYour current score is: " + score);
            }

            string scoreString = score.ToString();
            /*File.Create("/" + name + ".txt");*/
            File.WriteAllText(name + ".txt", scoreString);

            string readText = File.ReadAllText(name + ".txt");
            Console.WriteLine("Your final saved score is:" + readText);
            
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nPress p if you want to play again and q if you want to quit");
                String playOrQuit = Console.ReadLine();

                if (playOrQuit == "p")
                {
                    play();
                }
                else
                {
                    Console.WriteLine("Thanks for playing");
                    break;
                }
            }

            
            
        }

        }
    }

