namespace BanMuBaoHiem
{
    partial class UserControl_Search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_all = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_search = new System.Windows.Forms.ComboBox();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgr_search = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(431, 152);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 3;
            this.btn_all.Text = "Hiển thị tất cả";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbo_search);
            this.panel1.Controls.Add(this.txb_search);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_all);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 195);
            this.panel1.TabIndex = 3;
            // 
            // cbo_search
            // 
            this.cbo_search.FormattingEnabled = true;
            this.cbo_search.Items.AddRange(new object[] {
            "Nhân viên",
            "Sản phẩm",
            "Nhà cung cấp"});
            this.cbo_search.Location = new System.Drawing.Point(342, 26);
            this.cbo_search.Name = "cbo_search";
            this.cbo_search.Size = new System.Drawing.Size(164, 21);
            this.cbo_search.TabIndex = 13;
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(342, 77);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(164, 20);
            this.txb_search.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm kiếm theo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nội dung";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(264, 152);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgr_search
            // 
            this.dgr_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_search.Location = new System.Drawing.Point(3, 204);
            this.dgr_search.Name = "dgr_search";
            this.dgr_search.Size = new System.Drawing.Size(782, 274);
            this.dgr_search.TabIndex = 2;
            // 
            // UserControl_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgr_search);
            this.Name = "UserControl_Search";
            this.Size = new System.Drawing.Size(788, 481);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_search;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgr_search;
    }
}
