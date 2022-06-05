using System;

namespace StackOverFlow
{
    public class Post
    {
        private string _tile;
        private string _description;
        private DateTime _creationTime;
        private int _votes;

        public Post(string title, string description)
        {
            this._tile = title;
            this._description = description;
            this._creationTime = DateTime.Now;

            this._votes = 0;
        }

        public void UpVote()
        {
            this._votes++;
        }

        public void DownVote()
        {
            this._votes--;
        }

        public string getTitle()
        {
            return this._tile;
        }

        public string getDescription()
        {
            return this._description;
        }

        public DateTime getCreationTime()
        {
            return this._creationTime;
        }

        public int CurrentVotes {             
             get
             {
                return this._votes;    
             } 
        }
    }
}
