using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para.models
{
    internal class DeliveryAttempt
    {
        public Departure departure;
        public Stop stop;
        public DateTime AttemptDate;
        public DateTime AttemptTime;
        public string Result;
        public string FailReason;
    }
}
