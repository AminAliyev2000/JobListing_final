using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing
{
    class Choiches
    {

        public static void ChoicheForWorkers()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1.Show your CV");
            Console.WriteLine("2.Create new CV");
            Console.WriteLine("3.Delete CV");
            Console.WriteLine("4.Update CV");
            Console.WriteLine("5.Show vacancies");
            Console.WriteLine("6.Show Bid list");
            Console.WriteLine("7.Remove Bid");
            Console.WriteLine("8.Show Favorites");
            Console.WriteLine("9.Notifications");
            Console.WriteLine("10.Search");
            Console.WriteLine("0.Exit");
        }
        public static void ChoicheForEmployers()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1.Show your vacancies");
            Console.WriteLine("2.Create new vacancy");
            Console.WriteLine("3.Delete vacancy");
            Console.WriteLine("4.Update vacancy");
            Console.WriteLine("5.Show all employees");
            Console.WriteLine("6.Show Favorites");
            Console.WriteLine("7.Incoming CVs");
            Console.WriteLine("0.Exit");
        }
        public static void ChoiceforVacancyAndCVMenu()
        {
            Console.WriteLine("1.Bid");
            Console.WriteLine("2.Add Favorites");
            Console.WriteLine("0.Exit");
        }
        public static void PrintCategories()
        {
            Console.WriteLine("1.IT");
            Console.WriteLine("2.Marketing");
            Console.WriteLine("3.Design");
            Console.WriteLine("4.Business");
            Console.WriteLine("5.Writing");
        }
        public static void PrintPlaces()
        {
            Console.WriteLine("1.Baku");
            Console.WriteLine("2.Ganja");
            Console.WriteLine("3.Sumgait");
            Console.WriteLine("4.Tovuz");
            Console.WriteLine("5.Lankaran");
            Console.WriteLine("6.Barda");
        }
        public static void PrintAcceptRefuseMenu()
        {
            Console.WriteLine("Accept or refuse?");
            Console.WriteLine("1.Accept");
            Console.WriteLine("2.Refuse");
            Console.WriteLine("0.Exit");
        }
        public static void UpdateChoicheForCV()
        {
            Console.WriteLine("1.Update Education");
            Console.WriteLine("2.Update SchoolNo");
            Console.WriteLine("3.Update Companies");
            Console.WriteLine("4.Update Experience");
            Console.WriteLine("5.Update Score");
            Console.WriteLine("6.Update Skills");
            Console.WriteLine("7.Update Certificate");
            Console.WriteLine("8.Update Github");
            Console.WriteLine("9.Update LinkedIn");
            Console.WriteLine("10.Update Language");
            Console.WriteLine("11.Update StartTime");
            Console.WriteLine("12.Update EndTime");
            Console.WriteLine("0.Exit");

            /*
        public string Education { get; set; }
        public string SchoolNo { get; set; }
        public string Companie { get; set; }
        public int Experience { get; set; }
        public int UniversityScore { get; set; }
        public string Skills { get; set; }
        public bool Certificate { get; set; } = false;
        public string GitHub { get; set; }
        public string Linkedin { get; set; }
        public string Language { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
             */
        }
        public static void UpdateChoicheForVacancy()
        {
            Console.WriteLine("1.Update category");
            Console.WriteLine("2.Update place");
            Console.WriteLine("3.Update salary");
            Console.WriteLine("4.Update start time");
            Console.WriteLine("5.Update end time");
            Console.WriteLine("6.Update requirements");
            Console.WriteLine("7.Update job details");
            Console.WriteLine("8.Update experience");
            Console.WriteLine("9.Update email");
            Console.WriteLine("0.Exit");
            /*    
        public string VacancyName { get; set; }
        public string Place { get; set; } = "Baku";
        public double Salary { get; set; } = 300;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Requirement { get; set; } = "";
        public string InformationAboutJob { get; set; } = "";
        public int Experience { get; set; }
        public string Email { get; set; } = "@gmail.com";*/
        }
    }
}
