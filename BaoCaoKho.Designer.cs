namespace WindowsFormsApp1
{
    partial class BaoCaoKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoKho));
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.nmMonth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIN = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblBaoCao = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.lblChia = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBCKho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCKho)).BeginInit();
            this.SuspendLayout();
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.Location = new System.Drawing.Point(171, 107);
            this.nmYear.Margin = new System.Windows.Forms.Padding(4);
            this.nmYear.Maximum = new decimal(new int[] {
            9998,
            0,
            0,
            0});
            this.nmYear.Minimum = new decimal(new int[] {
            1777,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(160, 58);
            this.nmYear.TabIndex = 4;
            this.nmYear.Value = new decimal(new int[] {
            1777,
            0,
            0,
            0});
            this.nmYear.ValueChanged += new System.EventHandler(this.check_month_year);
            // 
            // nmMonth
            // 
            this.nmMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMonth.Location = new System.Drawing.Point(171, 31);
            this.nmMonth.Margin = new System.Windows.Forms.Padding(4);
            this.nmMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMonth.Name = "nmMonth";
            this.nmMonth.Size = new System.Drawing.Size(160, 58);
            this.nmMonth.TabIndex = 3;
            this.nmMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMonth.ValueChanged += new System.EventHandler(this.check_month_year);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // btnIN
            // 
            this.btnIN.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.Image")));
            this.btnIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIN.Location = new System.Drawing.Point(401, 106);
            this.btnIN.Margin = new System.Windows.Forms.Padding(4);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(215, 60);
            this.btnIN.TabIndex = 33;
            this.btnIN.Text = "In";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.Image = ((System.Drawing.Image)(resources.GetObject("btnKiemTra.Image")));
            this.btnKiemTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemTra.Location = new System.Drawing.Point(401, 31);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(4);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(215, 60);
            this.btnKiemTra.TabIndex = 32;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // lblBaoCao
            // 
            this.lblBaoCao.AutoSize = true;
            this.lblBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lblBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCao.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblBaoCao.Location = new System.Drawing.Point(64, 37);
            this.lblBaoCao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaoCao.Name = "lblBaoCao";
            this.lblBaoCao.Size = new System.Drawing.Size(477, 54);
            this.lblBaoCao.TabIndex = 5;
            this.lblBaoCao.Text = "BÁO CÁO TỒN KHO";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelMonth.Location = new System.Drawing.Point(259, 105);
            this.labelMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(50, 54);
            this.labelMonth.TabIndex = 5;
            this.labelMonth.Text = "1";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelYear.Location = new System.Drawing.Point(359, 105);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(131, 54);
            this.labelYear.TabIndex = 34;
            this.labelYear.Text = "2002";
            // 
            // lblChia
            // 
            this.lblChia.AutoSize = true;
            this.lblChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChia.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblChia.Location = new System.Drawing.Point(328, 105);
            this.lblChia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChia.Name = "lblChia";
            this.lblChia.Size = new System.Drawing.Size(37, 54);
            this.lblChia.TabIndex = 35;
            this.lblChia.Text = "/";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblThang.Location = new System.Drawing.Point(95, 105);
            this.lblThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(161, 54);
            this.lblThang.TabIndex = 36;
            this.lblThang.Text = "Tháng";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblThang);
            this.panel2.Controls.Add(this.lblChia);
            this.panel2.Controls.Add(this.labelYear);
            this.panel2.Controls.Add(this.labelMonth);
            this.panel2.Controls.Add(this.lblBaoCao);
            this.panel2.Location = new System.Drawing.Point(789, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 185);
            this.panel2.TabIndex = 38;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(1457, 33);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(180, 166);
            this.pbLogo.TabIndex = 39;
            this.pbLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmYear);
            this.groupBox1.Controls.Add(this.btnKiemTra);
            this.groupBox1.Controls.Add(this.nmMonth);
            this.groupBox1.Controls.Add(this.btnIN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(673, 186);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu";
            // 
            // dgvBCKho
            // 
            this.dgvBCKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBCKho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBCKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCKho.Location = new System.Drawing.Point(29, 226);
            this.dgvBCKho.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBCKho.Name = "dgvBCKho";
            this.dgvBCKho.RowHeadersWidth = 51;
            this.dgvBCKho.Size = new System.Drawing.Size(1627, 512);
            this.dgvBCKho.TabIndex = 41;
            // 
            // BaoCaoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1691, 753);
            this.Controls.Add(this.dgvBCKho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaoCaoKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.BaoCaoKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.NumericUpDown nmMonth;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblBaoCao;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label lblChia;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBCKho;
    }
}