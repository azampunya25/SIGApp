using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataContextLayer.Models
{
    [Table("Menu", Schema = "dbo")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "User Id")]
        public int MenuID { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "MenuParentID")]
        public string MenuParentID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "MenuType")]
        public string MenuType { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "MenuName")]
        public string MenuName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "MenuIcon")]
        public string MenuIcon { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "MenuOrder")]
        public int MenuOrder { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "ControllerName")]
        public string ControllerName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "ActionName")]
        public string ActionName { get; set; }

    }
}
