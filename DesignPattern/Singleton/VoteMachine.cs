namespace Singleton
{
    public class VoteMachine
    {
        private static VoteMachine _VoteInstance = null;
        private int _totalvote;
        private static readonly object _lock = new object();
        private VoteMachine()
        {
        }

        public static VoteMachine VoteInstance
        {
            get
            {
                lock (_lock)
                    {
                        if (_VoteInstance == null)
                        {
                            _VoteInstance = new VoteMachine();
                        }
                    }

                    return _VoteInstance;
                


            }
        }

        public void Register()
        {
            _totalvote++;
            Console.WriteLine($"#Registered Vote: {_totalvote}");
        }

        public int TotalVote
        {
            get { return _totalvote; }
        }

    }
}
