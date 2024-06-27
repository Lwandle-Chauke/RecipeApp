using System.Windows;

namespace Lwandle_Chauke___ST10380788___PROG6221___POE
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnAddRecipe.Click += BtnAddRecipe_Click;
            btnViewRecipes.Click += BtnViewRecipes_Click;

            // Initialize content to AddRecipeControl by default
            contentControl.Content = new AddRecipeControl();
        }

        private void BtnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new AddRecipeControl();
        }

        private void BtnViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new ViewRecipesControl();
        }
    }
}
