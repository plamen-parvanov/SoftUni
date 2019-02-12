namespace _04.OnlineRadioDatabase.Songs
{
    using _04.OnlineRadioDatabase.Exceptions;
    using System;

    public class Song
    {
        private const int ARTIST_NAME_MIN_LENGTH = 3;
        private const int ARTIST_NAME_MAX_LENGTH = 20;
        private const int SONG_NAME_MIN_LENGTH = 3;
        private const int SONG_NAME_MAX_LENGTH = 30;



        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song()
        {

        }

        public string ArtistName
        {
            get
            {
                return this.artistName;
            }
            private set
            {
                ValidateArtistName(value, ARTIST_NAME_MIN_LENGTH, ARTIST_NAME_MAX_LENGTH);

                this.artistName = value;
            }
        }

        private void ValidateArtistName(string value, int minLength, int maxLength)
        {
            if (value.Length < minLength || value.Length > maxLength)
            {
                throw new InvalidArtistNameException(minLength, maxLength);
            }
        }
    }
}
