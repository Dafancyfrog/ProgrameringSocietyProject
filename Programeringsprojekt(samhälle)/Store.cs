using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Store
    {
        public int id { get; set; }
        public string type { get; set; }
        public string location { get; set; }

        public List<Employee> employees { get; set; } = new List<Employee>();

        public Store (int aid, string atype, string alocation, List<Employee> aemployees)
        {
            this.id = aid;
            this.type = atype;
            this.location = alocation;
            this.employees = aemployees;
        }

    }
}
