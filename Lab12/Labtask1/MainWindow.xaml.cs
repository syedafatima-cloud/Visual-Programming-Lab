using System.Windows;

namespace OrderManagementApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new AddressListViewModel();
        }

        // Event handler for the Edit Address button
        private void OnEditAddressClick(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AddressListViewModel;

            if (viewModel.SelectedAddress != null)
            {
                var inputWindow = new AddressInputWindow(viewModel.SelectedAddress);
                if (inputWindow.ShowDialog() == true)
                {
                    viewModel.UpdateAddress(viewModel.SelectedAddress, inputWindow.UpdatedAddress);
                }
            }
            else
            {
                MessageBox.Show("Please select an address to edit.", "No Address Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void OnChangeAddressClick(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AddressListViewModel;

            if (viewModel.SelectedAddress != null)
            {
                var result = MessageBox.Show("Do you want to update the existing address?", "Update Address", MessageBoxButton.YesNoCancel);

                if (result == MessageBoxResult.Yes)
                {
                    // Update logic
                    MessageBox.Show("Address updated!");
                }
                else if (result == MessageBoxResult.No)
                {
                    // Add new address
                    viewModel.Addresses.Add(new Address
                    {
                        AddressLine = "789 Pine St",
                        City = "San Francisco",
                        PostalCode = "94101"
                    });
                    MessageBox.Show("New address added!");
                }
            }
            else
            {
                MessageBox.Show("Please select an address first.");
            }
        }
    }
}
