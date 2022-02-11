using System;

namespace Programeringsprojekt_samhälle_
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen1 = new Citizen(1, "Kevin","Kronhusgatan", "Teacher", 30000);
            //Store Foodstore = new Store(1, "food", "nordstan",   );

            Console.WriteLine(citizen1.Salary);
        }
    }
}
