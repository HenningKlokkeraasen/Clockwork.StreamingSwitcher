using System.ComponentModel.DataAnnotations;

namespace Clockwork.StreamingSwitcher.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Tidal username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Tidal Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
