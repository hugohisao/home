using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load1;

            this.SizeChanged += MainForm_SizeChanged;
           

        }

        //窗體的默認寬和高
        int normalWidth = 0;
        int normalHeight = 0;
        //需要記錄的空間的位置以及寬和高（X, Y, Widht, Height）
        Dictionary<string, Rectangle> normalControl = new Dictionary<string, Rectangle>();


        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //根據原始比例進行新尺寸的計算
            
            
        }

        private void MainForm_Load1(object sender, EventArgs e)
        {
            //記錄相關對象以及原始尺寸
            normalWidth = this.normalWidth;
            normalHeight = this.normalHeight;
            foreach (Console  in  this.panel2.Controls) {


            }
       
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
