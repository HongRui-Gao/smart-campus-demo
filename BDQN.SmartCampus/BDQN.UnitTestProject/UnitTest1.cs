using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BDQN.IDAL;
using BDQN.DAL;
using BDQN.Factory;

namespace BDQN.UnitTestProject
{
    [TestClass] //这个标识，用于告诉开发人员这个是测试类
    public class UnitTest1
    {
        [TestMethod] //提示下面的方法为测试方法
        public void TestMethod1()
        {
            //我们需要在这个里面来调用我们想要测试的方法代码

            //我们主要测试的内容是DAL和BLL

            //我们今天以测试DAL为例，测试我们之前写的权限表的查询方法是否可用
            //IRolesDal dal = new RolesDal();
            //var list = dal.Query(); //我们在这执行了查询方法，下面我们该
            //使用断言语法来验证我们得到的数据是否正确
            //断言的关键字 Assert
           // Assert.IsNotNull(list);
            //我们该如何执行这个单元测试

            //当我们的内容要使用数据库连接的时候，
            //我们只需要把数据库连接内容复制进来即可，
            //但是这个文件要求必须是App.config
            //而不是Web.config

            IRolesDal dal = StaticDalFactory.GetRoleDal();
            var list = dal.Query();
            Assert.IsTrue(list.Count > 0);

        }
    }
}
