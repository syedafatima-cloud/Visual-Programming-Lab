using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OrderManagementApp
{
    public static class AttachedProperties
    {
        public static readonly DependencyProperty IsShippingAddressProperty =
            DependencyProperty.RegisterAttached("IsShippingAddress", typeof(bool), typeof(AttachedProperties),
                new PropertyMetadata(false, OnIsShippingAddressChanged));

        public static bool GetIsShippingAddress(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsShippingAddressProperty);
        }

        public static void SetIsShippingAddress(DependencyObject obj, bool value)
        {
            obj.SetValue(IsShippingAddressProperty, value);
        }

        private static void OnIsShippingAddressChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Handle property change logic if needed
        }
    }
}
