using System.ComponentModel.DataAnnotations;

namespace BazorApi.Model.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please provide user name")]
        public string username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide password")]
        public string password { get; set; }
    }
}
