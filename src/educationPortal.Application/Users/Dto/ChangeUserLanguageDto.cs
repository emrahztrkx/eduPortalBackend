using System.ComponentModel.DataAnnotations;

namespace educationPortal.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}