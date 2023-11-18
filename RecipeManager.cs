using System;
using System.Collections.Generic;
using System.Linq;

public class RecipeManager
{
    private List<Recipe> recipes;

    public RecipeManager()
    {
        recipes = LoadRecipes();
    }

    public List<Recipe> SearchRecipes(string keyword)
    {
        return recipes
            .Where(r => r.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        r.Instructions.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        r.Ingredients.Any(i => i.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
            .ToList();
    }

    private List<Recipe> LoadRecipes()
    {
        return new List<Recipe>
        {
            new Recipe
            {
                Name = "Pasta Carbonara",
                Instructions = "Boil pasta. Fry bacon. Mix with eggs and cheese. Combine with pasta.",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Pasta", Quantity = "200g" },
                    new Ingredient { Name = "Bacon", Quantity = "100g" },
                    new Ingredient { Name = "Eggs", Quantity = "2" },
                    new Ingredient { Name = "Cheese", Quantity = "50g" }
                },
                Keywords = new List<Keywords>
                {
                    new Keywords {Keyword_Meat = "Bacon"},                    
                    new Keywords {Keyword_MainStarch = "Pasta"}
                }
            },
        };
    }
}