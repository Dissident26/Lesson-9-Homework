using MyClass;

MyCollection<MediaContent> MyDiskCollection = new ();

MyDiskCollection.Add(new CD("Iron Maiden", "Power Metal", 54, 9));
MyDiskCollection.Add(new DVD("Terminator", "Action/Fantasitc", 120, "James Cameron"));
MyDiskCollection.Add(new CD("Burzum", "Black Metal", 42, 6));
MyDiskCollection.Add(new DVD("Die Hard", "Action", 123, "John McTiernan"));
MyDiskCollection.Add(new CD("Accept", "Heavy Metal", 51, 12));

var someDisk = MyDiskCollection.GetItemByIndex(0);
var someDisk2 = MyDiskCollection.GetItemByIndex(3);

Console.WriteLine(someDisk);
Console.WriteLine(someDisk2);
Console.WriteLine("total disks in collection: {0}", MyDiskCollection.CollectionLength);

class MediaContent
{
    public string Name, Genre;
    public int Length;

    public MediaContent(string name, string genre, int length)
    {
        this.Name = name;
        this.Genre = genre;
        this.Length = length;
    }
}

class CD : MediaContent
{
    int NumberOfTracks;

    public CD(string name, string genre, int length, int numberOfTracks) : base(name, genre, length)
    {
        this.NumberOfTracks = numberOfTracks;
    }

    public override string ToString()
    {
        return $"name: {Name}; genre: {Genre}; length: {Length}; # of tracks: {NumberOfTracks}";
    }
}

class DVD : MediaContent
{
    string Director;
    public DVD(string name, string genre, int length, string director) : base(name, genre, length)
    {
        this.Director = director;
    }

    public override string ToString()
    {
        return $"name: {Name}; genre: {Genre}; length: {Length}; director: {Director}";
    }
}