using System.ComponentModel.DataAnnotations;

namespace abp_angular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}