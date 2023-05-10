//----------------------------------------------------------------------
//2023.05.08 hugohisao P8計算羅輯編寫;
//2023.05.09 hugohisao P9計算羅輯編寫;
//2023.05.10 hugohisao P10 小數點及混合運算;

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
        //1.需要进行按比例缩放
        //2.记录一下原始比例
        //  窗口加载的时候完成
        //3.根据原始比例进行新尺寸定位计算
        //4.将新的定位尺寸设置给控件
        private string _number1;

        public string number1
        {
            get { return _number1; }
            set { _number1 = value;
                this.label1.Text = value;
            }
        }

        private string _number2;

        public string number2
        {
            get { return _number2; }
            set { _number2 = value;
                this.label1.Text = number1 + Operator + value;
            }
        }

        private string _operator;

        public string Operator
        {
            get { return _operator; }
            set { _operator = value;
                this.label1.Text = number1 + value;
            }
        }



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




        //觸發這個(事件)方法的對象
        //e鼠標動作參數
        private void button1_Click(object sender, EventArgs e)
        {   
            //獲取到觸發這個事件的對象
            //拿到對象後獲取對象的Text屬性值
            Button bt = sender as Button;
            string number = bt.Text;
           // this.label1.Text = bt.Text;


            //当运算符为空的时候，一直往一个算数中添加数字
            if (string.IsNullOrEmpty(Operator))
                this.number1 += bt.Text;
            else 
                this.number2 += bt.Text;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string op = bt.Text;
            this.Operator = op;

            if (!string.IsNullOrEmpty(number2)) {
                //执行计算
                //计算结果给Num1
                button15_Click(null, null);
                }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(this.number1);
            double n2 = double.Parse(this.number2);

            switch (Operator) {
                case "+":
                    this.label1.Text = (n1 + n2).ToString();
                    break;
                case "-":
                    this.label1.Text = (n1 - n2).ToString();
                    break;
                case "×":
                    this.label1.Text = (n1 * n2).ToString();
                    break;
                case "÷":
                    this.label1.Text = (n1 / n2).ToString();
                    break;
            }


        }
    }
}
