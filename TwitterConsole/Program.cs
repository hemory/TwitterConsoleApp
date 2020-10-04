using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetManager;

namespace TwitterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TweetManagerFile tm = new TweetManagerFile();

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("-----Main Menu-----");
                Console.WriteLine();
                Console.WriteLine("(1) View all tweets");
                Console.WriteLine("(2) Post a new Post");
                Console.WriteLine("(3) Search");
                Console.WriteLine("(4) Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        for (int i = 0; i < tm.TweetCounter(); i++)
                        {
                            Console.WriteLine($"Tweet #{i + 1}:{tm.GetTweets()[i]}");
                        }

                        break;

                    case "2":
                        Console.WriteLine("Enter your tweet");
                        string tweet = Console.ReadLine();

                        //Calls the PostTweet method in the abstract class
                        tm.PostTweet(tweet);
                        break;

                    case "3":
                        Console.WriteLine("Enter search term");
                        string searchTerm = Console.ReadLine();

                        List<string> results = tm.Search(searchTerm);

                        Console.WriteLine($"Found {results.Count} tweets.");

                        break;

                    case "4":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        break;
                }
            }
        }
    }
}
