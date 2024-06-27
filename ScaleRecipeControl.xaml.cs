using System;
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
            cmbRecipes.Items.Add("Recipe 1");
            cmbRecipes.Items.Add("Recipe 2");
            // Add more recipes as needed
        }

        private void BtnScale_Click(object sender, RoutedEventArgs e)
        {
            if (cmbRecipes.SelectedItem != null && cmbScaleFactor.SelectedItem is ComboBoxItem selectedItem)
            {
                double scaleFactor = Convert.ToDouble(selectedItem.Tag);
                string recipeName = cmbRecipes.SelectedItem.ToString();

                // Implement logic to scale the recipe (example)
                MessageBox.Show($"Recipe '{recipeName}' scaled by {scaleFactor}.");
            }
        }
    }
}
