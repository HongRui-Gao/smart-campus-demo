using BDQN.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace BDQN.IDAL
{
    public interface IBaseDal<T> where T : BaseEntity,new()
    {

        int Add(T model,bool isSaved = true); 

        int Edit(T model, bool isSaved = true);

        int Delete(T model, bool isSaved = true);

        List<T> Query();

        List<T> Query(Expression<Func<T, bool>> whereLambda);

        //Func是委托,它带有的2个内容T,bool 分别为 T: 我们声明的这个变量是什么类型的
        //a => xxxxx   这个a就是参数,用于我们给后面实现代码传递的
        //bool 代表的是整个这个表达式的返回值是什么类型的

        T Query(int id);

        int SaveData(); //用于保存数据的方法,返回的内容就是受影响行数
    }
}
