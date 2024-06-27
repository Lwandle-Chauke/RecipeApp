using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lwandle_Chauke___ST10380788___PROG6221___POE
{
    public partial class AddRecipeControl : UserControl
    {
        public AddRecipeControl()
        {
            InitializeComponent();
            InitializeIngredients();
            InitializeSteps();
        }

        private void InitializeIngredients()
        {
            // Example initialization for ingredients
            ObservableCollection<IngredientViewModel> ingredients = new ObservableCollection<IngredientViewModel>();
            ingredients.Add(new IngredientViewModel());
            ingredientsItemsControl.ItemsSource = ingredients;
        }

        private void InitializeSteps()
        {
            // Example initialization for steps
            ObservableCollection<string> steps = new ObservableCollection<string>();
            steps.Add("");
            stepsItemsControl.ItemsSource = steps;
        }

        private void BtnEnterRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Show the enter recipe grid
            enterRecipeGrid.Visibility = Visibility.Visible;
        }

        private void BtnSaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Validate and save recipe details here
            if (ValidateRecipe())
            {
                // Save logic (e.g., create Recipe object, add to collection, etc.)
                MessageBox.Show("Recipe saved successfully!");
            }
        }

        private bool ValidateRecipe()
        {
            // Validate all fields before saving
            bool isValid = true;

            // Validate recipe name
            if (string.IsNullOrWhiteSpace(txtRecipeName.Text))
            {
                MessageBox.Show("Please enter a recipe name.");
                isValid = false;
            }

            // Validate number of ingredients
            int numIngredients;
            if (!int.TryParse(txtNumIngredients.Text, out numIngredients) || numIngredients <= 0)
            {
                MessageBox.Show("Please enter a valid number of ingredients.");
                isValid = false;
            }
            else
            {
                // Validate each ingredient
                foreach (var item in ingredientsItemsControl.Items)
                {
                    var container = ingredientsItemsControl.ItemContainerGenerator.ContainerFromItem(item) as FrameworkElement;
                    TextBox txtIngredientName = FindVisualChild<TextBox>(container, "txtIngredientName");
                    ComboBox cmbFoodGroup = FindVisualChild<ComboBox>(container, "cmbFoodGroup");
                    TextBox txtCalories = FindVisualChild<TextBox>(container, "txtCalories");

                    if (string.IsNullOrWhiteSpace(txtIngredientName?.Text) || cmbFoodGroup?.SelectedItem == null || string.IsNullOrWhiteSpace(txtCalories?.Text))
                    {
                        MessageBox.Show("Please fill in all ingredient details.");
                        isValid = false;
                        break;
                    }

                    double calories;
                    if (!double.TryParse(txtCalories.Text, out calories) || calories <= 0)
                    {
                        MessageBox.Show("Please enter valid calories for each ingredient.");
                        isValid = false;
                        break;
                    }

                    // Check calories threshold
                    if (calories > 300)
                    {
                        MessageBox.Show("CALORIES EXCEED 300!", "WARNING", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }

            // Validate number of steps
            int numSteps;
            if (!int.TryParse(txtNumSteps.Text, out numSteps) || numSteps <= 0)
            {
                MessageBox.Show("Please enter a valid number of steps.");
                isValid = false;
            }
            else
            {
                // Validate each step
                foreach (var item in stepsItemsControl.Items)
                {
                    var container = stepsItemsControl.ItemContainerGenerator.ContainerFromItem(item) as FrameworkElement;
                    TextBox txtStep = FindVisualChild<TextBox>(container, "txtStep");

                    if (string.IsNullOrWhiteSpace(txtStep?.Text))
                    {
                        MessageBox.Show("Please fill in all step details.");
                        isValid = false;
                        break;
                    }
                }
            }

            return isValid;
        }

        private T FindVisualChild<T>(DependencyObject obj, string name) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T && ((FrameworkElement)child).Name == name)
                    return (T)child;
                else
                {
                    T childOfChild = FindVisualChild<T>(child, name);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        // Button click events for other menu options can be added similarly
        private void BtnViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Implement view recipes logic here
        }

        private void BtnScaleRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Implement scale recipes logic here
        }

        private void BtnResetQuantities_Click(object sender, RoutedEventArgs e)
        {
            // Implement reset quantities logic here
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            // Implement exit logic here
        }
    }

    public class IngredientViewModel
    {
        public string Name { get; set; }
        public string FoodGroup { get; set; }
        public double Calories { get; set; }
    }
}
