using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SubscriptionTracker.Validations
{
    public class TextOnlyValidation : ValidationRule
    {
        /// <summary>
        /// Max characters allowed
        /// </summary>
        public int Max { get; set; }    
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string s = (string)value;

            foreach (char c in s)
            {
                if(char.IsDigit(c))
                    return new ValidationResult(false, "No Numbers");
            }

            return ValidationResult.ValidResult;
        }
    }
}
