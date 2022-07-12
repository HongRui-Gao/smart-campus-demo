using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace BDQN.WebApp.Areas.Manager.Models.Roles
{
    public class RolesEditViewModel
    {
        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "序号")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "身份名称")]
        public string Title { get; set; }

    }
}