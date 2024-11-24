namespace ai_recipes_blazor.Data.Ingredients;

public static class CommonIngredientsData
{
    public static readonly Dictionary<string, List<IngredientCategory>> Ingredients = new()
    {
        { "salt", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "pepper", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "sugar", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "garlic", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "onion", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "butter", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Butter is not gluten-free
        { "oil", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "vinegar", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "lemon", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "lime", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "soy sauce", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Assuming it's vegetarian but not gluten-free (depending on the brand)
        { "flour", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } },
        { "rice", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "milk", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Milk is vegetarian but not gluten-free
        { "cheese", new List<IngredientCategory>() { IngredientCategory.Vegetarian } },
        { "honey", new List<IngredientCategory>() { IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "yeast", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        // Add more ingredients and their categories...
    };
}
