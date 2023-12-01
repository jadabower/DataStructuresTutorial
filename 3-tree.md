# Tree

[Back to Home](0-welcome.md)

## Overview

A Tree is a data structure that is very similar to the Linked List structure that we looked at
in [the previous section](2-linkedList.md). The main difference between a Tree and a Linked List is that the Linked 
List has only one head and one tail. A Tree can have many tails. However, in Trees, we call
the "head" the "root" and the "tail[s]" the "leaves", just like a real tree. If you will
recall from the Linked List structure, there are two classes: the class for the Linked List
itself, and the class for the node (or individual item in the list). Each node had a `Previous`
and a `Next` member variable that pointed to the node before and after it in the Linked List.
In a Tree, we have the Tree class that just points to the root, and a node class.
Each node will instead point to the `Left` and `Right` nodes. 

When a Tree is set up like this so that each node only has a `Left` and a `Right` node (meaning
no more than two "child" nodes, or nodes that extend from it), we call it a "Binary Tree". 
This is the kind of Tree we will focus on in this tutorial, specifically a type of Binary Tree
called the "Binary Search Tree" or "BST". The BST is just a Binary Tree (each node has a maximum
of two branches) with a rule that says everything on the left of each node is smaller
than the node, and everything on the right of the node is bigger than (or equal to, depending
on if you want the tree to allow for repeated nodes) the node. "smaller than" and "bigger than" 
can be kind of ambiguous terms, but that is the point. With this data structure, we can decide
what we want "smaller than" and "bigger than" to mean, and with that we can sort a BST however
we choose. This means we can search through easily (much more efficiently) the whole data
structure if we are looking for a specific node.

## Recursion

To understand how a BST can "search", we must first understand the idea of "Recursion". 
Recursion is the idea of breaking things down into the smallest possible step we can take,
and taking that step many times, until we eventually get the outcome we need. In programming,
we use recursion by calling some function or other within itself, meaning it would create a
never ending loop (until the call stack overflows) unless we call it each time with self-depreciating
parameters (the arguments given in the calling of the function within the function cannot be
the same as the arguments this instance of the function received). Let's make a BST of 
cards to explain more in depth:

## Cards Sorting Example
 
