using System.ComponentModel;
using System.Windows;
using Models;
using SubscriptionTracker.ViewModel;

namespace SubscriptionTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel mwvm = new MainWindowViewModel();
            DataContext = mwvm;
            
            //Hard Coded options set in the combo boxes
            RenewalTypeInput.ItemsSource = typeof(RenewTypeEnum).GetEnumValues();
            CategoryInput.ItemsSource = typeof(CategoryTypeEnum).GetEnumValues();
        }

        //private void AddSub_Click(object sender, RoutedEventArgs e)
        //{
        //    Subscription s = ConvertToSubObject();

        //    if (s != null)
        //        subscriptionsList.Add(s);
        //}        
    }
}