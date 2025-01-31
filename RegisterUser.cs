// Rename your MySite namespace


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MySite.Models
{
    public class RegisterUser
    {
        [RemoteClientServer("CheckEmailIsValid", "User", ErrorMessage = "Username is already in use")]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "The email is invalid.")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$", ErrorMessage = "The email is invalid.")]
        public string Email { get; set; }

    }
}
