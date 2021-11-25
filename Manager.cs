using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaLIONETTO.GestioneImpiegati
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string code, SectorEnum sector, List<Skill> skills, int overtimeSalary,decimal basicSalary)
            : base(firstName, lastName, code, sector, skills)
        {
            OvertimeHours = overtimeSalary;
            BasicSalary = basicSalary;
        }
        public int OvertimeHours { get; set; }
        public decimal BasicSalary { get; set; }
        public override decimal GetSalary()
        {
            decimal salary = BasicSalary+(OvertimeHours*10);
            return salary;
        }

    }
}
