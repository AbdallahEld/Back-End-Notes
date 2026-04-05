namespace Indexer
{
    public class Team
    {
        private List<string> players = new();

        public string this[int i]
        {
            get => players[i];
            set
            {
                while (players.Count <= i)
                {
                    players.Add(string.Empty);
                }
                players[i] = value;
            }
        }
    }
}
