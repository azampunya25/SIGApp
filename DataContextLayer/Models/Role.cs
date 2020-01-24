using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataContextLayer.Models
{
    [Table("Role", Schema = "dbo")]
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Role Id")]
        public int RoleID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
