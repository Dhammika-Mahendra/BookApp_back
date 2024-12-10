using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public required string Title { get; set; }

        [MaxLength(100)]
        public required string Author { get; set; }

        [Required]
        public DateTime Date_published { get; set; }
    }
}
