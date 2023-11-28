# Stack

[Back to Home](0-welcome.md)

## Overview

A Stack is a very useful data structure because it allows us to keep
everything in order. It is also a very simple structure, containing two main
methods: Push and Pop. The way a Stack works is that you create a stack with
a data type for what it can hold. You can create the Stack either as an empty
Stack or with a given collection of information.

```c#
// Instantiating an empty Stack
var myEmptyStack = new Stack<int>();

// Instantiating a Stack with a given collection
var myGivenStack = new Stack<string>(new[] {"H", "e", "l", "l", "o"});
```

After your Stack is created, you can Push (add a value to the front, or
top, of the Stack), or Pop (remove the most recently added item). This
method of both adding and removing from the same side of the data structure
is called "First In Last Out", or "FILO". It means that the first item you
add to the Stack (using Push) will be the last one you remove. Or that the
item you Pushed most recently to the Stack will be the first one you remove.
Because of this, this data structure is excellent at keeping information in
the order that you added it. This is also useful for keeping track of where
You are in the stack (which is often used in programming for keeping track of
operations, and order in which to execute code).

## Methods

### Push

The Push method is one of the two methods needed to create a functional Stack
class. The `Push(value)` method allows you to add a `value` to the top of
your Stack, *pushing* it's way in front of all the other values. Here is
an example of using the Push method:

```c#
// Creates an empty Stack named myStack
var myStack = new Stack<int>();
// myStack now looks like: {}

// Adds a value to the front of the stack
myStack.Push(0); 
// myStack now looks like: {0}

// Adds a value to the front of the stack
myStack.Push(1); 
// myStack now looks like: {1, 0}

// Adds a value to the front of the stack
myStack.Push(2); 
// myStack now looks like: {2, 1, 0}
```

The Big-O efficiency of this operation is O(1) because all it needs to do
is add the value to the front of the Stack, so it doesn't take into account
any other data in the Stack. This extremely fast adding is one of the most
important features of Stacks.

### Pop

Aside from Push, Pop is the only method you need to make a Stack class.
`Pop()` is a method that removes and returns whatever `value` is at the
front/top of a Stack. Here is an example of `Pop()` being used:

```c#
// Same code as from previous example
var myStack = new Stack<int>();
myStack.Push(0); 
myStack.Push(1); 
myStack.Push(2); 
// myStack now looks like: {2, 1, 0}

var firstItem = myStack.Pop();
// firstItem now looks like: 2
// myStack now looks like: {1, 0}

firstItem = myStack.Pop();
// firstItem now looks like: 1
// myStack now looks like: {0}

firstItem = myStack.Pop();
// firstItem now looks like: 0
// myStack now looks like: {}
```

The Big-O efficiency of this method is also O(1) for the same reason as Push:
the algorithm for removing and returning something from the top of a Stack
will always take the same amount of time, no matter how many items are in
the Stack.

### Peek

The `Peek()` method works similarly to the `Pop()` function in that both return the
item from the front of the Stack. The difference is that Pop *removes* the item from
the Stack as well, while Peek does not. Here is an example of `Peek()` being used:

```c#
// Same code as from a previous example
var myStack = new Stack<int>();
myStack.Push(0); 
myStack.Push(1); 
myStack.Push(2); 
// myStack now looks like: {2, 1, 0}

var firstItem = myStack.Peek();
// firstItem now looks like: 2
// myStack now looks like: {2, 1, 0}
```

The Big-O efficiency of this method is also O(1) for the same reason as the last two.
It does not matter how many items are in the list, the method just needs to look at
the very first item.
### Others
There are, of course, other methods in the Stack class, but these are the methods that
are most unique to Stacks and most necessary for the class to work. For a list of other
Stack methods in C#, click [here](https://www.geeksforgeeks.org/c-sharp-stack-class/).

## Big-O Efficiency Chart

| **Method** | **Efficiency** |
|------------|----------------|
| Push       | O(1)           |
| Pop        | O(1)           |
| Peek       | O(1)           |

## Stack of Books Example
Let's use a stack of books to describe how Stacks in programming work. 

Say you had a stack of books. At first, the stack is empty.

![image of the empty stack](images/emptyStack.PNG)

You can add a book to the top of the stack. This is like the `Push` method of the Stack class
in C#.

![image of the stack with one book](images/oneBookStack.PNG)

You can continue adding books to the top of the stack for as long as you want.

![image of full stack](images/fullStack.PNG)

To remove a book from the stack, you can use the `Pop` method.

![image of stack with one less book](images/oneBookRemovedStack.PNG)

To reverse the stack, we just remove the book from the top of the stack and add it to the top
of the reversed stack. 

![image of reversed stack](images/reversedStack.PNG)

To watch a video of the book example click [here](https://youtu.be/br35tJmDHTg).

## Code Example - Recently Added

Let's use the example of a music player (like Spotify or Apple Music) to show off the
functionality of Stacks. If we wanted to create a playlist in Spotify, it would
automatically make it sorted by the most recently added songs to the least recently
added songs. That sounds suspiciously like a Stack to me!

Let's assume for our example that each song is just a `string` with the song title. Of
course if we wanted to make a more realistic music player, we would need to create a
`Song` class with additional information like the creators, release date, album name,
song file, etc.. For sake of simplicity, we will just use the song name.

First, we create a `Playlist` class that we will be able to add (or `Push`) songs to.
The Playlist will have a Stack of songs. 
```c#
public class Playlist
{
    // Member variable - a Stack of songs (as strings).
    private Stack<string> _songs = new();
}
```
We should also create a method to add a song to our playlist.
```c#
public class Playlist
{
    //...
    // Adds a song to the front of the Playlist
    public void AddSong(string songToAdd)
    {
        _songs.Push(songToAdd);
    }
}
```
After adding a simple method to get the Stack in the form of a `string`, we can safely test
our `Playlist` class by adding songs and printing out the playlist.

Test Code:
```c#
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
```
Test Output:
```
My Happy Playlist: {}
My Happy Playlist: {The Happiest Days of Our Lives, We Were Happy (Taylor's Version), Happy Instead}
```
What an awesome program! This makes it clear how useful Stacks are at keeping information 
in order!

If you want to run this program for yourself, here is the [solution code](ds1-example)!

## Problem to Solve - Previous and Next
Right now, our Playlist class is not very functional. We can create a Playlist, sure, and
can add songs to it, but we have no way of iterating through the playlist.

For this problem, I want **you** to use the [starter code](ds1-problem) as a starting
point in creating the `PlayNext` and `PlayPrevious` methods of the `Playlist` Class, so
that we can iterate through the songs to play and go back through the songs already played.

For this problem, remember the `Push` and `Pop` methods of the Stack class. These methods
will be very useful in creating highly efficient code. 

Replace the `TODO!` comments in the `Playlist` class with code using the method 
variables provided. Try to get it so that all the test cases in the `Program` file give the 
correct output (based on the comments following each line).

Once you have worked on the code for a while or have come up with a solution to the problem,
check your solution against [my solution](ds1-problem-solution)!

Congratulations! You can now use Stacks in your daily life!