using System;
using System.ComponentModel.DataAnnotations;

namespace NoSkillTeam_PrivacyPassport.Models
{
    public class Vehicule
    {
        [Key]
        public int VehiculeID { get; set; }

        public string Registration { get; set; }
        public DateTime FirstRegistrationDate { get; set; }
        public string Constructor { get; set; }

        public Int16 CubicCapacity { get; set; }
        public Int16 MaxPower { get; set; }
        public string FuelType { get; set; }
        public Int16 ConstructionYear { get; set; }
    }
}
