using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing.User
{
    class Vacancy
    {
        public static int StaticID { get; set; } = 0;
        public int ID { get; set; }
        public string VacancyName { get; set; }
        public string Place { get; set; } = "Baku";
        public double Salary { get; set; } = 300;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Requirement { get; set; } = "";
        public string InformationAboutJob { get; set; } = "";
        public int Experience { get; set; }
        public string Email { get; set; } = "@gmail.com";
        public int ViewCount { get; set; }

        public Vacancy()
        {
            ID = ++StaticID;
        }
        public static Vacancy operator ++(Vacancy vacancy)
        {
            vacancy.ViewCount++;
            return vacancy;
        }
        public override string ToString()
        {
            return $"\n========================================================================" +
                $"Id : {ID}\nVacancy Name: {VacancyName}\tWorking hours : {StartTime.ToShortTimeString()} - {EndTime.ToShortTimeString()}\nPlace : {Place}\nSalary : {Salary}\nRequirement - {Requirement}\nInformation about : {InformationAboutJob},Email : {Email}";
        }
    }
}
