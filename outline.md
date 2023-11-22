# Data Structures Tutorial

## I. Welcome

### About This Tutorial

This project will be a tutorial to learn and use a few commonly used Data Structures.

A Data Structure is a formatted way of organizing information, specifically in code. There are many different kinds of
Data Structures because each one has it's own strengths and weaknesses.

We represent a Data Structures' efficiency (how fast it is at doing a specific task, in other words, the strengths and
weaknesses of the structure) by using the "Big O" notation. Big O works just like a function in math: there is an
input (n), and an output (time). So if I were to say the performance of a function is O(n^2), that would mean the time
it takes to complete the task is roughly squared the input size. So a function with O(n) input is faster than one with
O(n^2).

This tutorial is in the C# language, so any syntactical questions may be referred to
the [C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/).

### Get Started

* [Stack](1-stack.md)
* [Linked List](2-linkedList.md)
* [Tree](3-tree.md)

### Contact Information

For questions or comments, please send them to:

Jada Bower, BYU-Idaho, CSE 212, Section 3

[bow22005@byui.edu](mailto:bow22005@byui.edu?)

## II. Stack

* Explain what a Stack is and why they are good at keeping things in order. Explain that it is O(1) to push a value, pop
  a value, get the size, and get if the stack is empty. It is also very fast to reverse the stack.
* Stack of books example with video demonstration.
* Code Example with music player - How to sort a playlist by recently added
* Problem to solve with music player - How to sort a playlist with the oldest song first and the most recently added
  song at the back.

## III. Linked List

* Explain what a Linked List is and how it contains two classes: the Linked List class and the Node class. All the
  Linked List has is a head and a tail Node (and functions to manipulate the List). The Node class simply has a value
  and a next and previous Node. Explain that the Linked List structure is excellent at adding or removing from the
  beginning or end O(1), and not as good at adding or removing from the middle of the list O(n).
* Example with people holding hands in a line (drawings along with the example).
* Code Example with music player - Adding a song to be "played next", or to the front of a queue
* Problem to Solve with music player - Adding a song to be "played last", or to the back of a queue

## IV. Tree

* Explain what a Binary Search Tree is and how each path on the tree is like a sorted Linked List. Explain the
  relationships between the nodes (parent and children nodes, with each Node containing a right and left Node pointer).
  Also explain why this Data Structure is so good at sorting things and how it is easy to find any item if you know the
  value of the item. Explain that we typically use Recursion to traverse through BST's (and explain what Recursion is
  and why it's useful). Explain that because of Recursion and the nature of the BST, the Big O of BST's are O(log(n))
  for a lot of functions that would have been O(n) otherwise.
* Deck of cards sorting example with video
* Code Example with music player - Alphabetize playlist (sort the playlist)
* Problem to Solve with music player - Sort a playlist by release date