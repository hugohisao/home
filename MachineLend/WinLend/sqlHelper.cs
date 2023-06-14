using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

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

        //返回 DataTable
        public static DataTable GetDataTable(string sql, params SqlParameter[] paras)
        {
            DataTable dt = new DataTable();
            //DataSet dt = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {              
                //創建Command對象
                SqlCommand cmd = new SqlCommand(sql, conn);
                // cmd.CommandType = CommandType.StoredProcedure;//存儲過程
                if (paras != null)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(paras);
                }

                //方法一:參數調用SQL 數據庫;
                //打開鏈接
                //conn.Open(); //最晚打開 最早關閉
                //斷開式鏈接 需要鏈接數據庫
                //執行命令 Command來執行 
                SqlDataAdapter da = new SqlDataAdapter();//橋接器實例化
                da.SelectCommand = cmd; //打開conn

                // SqlDataAdapter da = new SqlDataAdapter(sql, conn);//方法二:無參數調用SQL 數據庫;

                //數據填充
                da.Fill(dt);//關閉 conn
                //da.Fill(dt, "WALSINMES.dbo.UserInfo");

                //執行命令
               // o = cmd.ExecuteScalar();//執行查詢，返回結果第一行第一列的值，忽略其他行
                                        //或者列
                //關閉鏈接
                // conn.Close();
            }

            return dt;

        }
        

        
    }
}
