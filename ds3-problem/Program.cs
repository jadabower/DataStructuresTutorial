// See https://aka.ms/new-console-template for more information

using ds3_problem;

Console.WriteLine("--------------------Test-Song-Class--------------------");
// Creates some new Songs to add to the tree
Song isItOverNow = new Song("Is It Over Now? (Taylor's Version) (From the Vault)", "Taylor Swift", "10/27/2023");
Console.WriteLine(isItOverNow.Stringify()); 
// Should print out:
// 'Is It Over Now? (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
Song nineBall = new Song("Nine Ball", "Zach Bryan", "09/22/2023");
Song theHappiestDaysOfOurLives = new Song("The Happiest Days of Our Lives", "Pink Floyd", "11/30/1979");
Song high = new Song("High", "Steven Sanchez", "09/22/2023");
Song suburbanLegends = new Song("Suburban Legends (Taylor's Version) (From the Vault)", "Taylor Swift", "10/27/2023");

Console.WriteLine("--------------------Test-BST-Class--------------------");
// Creates a new tree sorted by Artist
BST sortedByArtist = new BST("Artist");

Console.WriteLine("--------------------Test-Insert--------------------");
// Adds the previously creates songs to the tree
sortedByArtist.Insert(isItOverNow);
sortedByArtist.Insert(nineBall);
sortedByArtist.Insert(theHappiestDaysOfOurLives);
sortedByArtist.Insert(high);
sortedByArtist.Insert(suburbanLegends);

Console.WriteLine("--------------------Test-TraverseForward--------------------");
sortedByArtist.WriteOutListOfSongs(sortedByArtist.TraverseForward(sortedByArtist.Root, new()));
// Should print out:
// 1.'The Happiest Days of Our Lives' - Pink Floyd, Released 11/30/1979
// 2.'High' - Steven Sanchez, Released 09/22/2023
// 3.'Is It Over Now? (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 4.'Suburban Legends (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 5.'Nine Ball' - Zach Bryan, Released 09/22/2023

Console.WriteLine("--------------------Test-TraverseBackward--------------------");
sortedByArtist.WriteOutListOfSongs(sortedByArtist.TraverseBackward(sortedByArtist.Root, new()));
// Should print out:
// 1.'Nine Ball' - Zach Bryan, Released 09/22/2023
// 2.'Suburban Legends (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 3.'Is It Over Now? (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 4.'High' - Steven Sanchez, Released 09/22/2023
// 5.'The Happiest Days of Our Lives' - Pink Floyd, Released 11/30/1979

Console.WriteLine("--------------------Test-Height--------------------");
int heightOfTree = sortedByArtist.Height();
Console.WriteLine(heightOfTree.ToString());
// Should print out:
// 3

Console.WriteLine("--------------------Test-Contains--------------------");
bool contiansValue = sortedByArtist.Contains(high);
Console.WriteLine("Contains 'High': " + contiansValue.ToString());
// Should print out:
// Contains 'High': True

Console.WriteLine("--------------------Test-Remove--------------------");
sortedByArtist.Remove(high);
sortedByArtist.WriteOutListOfSongs(sortedByArtist.TraverseForward(sortedByArtist.Root, new()));
// Should print out:
// 1.'The Happiest Days of Our Lives' - Pink Floyd, Released 11/30/1979
// 2.'Is It Over Now? (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 3.'Suburban Legends (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 4.'Nine Ball' - Zach Bryan, Released 09/22/2023

Console.WriteLine("--------------------Test-Contains--------------------");
contiansValue = sortedByArtist.Contains(high);
Console.WriteLine("Contains 'High': " + contiansValue.ToString());
// Should print out:
// Contains 'High': False

Console.WriteLine("--------------------Test-Alphabetize-By-Title--------------------");
// Creates a new tree sorted by Song name
BST sortedByTitle = new BST("Name");

// Adds the previously creates songs to the tree
sortedByTitle.Insert(isItOverNow);
sortedByTitle.Insert(nineBall);
sortedByTitle.Insert(theHappiestDaysOfOurLives);
sortedByTitle.Insert(high);
sortedByTitle.Insert(suburbanLegends);

sortedByTitle.WriteOutListOfSongs(sortedByTitle.TraverseForward(sortedByTitle.Root, new()));
// Should print out:
// 1.'High' - Steven Sanchez, Released 09/22/2023
// 2.'Is It Over Now? (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 3.'Nine Ball' - Zach Bryan, Released 09/22/2023
// 4.'Suburban Legends (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 5.'The Happiest Days of Our Lives' - Pink Floyd, Released 11/30/1979

Console.WriteLine("--------------------Test-Sort-By-Release-Date--------------------");
// Creates a new tree sorted by Song release date
BST sortedByDate = new BST("ReleaseDate");
// TODO! Edit the Insert method in the Node class to be able to add a Song based on the "ReleaseDate".
// Adds the previously creates songs to the tree
sortedByDate.Insert(isItOverNow);
sortedByDate.Insert(nineBall);
sortedByDate.Insert(theHappiestDaysOfOurLives);
sortedByDate.Insert(high);
sortedByDate.Insert(suburbanLegends);

sortedByDate.WriteOutListOfSongs(sortedByDate.TraverseForward(sortedByDate.Root, new()));
// Should print out:
// 1.'The Happiest Days of Our Lives' - Pink Floyd, Released 11/30/1979
// 2.'Nine Ball' - Zach Bryan, Released 09/22/2023
// 3.'High' - Steven Sanchez, Released 09/22/2023
// 4.'Is It Over Now? (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
// 5.'Suburban Legends (Taylor's Version) (From the Vault)' - Taylor Swift, Released 10/27/2023
