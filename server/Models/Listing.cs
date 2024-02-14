namespace MarketSpace.Models;


public class Listing : RepoItem<int> {
    public int CreatorId {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    public string ImgOne {get; set;}
    public string ImgTwo {get; set;}
    public int Price {get; set;}
}

public class SavedListing : Listing{
    public int SavedId {get; set;}
}