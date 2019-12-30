using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataContextLayer.Models
{
    [Table("User", Schema = "dbo")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "User Id")]
        public int UserID { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }
    }
}
