using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BDQN.Models;
namespace BDQN.DAL
{
    //这个类我们用于获取数据上下文对象
    public class MyDalContext
    {
        //单例模式
        public static SmartCampusContext GetSmContext() 
        {
            //CallContext 这个对象用于我们进行查找或者设定保存上下文信息
            //我们现在这个地方通过GetData("Key")我们在上下文当中查找key这个内容
            var context = CallContext.GetData("MyContext");
            if (context == null) //当我们查找这个上下文不存在的时候
            {
                context = new SmartCampusContext(); //我们在这创建上下文
                CallContext.SetData("MyContext", context); 
                //在这我们把当前创建出来的上下文进行报错到CallContext对象当中
                //对应的这个上下文数据存储到对应这个key的位置上
                //SetData(key,value)
                //我们用于获取的方法GetData得到最后的结果数据类型是object
            }
            return (SmartCampusContext)context; //DataBase First
            //数据库名字Entities
        }
    }
}
