using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
   public class TweetManagerFile :TweetManager
   {
       private string fileName = @"C:\Users\Hemory\source\repos\TwitterConsole\TwitterConsole\tweets.txt";

        public override string WriteTweet(string tweet)
        {
            
            File.AppendAllLines(fileName, new string[] { tweet });

            return "Tweet posted successfully";
        }

        public override int TweetCounter()
        {
            return File.ReadAllLines(fileName).Length;
        }

        public override string[] GetTweets()
        {
            return File.ReadAllLines(fileName);
        }

       
    }
}
