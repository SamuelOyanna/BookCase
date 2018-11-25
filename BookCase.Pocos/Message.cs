using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Pocos
{
    [Table("Message")]
    class Message : IPoco
    {
        public Guid Id { get; set; }

        public Guid Sender { get; set; }

        public Guid Recipient { get; set; }

        [Column("MessageSubject", TypeName = "varchar")]
        [MaxLength(20)]
        public string MessageSubject { get; set; }

        [Column("MessageBody", TypeName = "varchar")]
        [MaxLength(1000)]
        [Required]
        public string MessageBody { get; set; }

        [Column("DateSent")]
        [Required]
        public DateTime DateSent { get; set; }

        [Column("isReply", TypeName = "bit")]
        [Required]
        public bool isReply { get; set; }

        public virtual ICollection<MessageReply> Replies { get; set; }
        
    }
}
