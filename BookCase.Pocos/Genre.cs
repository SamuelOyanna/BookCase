using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Pocos
{

    public class Genre : IPoco
    {
        public Guid Id { get; set; }

        [Column("Name", TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

    }
}
