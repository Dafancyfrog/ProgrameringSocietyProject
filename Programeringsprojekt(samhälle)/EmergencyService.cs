using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Emergencyservice
    {
        public int id { get; set; }
        public int type { get; set; }

        public int numberOfPatients { get; set; }

        public int vehicle { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();

        public Emergencyservice(int aid, int atype, int anumberOfPatients, int avehicle, List<Employee> aemployees)
        {
            this.id = aid;
            this.type = atype;
            this.numberOfPatients = anumberOfPatients;
            this.vehicle = avehicle;
            this.employees = aemployees;
            
        }

    }
}
