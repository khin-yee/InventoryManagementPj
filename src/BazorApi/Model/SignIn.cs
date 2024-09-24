using System.ComponentModel.DataAnnotations;

namespace BazorApi.Model
{
    public class SignIn
    {
        public Id Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide user name")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide password")]
        public string Password { get; set; }

        public string Role { get; set; }

        public Boolean? IsActive { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }

}
