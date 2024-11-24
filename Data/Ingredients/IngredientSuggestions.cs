namespace ai_recipes_blazor.Data.Ingredients;

public static class IngredientSuggestions
{
    public static readonly Dictionary<string, List<IngredientCategory>> Suggestions = new()
    {
        // Spices and Herbs
        { "basil", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "oregano", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "thyme", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "parsley", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "coriander", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "cumin", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "paprika", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "turmeric", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "cinnamon", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "nutmeg", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "clove", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "cardamom", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "saffron", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "star anise", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "fenugreek", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "mustard seeds", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "dill", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "fennel", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "curry leaves", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "bay leaf", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "mace", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "chili flakes", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },

        // Vegetables
        { "broccoli", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "cauliflower", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "spinach", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "kale", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "carrot", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "potato", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "sweet potato", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "zucchini", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "eggplant", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "bell pepper / paprika", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        
        // Fruits
        { "apple", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "banana", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "orange", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "pear", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "grape", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        
        // Fruits (Continued)
        { "cherry", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "peach", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "plum", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "kiwi", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "mango", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "papaya", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "pineapple", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "pomegranate", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "coconut", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "lychee", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "guava", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "dragon fruit", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "durian", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "lime", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "lemon", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        
        // Proteins
        { "chicken", new List<IngredientCategory>() }, // Not vegan or gluten-free
        { "beef", new List<IngredientCategory>()}, // Not vegan or gluten-free
        { "pork", new List<IngredientCategory>()}, // Not vegan or gluten-free
        { "lamb", new List<IngredientCategory>()}, // Not vegan or gluten-free
        { "duck", new List<IngredientCategory>()}, // Not vegan or gluten-free
        { "tofu", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "tempeh", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "fish", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        { "shrimp", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        { "crab", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        { "lobster", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        { "oysters", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        { "clams", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        { "squid", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        { "mussels", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        { "eggs", new List<IngredientCategory>() { IngredientCategory.Vegetarian, IngredientCategory.GlutenFree}}, // Not vegan, but often gluten-free
        { "quail eggs", new List<IngredientCategory>() }, // Not vegan, but often gluten-free
        
        // Grains and Legumes
        { "white rice", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "brown rice", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "basmati rice", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "jasmine rice", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "quinoa", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "bulgur", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "couscous", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Typically not gluten-free
        { "lentils", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "chickpeas", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "black beans", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "kidney beans", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "mung beans", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "edamame", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "peanuts", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "soybeans", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "wheat", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free
        { "barley", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free
        { "oats", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (unless labeled)
        { "millet", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        
        // Dairy
        { "cream", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "yogurt", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "buttermilk", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "ghee", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan, but gluten-free
        { "paneer", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "cheddar", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "parmesan", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "mozzarella", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "feta", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "brie", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "blue cheese", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        { "camembert", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan or gluten-free
        
        // Oils and Fats
        { "olive oil", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "sesame oil", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "vegetable oil", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "coconut oil", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "sunflower oil", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "peanut oil", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "lard", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan, but gluten-free
        
        // Condiments
        { "ketchup", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "mustard", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "mayonnaise", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan, but gluten-free
        { "soy sauce", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (depends on brand)
        { "hoisin sauce", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (depends on brand)
        { "fish sauce", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan, but gluten-free
        { "oyster sauce", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan, but gluten-free
        { "sriracha", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "mirin", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (depends on brand)
        { "rice vinegar", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "balsamic vinegar", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "worcestershire sauce", new List<IngredientCategory>() { IngredientCategory.Vegetarian } }, // Not vegan, not gluten-free (contains anchovies)
        { "teriyaki sauce", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (depends on brand)
        { "tahini", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "miso", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (depends on brand)
        { "wasabi", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "chili paste", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "harissa", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        
        // Other Essentials
        { "noodles", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (unless labeled)
        { "pasta", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (unless labeled)
        { "spaghetti", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (unless labeled)
        { "lasagna sheets", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (unless labeled)
        { "udon", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free
        { "soba", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (unless buckwheat)
        { "vermicelli", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (depends on type)
        { "pho noodles", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (unless labeled)

        // Miscellaneous
        { "seaweed", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "kimchi", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian } }, // Not gluten-free (depending on preparation)
        { "pickles", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "capers", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "anchovies", new List<IngredientCategory>() { IngredientCategory.GlutenFree } },
        { "sesame seeds", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "almonds", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "cashews", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "walnuts", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "hazelnuts", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "pistachios", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "chia seeds", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "flaxseeds", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "poppy seeds", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "coconut milk", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
        { "ginger", new List<IngredientCategory>() { IngredientCategory.Vegan, IngredientCategory.Vegetarian, IngredientCategory.GlutenFree } },
    };
}
