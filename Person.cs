using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaLIONETTO.GestioneImpiegati
{
    internal class Person
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Code { get; set; }

        

        public Person(string firstName, string lastName, string code)
        {
            FirstName = firstName;
            LastName = lastName;
            Code = code;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Code}");
        }


        //public void Print()
        //{
        //    Console.WriteLine($"{FirstName} {LastName}");
        //}
    }
}

