using System.ComponentModel.DataAnnotations;

namespace connectmydql.Model
{
    public class Books
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
