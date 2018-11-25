using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Pocos
{
    [Table("Book")]
    public class Book : IPoco
    {
        public Guid Id { get; set; }

        public Guid AddedBy { get; set; }

        [Column("Name", TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        [Column("Version", TypeName = "varchar")]
        [MaxLength(5)]
        [Required]
        public string Version { get; set; }

        [Column("Author", TypeName = "varchar")]
        [MaxLength(30)]
        [Required]
        public string Author { get; set; }

        [Column("FirstAddedDate")]
        [Required]
        public DateTime FirstAddedDate { get; set; }

        [Column("yearPublished", TypeName = "int")]
        public int yearPublished { get; set; }

        public virtual User Owner { get; set; }
    }
}
