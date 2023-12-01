namespace ds3_problem;

public class Song
{
    public string Name;
    public string Artist;
    public string ReleaseDate;
    private string ReleaseYear;
    private string ReleaseMonth;
    private string ReleaseDay;
    private string ReleaseDateFormatted;

    public Song(string name, string artist, string releaseDate)
    {
        Name = name;
        Artist = artist;
        ReleaseYear = releaseDate.Split('/')[2];
        ReleaseMonth = releaseDate.Split('/')[1];
        ReleaseDay = releaseDate.Split('/')[0];
        ReleaseDate = ReleaseYear + '/' + ReleaseMonth + '/' + ReleaseDay;
        ReleaseDateFormatted = releaseDate;
    }

    public string Stringify()
    {
        return $"'{Name}' - {Artist}, Released {ReleaseDateFormatted}";
    }
}