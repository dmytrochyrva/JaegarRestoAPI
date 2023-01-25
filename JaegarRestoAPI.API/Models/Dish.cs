namespace JaegarRestoAPI;

public class Dish
{
    public string? Id { get; set; }

    public int Price { get; set; }

    public int Available { get; set;}

    public Category? Category { get; set; }

    public string? ImageUrl { get; set; }
    
    public string? Name { get; set; }
}


