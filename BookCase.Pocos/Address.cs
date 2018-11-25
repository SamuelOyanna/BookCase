using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCase.Pocos
{
    [Table("Address")]
    public class Address : IPoco
    {
        public Guid Id { get; set; }

        [Column("AddressLineOne", TypeName = "varchar")]
        [MaxLength(30)]
        [Required]
        public string AddressLineOne { get; set; }

        [Column("AddressLineTwo", TypeName = "varchar")]
        [MaxLength(1000)]
        public string AddressLineTwo { get; set; }

        [Column("ApartmentOrUnitNumber", TypeName = "varchar")]
        [MaxLength(6)]
        public string ApartmentOrUnitNumber { get; set; }

        [Column("PostalCode", TypeName = "varchar")]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [Column("Province", TypeName = "varchar")]
        [MaxLength(20)]
        public string Province { get; set; }

        [Column("Province", TypeName = "varchar")]
        [MaxLength(20)]
        public string Country { get; set; }





    }
}