using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace SocialNetwork1._1.Models
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        
        public HttpPostedFileBase Photo { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords dont match")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}