using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SubscriptionTracker.Validations
{
    public class PriceValidation : ValidationRule
    {
        public double Min { get; set; } 
        private const double Max = double.MaxValue;
        public PriceValidation() { }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (double.TryParse((string)value, out double res))
            {
                if (res >= Min & res < Max)
                    return ValidationResult.ValidResult;
            }

            return new ValidationResult(false, "Bad Input");
        }
    }
}
