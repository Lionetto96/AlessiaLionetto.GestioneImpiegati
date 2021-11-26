using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaLIONETTO.GestioneImpiegati
{
    internal class Manage
    {
        static Skill s1= new Skill("S1","leadership");
        static Skill s2 = new Skill("S2", "problem solving");
        static Skill s3 = new Skill("S3", "work in team");
        static Skill s4 = new Skill("S4", "creativity");
        static List<Skill> skills = new List<Skill>() { s1,s2,s3,s4};
        //static Employee e1 = new Employee("Ale","Lio","LNTLSS96M59E815Y",SectorEnum.Development,new List<Skill>() { s1,s2});
        static Employee t1 = new Trainee("Giada","Rossi", "RSSGDA76A01L219J",SectorEnum.Manutention,new List<Skill>() { s3,s4},4);
        static Employee tec1 = new Technical("Rosa", "Rossi", "RSSRSA76A01L219J", SectorEnum.Administration,new List<Skill>() { s1,s2},10,40);
        static Employee m1 = new Manager("Viola", "Rossi", "RSSVLA76A01L219J", SectorEnum.Administration,new List<Skill>() { s3,s2},5,1200);
        static List<Employee> employees = new List<Employee>() {t1,tec1,m1 };

        internal static List<Employee> FetchEmployees()
        {
            return employees;
        }
        internal static Employee GetEmployeeBySector(SectorEnum sector )
        {
            foreach (Employee e in employees)
            {
                if (sector ==e.Sector )
                {
                    return e;
                }
            }
            return null;
        }
        internal static bool CheckCf(string cf)
        {
            foreach(Employee e in employees)
            {
                if (cf == e.Code)  return true; 
            }
            return false;
        }

        internal static List<Skill> FetchSkill()
        {
            return skills;
        }

        internal static bool CheckCode(string codice)
        {
           foreach(Skill s in skills)
            {
                if(codice==s.Codice) return true;
            } return false; 
        }
        internal static bool AddNewEmployee(Employee newEmployee)
        {
            if (newEmployee != null)
            {
                employees.Add(newEmployee);
                return true;
            }

            return false;
        }

        
       
    }
}
