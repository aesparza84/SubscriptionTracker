using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum Category {Streaming, Personal, Gaming}
    public enum RenewalType {Monthly, Weekly, Annual}
    public class Subscription
    {
        public required string Name { get; set; }
        public required double Price { get; set; }   
        public required Category Category { get; set; }
        public required RenewalType RenewalType { get; set; }
        public required DateTime RenewalDate { get; set; }
    }
}
