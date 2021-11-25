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
        List<Skill> skills = new List<Skill>() { s1,s2,s3,s4};
        //static Employee e1 = new Employee("Ale","Lio","LNTLSS96M59E815Y",SectorEnum.Development,);
        //static Employee t1 = new Trainee("Giada","Rossi", "RSSGDA76A01L219J",SectorEnum.Sales,,6);
        //static Employee tec1 = new Technical("Rosa", "Rossi", "RSSRSA76A01L219J", SectorEnum.Administration,,10,40);
        //static Employee m1 = new Manager("Viola", "Rossi", "RSSVLA76A01L219J", SectorEnum.Administration,,5,1200);
    }
}
