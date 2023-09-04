namespace WindowsFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnPhieuBan = new System.Windows.Forms.Button();
            this.btnPhieuDV = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AdminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbTenCuaHang = new System.Windows.Forms.PictureBox();
            this.btnPhieuMua = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenCuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPhieuBan
            // 
            this.btnPhieuBan.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPhieuBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuBan.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuBan.Image")));
            this.btnPhieuBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuBan.Location = new System.Drawing.Point(75, 241);
            this.btnPhieuBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhieuBan.Name = "btnPhieuBan";
            this.btnPhieuBan.Size = new System.Drawing.Size(480, 84);
            this.btnPhieuBan.TabIndex = 0;
            this.btnPhieuBan.Text = "Phiếu bán";
            this.btnPhieuBan.UseVisualStyleBackColor = false;
            this.btnPhieuBan.Click += new System.EventHandler(this.btnPhieuBan_Click);
            // 
            // btnPhieuDV
            // 
            this.btnPhieuDV.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPhieuDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuDV.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuDV.Image")));
            this.btnPhieuDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuDV.Location = new System.Drawing.Point(75, 332);
            this.btnPhieuDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhieuDV.Name = "btnPhieuDV";
            this.btnPhieuDV.Size = new System.Drawing.Size(480, 84);
            this.btnPhieuDV.TabIndex = 0;
            this.btnPhieuDV.Text = "Phiếu dịch vụ";
            this.btnPhieuDV.UseVisualStyleBackColor = false;
            this.btnPhieuDV.Click += new System.EventHandler(this.btnPhieuDV_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(75, 422);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(480, 84);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "Báo cáo tồn kho";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 33);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdminMenuItem
            // 
            this.AdminMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMenuItem.Name = "AdminMenuItem";
            this.AdminMenuItem.Size = new System.Drawing.Size(81, 29);
            this.AdminMenuItem.Text = "Admin";
            this.AdminMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(624, 150);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(331, 356);
            this.pbLogo.TabIndex = 31;
            this.pbLogo.TabStop = false;
            // 
            // pbTenCuaHang
            // 
            this.pbTenCuaHang.Image = ((System.Drawing.Image)(resources.GetObject("pbTenCuaHang.Image")));
            this.pbTenCuaHang.Location = new System.Drawing.Point(136, 38);
            this.pbTenCuaHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbTenCuaHang.Name = "pbTenCuaHang";
            this.pbTenCuaHang.Size = new System.Drawing.Size(777, 105);
            this.pbTenCuaHang.TabIndex = 32;
            this.pbTenCuaHang.TabStop = false;
            // 
            // btnPhieuMua
            // 
            this.btnPhieuMua.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPhieuMua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMua.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuMua.Image")));
            this.btnPhieuMua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuMua.Location = new System.Drawing.Point(75, 150);
            this.btnPhieuMua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhieuMua.Name = "btnPhieuMua";
            this.btnPhieuMua.Size = new System.Drawing.Size(480, 84);
            this.btnPhieuMua.TabIndex = 33;
            this.btnPhieuMua.Text = "Phiếu mua";
            this.btnPhieuMua.UseVisualStyleBackColor = false;
            this.btnPhieuMua.Click += new System.EventHandler(this.btnPhieuMua_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPhieuMua);
            this.Controls.Add(this.pbTenCuaHang);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnPhieuDV);
            this.Controls.Add(this.btnPhieuBan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenCuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPhieuBan;
        private System.Windows.Forms.Button btnPhieuDV;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AdminMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbTenCuaHang;
        private System.Windows.Forms.Button btnPhieuMua;
    }
}