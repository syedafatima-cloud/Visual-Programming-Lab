using System.Windows;

namespace OrderManagementApp
{
    public partial class AddressInputWindow : Window
    {
        // Property to hold the updated address
        public Address UpdatedAddress { get; private set; }

        // Default constructor
        public AddressInputWindow()
        {
            InitializeComponent();
        }

        // Constructor that takes an existing address as input and pre-fills the fields
        public AddressInputWindow(Address address) : this()
        {
            AddressLineTextBox.Text = address.AddressLine;
            CityTextBox.Text = address.City;
            PostalCodeTextBox.Text = address.PostalCode;
        }

        // Button click handler for the "OK" button to save the updated address
        private void OnOkButtonClick(object sender, RoutedEventArgs e)
        {
            UpdatedAddress = new Address
            {
                AddressLine = AddressLineTextBox.Text,
                City = CityTextBox.Text,
                PostalCode = PostalCodeTextBox.Text
            };
            this.DialogResult = true;
            this.Close();
        }

        // Button click handler for the "Cancel" button
        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
