//----------------------------------------------------------------------
//2023.05.08 hugohisao P8計算羅輯編寫;

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
            int w = this.panel2.Width;
            int h = this.panel2.Height;
            foreach (Control item in this.panel2.Controls)
            {
                int newX = (int)(w * 1.0 / normalWidth * normalControl[item.Name].X);
                int newY = (int)(h * 1.0 / normalHeight * normalControl[item.Name].Y);
                int newW = (int)(w * 1.0 / normalWidth * normalControl[item.Name].Width);
                int newH = (int)(h * 1.0 / normalHeight * normalControl[item.Name].Height);

                item.Left = newX;
                item.Top = newY;
                item.Width = newW;
                item.Height = newH;
             
            }

        }

        private void MainForm_Load1(object sender, EventArgs e)
        {
            //記錄相關對象以及原始尺寸
            normalWidth = this.panel2.Width;
            normalHeight = this.panel2.Height;

            foreach (Control item  in  this.panel2.Controls) {             

                normalControl.Add(item.Name, new Rectangle(item.Left, item.Top, item.Width, item.Height));
            }
       
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{

        //}

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}


        //觸發這個(事件)方法的對象
        //e鼠標動作參數
        private void button1_Click(object sender, EventArgs e)
        {   
            //獲取到觸發這個事件的對象
            //拿到對象後獲取對象的Text屬性值
            Button bt = sender as Button;
            string number = bt.Text;
            this.label1.Text = bt.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string op = bt.Text;

        }
    }
}
