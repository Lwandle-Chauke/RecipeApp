using System.Windows;
using System.Windows.Controls;

namespace Lwandle_Chauke___ST10380788___PROG6221___POE
{
    public partial class ScaleRecipeControl : UserControl
    {
        public ScaleRecipeControl()
        {
            InitializeComponent();
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            // Implement logic to load recipes into the ComboBox
            cmbRecipes.Items.Add("Example Recipe 1");
            cmbRecipes.Items.Add("Example Recipe 2");
        }

        private void BtnScale_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Implement logic to scale the selected recipe
            MessageBox.Show("Recipe scaled successfully!");
        }
    }
}
