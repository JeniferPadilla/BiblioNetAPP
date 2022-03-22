using BiblioNetAPP.Validation;
using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public int Pages { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public int CategoryId { get; set; }
    }
}