To understand how to use the Binary Search Tree `Insert` function, I made 
[this vide](https://youtu.be/1nyi1O2bMqs). Basically, we compare the node we want 
to add to the Root of the tree. If the new node's data is smaller, try to insert the
new value to the Left of the Root. If there is already a node there however, we just 
call the `Insert` method again acting as if this node were the Root of the tree. If
the value to add is bigger than or equal to the Root, do the same thing but on the 
Right node. Continue this process until you have found a null spot to try to insert
into, and just put the new node there. 

This method of calling the same function within itself with a more specific value
is what programmers mean by recursion.

## Methods

### Insert

`Insert(value)` should insert a `value` to the BST wherever it fits. It should recursively 
move through the tree to find where the new node should be inserted, and put it there.

To find where the value must be inserted, we search through the BST recursively.

```c#
// If we had a BST called 'myBST' that looks like this:
//         4
//        / \
//       2   6
//      / \   \
//     1   3   7
// and we wanted to insert 5 to the tree, we would do something like:

myBST.Insert(5);
// and now the myBST looks like this:
//          4
//        /   \
//       2     6
//      / \   / \
//     1   3 5   7
```

In the previous example, here are the steps the Insert function would have taken:
1. Check the value against the Root (4). Because the value to be inserted is greater than 
the value of the Root, move to the Root's Right node. 
2. Now we are on the (6) node. The value to be inserted is less than the current node's value.
3. Because the Left of (6) is null, we simply create a new node on (6)'s Left with the value. 

The actual C# implementation may look different based on how you choose to write your BST 
class, but this is the general idea.

The Big-O of this method is O(log(n)). This is because with each decision (each time the method
checks whether the value should go to the Left or Right of the current node), the number of 
remaining numbers to check against is cut in half (or, roughly in half. It is only perfectly
in half if there are the same number of nodes on both sides of the tree. We call this being
balanced). The mathematical way to suggest this is log base two. But in Big-O notation we 
drop the base two and simply say it is O(log(n)).

### Remove

This method is slightly different based on how the person who wrote the method chose to implement
it. It might remove a given value or a given node. It also might remove only the first
instance of the value given or all instances of it. For our purposes, we will assume the 
`Remove(value)` method takes in a value to remove from the BST, and removes the first instance
of that value. 

This method is fairly similar to the Insert method, except than instead of simply adding the 
new value wherever there is room and it fits, Remove takes the first instance it finds of the
given value and then removes it. It then must readjust the children of the removed node.

Here is an example of the Remove method being used:

```c#
// If we had a BST called 'myBST' that looks like this:
//          4
//        /   \
//       2     6
//      / \   / \
//     1   3 5   7
// and we wanted to remove 6 from the tree, we would do something like:

myBST.Remove(6);
// and now the myBST looks like this:
//          4
//         / \
//        2   5
//       / \   \
//      1   3   7
```

The Big-O for this method is also O(log(n)), for the same reason as the Insert method.

### Contains

The `Contains(value)` method is another common method for BST's to have. The method should
return true if the BST has a node with the given value, and false otherwise. 

Example: 
```c#
// If we had a BST called 'myBST' that looks like this:
//          4
//        /   \
//       2     6
//      / \   / \
//     1   3 5   7

contains5 = myBST.Contains(5);
// contains5 is true because there is a node with the value of 5 in the BST

contains11 = myBST.Contains(11);
// contians11 is false becasue there is no node with the value of 11 in the BST
```

The Big-O for this method is also O(log(n)), for the same reason as the previous methods.

### TraverseForward

This method will also do different things based on how you implement it, but for our case
we will assume that it will return a List of all the values in the BST, sorted from the least
to greatest. To do this, we will need to use an "accumulator". Accumulators are often used in
recursion, as they allow you to add on to some value every time you iterate through the
recursive function. Accumulators are added as a second (optional) parameter, and are typically
returned at the end of the recursive loop. 

Example:
```c#
// If we had a BST called 'myBST' that looks like this:
//          4
//        /   \
//       2     6
//      / \   / \
//     1   3 5   7

forward = myBST.TraverseForward();
// forward is: [1, 2, 3, 4, 5, 6, 7]
```

The Big-O for this method is O(n) because it must iterate through each of the elements in
the Tree.

### TraverseBackward

The TraverseBackward method will do the same thing as the TraverseForward method, but backwards.
It will recursively loop through the tree starting at the right-most leaf rather than the 
left-most one.

Example:
```c#
// If we had a BST called 'myBST' that looks like this:
//          4
//        /   \
//       2     6
//      / \   / \
//     1   3 5   7

backward = myBST.TraverseForward();
// backward is: [7, 6, 5, 4, 3, 2, 1]
```

The Big-O for this method is O(n) because it must iterate through each of the elements in
the Tree.

### Height

Height is a slightly different method because it is actually a method of the node class,
and not the BST class. The height of a node refers to how many "levels" there are in the
Tree:

```c#
// The height of the root  (4) node of this tree (the height of the tree) would be 3
//          4           <- level 1
//        /   \         
//       2     6        <- level 2
//      / \   / \
//     1   3 5   7      <- level 3

// The height of the 'subtree' starting at the (6) node would be 2
//          6           <- level 1
//         / \         
//        5   7         <- level 2

// The height of the subtree starting at the (7) node would be 1
//          7           <- level 1
```

To find the height of a node we simply find the height of the left and the right of the node,
and return whichever side is taller (we do this by recursively calling the Height method on
both sides, adding one each iteration).

The Big-O for this method is O(n) because it must iterate through each of the elements in
the Tree.

### Others

Because there is no built-in BST in C#, you will have to create any methods for this class
that you want. The ones listed above are the most common BST methods, but because it is your
creation, feel free to add any method you can think of!

## Big-O Efficiency Chart

| **Method**       | **Efficiency** |
|------------------|----------------|
| Insert           | O(log(n))      |
| Remove           | O(log(n))      |
| Contains         | O(log(n))      |
| TraverseForward  | O(n)           |
| TraverseBackward | O(n)           |
| Height           | O(n)           |

## Code Example - Alphabetize Playlist

BST's, as discussed, are excellent structures for sorting any amount of data, and finding
data in the structure. Let's use this strength of BST's to create a Playlist of Songs
that are sorted by a specific value.

Sometimes when we create a playlist in a music player, we want to sort it in different
way than just alphabetically by the Artist's name. For this example, we will implement
a way to create a sorted playlist based on the Song name. 

I have gone ahead and created the rest of the BST and Node class, along with a class
for the Songs. The Song class just has a few member variables (like Artist, Name, and 
ReleaseDate), and a Stringify method. 

The only method we need to edit to make it so that we can add a song to a playlist
with a specific 'SortBy' value is the `Insert()` method of the `Node` class. When we
create a BST, we decide what we want the tree to be sorted by when we first create it.
So for our example, we will give the playlist what we want it to be sorted by when we
first create it. Then it should use that SortBy value we gave any time we want to
Insert, Remove, or search for a value. 

Here, we have a method that inserts a Song into the BST wherever it fits based off the
'sortByValue' and 'sortByCurrentNode' string (which the method compares. If the 
sortByValue, or the song-to-add's value is smaller than the current node, it will
insert to the left, otherwise it will insert to the right). Right now, both the value
(the song to add) and the current node are being sorted by the Artist, because we did
not change it based on the sortBy.

```c#
public void Insert(Song value, string sortBy)
    {
        // Decides how to sort the tree based on what is given. Default is Artist
        string sortByValue = value.Artist;
        string sortByCurrentNode = Data.Artist;
        
        // Recursively loops through the Tree and inserts it where it should be
        // based on the given sortBy value
        int compareValue = string.Compare(sortByValue, sortByCurrentNode);
        if (compareValue == -1) 
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value, sortBy);
        }
        else 
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value, sortBy);
        }
    }
```

So, we need to change that logic to add functionality for if the 'sortBy' value
is "Name", meaning the Name of the Song:

```c#
public void Insert(Song value, string sortBy)
    {
        // Decides how to sort the tree based on what is given. Default is Artist
        string sortByValue = value.Artist;
        string sortByCurrentNode = Data.Artist;
        if (sortBy == "Name")
        {
            sortByValue = value.Name;
            sortByCurrentNode = Data.Name;
        }
        
        // Recursively loops through the Tree and inserts it where it should be
        // based on the given sortBy value
        int compareValue = string.Compare(sortByValue, sortByCurrentNode);
        if (compareValue == -1) 
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value, sortBy);
        }
        else 
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value, sortBy);
        }
    }
```

This will make it so that any time the value of "Name" is passed in as the variable
to sort by, it will make it so that it compares the Song-to-add's Name against the Name
of the current Node to decide where to insert it, rather than the default "Artist".

If you would like to test this code out for yourself, click [here](ds3-example)!

## Problem to Solve - Sort by Release Date

Now I want you to go [here](ds3-problem) and try to add the same implementation but 
instead of looking for the `Name`, look at the `ReleaseDate` value of the Songs.

Look at the `// TODO!` comments in the `Program.cs` and `Node.cs` files to see more
information and hints. We want the "Test-Sort-By-Release-Date" Test case to print out
the tree in the same order as it says in the comments.

Once you have spent sufficient time thinking about this problem or have found a
solution that works, you can check your solution against [mine](ds3-problem-solution)! 
Remember there are many ways to do the same thing, so don't be discouraged if your
solution looks different than mine. 

Congratulations! You have now learned about Binary Search Trees and can use them in 
your daily life!