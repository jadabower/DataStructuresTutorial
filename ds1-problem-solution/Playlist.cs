namespace ds1_problem_solution;

public class Playlist
{
    // Member variables
    private Stack<string> _songsToPlay = new();
    private Stack<string> _songsPlayed = new();
    private string? _currentSong;

    // Getters
    public Stack<string> GetSongsToPlay()
    {
        return _songsToPlay;
    }
    public Stack<string> GetSongsPlayed()
    {
        return _songsPlayed;
    }
    public string GetCurrentSong()
    {
        if (_currentSong is not null)
        {
            return _currentSong;
        }

        return "";
    }

    // Adds a song to the front of the Playlist
    public void AddSong(string songToAdd)
    {
        _songsToPlay.Push(songToAdd);
    }
    
    // "Plays" the next song
    public void PlayNext()
    {
        // Check if the current song is not null
        if (_currentSong is not null)
        {
            // Move the current song to the songs played Stack
            _songsPlayed.Push(_currentSong);
        }

        // Set the current song to the first song in the songs to play Stack
        _currentSong = _songsToPlay.Count == 0 ? null : _songsToPlay.Pop();
    }
    
    // "Plays" the previous song
    public void PlayPrevious()
    {
        // Check if the current song is not null
        if (_currentSong is not null)
        {
            // Move the current song to the songs to play Stack
            _songsToPlay.Push(_currentSong);
        }
        // Set the current song to the first song in the songs played Stack
        _currentSong = _songsPlayed.Count == 0 ? null : _songsPlayed.Pop();
    }

    // You don't really need to worry about this function. All it does it returns a string with
    // all the elements of the Stack nicely formatted.
    public string Stringify(Stack<string> stackToStringify)
    {
        var result = "{";
        // Iterates through the _songs and creates a string with all the elements of the Stack
        for (int i = 0; i < stackToStringify.Count; i++)
        {
            // If it's the last song, don't add another comma
            if (i == stackToStringify.Count - 1)
            {
                result += stackToStringify.ElementAt(i);
            }
            // Otherwise, add a comma and space after the song
            else
            {
                result += stackToStringify.ElementAt(i) + ", ";
            }
        }
        result += "}";
        return result;
    }
}