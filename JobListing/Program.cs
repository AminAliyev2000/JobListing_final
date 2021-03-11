using JobListing.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing
{


    class Program
    {
        enum ChoicheForEmployers:int
        {
            Show_Vacancies = 1, Create_Vacancy = 2, Delete_Vacancy = 3, Update_Vacancy = 4, Show_Worker = 5,
            Show_Favorites = 6, Incoming_CV = 7,Exit = 0
        };
        enum ChoicheForWorkers:int { Show_CV=1, Create_CV = 2, Delete_CV = 3, Update_CV = 4, Show_Vacancies = 5
                , Show_BidList = 6, Remove_Bid = 7, Show_Favorites = 8, Notifications = 9, Search=10, Exit = 0 };
        enum ChoiceforVacancyAndCVMenu:int { Bid = 1, Add_Favorites = 2, Exit = 0 };
        enum PrintCategories { IT = 1, Marketing = 2, Design = 3, Business = 4, Writing = 5 };
        enum PrintPlaces { Baku = 1, Ganja = 2, Sumgait = 3, Tovuz = 4, Lankaran = 5, Barda = 6 };
        enum PrintAcceptRefuse { Accept = 1, Refuse = 2 ,Exit=0};
        enum UpdateChoicheForCV
        {
            Update_Education = 1, Update_SchoolNo = 2, Update_Companie = 3, Update_Experience = 4, Update_Score = 5,
            Update_Skills = 6, Update_Certificate = 7, Update_Github = 8, Update_LinkedIn = 9, Update_Language = 10, Update_StartTime = 11, Update_EndTime = 12, Exit = 0
        }
        enum UpdateChoicheForVacancy
        {
            Update_category = 1, Update_place = 2, Update_salary = 3, Update_start_time = 4, Update_end_time = 5,
            Update_requirements = 6, Update_job_details = 7, Update_experience = 8, Update_email = 9, Exit = 0
        };

        static Worker FindWorker(List<Worker> workers, string username)
        {
            Worker worker = new Worker();
            foreach (var item in workers)
            {
                if (item.Username == username)
                {
                    return item;
                }
            }
            return worker;
        }
        static Employer FindEmployer(List<Employer> employers, string username)
        {
            Employer employer = new Employer();
            foreach (var item in employers)
            {
                if (item.Username == username)
                {
                    return item;
                }
            }
            return employer;
        }
        static Employer FindEmployerByVacancyID(List<Employer> employers, int id)
        {
            Employer employer = new Employer();
            foreach (var itemEmployer in employers)
            {
                foreach (var itemVacancy in itemEmployer.vacancies)
                {
                    if (id == itemVacancy.ID)
                    {
                        return itemEmployer;
                    }
                }
            }
            return employer;
        }
        static Worker FindWorkerByID(List<Worker> workers, int id)
        {
            Worker worker = new Worker();
            foreach (var itemWorker in workers)
            {
                foreach (var item in itemWorker.cv)
                {
                    if (id == item.ID)
                    {
                        return itemWorker;
                    }
                }
            }
            return worker;
        }
        public static string LogIN(List<Worker> workers, List<Employer> employers, string username, string password)
        {
            foreach (var item in workers)
            {
                if (item.Username == username)
                {
                    if (item.Password == password)
                    {
                        return "worker";
                    }
                }
            }
            foreach (var item in employers)
            {
                if (item.Username == username)
                {
                    if (item.Password == password)
                    {
                        return "employer";
                    }
                }
            }
            return "There is no any worker or employer with this credentials!Try again";
        }
        static void SendNotificationToWorker(Worker employee, string choice)
        {
            if (choice == "accept")
            {
                employee.Notifications.Add("Your CV was accepted!");
            }
            else if (choice == "refuse")
            {
                employee.Notifications.Add("Your CV was refused!");
            }
            else
            {
                Console.WriteLine("Wrong Input!");
            }
        }
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            List<Employer> employers = new List<Employer>();
            Worker worker1 = new Worker
            {
                Name = "John",
                Surname = "Johnlu",
                Age = 30,
                PhoneNum = "1231231233",
                Place = Places.Baku,
                Email="someemail@gmail.com",
                Username = "John",
                Password = "john"
            };
            Worker worker2 = new Worker
            {
                Name = "John1",
                Surname = "Johnlu1",
                Age = 31,
                PhoneNum = "1231231111111",
                Place = Places.Barda,
                Email = "someemail1@gmail.com",
                Username = "John1",
                Password = "john1"
            };
            Worker worker3 = new Worker
            {
                Name = "John2",
                Surname = "Johnlu",
                Age = 32,
                PhoneNum = "1231231233",
                Place = Places.Ganja,
                Email = "someemail2@gmail.com",
                Username = "John2",
                Password = "john2"
            };
            Worker worker4 = new Worker
            {
                Name = "John3",
                Surname = "Johnlu",
                Age = 33,
                PhoneNum = "1231231233",
                Place = Places.Baku,
                Email = "someemail@gmail.com",
                Username = "John3",
                Password = "john3"
            };
            Worker worker5 = new Worker
            {
                Name = "John4",
                Surname = "Johnlu",
                Age = 34,
                PhoneNum = "1231231233",
                Place = Places.Tovuz,
                Email = "someemail@gmail.com",
                Username = "John4",
                Password = "john4"
            };
            Worker worker6 = new Worker
            {
                Name = "John5",
                Surname = "Johnlu",
                Age = 35,
                PhoneNum = "1231231233",
                Place = Places.Lankaran,
                Email = "someemail@gmail.com",
                Username = "John5",
                Password = "john5"
            };
            Worker worker7 = new Worker
            {
                Name = "John6",
                Surname = "Johnlu",
                Age = 36,
                PhoneNum = "1231231233",
                Place = Places.Baku,
                Email = "someemail@gmail.com",
                Username = "John6",
                Password = "john6"
            };
            Worker worker8 = new Worker
            {
                Name = "John7",
                Surname = "Johnlu",
                Age = 37,
                PhoneNum = "1231231233",
                Place = Places.Barda,
                Email = "someemail@gmail.com",
                Username = "John7",
                Password = "john37"

            };
            Worker worker9 = new Worker
            {
                Name = "John8",
                Surname = "Johnlu",
                Age = 38,
                PhoneNum = "1231231233",
                Place = Places.Baku,
                Email = "someemail@gmail.com",
                Username = "John8",
                Password = "john8"
            };
            Worker worker10 = new Worker
            {
                Name = "John9",
                Surname = "Johnlu",
                Age = 39,
                PhoneNum = "1231231233",
                Place = Places.Lankaran,
                Email = "someemail@gmail.com",
                Username = "John9",
                Password = "john9"
            };
            Employer employer1 = new Employer {
                Name = "Amin",
                Surname = "Aliyev",
                Age = 21,
                PhoneNum = "0513110929",
                Place = Places.Baku,
                Email = "aliyevamin50@gmail.com",
                Username = "Amin",
                Password = "amin"
            };
            Employer employer2 = new Employer {
                Name = "Amin2",
                Surname = "Aliyev",
                Age = 22,
                PhoneNum = "0513110929",
                Place = Places.Tovuz,
                Email = "aliyevamin50@gmail.com",
                Username = "Amin2",
                Password = "amin2"

            };
            Employer employer3 = new Employer {
                Name = "Amin3",
                Surname = "Aliyev",
                Age = 23,
                PhoneNum = "0513110929",
                Place = Places.Lankaran,
                Email = "aliyevamin50@gmail.com",
                Username = "Amin3",
                Password = "amin3"
            };
            Employer employer4 = new Employer {
                Name = "Amin4",
                Surname = "Aliyev",
                Age = 24,
                PhoneNum = "0513110929",
                Place = Places.Baku,
                Email = "aliyevamin50@gmail.com",
                Username = "Amin4",
                Password = "amin4"
            };
            Employer employer5 = new Employer {
                Name = "Amin5",
                Surname = "Aliyev",
                Age = 25,
                PhoneNum = "0513110929",
                Place = Places.Baku,
                Email = "aliyevamin50@gmail.com",
                Username = "Amin5",
                Password = "amin5"
            };
            CV cv1 = new CV{
             Education="Engineer",
             SchoolNo= "249",
             Companie="BP,Socar",
             Experience=3,  
             Language="Turkish,English",
             UniversityScore=569,
             Skills= "To mine oil and gas",
             Certificate= true,
             GitHub="i have no github",
             Linkedin="i have no Linkedin"
            };
            CV cv2 = new CV {

            Education ="Designer",
            SchoolNo = "250",
            Companie ="SmartArt",
            Experience = 2,
            Language = "Turkish,English",
            UniversityScore =600,
            Skills ="Adobe",
            Certificate =true,
            GitHub ="gitgit",
            Linkedin ="linklink"
            };
            CV cv3 = new CV {
                Education ="Teacher",
                SchoolNo = "251",
                Companie ="250 numbered school",
                Experience = 5,
                Language = "Turkish,English",
                UniversityScore =400,
                Skills ="Math Teacher",
                Certificate =true,
                GitHub ="gti1git1",
                Linkedin ="link1link1",
            }; 
            CV cv4 = new CV {
            Education ="Business,Brocker",
            SchoolNo = "252",
            Companie ="Wall Street",
            Experience = 6,
            Language = "Turkish,English",
            UniversityScore =680,
            Skills ="i sold unuseful actions toJP morgan executive director",
            Certificate =false,
            GitHub ="google",
            Linkedin ="linkgoogle"
            };
            CV cv5 = new CV {
            Education ="Developer",
            SchoolNo = "253",
            Companie ="Risc",
            Experience = 7,
            Language = "Turkish,English",
            UniversityScore =350,
            Skills ="Linux",
            Certificate =true,
            GitHub ="linuxman",
            Linkedin ="linuxman"
            };
            CV cv6 = new CV {
            Education ="Designer",
            SchoolNo = "254",
            Companie ="Tesla",
            Experience =1,
            Language = "Turkish,English",
            UniversityScore =130,
            Skills ="Adobe",
            Certificate =false,
            GitHub ="gitlink",
            Linkedin ="linklink"
            };
            CV cv7 = new CV {
            Education ="Developer",
            SchoolNo = "255",
            Companie ="Samsung",
            Experience = 3,
            Language = "Turkish,English",
            UniversityScore =655,
            Skills ="Flutter",
            Certificate =true,
            GitHub ="samsam",
            Linkedin ="yamyam"
            };
            CV cv8 = new CV {
            Education ="Developer",
            SchoolNo = "256",
            Companie ="Apple",
            Experience = 3,
            Language = "Turkish,English",
            UniversityScore =550,
            Skills ="Swift",
            Certificate =true,
            GitHub ="gitapple",
            Linkedin ="newton"
            };
            CV cv9 = new CV {
            Education ="Developer",
            SchoolNo = "257",
            Companie ="Xiaomi",
            Experience = 3,
            Language = "Turkish,English",
            UniversityScore =600,
            Skills ="Kotlin",
            Certificate =true,
            GitHub ="xioxio",
            Linkedin ="mimi"
            };
            CV cv10 = new CV {
            Education ="Developer",
            SchoolNo = "258",
            Companie ="Steps",
            Experience = 3,
            Language = "Turkish,English",
            UniversityScore =390,
            Skills ="Junior skills c++ and c#",
            Certificate =true,
            GitHub ="nope",
            Linkedin ="nope"
            };
            Vacancy vc1 = new Vacancy {
                VacancyName = "Design",
                Place=Places.Tovuz,
                StartTime=new DateTime(2021,04,06,06,14,00),
                EndTime= new DateTime(2021, 04, 06, 22, 00, 00),
                Salary=800,
                Experience=1,
                Email="efiefioehoi@mail.ru",
                InformationAboutJob="We need designer",
                Requirement="Strong Adobe abilities"


            };
            Vacancy vc2 = new Vacancy {
                VacancyName = "IT",
                Place = Places.Lankaran,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 2500,
                Experience = 3,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need a developer",
                Requirement = "Strong C# abilities"
            };
            Vacancy vc3 = new Vacancy {
                VacancyName = "Writing",
                Place=Places.Barda,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 1700,
                Experience = 5,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need a teacher",
                Requirement = "Good managing of class"
            };
            Vacancy vc4 = new Vacancy {
                VacancyName = "Marketing",
                Place=Places.Ganja,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 3800,
                Experience = 10,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need a manager",
                Requirement = "Manage the store and take statistics of profit"
            };
            Vacancy vc5 = new Vacancy {
                VacancyName = "Business",
                Place = Places.Baku,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 2800,
                Experience = 1,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need a brocker",
                Requirement = "Able to tell lies to customers"
            };
            Vacancy vc6 = new Vacancy {
                VacancyName = "IT",
                Place = Places.Baku,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 800,
                Experience = 1,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need Java developer",
                Requirement = "Java,Git,Linux"
            };
            Vacancy vc7 = new Vacancy {
                VacancyName = "Designer",
                Place = Places.Baku,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 1200,
                Experience = 4,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need a designer",
                Requirement = "Strong Adobe abilities and AE"
            };
            Vacancy vc8 = new Vacancy {
                VacancyName = "IT",
                Place = Places.Baku,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 8000,
                Experience = 6,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need developer",
                Requirement = "C++,C#,Java........and others"
            };
            Vacancy vc9 = new Vacancy {
                VacancyName = "IT",
                Place = Places.Baku,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 3500,
                Experience = 6,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need mobile developer",
                Requirement = "Write programs for IOS and Android"
            };
            Vacancy vc10 = new Vacancy {
                VacancyName = "IT",
                Place = Places.Baku,
                StartTime = new DateTime(2021, 04, 06, 06, 14, 00),
                EndTime = new DateTime(2021, 04, 06, 22, 00, 00),
                Salary = 500,
                Experience = 1,
                Email = "efiefioehoi@mail.ru",
                InformationAboutJob = "We need Junior C++ developer",
                Requirement = "C++,STL"
            };
         
            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);
            workers.Add(worker4);
            workers.Add(worker5);
            workers.Add(worker6);
            workers.Add(worker7);
            workers.Add(worker8);
            workers.Add(worker9);
            workers.Add(worker10);
            employers.Add(employer1);
            employers.Add(employer2);
            employers.Add(employer3); 
            employers.Add(employer4);
            employers.Add(employer5);
            worker1.AddCV(cv1);
            worker2.AddCV(cv2);
            worker3.AddCV(cv3);
            worker4.AddCV(cv4);
            worker5.AddCV(cv5);
            worker6.AddCV(cv6);
            worker7.AddCV(cv7);
            worker8.AddCV(cv8);
            worker9.AddCV(cv9);
            worker10.AddCV(cv10);
            employer1.AddVacancy(vc1);
            employer1.AddVacancy(vc2);
            employer2.AddVacancy(vc3);
            employer2.AddVacancy(vc4);
            employer3.AddVacancy(vc5);
            employer3.AddVacancy(vc6);
            employer4.AddVacancy(vc7);
            employer4.AddVacancy(vc8);
            employer4.AddVacancy(vc9);
            employer5.AddVacancy(vc10);


            JsonWriteRead js = new JsonWriteRead();
            js.WriteWorkers("Workers.json", workers);
            js.WriteEmployers("Employer.json", employers);
            foreach (var item in workers)
            {
                js.WriteCV("CV.json", item.cv);
            }
            foreach (var item in employers)
            {
                js.WriteVacancies("Vacancies.json", item.vacancies);
            }
            string username;
            string password;
            int choiceforWorker;
            int choiceforEmployer;
            string vacancyName;
            string place;
            bool @while1 = true;
            while (@while1)
            {
                Console.Clear();
                
                
                bool @while2 = true;
                while (@while2)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to our not ideal job listing system!\n");
                    Console.WriteLine("Enter your username: ");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    password = Console.ReadLine();
                    bool workerch = true;
                    bool employerch = true;
                    Console.Clear();
                    if (LogIN(workers, employers, username, password) == "worker")
                    {
                        while (workerch)
                        {
                            Console.Clear();
                            Choiches.ChoicheForWorkers();
                            choiceforWorker =Convert.ToInt32( Console.ReadLine());
                            switch (choiceforWorker)
                            {
                                case (int)ChoicheForWorkers.Show_CV:
                                    Console.Clear();
                                    FindWorker(workers, username).ShowCV();
                                    Console.ReadLine();
                                    break;
                                case (int)ChoicheForWorkers.Create_CV:
                                    
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter profession: ");
                                        string profession = Console.ReadLine();
                                        Console.WriteLine("Enter school: ");
                                        string school = Console.ReadLine();
                                        Console.WriteLine("Enter score: ");
                                        int score = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Write about your skills: ");
                                        string skills = Console.ReadLine();
                                        Console.WriteLine("Write about companies which you worked: ");
                                        string companies = Console.ReadLine();
                                        Console.WriteLine("Start time: (mm/dd/yyyy)");
                                        DateTime startTime = Convert.ToDateTime(Console.ReadLine());
                                        Console.WriteLine("End time: (mm/dd/yyyy)");
                                        DateTime endTime = Convert.ToDateTime(Console.ReadLine());
                                        Console.WriteLine("Enter your experience:");
                                        int experience = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter languages that you know: ");
                                        string languages = Console.ReadLine();
                                        Console.WriteLine("Do you have any certificate: (true/false)");
                                        bool certificate = Convert.ToBoolean(Console.ReadLine());
                                        Console.WriteLine("Your Github link: ");
                                        string github = Console.ReadLine();
                                        Console.WriteLine("Your LinkedIn account link: ");
                                        string linkedin = Console.ReadLine();
                                        var newCV = FindWorker(workers, username).CreateCV(profession, school, score, skills, companies, startTime, endTime, experience, languages, certificate, github, linkedin);
                                        FindWorker(workers, username).AddCV(newCV);
                                        FindWorker(workers, username).ShowCV();
                                        js.WriteWorkers("Workers.json", workers);
                                        Console.ReadLine();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                        Console.ReadLine();
                                    }
                                    break;
                                case (int)ChoicheForWorkers.Delete_CV:
                                     
                                    try
                                    {
                                        Console.Clear();
                                        FindWorker(workers, username).ShowCV();
                                        Console.WriteLine("Enter ID: ");
                                        int id = int.Parse(Console.ReadLine());
                                        FindWorker(workers, username).DeleteCV(id);
                                        js.WriteWorkers("Workers.json", workers);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                        Console.ReadLine();
                                    }
                                    break;
                                case (int)ChoicheForWorkers.Update_CV:
                                    try
                                    {
                                        bool updateCV = true;
                                        while (updateCV)
                                        {

                                            Console.Clear();
                                            FindWorker(workers, username).ShowCV();
                                            Console.WriteLine("Which CV you want to update ?\nEnter an ID:");
                                            int idForUpdateCV = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            Choiches.UpdateChoicheForCV();
                                            Console.WriteLine("Choose an option which you want to update: ");
                                            int choiceForUpdateCV =Convert.ToInt32( Console.ReadLine());

                                            switch (choiceForUpdateCV)
                                            {
                                                case (int)UpdateChoicheForCV.Update_Education:
                                                    Console.WriteLine("Enter new education: ");
                                                    string updatedEducation = Console.ReadLine();
                                                    FindWorker(workers, username).UpdateCVEducationInfo(idForUpdateCV, updatedEducation);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_SchoolNo:
                                                    Console.WriteLine("Enter new school: ");
                                                    string updatedSchool = Console.ReadLine();
                                                    FindWorker(workers, username).UpdateCVSchoolInfo(idForUpdateCV, updatedSchool);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_Companie:
                                                    Console.WriteLine("Enter new companie: ");
                                                    string updatedCompanies = Console.ReadLine();
                                                    FindWorker(workers, username).UpdateCVCompanyInfo(idForUpdateCV, updatedCompanies);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_Experience:
                                                    Console.WriteLine("Enter your new experience:");
                                                    int updateExperience = int.Parse(Console.ReadLine());
                                                    FindWorker(workers, username).UpdateCVExperienceInfo(idForUpdateCV, updateExperience);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_Score:
                                                    Console.WriteLine("Enter new score: ");
                                                    int updatedScore = int.Parse(Console.ReadLine());
                                                    FindWorker(workers, username).UpdateCVUniversityScoreInfo(idForUpdateCV, updatedScore);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_Skills:
                                                    Console.WriteLine("Enter new skill: ");
                                                    string updatedSkills = Console.ReadLine();
                                                    FindWorker(workers, username).UpdateCVSkillsInfo(idForUpdateCV, updatedSkills);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_Certificate:
                                                    Console.WriteLine("Enter new certificate(true/false): ");
                                                    bool updatedCertificae = bool.Parse(Console.ReadLine());
                                                    FindWorker(workers, username).UpdateCVCertificateInfo(idForUpdateCV, updatedCertificae);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_Github:
                                                    Console.WriteLine("Enter new Github link: ");
                                                    string updatedGithub = Console.ReadLine();
                                                    FindWorker(workers, username).UpdateCVGitHubInfo(idForUpdateCV, updatedGithub);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_LinkedIn:
                                                    Console.WriteLine("Enter new LinkedIn link: ");
                                                    string updatedLinkedIn = Console.ReadLine();
                                                    FindWorker(workers, username).UpdateCVLinkedinInfo(idForUpdateCV, updatedLinkedIn);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_Language:
                                                    Console.WriteLine("Enter new languages: ");
                                                    string updatedLanguage = Console.ReadLine();
                                                    FindWorker(workers, username).UpdateCVLanguageInfo(idForUpdateCV, updatedLanguage);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_StartTime:
                                                    Console.WriteLine("Enter new start time(mm/dd/yyyy): ");
                                                    DateTime updatedStartTime = DateTime.Parse(Console.ReadLine());
                                                    FindWorker(workers, username).UpdateCVStartTimeInfo(idForUpdateCV, updatedStartTime);
                                                    break;
                                                case (int)UpdateChoicheForCV.Update_EndTime:
                                                    Console.WriteLine("Enter new end time(mm/dd/yyyy): ");
                                                    DateTime updatedEndTime = DateTime.Parse(Console.ReadLine());
                                                    FindWorker(workers, username).UpdateCVEndTimeInfo(idForUpdateCV, updatedEndTime);
                                                    break;
                                                case (int)UpdateChoicheForCV.Exit:
                                                    updateCV = false;
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        js.WriteWorkers("Workers.json", workers);

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                        Console.ReadLine();
                                    }
                                    break;
                                case (int)ChoicheForWorkers.Show_Vacancies:
                                 
                                    Console.Clear();
                                    foreach (var item in employers)
                                    {
                                        item.ShowVacancies();
                                    }
                                    Choiches.ChoiceforVacancyAndCVMenu();
                                    Console.WriteLine("Choose an option: ");
                                    int choiceForVacancy =Convert.ToInt32(Console.ReadLine());
                                    switch (choiceForVacancy)
                                    {
                                        case (int)ChoiceforVacancyAndCVMenu.Bid:
                                            try
                                            {
                                                Console.WriteLine("Enter ID of vacancy you want to bid: ");
                                                int IDBid = int.Parse(Console.ReadLine());
                                                FindWorker(workers, username).ShowCV();
                                                Console.WriteLine("Which CV you want to bid ?");
                                                int choiceCV = int.Parse(Console.ReadLine());
                                                FindWorker(workers, username).Bid(FindEmployerByVacancyID(employers, IDBid), choiceCV, IDBid);
                                                Console.WriteLine("Vacancy added to your bid list succesfully!");
                                                Console.ReadLine();
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                                js.WriteExceptions(ex);
                                                Console.ReadLine();
                                            }
                                            break;
                                        case (int)ChoiceforVacancyAndCVMenu.Add_Favorites:
                                            try
                                            {
                                                Console.WriteLine("Enter ID of vacancy you want to add to your favorites: ");
                                                int IDFav = Convert.ToInt32(Console.ReadLine());
                                                FindWorker(workers, username).AddToFavoritesVacancy(FindEmployerByVacancyID(employers, IDFav), IDFav);
                                                Console.WriteLine("Vacancy added to your favorites succesfully!");
                                                Console.ReadLine();
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                                js.WriteExceptions(ex);
                                                Console.ReadLine();
                                            }
                                            break;
                                        case (int)ChoiceforVacancyAndCVMenu.Exit:
                                            break;
                                        default:
                                            Console.WriteLine("Wrong Input!");
                                            Console.ReadLine();
                                            break;
                                    }
                                    break;
                                case (int)ChoicheForWorkers.Show_BidList:
                                    
                                    Console.Clear();
                                    FindWorker(workers, username).ShowBidList();
                                    Console.ReadLine();
                                    break;
                                case (int)ChoicheForWorkers.Remove_Bid:
                                    
                                    Console.Clear();
                                    FindWorker(workers, username).ShowBidList();
                                    Console.WriteLine("Enter ID of vacancy you want to remove bid: ");
                                    int ID = int.Parse(Console.ReadLine());
                                    FindWorker(workers, username).RemoveBid(ID);
                                    Console.WriteLine("Your bid removed");
                                    Console.ReadLine();
                                    break;
                                case (int)ChoicheForWorkers.Show_Favorites:
                                   
                                    Console.Clear();
                                    FindWorker(workers, username).ShowFavoriteVacancies();
                                    Console.ReadLine();
                                    break;
                                case (int)ChoicheForWorkers.Notifications:
                                   
                                    Console.Clear();
                                    FindWorker(workers, username).ShowNotifications();
                                    Console.ReadLine();
                                    break;
                                case (int)ChoicheForWorkers.Search:
                                    
                                    try
                                    {
                                        Console.Clear();
                                        Choiches.PrintCategories();
                                        Console.WriteLine("0.All");
                                        Console.WriteLine("Choose category: ");
                                        string categoryFilter = Console.ReadLine();
                                        foreach (var item in employers)
                                        {
                                            if (categoryFilter == "1") item.SearchByCategory(Category.IT);
                                            else if (categoryFilter == "2") item.SearchByCategory(Category.Marketing);
                                            else if (categoryFilter == "3") item.SearchByCategory(Category.Design);
                                            else if (categoryFilter == "4") item.SearchByCategory(Category.Business);
                                            else if (categoryFilter == "5") item.SearchByCategory(Category.Writing);
                                            else item.SearchByCategory(Category.Unassigned);
                                        }
                                        Choiches.PrintPlaces();
                                        Console.WriteLine("0.All");
                                        Console.WriteLine("Choose city: ");
                                        string cityFilter = Console.ReadLine();
                                        foreach (var item in employers)
                                        {
                                            if (cityFilter == "1") item.SearchByCity(Places.Baku);
                                            else if (cityFilter == "2") item.SearchByCity(Places.Ganja);
                                            else if (cityFilter == "3") item.SearchByCity(Places.Sumgait);
                                            else if (cityFilter == "4") item.SearchByCity(Places.Tovuz);
                                            else if (cityFilter == "5") item.SearchByCity(Places.Lankaran);
                                            else if (cityFilter == "6") item.SearchByCity(Places.Barda);
                                            else item.SearchByCity(Places.Unassigned);
                                        }
                                        Console.WriteLine("Enter minimum salary: ");
                                        int minimumSalary = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter maximum salary: ");
                                        int maximumSalary = int.Parse(Console.ReadLine());
                                        foreach (var item in employers)
                                        {
                                            item.SearchBySalary(minimumSalary, maximumSalary);
                                        }
                                        Console.Clear();
                                        foreach (var item in employers)
                                        {
                                            item.ShowSearchList();
                                        }
                                        Console.ReadLine();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                    }
                                    break;
                                case (int)ChoicheForWorkers.Exit:
                                    workerch = false;
                                    while2 = false;
                                    break;
                                default:

                                    break;
                            }
                        }
                    }
                    else if (LogIN(workers, employers, username, password) == "employer")
                    {
                        while (employerch)
                        {
                            Console.Clear();
                            Choiches.ChoicheForEmployers();
                            choiceforEmployer = Convert.ToInt32(Console.ReadLine());
                            switch (choiceforEmployer)
                            {
                                case (int)ChoicheForEmployers.Show_Vacancies:
                                    
                                    Console.Clear();
                                    FindEmployer(employers, username).ShowVacancies();
                                    Console.ReadLine();
                                    break;
                                case (int)ChoicheForEmployers.Create_Vacancy:
                                    
                                    try
                                    {
                                       
                                        Console.WriteLine("Enter vacancy category: ");
                                        Choiches.PrintCategories();
                                        string choiceCategory = Console.ReadLine();
                                        if (choiceCategory == "1") vacancyName = Category.IT;
                                        else if (choiceCategory == "2") vacancyName = Category.Marketing;
                                        else if (choiceCategory == "3") vacancyName = Category.Design;
                                        else if (choiceCategory == "4") vacancyName = Category.Business;
                                        else if (choiceCategory == "5") vacancyName = Category.Writing;
                                        else vacancyName = Category.Unassigned;
                                        Console.WriteLine("Enter city: ");
                                        Choiches.PrintPlaces();
                                      
                                        string choiceCity = Console.ReadLine();
                                        if (choiceCity == "1") place = Places.Baku;
                                        else if (choiceCity == "2") place = Places.Ganja;
                                        else if (choiceCity == "3") place = Places.Sumgait;
                                        else if (choiceCity == "4") place = Places.Tovuz;
                                        else if (choiceCity == "5") place = Places.Lankaran;
                                        else if (choiceCity == "6") place = Places.Barda;
                                        else place = Places.Unassigned;
                                        Console.WriteLine("Enter start time: ");
                                        DateTime startTime = DateTime.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter end time: ");
                                        DateTime endTime = DateTime.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter salary: ");
                                        int salary = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter required experience");
                                        int experience = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter email: ");
                                        string email = Console.ReadLine();
                                        Console.WriteLine("Enter information about job: ");
                                        string jobDetails = Console.ReadLine();
                                        Console.WriteLine("Enter requirements: ");
                                        string requirements = Console.ReadLine();
                                        var newVacancy = FindEmployer(employers, username).CreateVacancy(vacancyName, place, startTime, endTime, salary, experience, email, jobDetails, requirements);
                                        FindEmployer(employers, username).AddVacancy(newVacancy);
                                        FindEmployer(employers, username).ShowVacancies();
                                        js.WriteEmployers("Employers.json", employers);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                        Console.ReadLine();
                                    }
                                    break;
                                case (int)ChoicheForEmployers.Delete_Vacancy:
                                   
                                    try
                                    {
                                        Console.Clear();
                                        FindEmployer(employers, username).ShowVacancies();
                                        Console.WriteLine("Enter ID: ");
                                        int id = int.Parse(Console.ReadLine());
                                        FindEmployer(employers, username).DeleteVacancy(id);
                                        js.WriteEmployers("Employers.json", employers);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                        Console.ReadLine();
                                    }
                                    break;
                                case (int)ChoicheForEmployers.Update_Vacancy:
                                    
                                    try
                                    {
                                        bool updateVacancy = true;
                                        while (updateVacancy)
                                        {

                                            Console.Clear();
                                            FindEmployer(employers, username).ShowVacancies();
                                            Console.WriteLine("Which Vacancy you want to update ?\nEnter an ID:");
                                            int idForUpdateVacancy = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            Choiches.UpdateChoicheForVacancy();
                                            Console.WriteLine("Choose an option which you want to update: ");
                                            int choiceForUpdateVacancy =  Convert.ToInt32(Console.ReadLine());
                                            switch (choiceForUpdateVacancy)
                                            {
                                                case (int)UpdateChoicheForVacancy.Update_category:
                                                    Console.WriteLine("Enter new vacancy category: ");
                                                    Choiches.PrintCategories();
                                                    string choiceCategory = Console.ReadLine();
                                                    if (choiceCategory == "1") FindEmployer(employers, username).UpdateVacancyName(idForUpdateVacancy, Category.IT);
                                                    else if (choiceCategory == "2") FindEmployer(employers, username).UpdateVacancyName(idForUpdateVacancy, Category.Marketing);
                                                    else if (choiceCategory == "3") FindEmployer(employers, username).UpdateVacancyName(idForUpdateVacancy, Category.Design);
                                                    else if (choiceCategory == "4") FindEmployer(employers, username).UpdateVacancyName(idForUpdateVacancy, Category.Business);
                                                    else if (choiceCategory == "5") FindEmployer(employers, username).UpdateVacancyName(idForUpdateVacancy, Category.Writing);
                                                    else FindEmployer(employers, username).UpdateVacancyName(idForUpdateVacancy, Category.Unassigned);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Update_place:
                                                    Console.WriteLine("Enter new city: ");
                                                    Choiches.PrintPlaces();
                                                    string choiceCity = Console.ReadLine();
                                                    if      (choiceCity == "1") FindEmployer(employers, username).UpdatePlaceInfo(idForUpdateVacancy, Places.Baku);
                                                    else if (choiceCity == "2") FindEmployer(employers, username).UpdatePlaceInfo(idForUpdateVacancy, Places.Ganja);
                                                    else if (choiceCity == "3") FindEmployer(employers, username).UpdatePlaceInfo(idForUpdateVacancy, Places.Sumgait);
                                                    else if (choiceCity == "4") FindEmployer(employers, username).UpdatePlaceInfo(idForUpdateVacancy, Places.Tovuz);
                                                    else if (choiceCity == "5") FindEmployer(employers, username).UpdatePlaceInfo(idForUpdateVacancy, Places.Lankaran);
                                                    else if (choiceCity == "6") FindEmployer(employers, username).UpdatePlaceInfo(idForUpdateVacancy, Places.Barda);
                                                    else FindEmployer(employers, username).UpdatePlaceInfo(idForUpdateVacancy, Places.Unassigned);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Update_salary:
                                                    Console.WriteLine("Enter new salary: ");
                                                    int updatedSalary = int.Parse(Console.ReadLine());
                                                    FindEmployer(employers, username).UpdateSalaryInfo(idForUpdateVacancy, updatedSalary);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Update_start_time:
                                                    Console.WriteLine("Enter new start time(mm/dd/yyyy): ");
                                                    DateTime updatedStartTime = DateTime.Parse(Console.ReadLine());
                                                    FindEmployer(employers, username).UpdateStartTimeInfo(idForUpdateVacancy, updatedStartTime);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Update_end_time:
                                                    Console.WriteLine("Enter new end time(mm/dd/yyyy): ");
                                                    DateTime updatedEndTime = DateTime.Parse(Console.ReadLine());
                                                    FindEmployer(employers, username).UpdateEndTimeInfo(idForUpdateVacancy, updatedEndTime);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Update_requirements:
                                                    Console.WriteLine("Enter new requirements: ");
                                                    string updatedRequirements = Console.ReadLine();
                                                    FindEmployer(employers, username).UpdateRequirementInfo(idForUpdateVacancy, updatedRequirements);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Update_job_details:
                                                    Console.WriteLine("Enter new job details: ");
                                                    string updatedJobDetails = Console.ReadLine();
                                                    FindEmployer(employers, username).UpdateInformationAboutJob(idForUpdateVacancy, updatedJobDetails);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Update_experience:
                                                    Console.WriteLine("Enter new experience: ");
                                                    int updatedExperience = int.Parse(Console.ReadLine());
                                                    FindEmployer(employers, username).UpdateExperience(idForUpdateVacancy, updatedExperience);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Update_email:
                                                    Console.WriteLine("Enter new email: ");
                                                    string updatedEmail = Console.ReadLine();
                                                    FindEmployer(employers, username).UpdateEmailInfo(idForUpdateVacancy, updatedEmail);
                                                    break;
                                                case (int)UpdateChoicheForVacancy.Exit:
                                                    updateVacancy = false;
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        js.WriteEmployers("Employers.json", employers);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                        Console.ReadLine();
                                    }
                                    break;
                                case (int)ChoicheForEmployers.Show_Worker:
                                    
                                    Console.Clear();
                                    js.ReadWorkers("Workers.json");
                                    try
                                    {
                                        Console.WriteLine("Choose an ID to see CV: ");
                                        int ID = int.Parse(Console.ReadLine());
                                        FindWorkerByID(workers, ID).ShowCV();
                                        Console.WriteLine("Do you want to add this worker to your favorites ? (y/n)");
                                        string choiceForCV = Console.ReadLine();
                                        switch (choiceForCV)
                                        {
                                            case "y":
                                                FindEmployer(employers, username).AddToFavoritesCV(FindWorkerByID(workers, ID), ID);
                                                Console.WriteLine("Worker added to your favorite list");
                                                Console.ReadLine();
                                                break;
                                            case "n":
                                                break;
                                            default:
                                                Console.WriteLine("Wrong Input!");
                                                break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                        Console.ReadLine();
                                    }
                                    break;
                                case (int)ChoicheForEmployers.Show_Favorites:
                                    
                                    Console.Clear();
                                    FindEmployer(employers, username).ShowFavoriteCVs();
                                    Console.ReadLine();
                                    break;
                                case (int)ChoicheForEmployers.Incoming_CV:
                                   
                                    try
                                    {
                                        Console.Clear();
                                        FindEmployer(employers, username).ShowIncomingCVs();
                                        Console.WriteLine("Enter ID of CV: ");
                                        int IdOfCV = int.Parse(Console.ReadLine());
                                        Choiches.PrintAcceptRefuseMenu();
                                        int choiceAR =Convert.ToInt32(Console.ReadLine());
                                        switch (choiceAR)
                                        {
                                            case (int)PrintAcceptRefuse.Accept:
                                                var emp = FindWorkerByID(workers, IdOfCV);
                                                FindEmployer(employers, username).Accept(emp, IdOfCV);
                                                SendNotificationToWorker(emp, "accept");
                                                Console.WriteLine("Your CV Accepted");
                                               
                                                Console.ReadLine();
                                                break;
                                            case (int)PrintAcceptRefuse.Refuse:
                                                emp = FindWorkerByID(workers, IdOfCV);
                                                FindEmployer(employers, username).Refuse(emp, IdOfCV);
                                                SendNotificationToWorker(emp, "refuse");
                                                Console.WriteLine("You CV Refused");

                                                Console.ReadLine();
                                                break;
                                            case (int)PrintAcceptRefuse.Exit:
                                                break;
                                            default:
                                                Console.WriteLine("Wrong Input");
                                                break;
                                        }
                                        js.WriteEmployers("Employers.json", employers);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        js.WriteExceptions(ex);
                                        Console.ReadLine();
                                    }
                                    break;
                               
                                case (int)ChoicheForEmployers.Exit:
                                    employerch = false;
                                    while2 = false;
                                    break;
                                default:
                                    break;
                            }


                        }
                    }
                }

            }
        }
    } 
}
