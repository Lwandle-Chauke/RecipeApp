using System.Windows;
using System.Windows.Controls;

namespace Lwandle_Chauke___ST10380788___PROG6221___POE
{
    public partial class ResetQuantitiesControl : UserControl
    {
        public ResetQuantitiesControl()
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

        private void BtnReset_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Implement logic to reset the quantities of the selected recipe
            MessageBox.Show("Recipe quantities reset successfully!");
        }
    }
}
