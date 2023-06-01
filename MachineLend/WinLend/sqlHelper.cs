using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WinLend
{
    public  class  sqlHelper
    {
        //private string connString = "server=10.206.52.2;database=WALSINMES;uid=sa;pwd=sa;";//sql Server身份驗證的方法 
        private static  string connString = ConfigurationManager.ConnectionStrings
            ["connStr"].ConnectionString;  
        public static object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            object o = null;
                
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //創建Command對象
                SqlCommand cmd = new SqlCommand(sql, conn);
                // cmd.CommandType = CommandType.StoredProcedure;//存儲過程
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);

                

                //打開鏈接
                conn.Open(); //最晚打開 最早關閉

                Console.WriteLine(sql);//查詢最後執行的SQL語句
                //執行命令
                o = cmd.ExecuteScalar();//執行查詢，返回結果第一行第一列的值，忽略其他行
                                        //或者列

                //關閉鏈接
                // conn.Close();
            }
            return o;
       
        }
    }
}
