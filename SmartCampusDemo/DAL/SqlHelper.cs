using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class SqlHelper<T> where T : class,new()
    {
        //得到链接语句
        private static string constr = 
                ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;


        public static int ExecuteNonQuery(string sql, T model) 
        {
            using (IDbConnection db = new SqlConnection(constr)) 
            {
                return db.Execute(sql, model);
            }
        }

        public static List<T> Query(string sql, T model) 
        {
            using (IDbConnection db = new SqlConnection(constr)) 
            {
                if (model == null)
                    return db.Query<T>(sql).ToList();
                else
                    return db.Query<T>(sql, model).ToList();
            }
        }

    }
}
