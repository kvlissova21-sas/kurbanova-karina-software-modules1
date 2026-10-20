using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para.models
{
    internal class Departure
    {
        public Customer Customer;
        public Sender Sender;
        public int Id;
        public DateTime DateOfDeparture;
        public string Condition;
    }
}
