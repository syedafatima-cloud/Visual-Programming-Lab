using System;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace Activity1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Registering the DependencyProperty with a callback method
        public static readonly DependencyProperty CurrentTimeProperty =
            DependencyProperty.Register("CurrentTime", typeof(DateTime),
            typeof(MainWindow), new FrameworkPropertyMetadata(DateTime.Now, OnCurrentTimePropertyChanged));

        public MainWindow()
        {
            InitializeComponent();

            // Timer to update the CurrentTime property every second
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) => CurrentTime = DateTime.Now;
            timer.Start();

            // LINQ query execution on startup
            ExecuteLinqQuery();
        }

        // CLR Wrapper for DependencyProperty
        public DateTime CurrentTime
        {
            get { return (DateTime)GetValue(CurrentTimeProperty); }
            set { SetValue(CurrentTimeProperty, value); }
        }

        // Callback method for when the CurrentTime property changes
        private static void OnCurrentTimePropertyChanged(DependencyObject source,
                                                         DependencyPropertyChangedEventArgs e)
        {
            MainWindow control = source as MainWindow;
            DateTime newTime = (DateTime)e.NewValue;

            // Example logic for property change
            Console.WriteLine($"CurrentTime changed to: {newTime}");
            UpdateClockControl(control, newTime);
        }

        // Additional update logic for clock control
        private static void UpdateClockControl(MainWindow control, DateTime newTime)
        {
            Console.WriteLine($"Update logic for clock at: {newTime}");
        }

        // LINQ Query Example: Filter even numbers from an array
        private void ExecuteLinqQuery()
        {
            // 1. Data source
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution
            Console.WriteLine("Even numbers in the array:");
            foreach (int num in numQuery)
            {
                Console.WriteLine(num);
            }
        }
    }
}
