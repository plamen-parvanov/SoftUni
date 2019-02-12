namespace _04.OnlineRadioDatabase.Exceptions
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private const string text =
            "Artist name should be between {0} and {1} symbols.";

        public InvalidArtistNameException(int min, int max)
            : base(string.Format(text, min, max))
        {
            
        }

    }
}
