using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCase.Pocos
{
    [Table("UserSecurity")]
    public class UserSecurity : IPoco
    {
         public Guid Id { get; set; }
        public Guid User { get; set; }

        [Column("Salt", TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string Salt { get; set; }

        [Column("Password", TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Password { get; set; }

        [Column("Username", TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Username { get; set; }

        public virtual User Owner { get; set; }
    }
}