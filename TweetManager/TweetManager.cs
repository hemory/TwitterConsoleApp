using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public abstract class TweetManager
    {
        private int maxTweet = 10;

        public string PostTweet(string tweet)
        {
            if (tweet.Length > 140)
            {
                return "Error: Tweet is longer than 140 characters";
            }

            if (TweetCounter() >= maxTweet)
            {
                return "Error: Max tweet reached";
            }

            //Everything is forced to go through this PostTweet method in order to call the override of the Write Tweet method. So all the validation is 
            //done first and then the classes specific implementation of the method is executed
            return WriteTweet(tweet);
        }

        public abstract string[] GetTweets();
        public abstract int TweetCounter();
        public abstract string WriteTweet(string tweet);

        public List<string> Search(string searchTerm)
        {
            List<string> results = new List<string>();

            for (int i = 0; i < TweetCounter(); i++)
            {
                if (GetTweets()[i].Contains(searchTerm))
                {
                    results.Add(GetTweets()[i]);
                }
            }

            return results;
        }


    }
}
