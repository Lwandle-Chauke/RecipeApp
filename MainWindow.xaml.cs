using System.Windows;

namespace Lwandle_Chauke___ST10380788___PROG6221___POE
{
    public partial class MainWindow : Window
    {
        private AddRecipeControl addRecipeControl;
        private ViewRecipesControl viewRecipesControl;
        private ResetQuantitiesControl resetQuantitiesControl;
        private ScaleRecipeControl scaleRecipeControl;

        public MainWindow()
        {
            InitializeComponent();
            addRecipeControl = new AddRecipeControl();
            viewRecipesControl = new ViewRecipesControl();
            resetQuantitiesControl = new ResetQuantitiesControl();
            scaleRecipeControl = new ScaleRecipeControl();
        }

        private void BtnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = addRecipeControl;
        }

        private void BtnViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = viewRecipesControl;
        }

        private void BtnResetQuanties_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = resetQuantitiesControl;
        }

        private void BtnScaleRecipe_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = scaleRecipeControl;
        }
    }
}
