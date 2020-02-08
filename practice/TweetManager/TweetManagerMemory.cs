using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public class TweetManagerMemory : TweetManager
    {
        string[] tweets = new string[10];
        int tweetCounter = 0;

        public override string WriteTweet(string tweet)
        {
            tweets[tweetCounter++] = tweet;
            return "Tweet posted successfully.";
        }

        public override int TweetCounter ()
        {
            return tweetCounter;
        }

        public override string[] GetTweets()
        {
            return tweets;
        }
    }
}
