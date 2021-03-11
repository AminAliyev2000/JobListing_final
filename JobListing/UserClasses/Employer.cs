using JobListing.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing
{
    class Employer:Users
    {
        public List<Vacancy> vacancies = new List<Vacancy>();
        List<Vacancy> SearchList = new List<Vacancy>();
        public Worker Workers { get; set; }
        public List<CV> IncomingCVs = new List<CV>();
        public List<CV> AcceptedCVs = new List<CV>();
        public List<CV> RefusedCVs = new List<CV>();
        List<CV> Favorites = new List<CV>();
        JsonWriteRead js=new JsonWriteRead();
        public Employer() { }
        public Vacancy CreateVacancy(string vacancyName, string place,  DateTime startTime, DateTime endTime, int salary, int experience, string email, string InformationAboutJob, string requirements) 
        {
            Vacancy vacancy = new Vacancy
            {
                VacancyName = vacancyName,
                Place = place,
                Salary = salary,
                StartTime = startTime,
                EndTime = endTime,
                Experience = experience,
                InformationAboutJob = InformationAboutJob,
                Requirement = requirements,
                Email = email
                /*
        public string VacancyName { get; set; }
        public string Place { get; set; } = "Baku";
        public double Salary { get; set; } = 300;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Requirement { get; set; } = "";
        public string InformationAboutJob { get; set; } = "";
        public int Experience { get; set; }
        public string Email { get; set; } = "@gmail.com";
                 
                 */
            };
            return vacancy;
        }
        public void AddVacancy(Vacancy vacancy)
        {
            vacancies.Add(vacancy);
        }
        public void UpdateVacancyName(int ID, string vacancyName)
        {
            var itemToUpdate = vacancies.SingleOrDefault(c => c.ID == ID);
            if (itemToUpdate != null) itemToUpdate.VacancyName = vacancyName;
            else throw new Exception();
        }
        public void UpdatePlaceInfo(int ID,string place)
        {
            var itemToUpdate = vacancies.SingleOrDefault(p => p.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Place = place;
            else throw new Exception();
        }
        public void UpdateSalaryInfo(int ID,double salary)
        {
            var itemToUpdate = vacancies.SingleOrDefault(s => s.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Salary = salary;
            else throw new Exception();

        }
        public void UpdateStartTimeInfo(int ID,DateTime startTime)
        {
            var itemToUpdate = vacancies.SingleOrDefault(t => t.ID == ID);
            itemToUpdate.StartTime = startTime;
        }
        public void UpdateEndTimeInfo(int ID,DateTime endTime)
        {
            var itemToUpdate = vacancies.SingleOrDefault(t => t.ID == ID);
            itemToUpdate.EndTime = endTime;
        }
        public void UpdateRequirementInfo(int ID,string Requirement)
        {
            var itemToUpdate = vacancies.SingleOrDefault(r => r.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Requirement = Requirement;
            else throw new Exception();
        }
        public void UpdateInformationAboutJob(int ID,string InformationAboutJob)
        {
            var itemToUpdate = vacancies.SingleOrDefault(i => i.ID == ID);
            if (itemToUpdate != null) itemToUpdate.InformationAboutJob = InformationAboutJob;
            else throw new Exception();
        }
        public void UpdateExperience(int ID, int experience)
        {
            var itemToUpdate = vacancies.SingleOrDefault(c => c.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Experience = experience;
            else throw new Exception();
        }
        public void UpdateEmailInfo(int ID,string email)
        {
            var itemToUpdate = vacancies.SingleOrDefault(e => e.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Email = email;
            else throw new Exception();
        }
        /*    
         public string VacancyName { get; set; }
         public string Place { get; set; } = "Baku";
         public double Salary { get; set; } = 300;
         public DateTime StartTime { get; set; }
         public DateTime EndTime { get; set; }
         public string Requirement { get; set; } = "";
         public string InformationAboutJob { get; set; } = "";
         public int Experience { get; set; }
         public string Email { get; set; } = "@gmail.com";
        */


        public void DeleteVacancy(int ID)
        {
            var itemToRemove = vacancies.SingleOrDefault(r => r.ID == ID);
            if (itemToRemove != null) vacancies.Remove(itemToRemove);
            else throw new Exception();
        }
        public void ShowVacancies()
        {
            foreach(var item in vacancies)
            {
                Console.WriteLine(item);
            }
        }
        public void Accept(Worker worker, int id)
        {
            var item = IncomingCVs.SingleOrDefault(c => c.ID == id);
            AcceptedCVs.Add(item);
        }
        public void Refuse(Worker employee, int id)
        {
            var item = IncomingCVs.SingleOrDefault(c => c.ID == id);
            RefusedCVs.Add(item);
            IncomingCVs.Remove(item);
            Console.WriteLine($" Refused");
        }
        public void ShowIncomingCVs()
        {
            foreach (var item in IncomingCVs)
            {
                Console.WriteLine(item);
            }
        }

        public void SearchByCategory(string category)
        {
            if (category != "Unassigned")
            {
                foreach (var item in vacancies)
                {
                    if (item.VacancyName == category)
                    {
                        SearchList.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in vacancies)
                {
                    SearchList.Add(item);
                }
            }
        }
        public void SearchByCity(string place)
        {
            if (place != "Unassigned")
            {
                foreach (var item in vacancies)
                {
                    if (item.Place != place)
                    {
                        SearchList.Remove(item);
                    }
                }
            }
            else
            {

            }
        }
        public void SearchBySalary(int min, int max)
        {
            foreach (var item in vacancies)
            {
                if (item.Salary < min || item.Salary > max)
                {
                    SearchList.Remove(item);
                }
            }
        }
        public void SearchByExperience(int num)
        {
            foreach (var item in vacancies)
            {
                if (item.Experience != num)
                {
                    SearchList.Remove(item);
                }
            }
        }
        public void ShowSearchList()
        {
            foreach (var item in SearchList)
            {
                Console.WriteLine(item);
            }
        }
        public void AddToFavoritesCV(Worker worker, int id)
        {
            var item = worker.cv.SingleOrDefault(c => c.ID == id);
            if (item != null) Favorites.Add(item);
            else throw new Exception();
        }
        public void ShowFavoriteCVs()
        {
            foreach (var item in Favorites)
            {
                Console.WriteLine(item);
            }
        }
    }
}
