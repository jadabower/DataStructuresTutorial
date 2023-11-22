// See https://aka.ms/new-console-template for more information
using ds1_problem_solution;

Console.WriteLine("----------Test-AddSong----------");

// Creates a new Playlist
Playlist myPlaylist = new Playlist();

// Adds some songs to the Playlist
myPlaylist.AddSong("Happy Instead");
myPlaylist.AddSong("We Were Happy (Taylor's Version)");
myPlaylist.AddSong("The Happiest Days of Our Lives");

// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {The Happiest Days of Our Lives, We Were Happy (Taylor's Version), Happy Instead}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: "

Console.WriteLine("----------Test-PlayNext----------");

myPlaylist.PlayNext();
// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {We Were Happy (Taylor's Version), Happy Instead}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: The Happiest Days of Our Lives"
Console.WriteLine("--------------------");

myPlaylist.PlayNext();
// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {Happy Instead}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {The Happiest Days of Our Lives}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: We Were Happy (Taylor's Version)"
Console.WriteLine("--------------------");

myPlaylist.PlayNext();
// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {We Were Happy (Taylor's Version), The Happiest Days of Our Lives}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: Happy Instead"
Console.WriteLine("--------------------");

myPlaylist.PlayNext();
// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {Happy Instead, We Were Happy (Taylor's Version), The Happiest Days of Our Lives}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: "

Console.WriteLine("----------Test-PlayPrevious----------");

myPlaylist.PlayPrevious();
// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {We Were Happy (Taylor's Version), The Happiest Days of Our Lives}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: Happy Instead"
Console.WriteLine("--------------------");

myPlaylist.PlayPrevious();
// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {Happy Instead}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {The Happiest Days of Our Lives}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: We Were Happy (Taylor's Version)"
Console.WriteLine("--------------------");

myPlaylist.PlayPrevious();
// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {We Were Happy (Taylor's Version), Happy Instead}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: The Happiest Days of Our Lives"
Console.WriteLine("--------------------");

myPlaylist.PlayPrevious();
// Prints the songs to play, the songs that have already been played, and the current song
Console.WriteLine("Songs to Play: " + myPlaylist.Stringify(myPlaylist.GetSongsToPlay())); 
// Expected result: "Songs to Play: {The Happiest Days of Our Lives, We Were Happy (Taylor's Version), Happy Instead}"
Console.WriteLine("Songs Already Played: " + myPlaylist.Stringify(myPlaylist.GetSongsPlayed())); 
// Expected result: "Songs Already Played: {}"
Console.WriteLine("Current Song: " + myPlaylist.GetCurrentSong());
// Expected result: "Current Song: "
Console.WriteLine("--------------------");