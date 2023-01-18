using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLocadora.Entities
{
    class carRental
    {
        public DateTime start { get; set; }

        public DateTime finish { get; set; }

        public Invoice Invoice { get; set; }
        public Vehicle Vehicle { get; private set; }

        public carRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            this.start = start;
            this.finish = finish;
            Invoice = null;
            Vehicle = vehicle;
        }
    }
}
