using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para.models
{
    internal class Stop
    {
        public Route route;
        public int Id;
        public string Address;
        public DateTime PlannedTime;
        public int SequeenceNumber;
    }
}
