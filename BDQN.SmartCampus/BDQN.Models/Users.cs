using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDQN.Models
{
    public class Users : BaseEntity
    {
        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "真实姓名")]
        public string RealName { get; set; }
        [Required(ErrorMessage = "{0}不能为空")]
        [Column(TypeName = "date")]
        [Display(Name = "出生日期")]
        public DateTime BornTime { get; set; }
        public int Gender { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "邮箱地址")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "联系电话")]
        public string Tel { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Photo { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "家庭住址")]
        public string Address { get; set; }


        public int RolesId { get; set; }

    }
}
