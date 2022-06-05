namespace StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post("War of Thrones", "Song by Blind Guardian");

            System.Console.WriteLine("Title of post: " + post.getTitle());
            System.Console.WriteLine("Description: " + post.getDescription());
            System.Console.WriteLine("Creation Time: " + post.getCreationTime());

            post.UpVote();
            post.UpVote();

            System.Console.WriteLine("Total # of votes: " + post.CurrentVotes);

            post.DownVote();
            System.Console.WriteLine("Total # of votes: " + post.CurrentVotes);
            
            post.DownVote();

            System.Console.WriteLine("Total # of votes: " + post.CurrentVotes);

            var post2 = new Post("The Biker's Drug", "The DeathWheelers");

            post.UpVote();

            System.Console.WriteLine("Total votes for 1st post: " + post.CurrentVotes);
            System.Console.WriteLine("TOtal votes for brand new post: " + post2.CurrentVotes);

            System.Console.WriteLine("Names of posts!");
            System.Console.WriteLine("1th: " + post.getTitle());
            System.Console.WriteLine("2nd: " + post2.getTitle());

            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();

            System.Console.WriteLine("Total votes for 1st post: " + post.CurrentVotes);
            System.Console.WriteLine("TOtal votes for brand new post: " + post2.CurrentVotes);
            
        }
    }
}
