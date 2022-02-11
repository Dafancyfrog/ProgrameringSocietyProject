using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Location { get; set; }

        public School(int aId, string aName, string aLevel, string aLocation)
        {
            this.Id = aId;
            this.Name = aName;
            this.Level = aLevel;
            this.Location = aLocation;
        }
    }
}
