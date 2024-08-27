using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public required string Title { get; set; }
        public int? Year { get; set; }// nullable laukas DB

        [Column(TypeName = "decimal(18, 2)")] //nurodomas stulpelio tipas ir ilgis (du skaiciai po kablelio)
        public decimal? Price { get; set; }

        //navigacijos property
        public ICollection<Autor> Autors { get; set; }
    }
}

