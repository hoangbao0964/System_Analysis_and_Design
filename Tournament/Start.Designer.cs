namespace Tournament
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaGiai = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtMaGiai = new System.Windows.Forms.TextBox();
            this.DangNhap = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nếu Bạn Chưa Có Giải Đấu Vui Lòng Nhấp Vào";
            // 
            // MaGiai
            // 
            this.MaGiai.AutoSize = true;
            this.MaGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaGiai.ForeColor = System.Drawing.Color.White;
            this.MaGiai.Location = new System.Drawing.Point(96, 81);
            this.MaGiai.Name = "MaGiai";
            this.MaGiai.Size = new System.Drawing.Size(188, 17);
            this.MaGiai.TabIndex = 7;
            this.MaGiai.Text = "Vui Lòng Nhập Mã Giải Đấu:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb1.ForeColor = System.Drawing.Color.White;
            this.lb1.Location = new System.Drawing.Point(73, 32);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(254, 24);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Phần Mềm Quản Lý Giải Đấu";
            // 
            // txtMaGiai
            // 
            this.txtMaGiai.Location = new System.Drawing.Point(47, 101);
            this.txtMaGiai.Name = "txtMaGiai";
            this.txtMaGiai.Size = new System.Drawing.Size(294, 20);
            this.txtMaGiai.TabIndex = 5;
            // 
            // DangNhap
            // 
            this.DangNhap.Location = new System.Drawing.Point(134, 142);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(123, 26);
            this.DangNhap.TabIndex = 10;
            this.DangNhap.Text = "Đăng Nhập";
            this.DangNhap.UseVisualStyleBackColor = true;
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.Location = new System.Drawing.Point(321, 186);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 17);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đây";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(600, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaGiai);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.txtMaGiai);
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.Name = "Start";
            this.Text = "Phần Mềm Quản Lý Giải Đấu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaGiai;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtMaGiai;
        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

