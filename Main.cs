using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaLIONETTO.GestioneImpiegati
{
    internal class Main
    {

        internal static void Start()
        {
            char scelta;
            do
            {
                Console.WriteLine("scegli tra le varie opzioni: " +
                    "\n[1] visualizza tutti gli impiegati " +
                    "\n[2] visualizza impiegati appartenenti ad un determinato settore" +
                    "\n[3] aggiungo impiegato " +
                    "\n[4] elimino impiegato " +
                    "\n[5] visualizza impiegati con stipendio maggiore di una determinata cifra"+
                    "\n[6] visualizza impiegati con una determinata skill"+
                    "\n[Q] esci");
                scelta = Console.ReadKey().KeyChar;
                switch (scelta)
                {
                    case '1':
                        AllEmployees();
                        break;
                    case '2':
                        FetchEmployeesBySector();
                        break;
                    case '3':
                        AddEmployee();
                        break;
                    case '4':
                        string cf = GetInfo("cf");
                        RemoveEmployes(cf);
                        break;
                    case '5':
                        Console.WriteLine("inserisci il salario");
                        decimal salary=decimal.Parse(Console.ReadLine());
                        FetchEmployeesBySalary(salary);
                        break;
                    case '6':
                        string skill = GetInfo("skill");
                        FetchEmployeesBySkill(skill);
                        break;

                    case 'Q':
                        Console.WriteLine("arrivederci");
                        break;
                    default:
                        break;
                }
            } while (scelta != 'Q');
        }

        private static void FetchEmployeesBySkill(string skill)
        {
            List<Employee> employees = Manage.FetchEmployees();
            bool exist = Manage.CheckCode(skill);
            if (exist)
            {
                foreach (Employee e in employees)
                {
                    e.PrintInfo();
                }
            }
           
        }

        private static void FetchEmployeesBySalary(decimal salary)
        {
            List<Employee> employees = Manage.FetchEmployees();
            
            foreach (Employee e in employees)
            {
                decimal Esalary = e.GetSalary();
                if (Esalary>= salary)
                {
                    e.PrintInfo();
                }
            }
        }

        private static void RemoveEmployes(string cf)
        {
            List<Employee> employees = Manage.FetchEmployees();
            bool exist = Manage.CheckCf(cf);
            if (exist)
            {
                foreach(Employee e in employees)
                {
                    employees.Remove(e);
                }
            }
            else
            {
                Console.WriteLine($"non esiste un impiegato con questo codice fiscale {cf}");
            }
        }

        private static void AddEmployee()
        {
            bool exit;
            do
            {
                Console.WriteLine("che tipologia di impiegato vuoi aggiungere?" +
                "\n[1] stagista" +
                "\n[2] tecnico" +
                "\n[3] manager");
                int scelta=int.Parse(Console.ReadLine());
                exit=true;
                List<Skill> skills = Manage.FetchSkill();
                switch (scelta)
                {

                    case 1:
                        
                        string cf = GetInfo("cf");
                        bool exist=Manage.CheckCf(cf);
                        if (exist)
                        {
                            Console.WriteLine("questo impiegato è già presente");
                        }
                        else
                        {
                            string name = GetInfo("nome");
                            string lastName = GetInfo("cognome");
                            string sector;
                            do
                            {
                                Console.WriteLine($"scegli settore:   {SectorEnum.Manutention} \n {SectorEnum.Administration} \n {SectorEnum.Development}");

                                sector = GetInfo("settore");
                                
                            } while (string.IsNullOrWhiteSpace(sector));
                            SectorEnum sectorEnum = (SectorEnum)Enum.Parse(typeof(SectorEnum), sector);
                            int internshipDuration;
                            do
                            {
                                Console.WriteLine("inserisci durata di tirocinio in mesi");

                            } while (!int.TryParse(Console.ReadLine(), out internshipDuration));
                            string codice;
                            do
                            {
                                Console.WriteLine("inserisci il codice della skill da aggiungere tra quelle indicate:");
                                codice = Console.ReadLine().ToUpper();
                            } while (string.IsNullOrWhiteSpace(codice));
                            
                            bool existCod = Manage.CheckCode(codice);
                            if (existCod)
                            {
                                foreach (Skill s in skills)
                                {
                                    Employee newEmployee = new Trainee(name, lastName, cf, sectorEnum, new List<Skill>() { s }, internshipDuration);
                                    bool isAdded = Manage.AddNewEmployee(newEmployee);
                                    if (isAdded)
                                    {
                                        Console.WriteLine(" nuovo impiegato aggiunto  ");
                                        newEmployee.PrintInfo();
                                    }

                                    else
                                    {
                                        Console.WriteLine("qualcosa è andato storto");
                                    }

                                }



                            }
                            else
                            {
                                Console.WriteLine("questo codice skill non è presente");
                            }

                        }
                        
                        break;
                    case 2:
                        string cf1 = GetInfo("cf");
                        bool exist1 = Manage.CheckCf(cf1);
                        if (exist1)
                        {
                            Console.WriteLine("questo impiegato è già presente");
                        }
                        else
                        {
                            string name = GetInfo("nome");
                            string lastName = GetInfo("cognome");
                            string sector;
                            do
                            {
                                Console.WriteLine($"scegli settore:   {SectorEnum.Manutention} \n {SectorEnum.Administration} \n {SectorEnum.Development}");

                                sector = GetInfo("settore");

                            } while (string.IsNullOrWhiteSpace(sector));
                            SectorEnum sectorEnum = (SectorEnum)Enum.Parse(typeof(SectorEnum), sector);
                            decimal hourlyWage;
                            
                            do
                            {
                                Console.WriteLine("inserisci la paga giornaliera");

                            } while (!decimal.TryParse(Console.ReadLine(), out hourlyWage));
                            decimal hoursWorked;
                            do
                            {
                                Console.WriteLine("inserisci le ore lavorate");

                            } while (!decimal.TryParse(Console.ReadLine(), out hoursWorked));
                            string codice;
                            do
                            {
                                Console.WriteLine("inserisci il codice della skill da aggiungere tra quelle indicate:");
                                codice = Console.ReadLine().ToUpper();
                            } while (string.IsNullOrWhiteSpace(codice));

                            bool existCod = Manage.CheckCode(codice);
                            if (existCod)
                            {
                                foreach (Skill s in skills)
                                {
                                    Employee newEmployee = new Technical(name, lastName, cf1, sectorEnum, new List<Skill>() { s }, hourlyWage,hoursWorked);
                                    bool isAdded = Manage.AddNewEmployee(newEmployee);
                                    if (isAdded)
                                    {
                                        Console.WriteLine(" nuovo impiegato aggiunto  ");
                                        newEmployee.PrintInfo();
                                    }

                                    else
                                    {
                                        Console.WriteLine("qualcosa è andato storto");
                                    }

                                }



                            }
                            else
                            {
                                Console.WriteLine("questo codice skill non è presente");
                            }

                        }

                        break;

                    case 3:
                        string cf2 = GetInfo("cf");
                        bool exist2 = Manage.CheckCf(cf2);
                        if (exist2)
                        {
                            Console.WriteLine("questo impiegato è già presente");
                        }
                        else
                        {
                            string name = GetInfo("nome");
                            string lastName = GetInfo("cognome");
                            string sector;
                            do
                            {
                                Console.WriteLine($"scegli settore:   {SectorEnum.Manutention} \n {SectorEnum.Administration} \n {SectorEnum.Development}");

                                sector = GetInfo("settore");

                            } while (string.IsNullOrWhiteSpace(sector));
                            SectorEnum sectorEnum = (SectorEnum)Enum.Parse(typeof(SectorEnum), sector);
                            int overtimeHours;

                            do
                            {
                                Console.WriteLine("inserisci le ore di straordinario");

                            } while (!int.TryParse(Console.ReadLine(), out overtimeHours));
                            decimal basicSalary;
                            do
                            {
                                Console.WriteLine("inserisci il salario base");

                            } while (!decimal.TryParse(Console.ReadLine(), out basicSalary));
                            string codice;
                            do
                            {
                                Console.WriteLine("inserisci il codice della skill da aggiungere tra quelle indicate:");
                                codice = Console.ReadLine().ToUpper();
                            } while (string.IsNullOrWhiteSpace(codice));

                            bool existCod = Manage.CheckCode(codice);
                            if (existCod)
                            {
                                foreach (Skill s in skills)
                                {
                                    Employee newEmployee = new Technical(name, lastName, cf2, sectorEnum, new List<Skill>() { s }, overtimeHours, basicSalary);
                                    bool isAdded = Manage.AddNewEmployee(newEmployee);
                                    if (isAdded)
                                    {
                                        Console.WriteLine(" nuovo impiegato aggiunto  ");
                                        newEmployee.PrintInfo();
                                    }

                                    else
                                    {
                                        Console.WriteLine("qualcosa è andato storto");
                                    }

                                }



                            }
                            else
                            {
                                Console.WriteLine("questo codice skill non è presente");
                            }

                        }

                        break;




                }

            } while (!exit);


        }

        private static string GetInfo(string message)
        {
            string info;
            do
            {
                Console.WriteLine($"inserisci {message}");
                info = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(info));// POSSO AGGIUNGERE PER NON FAR INSERIRE UN INT|| !Regex.IsMatch(info, @"^[a-zA-Z]+$"));
            return info;
        }

        private static void FetchEmployeesBySector()
        {
            List<Employee> employees = Manage.FetchEmployees();
            SectorEnum sector;
            do
            {
                Console.WriteLine("questi sono i settori, scegline uno: ");

            } while (!Enum.TryParse(Console.ReadLine(), out sector));
            foreach(Employee e in employees)
            {
                Employee employee = Manage.GetEmployeeBySector(sector);
                e.PrintInfo();
            }
            

        }
        private static void AllEmployees()
        {
            List<Employee> employees = Manage.FetchEmployees();
            foreach (Employee e in employees)
            {
                e.PrintInfo();
            }
        }
    }
}
