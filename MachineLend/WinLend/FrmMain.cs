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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //新增借出信息
        private void menuLend_Click(object sender, EventArgs e)
        {
            FrmAddLend frmAddLend = new FrmAddLend();
            frmAddLend.MdiParent = this;//頂級窗體 顯示到MDI容器中，新增多個窗體;
            frmAddLend.Show();

        }

        //退出系統
        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//執行程序關閉，自動觸發FormClosing事件;
            //this.Close();
        }

        //查詢借出列表， 列表不可以同時打開多個頁面
        private void menuQuery_Click(object sender, EventArgs e)
        {
            //bool bl = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Name == "FrmLendList")
            //    {
            //        bl = true;
            //        break;
            //    }
            //}
            //bool bl = CheckForm(typeof(FrmLendList).Name); 
            bool bl = CheckForm("FrmLendList");// 設置查詢頁面只允許開啟1個,第二種方法；

            if (bl!=true)
            {
                FrmLendList frmAddList = new FrmLendList();
                //FrmLendList frmAddList = FrmLendList.CreateInstance();
                frmAddList.MdiParent = this;
                frmAddList.Show();               

            }

            ////FrmLendList fAddList = new FrmLendList();
            //FrmLendList frmAddList = FrmLendList.CreateInstance();// 設置查詢頁面只允許開啟1個,第一種方法；
            //frmAddList.MdiParent = this;
            //frmAddList.Show();

        }

        //檢查窗體是否打開
        private bool CheckForm(string formName)
        {
            bool bl = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formName)
                {
                    bl = true;
                    f.Activate();//獲取當前窗口頁面的焦點；
                    break;
                }
            }

            return bl;

        }

        private void menuMachine_Click(object sender, EventArgs e)
        {

        }

        //新增資產、耗材請購
        private void menuZcqg_Click(object sender, EventArgs e)
        {
            FrmAddQg frmAddQg = new FrmAddQg();
            frmAddQg.MdiParent = this;//頂級窗體，顯示到MDI容器中，新增多個窗體;
            frmAddQg.Show();

        }

        //查詢請購列表
        private void menuQglb_Click(object sender, EventArgs e)
        {
            bool bl = CheckForm("FrmQgList");// 設置查詢頁面只允許開啟1個,第二種方法；

            if (bl != true)
            {
                FrmQgList frmQgList = new FrmQgList();
                frmQgList.MdiParent = this;
                frmQgList.Show();

            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要退出系統嗎？", "退出系統提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//退出系統提示框
            if (result == DialogResult.Yes)
            {
                //Application.Exit();//退出應用系統
                Application.ExitThread(); //退出當前線程上的消息循環
            }
            else
            {
                e.Cancel = true;

            }
        }

        private void menuSystem_Click(object sender, EventArgs e)
        {
            bool bl = CheckForm("FrmSystem");// 設置查詢頁面只允許開啟1個,第二種方法；

            if (bl != true)
            {
                FrmSystem frmSystem = new FrmSystem();
                frmSystem.MdiParent = this;
                frmSystem.Show();

            }
        }

        private void menuPurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
