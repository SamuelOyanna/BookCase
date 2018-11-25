using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Pocos
{
    [Table("Group")]
    class Group : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Column("Name",TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        [Column("Description", TypeName = "varchar")]
        [MaxLength(500)]
        public string Description { get; set; }
        public Guid Genre { get; set; }
        public Guid CreatedByUser { get; set; }
        [Column("MaxNumberOfMembers", TypeName = "int")]
        public int MaxNumberOfMembers { get; set; }
        [Column("DateCreated")]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<User> Members { get; set; }
        public virtual ICollection<User> Moderators { get; set; }




    }
}
