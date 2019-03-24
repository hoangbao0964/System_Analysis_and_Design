namespace Tournament
{
    partial class DangKy
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
            this.Confirm = new System.Windows.Forms.Button();
            this.SoDoi = new System.Windows.Forms.ComboBox();
            this.txtTenGiai = new System.Windows.Forms.TextBox();
            this.txtMaGiai = new System.Windows.Forms.TextBox();
            this.lbTenGiai = new System.Windows.Forms.Label();
            this.lbSoDoi = new System.Windows.Forms.Label();
            this.lbMaGiai = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(156, 146);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(101, 23);
            this.Confirm.TabIndex = 13;
            this.Confirm.Text = "Xác Nhận";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // SoDoi
            // 
            this.SoDoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoDoi.FormattingEnabled = true;
            this.SoDoi.Items.AddRange(new object[] {
            "4 Teams",
            "8 Teams",
            "16 Teams"});
            this.SoDoi.Location = new System.Drawing.Point(119, 69);
            this.SoDoi.Name = "SoDoi";
            this.SoDoi.Size = new System.Drawing.Size(246, 21);
            this.SoDoi.TabIndex = 12;
            // 
            // txtTenGiai
            // 
            this.txtTenGiai.Location = new System.Drawing.Point(119, 96);
            this.txtTenGiai.Name = "txtTenGiai";
            this.txtTenGiai.Size = new System.Drawing.Size(246, 20);
            this.txtTenGiai.TabIndex = 10;
            // 
            // txtMaGiai
            // 
            this.txtMaGiai.Location = new System.Drawing.Point(119, 43);
            this.txtMaGiai.Name = "txtMaGiai";
            this.txtMaGiai.Size = new System.Drawing.Size(246, 20);
            this.txtMaGiai.TabIndex = 11;
            // 
            // lbTenGiai
            // 
            this.lbTenGiai.AutoSize = true;
            this.lbTenGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenGiai.ForeColor = System.Drawing.Color.White;
            this.lbTenGiai.Location = new System.Drawing.Point(20, 97);
            this.lbTenGiai.Name = "lbTenGiai";
            this.lbTenGiai.Size = new System.Drawing.Size(96, 17);
            this.lbTenGiai.TabIndex = 7;
            this.lbTenGiai.Text = "Tên Giải Đấu:";
            // 
            // lbSoDoi
            // 
            this.lbSoDoi.AutoSize = true;
            this.lbSoDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoDoi.ForeColor = System.Drawing.Color.White;
            this.lbSoDoi.Location = new System.Drawing.Point(20, 69);
            this.lbSoDoi.Name = "lbSoDoi";
            this.lbSoDoi.Size = new System.Drawing.Size(54, 17);
            this.lbSoDoi.TabIndex = 8;
            this.lbSoDoi.Text = "Số Đội:";
            // 
            // lbMaGiai
            // 
            this.lbMaGiai.AutoSize = true;
            this.lbMaGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaGiai.ForeColor = System.Drawing.Color.White;
            this.lbMaGiai.Location = new System.Drawing.Point(20, 44);
            this.lbMaGiai.Name = "lbMaGiai";
            this.lbMaGiai.Size = new System.Drawing.Size(60, 17);
            this.lbMaGiai.TabIndex = 9;
            this.lbMaGiai.Text = "Mã Giải:";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.SoDoi);
            this.Controls.Add(this.txtTenGiai);
            this.Controls.Add(this.txtMaGiai);
            this.Controls.Add(this.lbTenGiai);
            this.Controls.Add(this.lbSoDoi);
            this.Controls.Add(this.lbMaGiai);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.ComboBox SoDoi;
        private System.Windows.Forms.TextBox txtTenGiai;
        private System.Windows.Forms.TextBox txtMaGiai;
        private System.Windows.Forms.Label lbTenGiai;
        private System.Windows.Forms.Label lbSoDoi;
        private System.Windows.Forms.Label lbMaGiai;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}