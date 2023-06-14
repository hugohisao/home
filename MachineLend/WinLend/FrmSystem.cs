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
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();
        }

        private void FrmSystem_Load(object sender, EventArgs e)
        {
            string sql = "SELECT\n" +
                        "ui.SeqNo ,\n" +
                        "ui.UserName ,\n" +
                        "ui.UserPwd\n" +
                        "FROM\n" +
                        "WALSINMES.dbo.UserInfo ui\n";

            //string sql = "SELECT\n" +
            //               "ui.SeqNo '序號',\n" +
            //               "ui.UserName '用戶名',\n" +
            //               "ui.UserPwd '密碼'\n" +
            //               "FROM\n" +
            //               "WALSINMES.dbo.UserInfo ui\n";

            Console.WriteLine(sql);
            DataTable dtGradeList = sqlHelper.GetDataTable(sql);
            dgvPersonList.DataSource = dtGradeList;



        }

        private void dgvPersonList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
