using System.Collections.ObjectModel;
using System.ComponentModel;

namespace OrderManagementApp
{
    public class AddressListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Address> Addresses { get; set; }

        private Address _selectedAddress;
        public Address SelectedAddress
        {
            get => _selectedAddress;
            set
            {
                if (_selectedAddress != value)
                {
                    _selectedAddress = value;
                    OnPropertyChanged(nameof(SelectedAddress));
                }
            }
        }

        public AddressListViewModel()
        {
            Addresses = new ObservableCollection<Address>
        {
            new Address { AddressLine = "123 Main St", City = "New York", PostalCode = "10001" },
            new Address { AddressLine = "456 Elm St", City = "Chicago", PostalCode = "60601" },
            new Address { AddressLine = "789 Pine St", City = "San Francisco", PostalCode = "94101" }
        };
        }

        public void UpdateAddress(Address oldAddress, Address newAddress)
        {
            var index = Addresses.IndexOf(oldAddress);
            if (index >= 0)
            {
                Addresses[index] = newAddress;
            }
        }

        public void AddAddress(Address newAddress)
        {
            Addresses.Add(newAddress);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
