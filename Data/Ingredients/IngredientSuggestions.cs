namespace ai_recipes_blazor.Data.Ingredients;

public static class IngredientSuggestions
{
    // Sample ingredient list; perhaps Spoonactular is beter?
    public static readonly List<string> Suggestions = new()
    {
        // Spices and Herbs
        "basil", "oregano", "thyme", "parsley", "coriander", "cumin", "paprika", 
        "turmeric", "cinnamon", "nutmeg", "clove", "cardamom", "saffron", "star anise", 
        "fenugreek", "mustard seeds", "dill", "fennel", "curry leaves", "bay leaf", 
        "mace", "chili flakes",

        // Vegetables
        "broccoli", "cauliflower", "spinach", "kale", "carrot", "potato", 
        "sweet potato", "zucchini", "eggplant", "bell pepper", "green beans", 
        "asparagus", "cabbage", "leek", "mushrooms", "bamboo shoots", "bok choy", 
        "radish", "turnip", "celery", "parsnip", "lotus root",

        // Fruits
        "apple", "banana", "orange", "pear", "grape", "cherry", "peach", "plum", 
        "kiwi", "mango", "papaya", "pineapple", "pomegranate", "coconut", 
        "lychee", "guava", "dragon fruit", "durian", "lime", "lemon",

        // Proteins
        "chicken", "beef", "pork", "lamb", "duck", "tofu", "tempeh", 
        "fish", "shrimp", "crab", "lobster", "oysters", "clams", 
        "squid", "mussels", "eggs", "quail eggs",

        // Grains and Legumes
        "white rice", "brown rice", "basmati rice", "jasmine rice", 
        "quinoa", "bulgur", "couscous", "lentils", "chickpeas", "black beans", 
        "kidney beans", "mung beans", "edamame", "peanuts", "soybeans", 
        "wheat", "barley", "oats", "millet",

        // Dairy
        "cream", "yogurt", "buttermilk", "ghee", "paneer", 
        "cheddar", "parmesan", "mozzarella", "feta", "brie", 
        "blue cheese", "camembert",

        // Oils and Fats
        "olive oil", "sesame oil", "vegetable oil", "coconut oil", 
        "sunflower oil", "peanut oil", "lard",

        // Condiments
        "ketchup", "mustard", "mayonnaise", "soy sauce", "hoisin sauce", 
        "fish sauce", "oyster sauce", "sriracha", "mirin", "rice vinegar", 
        "balsamic vinegar", "worcestershire sauce", "teriyaki sauce", 
        "tahini", "miso", "wasabi", "chili paste", "harissa",

        // Other Essentials
        "noodles", "spaghetti", "lasagna sheets", "udon", "soba", 
        "vermicelli", "pho noodles", "couscous", "panko breadcrumbs", 
        "cornmeal", "polenta", "tapioca", "cornstarch", "gelatin",

        // Sweeteners
        "brown sugar", "powdered sugar", "molasses", "maple syrup", 
        "agave syrup", "palm sugar",

        // Miscellaneous
        "seaweed", "kimchi", "pickles", "capers", "anchovies", 
        "sesame seeds", "almonds", "cashews", "walnuts", "hazelnuts", 
        "pistachios", "chia seeds", "flaxseeds", "poppy seeds"
    };
}
