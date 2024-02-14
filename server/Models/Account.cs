namespace MarketSpace.Models;

public class Account: RepoItem<string>
{
  public string Email { get; set; }
  
}

public class Profile : Account{
  public string Bio {get; set;}

  public string Name { get; set; }

  public string Picture { get; set; }
}
