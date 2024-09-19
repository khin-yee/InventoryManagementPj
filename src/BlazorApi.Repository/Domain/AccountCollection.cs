using MongoDB.Bson;
using MongoDB.Driver.Core.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApi.Repository.Domain
{
    public class AccountCollection
    {
        public ObjectId Id { get; set; }
        public string UserName { get; set; }
        public  string Password { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    
    }
}
