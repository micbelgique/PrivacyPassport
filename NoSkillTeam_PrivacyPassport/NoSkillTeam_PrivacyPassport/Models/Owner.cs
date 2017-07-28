using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoSkillTeam_PrivacyPassport.Models
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }

        [ForeignKey("VehiculeID")]
        public Vehicule Vehicule { get; set; }
        public int VehiculeID { get; set; }

        [ForeignKey("PersonID")]
        public Person Person { get; set; }
        public int PersonID { get; set; }

        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
