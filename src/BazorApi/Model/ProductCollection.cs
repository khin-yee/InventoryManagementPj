
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BazorApi.Model
{
    public class ProductCollection
    {
        public Id Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
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
