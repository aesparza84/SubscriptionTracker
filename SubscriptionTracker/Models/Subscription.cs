using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Subscription
    {
        public required string Name { get; set; }
        public required double Price { get; set; }   
        public required CategoryTypeEnum Category { get; set; }
        public required RenewTypeEnum RenewalType { get; set; }
        public required DateTime RenewalDate { get; set; }
    }
}
