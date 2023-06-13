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
    public partial class FrmLendList : Form
    {
        public FrmLendList()
        {
            InitializeComponent();
        }

        //單例 只有一個實例 (重要實操)
        private static FrmLendList frmLendList = null; //定義這個窗體的實例；注:靜態方法裡面的成員應該也需要用靜態的；
        public static FrmLendList CreateInstance() //定義一個主頁面能調用的方法；
        {
            if(frmLendList == null || frmLendList.IsDisposed)
            {
                frmLendList = new FrmLendList();
            }
            
            return frmLendList;
        }

        private void FrmLendList_Load(object sender, EventArgs e)
        {

        }
    }
}
