using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Entertainment
    {
        public int id { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public string activity { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();
    }
}
