using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Employee
    {   
        public int Id { get; set; }
        public string WorkPlace { get; set; }
        public DateTime WorkShiftStart { get;  set; }
        public DateTime WorkShiftEnd { get;  set; }

        public Employee(int aId, string aWorkPlace, DateTime aWorkShiftStart, DateTime aWorkShiftEnd)
        {
            this.Id = aId;
            this.WorkPlace = aWorkPlace;
            this.WorkShiftStart = aWorkShiftStart;
            this.WorkShiftEnd = aWorkShiftEnd;
        }
    }
}
