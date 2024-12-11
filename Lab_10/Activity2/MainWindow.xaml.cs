using System.Windows;

namespace CheckboxStateApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Initialize the TextBoxes with the initial state
            UpdateTextBox1();
            UpdateTextBox2();
        }

        // Update TextBox1 when Checkbox1 is checked/unchecked
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            UpdateTextBox1();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateTextBox1();
        }

        // Update TextBox2 when Checkbox2 state changes (Checked, Unchecked, Indeterminate)
        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            UpdateTextBox2();
        }

        private void CheckBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateTextBox2();
        }

        private void CheckBox2_Indeterminate(object sender, RoutedEventArgs e)
        {
            UpdateTextBox2();
        }

        // Update the text based on the state of CheckBox1
        private void UpdateTextBox1()
        {
            if (CheckBox1.IsChecked == true)
            {
                TextBox1.Text = "Checkbox 1 is Checked";
            }
            else
            {
                TextBox1.Text = "Checkbox 1 is Unchecked";
            }
        }

        // Update the text based on the state of CheckBox2
        private void UpdateTextBox2()
        {
            if (CheckBox2.IsChecked == true)
            {
                TextBox2.Text = "Checkbox 2 is Checked";
            }
            else if (CheckBox2.IsChecked == false)
            {
                TextBox2.Text = "Checkbox 2 is Unchecked";
            }
            else
            {
                TextBox2.Text = "Checkbox 2 is Indeterminate";
            }
        }
    }
}
