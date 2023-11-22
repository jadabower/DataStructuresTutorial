// See https://aka.ms/new-console-template for more information
using ds1_example;

Console.WriteLine("----------Example Code----------");

// Creates a new Playlist
Playlist myHappyPlaylist = new Playlist();

// Prints the Playlist
Console.WriteLine("My Happy Playlist: " + myHappyPlaylist.Stringify()); 
// Expected result: "My Happy Playlist: {}"

// Adds some songs to the Playlist
myHappyPlaylist.AddSong("Happy Instead");
myHappyPlaylist.AddSong("We Were Happy (Taylor's Version)");
myHappyPlaylist.AddSong("The Happiest Days of Our Lives");

// Prints the Playlist (in the order we added the songs, with the most recently added song on the left)
Console.WriteLine("My Happy Playlist: " + myHappyPlaylist.Stringify()); 
// Expected result: "My Happy Playlist: {The Happiest Days of Our Lives, We Were Happy (Taylor's Version), Happy Instead}"


