using RecipeApp;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Lwandle_Chauke___ST10380788___PROG6221___POE
{
    public partial class ViewRecipesControl : UserControl
    {
        private ObservableCollection<Recipe> recipes;

        public ViewRecipesControl()
        {
            InitializeComponent();
            recipes = new ObservableCollection<Recipe>(); // Initialize your recipe collection
            LoadRecipes(); // Load recipes (replace with your actual implementation)
        }

        private void LoadRecipes()
        {
            // Populate recipes (example)
            recipes.Add(new Recipe
            {
                Name = "Recipe 1",
                Ingredients = new ObservableCollection<Ingredient>(), // Use ObservableCollection here
                Steps = new ObservableCollection<string>()
            });

            recipes.Add(new Recipe
            {
                Name = "Recipe 2",
                Ingredients = new ObservableCollection<Ingredient>(), // Use ObservableCollection here
                Steps = new ObservableCollection<string>()
            });

            // Bind the ListBox to your collection of recipes
            lstRecipes.ItemsSource = recipes;
        }

        private void lstRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Ensure an item is selected
            if (lstRecipes.SelectedItem != null && lstRecipes.SelectedItem is Recipe selectedRecipe)
            {
                // Display more details about the selected recipe
                MessageBox.Show($"Selected Recipe:\nName: {selectedRecipe.Name}\nTotal Calories: {selectedRecipe.CalculateTotalCalories()}");
            }
        }
    }
}
