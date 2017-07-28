using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoSkillTeam_PrivacyPassport.Models
{
    public class AccessLog
    {
        [Key]
        public int AccessLogID { get; set; }

        [ForeignKey("AccessReasonID")]
        public AccessReason AccessReason { get; set; }
        public int AccessReasonID { get; set; }

        [ForeignKey("VehiculeID")]
        public Vehicule Vehicule { get; set; }
        public int VehiculeID { get; set; }

        [ForeignKey("AccessorID")]
        public ApplicationUser Accessor { get; set; }
        public Guid AccessorID { get; set; }
    }
}
