using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
   public class TweetManagerMemory:TweetManager
    {
        readonly string[] tweets = new string[10];
        private int _tweetCounter;

        public override string WriteTweet(string tweet)
        {
            if (tweet.Length > 140)
            {
                return "Error: Tweet is longer than 140 characters";
            }

            if (_tweetCounter >= tweets.Length)
            {
                return "Error: Max tweet reached";
            }

            tweets[_tweetCounter++] = tweet;
            return "Tweet posted successfully";
        }

        public override string[] GetTweets()
        {
            return tweets;
        }

        public override int TweetCounter()
        {
            return _tweetCounter;
        }
    }
}
