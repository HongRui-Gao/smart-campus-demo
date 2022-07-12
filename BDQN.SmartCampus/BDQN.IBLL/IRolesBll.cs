using System;
using System.Collections.Generic;
using BDQN.Models;

namespace BDQN.IBLL
{
    public interface IRolesBll
    {
        int Add(Roles model, bool isSaved = true);

        int Edit(Roles model, bool isSaved = true);

        int Delete(Roles model, bool isSaved = true);

        List<Roles> GetAll();

        List<Roles> GetDataByTitle(string title);

        //Func是委托,它带有的2个内容T,bool 分别为 T: 我们声明的这个变量是什么类型的
        //a => xxxxx   这个a就是参数,用于我们给后面实现代码传递的
        //bool 代表的是整个这个表达式的返回值是什么类型的

        Roles GetDataById(int id);

        bool IsExist(string title);

    }
}
