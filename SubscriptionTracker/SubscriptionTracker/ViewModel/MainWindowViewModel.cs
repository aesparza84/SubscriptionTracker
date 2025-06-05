using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using SubscriptionTracker.MVVM;

namespace SubscriptionTracker.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// The name of the subscription
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string name;

        /// <summary>
        /// Price of the subscription
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private double price;

        /// <summary>
        /// The category of this subscription
        /// </summary>
        public CategoryTypeEnum CategoryType
        {
            get { return categoryType; }
            set { categoryType = value; }
        }
        private CategoryTypeEnum categoryType;

        /// <summary>
        /// Billing cycle of this subscription
        /// </summary>
        public RenewTypeEnum RenewType
        {
            get { return renewType; }
            set { renewType = value; }
        }
        private RenewTypeEnum renewType;

        /// <summary>
        /// Billing date of the subscription
        /// </summary>
        public DateTime RenewalDate 
        {
            get { return renewalDate; }
            set { renewalDate = value; }
        }
        private DateTime renewalDate = DateTime.Now.Date; //default

        /// <summary>
        /// List to store subscriptions
        /// </summary>
        public ObservableCollection<Subscription> SubCollection { get; private set; }

        public RelayCommand AddSubCommand { get; private set; }
        public MainWindowViewModel()
        {
            SubCollection = new ObservableCollection<Subscription>();

            AddSubCommand = new RelayCommand(AddSub);
        }

        private void AddSub()
        {
            Subscription newSub = CreateSubFromInput();
            SubCollection.Add(newSub);
        }

        private Subscription? CreateSubFromInput()
        {
            Subscription result = new Subscription()
            {
                Name = this.name,
                Price = this.price,
                Category = this.categoryType,
                RenewalType = this.renewType,
                RenewalDate = this.renewalDate.Date
            };

            return result;
        }
    }
}
