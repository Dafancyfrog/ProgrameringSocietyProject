using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Company
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string Popularity { get; set; }
        public int NumOfEmployees { get; set; }
        public List<Employees> employees { get; set; } = new List<Employees>();


        public Company(int aId, string aSize, string aPopularity, int aNumOfEmployees)
        {
            this.Id = aId;
            this.Size = aSize;
            this.Popularity = aPopularity;
            this.NumOfEmployees = aNumOfEmployees;
        }
    }
}
