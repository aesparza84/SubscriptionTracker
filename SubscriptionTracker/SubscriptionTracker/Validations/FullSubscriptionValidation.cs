using System.Globalization;
using System.Windows.Controls;
using Models;

namespace SubscriptionTracker.Validations
{
    public class FullSubscriptionValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Subscription val = value as Subscription;
            
            if (string.IsNullOrEmpty(val.Name))
                return new ValidationResult(false, "Include valid Name");

            if (val.Price <= 0)
                return new ValidationResult(false, "Include valid price");

            if (val.RenewalDate.Date > DateTime.Now)
                return new ValidationResult(false, "Include valid date");


            return ValidationResult.ValidResult;
        }
    }
}
