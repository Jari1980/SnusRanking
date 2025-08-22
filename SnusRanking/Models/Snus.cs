using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace SnusRanking.Models
{
    public class Snus
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Flavor { get; set; }
        public byte[]? Pic { get; set; }
    }
}
