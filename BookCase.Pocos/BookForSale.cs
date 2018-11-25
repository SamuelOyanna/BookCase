using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Pocos
{
    [Table("BookForSale")]
    public class BookForSale : IPoco
    {
        public Guid Id { get; set; }

        public Guid Book { get; set; }

        [Column("DatePutForSale")]
        [Required]
        public DateTime DatePutForSale { get; set; }

        [Column("askingPrice", TypeName = "money")]
        [Required]
        public decimal askingPrice { get; set; }

        [Column("isNegotiable", TypeName = "bit")]
        [Required]
        public bool isNegotiable { get; set; }




    }
}
