using System;
using System.ComponentModel.DataAnnotations;

namespace NoSkillTeam_PrivacyPassport.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        public string Surname { get; set; }
        public string FirstName { get; set; }

        public DateTime Birthday { get; set; }
        public Int64 InscriptionNumber { get; set; }
    }
}
