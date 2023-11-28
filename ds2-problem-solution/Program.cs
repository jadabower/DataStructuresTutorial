// See https://aka.ms/new-console-template for more information
using ds2_problem_solution;

Console.WriteLine("----------Test-PlayNext----------");

// Creates a new Queue
Queue myQueue = new Queue();

// Adds some songs to the Queue
myQueue.PlayNext("Happy Instead");
myQueue.PlayNext("We Were Happy (Taylor's Version)");
myQueue.PlayNext("The Happiest Days of Our Lives");

// Prints the songs in the Queue
Console.WriteLine("Songs to Play: " + myQueue.Stringify()); 
// Expected result: "Songs to Play: {The Happiest Days of Our Lives, We Were Happy (Taylor's Version), Happy Instead}"

Console.WriteLine("----------Test-PlayLast----------");

// Creates a new Queue
Queue myOtherQueue = new Queue();

// Adds some songs to the Queue
myOtherQueue.PlayLast("Happy Instead");
myOtherQueue.PlayLast("We Were Happy (Taylor's Version)");
myOtherQueue.PlayLast("The Happiest Days of Our Lives");

// Prints the songs in the Queue
Console.WriteLine("Songs to Play: " + myOtherQueue.Stringify()); 
// Expected result: "Songs to Play: {Happy Instead, We Were Happy (Taylor's Version), The Happiest Days of Our Lives}"