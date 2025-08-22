using System.ComponentModel.DataAnnotations;

namespace SnusRanking.Models
{
    public class Snus
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Flavor { get; set; }
    }
}
