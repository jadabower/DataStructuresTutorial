using System.Net.Sockets;

namespace ds3_problem;

public class Node
{
    public Node? Left = null;
    public Node? Right = null;
    public Song Data;

    public Node(Song data)
    {
        Data = data;
    }
    
    // Recursively moves through the Tree to the point where the value should be inserted
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
        
        // TODO! Add the implementation here to Insert by "ReleaseDate". Hint: Very similar to the previous if statement.
        // You do not have to change any of the other code.
        
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

    // Removes a given Song from the tree extending from this node
    public void Remove(Song value, string sortBy)
    {
        // Decides how to sort the tree based on what is given. Default is Artist
        string sortByValue = value.Artist;
        string sortByCurrentNode = Data.Artist;
        string? sortByNextLeft = null;
        string? sortByNextRight = null;
        if (Left is not null)
            sortByNextLeft = Left.Data.Artist;
        if (Right is not null)
           sortByNextRight = Right.Data.Artist;
        if (sortBy == "Name")
        {
            sortByValue = value.Name;
            sortByCurrentNode = Data.Name;
            if (Left is not null)
                sortByNextLeft = Left.Data.Name;
            if (Right is not null)
                sortByNextRight = Right.Data.Name;
        }
        else if (sortBy == "ReleaseDate")
        {
            sortByValue = value.ReleaseDate;
            sortByCurrentNode = Data.ReleaseDate;
            if (Left is not null)
                sortByNextLeft = Left.Data.ReleaseDate;
            if (Right is not null)
                sortByNextRight = Right.Data.ReleaseDate;
        }
        
        // Recursively loops through the Tree and removes the first instance of it
        // based on the given sortBy value
        int compareValue = string.Compare(sortByValue, sortByCurrentNode);
        
        int compareLeftValue = 2;
        int compareRightValue = 2;
        if (sortByNextLeft is not null)
            compareLeftValue = string.Compare(sortByValue, sortByNextLeft);
        if (sortByNextRight is not null)
            compareRightValue = string.Compare(sortByValue, sortByNextRight);

        // If the current node's child on the left is the one to delete and has no children,
        // delete it.
        if (compareLeftValue == 0)
        {
            if (Left.Left is null && Left.Right is null)
            {
                Left = null;
            }
        }
        
        // If the current node's child on the right is the one to delete and has no children,
        // delete it.
        if (compareRightValue == 0)
        {
            if (Right.Left is null && Right.Right is null)
            {
                Right = null;
            }
        }
        
        // This is the correct Node
        if (compareValue == 0)
        {
            // If the child on the right has no children on the left
            if (Right.Left is null)
            {
                // Replace the current node with the node on the right
                Data = Right.Data;
            }
            // Otherwise, replace the current node with the left-most node on the right
            else
            {
                Node parent = Right;
                Node rc = Right.Left;

                // Loops through to get the very left-most child of the Right node
                while (rc.Left is not null)
                {
                    parent = rc;
                    rc = rc.Left;
                }

                Data = rc.Data;
                parent.Left = rc.Right;
            }
        }
        else if (compareValue == -1) 
        {
            // Move to the left
            if (Left is not null)
            {
                Left.Remove(value, sortBy);
            }
        }
        else 
        {
            // Move to the right
            if (Right is not null)
            {
                Right.Remove(value, sortBy);
            }
        }
    }

    // Checks if the Tree below the given Node contains the value
    public bool Contains(Song value, string sortBy)
    {
        bool result = false;
        // Decides how to sort the tree based on what is given. Default is Artist
        string sortByValue = value.Artist;
        string sortByCurrentNode = Data.Artist;
        if (sortBy == "Name")
        {
            sortByValue = value.Name;
            sortByCurrentNode = Data.Name;
        }
        else if (sortBy == "ReleaseDate")
        {
            sortByValue = value.ReleaseDate;
            sortByCurrentNode = Data.ReleaseDate;
        }
        
        // Recursively loops through the Tree and checks every node. If the value is the same, returns true
        int compareValue = string.Compare(sortByValue, sortByCurrentNode);
        if (value.Name == Data.Name && value.Artist == Data.Artist && value.ReleaseDate == Data.ReleaseDate)
        {
            result = true;
        }
        else if (compareValue == -1) 
        { 
            // Value is to the left
            if (Left is not null)
                result = Left.Contains(value, sortBy);
        }
        else 
        {
            // Value is to the right
            if (Right is not null)
                result = Right.Contains(value, sortBy);
        }
        
        // Returns whether or not the value is in the tree
        return result;
    }

    // Returns the height of the Node (the height of the tree where the Node is the Root)
    public int Height()
    {
        // Set both branches heights equal to 1 originally
        int leftHeight = 1;
        int rightHeight = 1;
        if (Left is not null)
        {
            // Add the height of the Left branch to the left
            leftHeight += Left.Height();
        }
        if (Right is not null)
        {
            // Add the height of the Right branch to the right
            rightHeight += Right.Height();
        }
        // Return the higher height
        if (rightHeight > leftHeight)
        {
            return rightHeight;
        }
        return leftHeight;
    }
}