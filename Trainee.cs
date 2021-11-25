using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaLIONETTO.GestioneImpiegati
{
    internal class Trainee : Employee
    {
        public Trainee(string firstName, string lastName, string code, SectorEnum sector, List<Skill> skills,int internshipDuration) 
            : base(firstName, lastName, code, sector, skills)
        {
            InternshipDuration=internshipDuration;

        }

        public int InternshipDuration { get; set; }
        public override decimal GetSalary()
        {
            decimal salary = 600;
            return salary;
        }
    }
}
