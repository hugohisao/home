namespace WinLend
{
    partial class FrmSystem
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
            this.dgvPersonList = new System.Windows.Forms.DataGridView();
            this.SeqNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonList
            // 
            this.dgvPersonList.AllowUserToAddRows = false;
            this.dgvPersonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeqNo,
            this.UserName,
            this.UserPwd});
            this.dgvPersonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonList.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonList.Name = "dgvPersonList";
            this.dgvPersonList.RowTemplate.Height = 27;
            this.dgvPersonList.Size = new System.Drawing.Size(551, 458);
            this.dgvPersonList.TabIndex = 0;
            this.dgvPersonList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonList_CellContentClick);
            // 
            // SeqNo
            // 
            this.SeqNo.DataPropertyName = "SeqNo";
            this.SeqNo.HeaderText = "序號";
            this.SeqNo.Name = "SeqNo";
            this.SeqNo.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用戶名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserPwd
            // 
            this.UserPwd.DataPropertyName = "UserPwd";
            this.UserPwd.HeaderText = "密碼";
            this.UserPwd.Name = "UserPwd";
            this.UserPwd.ReadOnly = true;
            // 
            // FrmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 458);
            this.Controls.Add(this.dgvPersonList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSystem";
            this.Text = "系統維護";
            this.Load += new System.EventHandler(this.FrmSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPwd;
    }
}