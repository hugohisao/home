namespace WinLend
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLend = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJclb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZcqg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQglb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMachine,
            this.menuPurchase,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMachine
            // 
            this.menuMachine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLend,
            this.menuJclb});
            this.menuMachine.Name = "menuMachine";
            this.menuMachine.Size = new System.Drawing.Size(81, 24);
            this.menuMachine.Text = "設備異動";
            this.menuMachine.Click += new System.EventHandler(this.menuMachine_Click);
            // 
            // menuLend
            // 
            this.menuLend.Name = "menuLend";
            this.menuLend.Size = new System.Drawing.Size(216, 26);
            this.menuLend.Text = "新增借出信息";
            this.menuLend.Click += new System.EventHandler(this.menuLend_Click);
            // 
            // menuJclb
            // 
            this.menuJclb.Name = "menuJclb";
            this.menuJclb.Size = new System.Drawing.Size(216, 26);
            this.menuJclb.Text = "查詢借出列表";
            this.menuJclb.Click += new System.EventHandler(this.menuQuery_Click);
            // 
            // menuPurchase
            // 
            this.menuPurchase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuZcqg,
            this.menuQglb});
            this.menuPurchase.Name = "menuPurchase";
            this.menuPurchase.Size = new System.Drawing.Size(81, 24);
            this.menuPurchase.Text = "器材購買";
            // 
            // menuZcqg
            // 
            this.menuZcqg.Name = "menuZcqg";
            this.menuZcqg.Size = new System.Drawing.Size(216, 26);
            this.menuZcqg.Text = "新增資產/耗材請購";
            this.menuZcqg.Click += new System.EventHandler(this.menuZcqg_Click);
            // 
            // menuQglb
            // 
            this.menuQglb.Name = "menuQglb";
            this.menuQglb.Size = new System.Drawing.Size(216, 26);
            this.menuQglb.Text = "查詢請購列表";
            this.menuQglb.Click += new System.EventHandler(this.menuQglb_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(81, 24);
            this.menuExit.Text = "退出系統";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "資訊服務系統";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMachine;
        private System.Windows.Forms.ToolStripMenuItem menuLend;
        private System.Windows.Forms.ToolStripMenuItem menuPurchase;
        private System.Windows.Forms.ToolStripMenuItem menuZcqg;
        private System.Windows.Forms.ToolStripMenuItem menuQglb;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuJclb;
    }
}