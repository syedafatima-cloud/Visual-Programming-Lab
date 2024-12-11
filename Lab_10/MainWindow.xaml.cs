using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ImageDisplayApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            // Local file paths for the images (replace with your actual file paths)
            string imagePath1 = @"D:\Image\mountains.jpg";  // Replace with your image file path
            string imagePath2 = @"D:\Image\lake2.jpg";  // Replace with your image file path
            string imagePath3 = @"D:\Image\flowers.jpg";  // Replace with your image file path

            // Load images
            LoadImage(Image1, imagePath1);
            LoadImage(Image2, imagePath2);
            LoadImage(Image3, imagePath3);
        }

        private void LoadImage(System.Windows.Controls.Image imageControl, string imagePath)
        {
            try
            {
                // Create a BitmapImage to load the image
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);  // Use absolute path
                bitmap.EndInit();

                // Set the Image control's Source to the loaded BitmapImage
                imageControl.Source = bitmap;
            }
            catch (Exception ex)
            {
                // Display a default error message if the image fails to load
                MessageBox.Show($"Failed to load the image from {imagePath}. Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
