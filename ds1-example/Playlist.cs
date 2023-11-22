namespace ds1_example;

public class Playlist
{
    // Member variable - a Stack of songs (as strings).
    private Stack<string> _songs = new();

    // Adds a song to the front of the Playlist
    public void AddSong(string songToAdd)
    {
        _songs.Push(songToAdd);
    }

    // You don't really need to worry about this function. All it does it returns a string with
    // all the elements of the Stack nicely formatted.
    public string Stringify()
    {
        var result = "{";
        // Iterates through the _songs and creates a string with all the elements of the Stack
        for (int i = 0; i < _songs.Count; i++)
        {
            // If it's the last song, don't add another comma
            if (i == _songs.Count - 1)
            {
                result += _songs.ElementAt(i);
            }
            // Otherwise, add a comma and space after the song
            else
            {
                result += _songs.ElementAt(i) + ", ";
            }
        }
        result += "}";
        return result;
    }
}