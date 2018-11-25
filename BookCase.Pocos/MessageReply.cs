using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Pocos
{
    [Table("MessageReply")]
    public class MessageReply : IPoco
    {
        public Guid Id { get; set; }

        public Guid OriginalMessage { get; set; }

        public Guid MessageMappedTo { get; set; }

        [Column("ReplyBody", TypeName = "varchar")]
        [MaxLength(1000)]
        [Required]
        public string ReplyBody { get; set; }

        [Column("DateSent")]
        [Required]
        public DateTime DateSent { get; set; }
    }
}
