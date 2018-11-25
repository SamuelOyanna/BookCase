using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookCase.Pocos
{
    [Table("Login")]
    public class Login : IPoco
    {
        public Guid Id { get; set; }

        public Guid User { get; set; }

        [Column("LoginDateTime")]
        [Required]
        public DateTime LoginDateTime { get; set; }

        public virtual User UserLoggingIn { get; set; }

        [Column("UserIP", TypeName = "varchar")]
        [MaxLength(20)]
        public string UserIP { get; set; }

       
    }
}
