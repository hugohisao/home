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
            FrmAddLend fAddLend = new FrmAddLend();
            fAddLend.MdiParent = this;
            fAddLend.Show();//頂級窗體 不能顯示到MDI容器中

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //借出列表 不可以同時打開多個頁面
        private void menuQuery_Click(object sender, EventArgs e)
        {
            FrmLendList fAddList = new FrmLendList();
            fAddList.MdiParent = this;
            fAddList.Show();

        }

        private void menuMachine_Click(object sender, EventArgs e)
        {

        }
    }
}
