using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDQN.Models
{
    public class SystemMenus : BaseEntity
    {
        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "系统菜单名称")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "系统菜单链接")]
        public string Link { get; set; }

       
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "系统菜单图标")]
        public string Icon { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "系统菜单名称")]
        public int ParentId { get; set; }

    }
}
