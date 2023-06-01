//----------------------------------------------------------------------
//2023.05.30 hugohisao P4登錄功能實現;
//2023.06.01 hugohisao P15 代碼優化  



//-------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinLend
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //獲取用戶輸入信息
            string uName = txtUserName.Text.Trim();
            string uPwd = txtUserPwd.Text.Trim();

            //判斷是否為空
            if (string.IsNullOrEmpty(uName))
            {
                MessageBox.Show("請輸入賬號！","登錄提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(uPwd))
            {
                MessageBox.Show("請輸入密碼！", "登錄提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPwd.Focus();
                return;
            }

            //與數據庫通信 檢查輸入與數據庫是否一致
            {
                string sql = "SELECT " +
                "COUNT(1) " +
                "FROM " +
                "WALSINMES.dbo.UserInfo ui " +
                "WHERE " +
                "ui.UserName = @UserName " +
                "and ui.UserPwd = @UserPwd ";

                SqlParameter[] paras =
{
                                    new SqlParameter("@UserName", uName),
                                    new SqlParameter("@UserPwd", uPwd)
                                };


                ////建立與數據庫的鏈接
                ////鏈接字符串---鑰匙
                ////string connString = "server=.;database=WALSINMES;Integrated 
                ////Security =true";//字符串 Windows身份驗證
                //string connString = "server=10.206.52.2;database=WALSINMES;uid=sa;pwd=sa;";//sql Server身份驗證的方法           
                //SqlConnection conn = new SqlConnection(connString);
                ////寫查詢語句 拼接式 Sql注入 推薦大家使用參數化sql
                ////string sql = "select count(1) from WALSINMES.dbo.UserInfo where UserName ='" + uName+"' and " +
                ////    "UserPwd = '" + uPwd+"'";
                ///* string sql = "SELECT " +
                //                 "COUNT(1) " +
                //                 "from " +
                //                 "WALSINMES.dbo.UserInfo ui " +
                //                 "WHERE " +
                //                 "ui.UserName = '"+ uName + "' " +
                //                 "AND " +
                //                 "ui.UserPwd = '"+ uPwd + "' ";*/

                //string sql = "SELECT " +
                //                "COUNT(1) " +
                //                "FROM " +
                //                "WALSINMES.dbo.UserInfo ui " +
                //                "WHERE " +
                //                "ui.UserName = @UserName " +
                //                "and ui.UserPwd = @UserPwd ";
                ////添加參數
                ////SqlParameter ParaUname = new SqlParameter("@UserName", uName);
                ////SqlParameter ParaUPwd = new SqlParameter("@UserPwd", uPwd);
                //SqlParameter[] paras =
                //{
                //     new SqlParameter("@UserName", uName),
                //     new SqlParameter("@UserPwd", uPwd)
                // };



                ////創建Command對象
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //// cmd.CommandType = CommandType.StoredProcedure;//存儲過程
                //cmd.Parameters.Clear();
                ////cmd.Parameters.Add(ParaUname);
                ////cmd.Parameters.Add(ParaUPwd);

                //cmd.Parameters.AddRange(paras);


                // //打開鏈接
                // conn.Open(); //最晚打開 最早關閉
                //               //執行命令
                //object o = cmd.ExecuteScalar();//執行查詢，返回結果第一行第一列的值，忽略其他行
                //                               //或者列
                //                               //關閉鏈接
                //conn.Close();

                //調用
                //sqlHelper helper = new sqlHelper();
                object o = sqlHelper.ExecuteScalar(sql, paras);
                
                //處理結果
                if ((int)o == 0)
                {
                    MessageBox.Show("輸入的賬號和密碼錯誤！", "密碼錯誤提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtUserPwd.Text = "";
                    txtUserName.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("登錄成功！", "登錄提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //轉到主頁面                  

                }

            }

            //返回的結果進行不同的提示

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
              this.Close();//一個窗體並且這個窗體是主頁面窗體退出程序
            // Application.Exit();//不是主頁面退出程序
            //Application.ExitThread();//當出現對話框進行判斷YES/NO或循環對話框，退出程序
            
        }
    }
}
