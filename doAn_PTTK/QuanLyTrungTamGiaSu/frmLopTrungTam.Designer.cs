namespace QuanLyTrungTamGiaSu
{
    partial class frmLopTrungTam
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grvGiaSuLop = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grvHVLop = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grvMHLop = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvLop = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGiaSuLop)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvHVLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMHLop)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grvGiaSuLop);
            this.groupBox4.Location = new System.Drawing.Point(397, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 197);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Gia Sư";
            // 
            // grvGiaSuLop
            // 
            this.grvGiaSuLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGiaSuLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvGiaSuLop.Location = new System.Drawing.Point(3, 18);
            this.grvGiaSuLop.Name = "grvGiaSuLop";
            this.grvGiaSuLop.RowTemplate.Height = 24;
            this.grvGiaSuLop.Size = new System.Drawing.Size(665, 176);
            this.grvGiaSuLop.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grvHVLop);
            this.groupBox3.Location = new System.Drawing.Point(397, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 192);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Học Viên";
            // 
            // grvHVLop
            // 
            this.grvHVLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHVLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvHVLop.Location = new System.Drawing.Point(3, 18);
            this.grvHVLop.Name = "grvHVLop";
            this.grvHVLop.RowTemplate.Height = 24;
            this.grvHVLop.Size = new System.Drawing.Size(665, 171);
            this.grvHVLop.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grvMHLop);
            this.groupBox2.Location = new System.Drawing.Point(105, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Môn Học";
            // 
            // grvMHLop
            // 
            this.grvMHLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMHLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvMHLop.Location = new System.Drawing.Point(3, 18);
            this.grvMHLop.Name = "grvMHLop";
            this.grvMHLop.RowTemplate.Height = 24;
            this.grvMHLop.Size = new System.Drawing.Size(280, 248);
            this.grvMHLop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvLop);
            this.groupBox1.Location = new System.Drawing.Point(105, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 290);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp Ở Trung Tâm";
            // 
            // gvLop
            // 
            this.gvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvLop.Location = new System.Drawing.Point(3, 18);
            this.gvLop.Name = "gvLop";
            this.gvLop.RowTemplate.Height = 24;
            this.gvLop.Size = new System.Drawing.Size(280, 269);
            this.gvLop.TabIndex = 0;
            // 
            // frmLopTrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 773);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLopTrungTam";
            this.Text = "frmLopTrungTam";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvGiaSuLop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvHVLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvMHLop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grvGiaSuLop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grvHVLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grvMHLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvLop;
    }
}