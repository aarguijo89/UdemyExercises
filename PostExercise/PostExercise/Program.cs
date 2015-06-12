using System;

namespace PostExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("HellO!","Here is a description!!!");
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            Console.WriteLine("Votes: {0}", post.GetVoteCount());

            Console.ReadLine();
        }
    }
}
