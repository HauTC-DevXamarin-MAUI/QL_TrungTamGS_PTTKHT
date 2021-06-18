namespace QuanLyTrungTamGiaSu
{
    partial class frmGioiThieuGS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbLy = new System.Windows.Forms.RadioButton();
            this.rbAnh = new System.Windows.Forms.RadioButton();
            this.rbVan = new System.Windows.Forms.RadioButton();
            this.rbToan = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grvGS_GT = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGS_GT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rbLy);
            this.groupBox2.Controls.Add(this.rbAnh);
            this.groupBox2.Controls.Add(this.rbVan);
            this.groupBox2.Controls.Add(this.rbToan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(638, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Gia Sư Theo Môn";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(276, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbLy
            // 
            this.rbLy.AutoSize = true;
            this.rbLy.ForeColor = System.Drawing.Color.Yellow;
            this.rbLy.Location = new System.Drawing.Point(478, 61);
            this.rbLy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLy.Name = "rbLy";
            this.rbLy.Size = new System.Drawing.Size(38, 17);
            this.rbLy.TabIndex = 3;
            this.rbLy.TabStop = true;
            this.rbLy.Text = "Lý";
            this.rbLy.UseVisualStyleBackColor = true;
            // 
            // rbAnh
            // 
            this.rbAnh.AutoSize = true;
            this.rbAnh.ForeColor = System.Drawing.Color.Yellow;
            this.rbAnh.Location = new System.Drawing.Point(349, 61);
            this.rbAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAnh.Name = "rbAnh";
            this.rbAnh.Size = new System.Drawing.Size(47, 17);
            this.rbAnh.TabIndex = 2;
            this.rbAnh.TabStop = true;
            this.rbAnh.Text = "Anh";
            this.rbAnh.UseVisualStyleBackColor = true;
            // 
            // rbVan
            // 
            this.rbVan.AutoSize = true;
            this.rbVan.ForeColor = System.Drawing.Color.Yellow;
            this.rbVan.Location = new System.Drawing.Point(226, 61);
            this.rbVan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbVan.Name = "rbVan";
            this.rbVan.Size = new System.Drawing.Size(47, 17);
            this.rbVan.TabIndex = 1;
            this.rbVan.TabStop = true;
            this.rbVan.Text = "Văn";
            this.rbVan.UseVisualStyleBackColor = true;
            // 
            // rbToan
            // 
            this.rbToan.AutoSize = true;
            this.rbToan.ForeColor = System.Drawing.Color.Yellow;
            this.rbToan.Location = new System.Drawing.Point(101, 61);
            this.rbToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbToan.Name = "rbToan";
            this.rbToan.Size = new System.Drawing.Size(54, 17);
            this.rbToan.TabIndex = 0;
            this.rbToan.TabStop = true;
            this.rbToan.Text = "Toán";
            this.rbToan.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grvGS_GT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(9, 154);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(638, 207);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Gia Sư";
            // 
            // grvGS_GT
            // 
            this.grvGS_GT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGS_GT.Location = new System.Drawing.Point(4, 17);
            this.grvGS_GT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grvGS_GT.Name = "grvGS_GT";
            this.grvGS_GT.RowTemplate.Height = 24;
            this.grvGS_GT.Size = new System.Drawing.Size(628, 183);
            this.grvGS_GT.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(210, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "In Thông Tin GS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(358, 379);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmGioiThieuGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(654, 419);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGioiThieuGS";
            this.Text = "Giới Thiệu Gia Sư";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvGS_GT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbLy;
        private System.Windows.Forms.RadioButton rbAnh;
        private System.Windows.Forms.RadioButton rbVan;
        private System.Windows.Forms.RadioButton rbToan;
        private System.Windows.Forms.DataGridView grvGS_GT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}