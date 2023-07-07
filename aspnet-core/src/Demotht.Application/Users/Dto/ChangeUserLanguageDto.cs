using System.ComponentModel.DataAnnotations;

namespace Demotht.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}