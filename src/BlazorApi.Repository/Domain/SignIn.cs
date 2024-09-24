using System.ComponentModel.DataAnnotations;

namespace BlazorApi.Repository.Domain
{
    public class SignIn
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide user name")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide password")]
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
