using System;
using System.Collections.Generic;
using BDQN.IBLL;
using BDQN.Models;
using BDQN.DAL;
using BDQN.IDAL;
using System.Linq;
using BDQN.Factory;
namespace BDQN.BLL
{
    public class RolesBll : IRolesBll
    {
        //根据工厂函数来创建对象
        private IRolesDal dal = StaticDalFactory.GetRoleDal();


        public int Add(Roles model, bool isSaved = true)
        {
            return dal.Add(model,isSaved);
        }

        public int Delete(Roles model, bool isSaved = true)
        {
            return dal.Delete(model, isSaved);
        }

        public int Edit(Roles model, bool isSaved = true)
        {
            return dal.Edit(model, isSaved);
        }

        public List<Roles> GetAll()
        {
            return dal.Query();
        }

        public Roles GetDataById(int id)
        {
            return dal.Query(id);
        }

        public List<Roles> GetDataByTitle(string title)
        {
            return dal.Query(r => r.Title.Contains(title));
        }

        public bool IsExist(string title)
        {
            return !dal.Query(r => r.Title.Equals(title)).Any();
        }
    }
}
