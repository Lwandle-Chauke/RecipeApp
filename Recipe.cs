using System.Collections.ObjectModel;
using System.Linq;

namespace RecipeApp
{
    public class Recipe
    {
        public string Name { get; set; }
        public ObservableCollection<Ingredient> Ingredients { get; set; }
        public ObservableCollection<string> Steps { get; set; }

        // Constructor to initialize collections
        public Recipe()
        {
            Ingredients = new ObservableCollection<Ingredient>();
            Steps = new ObservableCollection<string>();
        }

        // Method to calculate total calories of the recipe
        public double CalculateTotalCalories()
        {
            // Calculate total calories by summing up calories of each ingredient
            double totalCalories = Ingredients.Sum(i => i.Calories);
            return totalCalories;
        }
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }
    }
}
