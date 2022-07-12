using BDQN.IDAL;
using BDQN.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Linq;
namespace BDQN.DAL
{
    public class BaseDal<T> : IBaseDal<T> where T : BaseEntity, new()
    {
        //1.添加泛型,导入IDAL当中的基类IBaseDal
        //2.实现接口
        //3.创建我们在Model层写的数据库上下文那个类的对象
        private SmartCampusContext _db = MyDalContext.GetSmContext();
        //DAL层也是需要有EntityFramework框架支持的

        public int Add(T model, bool isSaved = true)
        {
            _db.Entry(model).State = EntityState.Added;
            if (isSaved)
                return SaveData();
            return 0; //当我们把isSaved的值传false,代表我们的数据暂时存储到缓冲区中
            //并不会更新到数据库当中
        }

        public int Delete(T model, bool isSaved = true)
        {
            _db.Entry(model).State = EntityState.Deleted;
            if (isSaved)
                return SaveData();
            return 0; //当我们把isSaved的值传false,代表我们的数据暂时存储到缓冲区中
            //并不会更新到数据库当中
        }

        public int Edit(T model, bool isSaved = true)
        {
            _db.Entry(model).State = EntityState.Modified;
            if (isSaved)
                return SaveData();
            return 0; //当我们把isSaved的值传false,代表我们的数据暂时存储到缓冲区中
            //并不会更新到数据库当中
        }

        public List<T> Query()
        {
            return _db.Set<T>().OrderByDescending(t => t.CreateTime).ToList();
        }

        public List<T> Query(Expression<Func<T, bool>> whereLambda)
        {
            return _db.Set<T>()
                .Where(whereLambda)
                .OrderByDescending(t => t.CreateTime).ToList();
        }

        public T Query(int id)
        {
            return _db.Set<T>().Find(id); //我们按照传递进来的id进行查找,找到了返回这个对象
            //没找到返回null
        }

        public int SaveData()
        {
            return _db.SaveChanges();
        }
    }
}
