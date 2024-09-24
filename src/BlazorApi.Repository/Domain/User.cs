using System.ComponentModel.DataAnnotations;

namespace BlazorApi.Repository.Domain
{
    public class User
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
    public class Id
    {
        public int Timestamp { get; set; }
        public int Machine { get; set; }
        public int Pid { get; set; }
        public int Increment { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
