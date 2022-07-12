using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace BDQN.WebApp.Areas.Manager.Models.Roles
{
    public class RolesAddViewModel
    {
        //component 组件
        [Required(ErrorMessage = "{0}不能为空")]
        [Remote("IsExits","RolesManager",ErrorMessage = "{0}已存在")]
        [Display(Name = "身份名称")]
        public string Title { get; set; }
    }
}