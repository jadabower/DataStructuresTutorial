namespace ds2_example;
using System.Collections.Generic;

public class Queue
{
    LinkedList<string> _songs = new();
    
    // Adds a song to the beginning of the queue
    public void PlayNext(string songName) 
    {
        _songs.AddFirst(songName);
    }
    
    // Makes the Linked List pretty
    public string Stringify()
    {
        var result = "{";
        // Iterates through the _songs and creates a string with all the elements of the Stack
        foreach(string song in _songs)
        {
            
            // If it's the last song, don't add another comma
            if (song == _songs.Last.Value)
            {
                result += song;
            }
            // Otherwise, add a comma and space after the song
            else
            {
                result += song + ", ";
            }
        }
        result += "}";
        return result;
    }
}