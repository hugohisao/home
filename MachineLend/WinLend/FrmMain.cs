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
            frmAddLend.MdiParent = this;
            frmAddLend.Show();//頂級窗體 不能顯示到MDI容器中

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //借出列表 不可以同時打開多個頁面
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
                    f.Activate();//獲取窗口頁面的焦點；
                    break;
                }
            }

            return bl;

        }



        private void menuMachine_Click(object sender, EventArgs e)
        {

        }
    }
}
