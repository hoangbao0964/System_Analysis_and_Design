namespace TOURNAMENT_MANAGER
{
    partial class DangNhap
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.MaGiai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("NamLun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(73, 32);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(251, 23);
            this.Name.TabIndex = 1;
            this.Name.Text = "Phần Mềm Quản Lý Giải Đấu";
            // 
            // MaGiai
            // 
            this.MaGiai.AutoSize = true;
            this.MaGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaGiai.ForeColor = System.Drawing.Color.White;
            this.MaGiai.Location = new System.Drawing.Point(96, 81);
            this.MaGiai.Name = "MaGiai";
            this.MaGiai.Size = new System.Drawing.Size(188, 17);
            this.MaGiai.TabIndex = 2;
            this.MaGiai.Text = "Vui Lòng Nhập Mã Giải Đấu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nếu Bạn Chưa Có Giải Đấu Vui Lòng Nhấp Vào";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDay.ForeColor = System.Drawing.Color.Blue;
            this.lbDay.Location = new System.Drawing.Point(329, 166);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(36, 17);
            this.lbDay.TabIndex = 4;
            this.lbDay.Text = "Đây";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaGiai);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label MaGiai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDay;

    }
}

