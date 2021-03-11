using JobListing.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing
{
    class Worker : Users
    {
        public List<CV> cv = new List<CV>();
        public List<Vacancy> BidList = new List<Vacancy>();
        public Employer employer { get; set; }
        List<Vacancy> FavoriteVacancies = new List<Vacancy>();
        JsonWriteRead js = new JsonWriteRead();
        public List<string> Notifications = new List<string>();
        public CV CreateCV(string education, string school, int score, string skills, string companies, DateTime startTime, DateTime endTime, int experience, string languages, bool certificate, string github, string linkedin)
        {
            CV cvs = new CV
            {
                Education = education,
                SchoolNo = school,
                UniversityScore = score,
                Skills = skills,
                Companie = companies,
                StartTime = startTime,
                EndTime = endTime,
                Experience = experience,
                Language = languages,
                Certificate = certificate,
                GitHub = github,
                Linkedin = linkedin
            };
            return cvs;
        }
        public void AddCV(CV cvs)
        {
            cv.Add(cvs);
        }
        public void UpdateCVEducationInfo(int ID, string education)
        {
            var itemToUpdate = cv.SingleOrDefault(e => e.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Education = education;
            else throw new Exception();
        }
        public void UpdateCVSchoolInfo(int ID, string schoolNo)
        {
            var itemToUpdate = cv.SingleOrDefault(n => n.ID == ID);
            if (itemToUpdate != null) itemToUpdate.SchoolNo = schoolNo;
            else throw new Exception();
        }
        public void UpdateCVCompanyInfo(int ID, string Companie)
        {
            var itemToUpdate = cv.SingleOrDefault(c => c.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Companie = Companie;
            else throw new Exception();
        }
        public void UpdateCVExperienceInfo(int ID, int Experience)
        {
            var itemToUpdate = cv.SingleOrDefault(e => e.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Experience = Experience;
            else throw new Exception();
        }
        public void UpdateCVUniversityScoreInfo(int ID, int score)
        {
            var itemToUpdate = cv.SingleOrDefault(e => e.ID == ID);
            if (itemToUpdate != null) itemToUpdate.UniversityScore = score;
            else throw new Exception();
        }
        public void UpdateCVSkillsInfo(int ID, string skills)
        {
            var itemToUpdate = cv.SingleOrDefault(s => s.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Skills = skills;
            else throw new Exception();
        }
        public void UpdateCVCertificateInfo(int ID, bool certificate)
        {
            var itemToUpdate = cv.SingleOrDefault(c => c.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Certificate = certificate;
            else throw new Exception();
        }
        public void UpdateCVGitHubInfo(int ID, string GitHub)
        {
            var itemToUpdate = cv.SingleOrDefault(g => g.ID == ID);
            if (itemToUpdate != null) itemToUpdate.GitHub = GitHub;
            else throw new Exception();
        }
        public void UpdateCVLinkedinInfo(int ID, string Linkedin)
        {
            var itemToUpdate = cv.SingleOrDefault(l => l.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Linkedin = Linkedin;
            else throw new Exception();
        }
        public void UpdateCVLanguageInfo(int ID, string language)
        {
            var itemToUpdate = cv.SingleOrDefault(s => s.ID == ID);
            if (itemToUpdate != null) itemToUpdate.Language = language;
            else throw new Exception();
        }
        public void UpdateCVStartTimeInfo(int ID, DateTime StartTime)
        {
            var itemToUpdate = cv.SingleOrDefault(n => n.ID == ID);
            if (itemToUpdate != null) itemToUpdate.StartTime = StartTime;
            else throw new Exception();
        }
        public void UpdateCVEndTimeInfo(int ID, DateTime EndTime)
        {
            var itemToUpdate = cv.SingleOrDefault(n => n.ID == ID);
            if (itemToUpdate != null) itemToUpdate.EndTime = EndTime;
            else throw new Exception();
        }

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
        public void DeleteCV(int ID)
        {
            var itemToRemove = cv.SingleOrDefault(r => r.ID == ID);
            if (itemToRemove != null) cv.Remove(itemToRemove);
            else throw new Exception();
        }
        public void ShowCV()
        {
            if (cv != null)
            {
                foreach (var item in cv)
                {
                    Console.WriteLine(item);
                }
            }
            else throw new Exception("You have NO CV");
        }
        public void Bid(Employer employer, int id, int idVac)
        {
            var item = cv.SingleOrDefault(c => c.ID == id);
            if (item != null)
            {
                foreach (var itemVac in employer.vacancies)
                {
                    if (idVac == itemVac.ID)
                    {
                        BidList.Add(itemVac);
                        js.WriteVacanciesToBidList("BidList.json", itemVac);
                    }
                };
                employer.IncomingCVs.Add(item);
            }
            else throw new Exception();
        }
        public void RemoveBid(int idVac)
        {
            var item = BidList.Single(c => c.ID == idVac);
            if (item != null) BidList.Remove(item);
            else throw new Exception();
        }
        public void ShowBidList()
        {
            foreach (var item in BidList)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowNotifications()
        {
            foreach (var item in Notifications)
            {
                Console.WriteLine(item);
            }
        }
        public void AddToFavoritesVacancy(Employer employer, int id)
        {
            var item = employer.vacancies.Single(v => v.ID == id);
            if (item != null) FavoriteVacancies.Add(item);
            else throw new Exception();
        }
        public void ShowFavoriteVacancies()
        {
            foreach (var item in FavoriteVacancies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
