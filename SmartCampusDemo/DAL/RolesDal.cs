using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class RolesDal
    {

        public int Add(Roles role) 
        {
            string sql = "INSERT INTO Roles(Title) VALUES(@Title)";
            return SqlHelper<Roles>.ExecuteNonQuery(sql, role);
        }

        public int Edit(Roles role) 
        {
            string sql = "UPDATE Roles SET Title=@Title WHERE Id = @Id";
            return SqlHelper<Roles>.ExecuteNonQuery(sql, role);
        }

        public int Delete(int id) 
        {
            string sql = "DELETE FROM Roles WHERE Id = @Id";
            return SqlHelper<Roles>.ExecuteNonQuery(sql, new Roles { Id = id });
        }

        public List<Roles> GetAll() 
        {
            string sql = "SELECT Id,Title FROM Roles";
            return SqlHelper<Roles>.Query(sql, null);
        }

        public List<Roles> GetDataByTitle(string title) 
        {
            string sql = "SELECT * FROM Roles WHERE Title LIKE @Title";
            return SqlHelper<Roles>.Query(sql, new Roles { Title = $"%{title}%" });
        }

        public Roles GetDataById(int id) 
        {
            string sql = "SELECT * FROM Roles WHERE Id = @Id";
            var data = SqlHelper<Roles>.Query(sql, new Roles { Id = id });
            return data == null || data.Count <= 0 ? new Roles() : data[0];
        }
        //上面的内容我们需要有一个表就需要写一个，那么太麻烦了，虽然我们现在使用了Dapper节省了一些
        //代码，但是总体来看还是比较麻烦的， ---》 Dapper这种轻量级的ORM框架已经不能满足我们了
        //所以我们后面这个地方需要用稍微完善的ORM --> EF（EntityFramework）这种框架是看不到
        //SQL语句，框架本身把SQL语句封装到框架最底层的代码当中，我们只需要拿过来进行调用即可，不需要
        //书写
        //
    }
}
