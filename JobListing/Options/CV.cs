using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing.User
{
    class CV
    {
        public static int StaticId{get;set;}=0;
        public int ID { get; set; }
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
        public CV()
        {
            ID=++StaticId;
        }
        public override string ToString()
        {
            return $"\n===================================================================================================" +
                $"Id :{ID}\nScool No : {SchoolNo}\nCompanies : {Companie}\nEducation : {Education}\nLanguage:{Language}\nUniversity score : {UniversityScore}\nExperience : {Experience}\nSkills : {Skills}\nSertificate : {Certificate}\nGithub adress: {GitHub}\nLinkedin adress: {Linkedin}\nStart time : {StartTime}\nEnd time : {EndTime}";
        }
    }
}
