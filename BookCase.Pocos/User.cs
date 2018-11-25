using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCase.Pocos
{
    [Table("User")]
    public class User : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        public Guid FavoriteGenre { get; set; }

        [Column("FirstName", TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string LastName { get; set; }

        [Column("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Column("Email", TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Email { get; set; }

        [Column("DateAccountCreated")]
        public DateTime DateAccountCreated { get; set; }

        public virtual ICollection<User> Books { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual UserSecurity SecurityLogin { get; set; }
        public virtual ICollection<Address> Address { get; set; }



    }
}
