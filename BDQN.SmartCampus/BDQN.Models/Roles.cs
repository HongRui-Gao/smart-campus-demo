using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BDQN.Models
{
    public class Roles : BaseEntity
    {   
        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "身份名称")]
        public string Title { get; set; }  //如果我们在code first当中写成 string?
        //这种写法代表当前的属性可以为null
    }
}
