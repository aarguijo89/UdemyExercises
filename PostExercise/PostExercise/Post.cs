using System;

namespace PostExercise
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; private set; }
        private int _voteCount;

        public Post()
        {
            CreatedDate = DateTime.Now;
        }

        public Post(string title, string description):this()
        {
            Title = title;
            Description = description;
        }

        public void UpVote()
        {
            _voteCount ++;
        }

        public void DownVote()
        {
            _voteCount--;
        }

        public int GetVoteCount()
        {
            return _voteCount;
        }

    }
}