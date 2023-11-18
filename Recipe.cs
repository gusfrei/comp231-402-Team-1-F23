using System.Collections.Generic;

public class Recipe
{
    public string Name { get; set; }
    public List<Keywords> Keywords { get; set; }
    public string Instructions { get; set; }
    public List<Ingredient> Ingredients { get; set; }
}

public class Ingredient
{
    public string Name { get; set; }
    public string Quantity { get; set; }
}

public class Keywords
{
    public string Keyword_Meat { get; set; }
    public string Keyword_MainVeg { get; set; }
    public string Keyword_MainStarch { get; set; }

}