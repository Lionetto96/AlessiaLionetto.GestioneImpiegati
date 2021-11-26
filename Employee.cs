using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaLIONETTO.GestioneImpiegati
{
    internal abstract class Employee : Person 
    {
        public SectorEnum Sector { get; set; }

        public List<Skill> Skills { get; set; }

        public abstract decimal GetSalary();
        
        

        public Employee(string firstName, string lastName, string code,SectorEnum sector,List<Skill> skills)
            : base(firstName, lastName, code)
        {
            Sector = sector;
            Skills = skills;
            



        }

        

        public override void PrintInfo()
        {
           
           
            Console.WriteLine($"{FirstName} {LastName} {Code} {Sector} {GetSalary()}");
            foreach (Skill s in Skills) { s.PrintInfo(); }
        }
    }

    public enum SectorEnum
    {
        Manutention = 1,
        Administration = 2,
        Development = 3
    }
}

