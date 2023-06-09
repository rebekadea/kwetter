using TweetService.Models;

namespace TweetService.Data
{
    public interface ITweetRepo
    {
        bool SaveChanges();
        IEnumerable<Tweet> GetAllTweets();
        Tweet GetTweetById(int id);
        void CreateTweet(Tweet tweet);
        void DeleteTweet(int id);
        void updateTweet(int tweetId, Tweet tweet);

        List<Tweet> GetTweetsByName(string username);
    }
}