using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using BDQN.IDAL;
using System.Configuration;
namespace BDQN.Factory
{
    //这个就是针对于DAL层的工厂类
    public static class StaticDalFactory
    {
        #region 基本使用
        //1. 我们需要先去根据程序集找到对应的内容  ---》 我们需要使用反射来进行操作
        //a. 添加引用 using System.Reflection
        //b. 通过Assembly.Load(程序集路径/程序集名称)我们进行加载要找到的程序集,把这个程序集的内容
        //存储到程序集变量当中
        //static Assembly assembly = Assembly.Load("BDQN.DAL");
        //在上面代码执行完成之后 assembly这个变量就是我们DAL的替身了

        //c. 我们写一个静态方法，用于返回我们RolesDal对象
        //public static IRolesDal GetRolesDal() 
        //{
        //    return assembly.CreateInstance("BDQN.DAL.RolesDal") as IRolesDal;
        //}
        #endregion

        //1. 找到对应的程序集名称
        static string assemblyName =
            ConfigurationManager.AppSettings["AssemblyDalName"];

        //2. 我们创建对应的静态方法返回想要的对象
        public static IRolesDal GetRoleDal() 
        {
            return Assembly.Load(assemblyName)
                    .CreateInstance(assemblyName+".RolesDal")
                    as IRolesDal;
        }

        public static IUsersDal GetUsersDal() 
        {
            return Assembly.Load(assemblyName)
                    .CreateInstance(assemblyName + ".UsersDal")
                    as IUsersDal;   
        }
    }
}
