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

                        break;
                    case '4':

                        break;
                    case '5':

                        break;
                    case '6':

                        break;

                    case 'Q':
                        Console.WriteLine("arrivederci");
                        break;
                    default:
                        break;
                }
            } while (scelta != 'Q');
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
