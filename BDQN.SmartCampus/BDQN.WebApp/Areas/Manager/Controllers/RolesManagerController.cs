using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDQN.IBLL;
using BDQN.BLL;
using BDQN.WebApp.Areas.Manager.Models.Roles;
using BDQN.Models;
namespace BDQN.WebApp.Areas.Manager.Controllers
{
    public class RolesManagerController : Controller
    {
        private IRolesBll bll = new RolesBll();

        //我们在这个地方要求实现全查询和模糊查询
        [HttpGet]
        public ActionResult List(string search="") //在这个地方我们需要传递过来一个
        {                                          //前端视图提交的值,第一回我们加载的时候
            var list = bll.GetDataByTitle(search); //并没有提交这个值,我们就默认给它指定一个
            ViewBag.Search = search;
            return View(list);                     //默认值 ""
        }

        [HttpGet]
        public ActionResult Add() 
        {
            return View(new RolesAddViewModel());
        }

        [HttpPost]
        public ActionResult Add(RolesAddViewModel model) 
        {
            if (ModelState.IsValid) //这个判断是判断我们表单元素存值是否满足了约束
            {
                var res = bll.Add(new Roles
                {
                    Title = model.Title
                });
                if (res > 0)
                    return Content("<script>alert('新增成功');location.href='../../../Manager/RolesManager/List'</script>");
            }
            //不满足约束的
            return View(model);
        }


        [HttpGet]
        public ActionResult IsExits(string Title) 
        {
            var result = bll.IsExist(Title); //查询我们输入的内容是否存在
            return Json(result,JsonRequestBehavior.AllowGet);
            //把结果返回到Remote验证当中,以Json数据格式返回的,第一个参数是存放的结果
            //第二个参数是用于设定我们当前方法是否允许get提交得到结果 AllowGet是允许
        }

        [HttpGet]
        public ActionResult Edit(int id) 
        {
            var data = bll.GetDataById(id);

            return View(new RolesEditViewModel
            {
                Id = data.Id,
                Title = data.Title
            });
        }

        [HttpPost]
        public ActionResult Edit(RolesEditViewModel model) 
        {
            if (ModelState.IsValid) 
            {
                var res = bll.Edit(new Roles
                {
                    Id = model.Id,
                    Title = model.Title
                });
                if (res > 0)
                    return Content("<script>alert('编辑成功');location.href='../../../Manager/RolesManager/List'</script>");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id) 
        {
            var data = bll.GetDataById(id);
            var res = bll.Delete(data);
            return Json(res > 0);
        }



    }
}