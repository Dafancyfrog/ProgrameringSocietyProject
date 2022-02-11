using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Citizen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public int Salary { get; set; }


        public Citizen(int aId, string aName, string aAddress, string aOccupation, int aSalary)
        {
            this.Id = aId;
            this.Name = aName;
            this.Address = aAddress;
            this.Occupation = aOccupation;
            this.Salary = aSalary;
        }
    }
}
