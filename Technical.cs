using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaLIONETTO.GestioneImpiegati
{
    internal class Technical  : Employee
    {
        public Technical(string firstName, string lastName, string code, SectorEnum sector, List<Skill> skills,decimal hourlyWage,decimal hoursWorked) 
            : base(firstName, lastName, code, sector, skills)
        {
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
        }

        public decimal HourlyWage { get; set; }
        public decimal HoursWorked { get; set; }

        public override decimal GetSalary()
        {
            decimal salary = HourlyWage * HoursWorked;
            return salary;
        }
        public override void PrintInfo()
        {


            Console.WriteLine($"{FirstName} {LastName} {Sector}  {GetSalary()} {HourlyWage} {HoursWorked}");
            foreach (Skill s in Skills) { s.PrintInfo(); }
        }
    }
}
