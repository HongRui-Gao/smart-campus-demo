using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDQN.IDAL;
using BDQN.DAL;
using BDQN.Models;
namespace BDQN.UnitTestProject.DAL
{
    [TestClass]
    public class UnitTestRolesDal
    {
        [TestMethod]
        public void TestQuery() 
        {
            IRolesDal dal = new RolesDal();
            var res = dal.Add(new Roles
            {
                Title = "学生"
            });

            Assert.IsTrue(res > 0); 

        }

        [TestMethod]
        public  void TestDelete() 
        {
            IRolesDal dal = new RolesDal();
            var data = dal.Query(4);
            var res = dal.Delete(data);
            Assert.IsTrue(res > 0);
        }

    }
}
