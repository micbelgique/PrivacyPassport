using System.ComponentModel.DataAnnotations;

namespace NoSkillTeam_PrivacyPassport.Models
{
    public class AccessReason
    {
        [Key]
        public int AccessReasonID { get; set; }

        public string Name { get; set; }
    }
}
