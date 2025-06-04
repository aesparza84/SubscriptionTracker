using System.ComponentModel;
using System.Windows;
using Models;

namespace SubscriptionTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string subscriptionName;
        public string SubscriptionName
        {
            get { return subscriptionName; }
            set { subscriptionName = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private CategoryTypeEnum category;
        public CategoryTypeEnum Category
        {
            get { return category; }
            set { category = value; }
        }

        private RenewTypeEnum renewType;
        public RenewTypeEnum RenewType
        {
            get { return renewType; }
            set { renewType = value; }
        }

        private DateTime renewalDate;
        public DateTime RenewalDate
        {
            get { return renewalDate; }
            set { renewalDate = value; }
        }

        //-------------
        private CategoryTypeEnum categoryOption;
        public CategoryTypeEnum CategoryOption
        {
            get { return categoryOption; }
            set { categoryOption = value; }
        }

        private RenewTypeEnum renewOption;
        public RenewTypeEnum RenewOption
        {
            get { return renewOption; }
            set { renewOption = value; }
        }


        //-------------


        public event PropertyChangedEventHandler? PropertyChanged;
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void PriceInput_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            foreach (char item in e.Text)
            {
                if (!char.IsDigit(item))
                {
                    e.Handled = true;
                    break;
                }
            }
        }

    }
}