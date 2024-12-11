using System.Windows;

namespace ComboBoxExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for ComboBox selection change
        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Get the selected ComboBoxItem
            var selectedItem = comboBox.SelectedItem as System.Windows.Controls.ComboBoxItem;

            // If an item is selected, update the TextBox with its content
            if (selectedItem != null)
            {
                textBox.Text = selectedItem.Content.ToString();
            }
        }
    }
}
