namespace ds3_problem_solution;

public class BST
{
    public Node? Root = null;
    private string SortBy;

    public BST(string sortBy)
    {
        SortBy = sortBy;
    }

    // Inserts the Song to the tree, based on sortBy 
    public void Insert(Song value)
    {
        // If the Root is null, just create a new Node here
        if (Root is null)
        {
            Root = new Node(value);
        }
        // Otherwise, call the Node's Insert method to recursively insert the new node into the correct spot
        else
        {
            Root.Insert(value, SortBy);
        }
    }

    // Removes the first instance of the given Song from the tree
    public void Remove(Song value)
    {
        // If the Root is not null remove the given song.
        if (Root is not null)
        {
            Root.Remove(value, SortBy);
        }
    }
    
    // Returns whether or not the tree contains the given Song
    public bool Contains(Song value)
    {
        // If the tree is empty, return false
        if (Root is null)
        {
            return false;
        }
        // Otherwise, call the Node Contains function on the Root
        return Root.Contains(value, SortBy);
    }

    // Returns a List of the entire tree in order (sorted by the sortBy value)
    public List<Song> TraverseForward(Node? node, List<Song> accum) {
        if (node is not null) 
        {
            TraverseForward(node.Left, accum);
            accum.Add(node.Data);
            TraverseForward(node.Right, accum);
        }

        return accum;
    }

    // Returns a List of the entire tree in reversed order (sorted by the sortBy value)
    public List<Song> TraverseBackward(Node? node, List<Song> accum)
    {
        if (node is not null) 
        {
            TraverseBackward(node.Right, accum);
            accum.Add(node.Data);
            TraverseBackward(node.Left, accum);
        }
        return accum;
    }

    // Gets the height of the full tree
    public int Height()
    {
        // If the tree is empty, return 0
        if (Root is null)
        {
            return 0;
        }
        // Otherwise, call the Node Height function on the Root
        return Root.Height();
    }

    // Writes a list of songs out nicely
    public void WriteOutListOfSongs(List<Song> songs)
    {
        for (int i = 0; i < songs.Count; i++)
        {
            Console.WriteLine($"{i + 1}." + songs[i].Stringify());
        }
    }
}