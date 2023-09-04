namespace WindowsFormsApp1
{
    partial class MenuDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDV));
            this.lblMenuPhieuDV = new System.Windows.Forms.Label();
            this.btnPhieuDV = new System.Windows.Forms.Button();
            this.btnDSDV = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuPhieuDV
            // 
            this.lblMenuPhieuDV.AutoSize = true;
            this.lblMenuPhieuDV.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblMenuPhieuDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPhieuDV.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblMenuPhieuDV.Location = new System.Drawing.Point(36, 11);
            this.lblMenuPhieuDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuPhieuDV.Name = "lblMenuPhieuDV";
            this.lblMenuPhieuDV.Size = new System.Drawing.Size(383, 54);
            this.lblMenuPhieuDV.TabIndex = 0;
            this.lblMenuPhieuDV.Text = "PHIẾU DỊCH VỤ";
            this.lblMenuPhieuDV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPhieuDV
            // 
            this.btnPhieuDV.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPhieuDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuDV.Location = new System.Drawing.Point(16, 75);
            this.btnPhieuDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhieuDV.Name = "btnPhieuDV";
            this.btnPhieuDV.Size = new System.Drawing.Size(449, 105);
            this.btnPhieuDV.TabIndex = 1;
            this.btnPhieuDV.Text = "Lập phiếu dịch vụ";
            this.btnPhieuDV.UseVisualStyleBackColor = false;
            this.btnPhieuDV.Click += new System.EventHandler(this.btnPhieuDV_Click);
            // 
            // btnDSDV
            // 
            this.btnDSDV.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDSDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSDV.Location = new System.Drawing.Point(16, 190);
            this.btnDSDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDSDV.Name = "btnDSDV";
            this.btnDSDV.Size = new System.Drawing.Size(449, 105);
            this.btnDSDV.TabIndex = 2;
            this.btnDSDV.Text = "Danh sách phiếu dịch vụ";
            this.btnDSDV.UseVisualStyleBackColor = false;
            this.btnDSDV.Click += new System.EventHandler(this.btnDSDV_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(16, 302);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(449, 105);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // MenuDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(481, 423);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDSDV);
            this.Controls.Add(this.btnPhieuDV);
            this.Controls.Add(this.lblMenuPhieuDV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPhieuDV;
        private System.Windows.Forms.Button btnPhieuDV;
        private System.Windows.Forms.Button btnDSDV;
        private System.Windows.Forms.Button btnHuy;
    }
}