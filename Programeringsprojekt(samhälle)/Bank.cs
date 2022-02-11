using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Bank
    {
        public int id { get; set; }
        public string currency { get; set; }
        private List<Account> Accounts { get; set; } =  new List<Account>();

        public Bank()
    }
}

