//----------------------------------------------------------------------
//2023.05.30 hugohisao P4登錄功能實現;


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

               // string i = "1";
            }

            //與數據庫通信 檢查輸入與數據庫是否一致

            //返回的結果進行不同的提示

        }
    }
}
