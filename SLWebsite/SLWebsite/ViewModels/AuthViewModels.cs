using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SLWebsite.ViewModels
{
    public class AuthLogin
    {
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}