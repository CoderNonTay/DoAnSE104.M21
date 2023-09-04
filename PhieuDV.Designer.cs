namespace WindowsFormsApp1
{
    partial class PhieuDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuDV));
            this.lblPhieuDV = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbLoaiDV = new System.Windows.Forms.ComboBox();
            this.txtTongTienConLai = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTongTienTraTruoc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTraTruoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmSL = new System.Windows.Forms.NumericUpDown();
            this.txtChiPhiRieng = new System.Windows.Forms.TextBox();
            this.txtDonGiaDuocTinh = new System.Windows.Forms.TextBox();
            this.txtDonGiaDV = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.dgvPhieuDichVu = new System.Windows.Forms.DataGridView();
            this.LoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhiRieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDuocTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToanTraTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToanTraSau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmSL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDichVu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhieuDV
            // 
            this.lblPhieuDV.AutoSize = true;
            this.lblPhieuDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuDV.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblPhieuDV.Location = new System.Drawing.Point(409, 155);
            this.lblPhieuDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhieuDV.Name = "lblPhieuDV";
            this.lblPhieuDV.Size = new System.Drawing.Size(306, 42);
            this.lblPhieuDV.TabIndex = 31;
            this.lblPhieuDV.Text = "PHIẾU DỊCH VỤ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 481);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 36);
            this.label17.TabIndex = 33;
            this.label17.Text = "Tình trạng:";
            // 
            // cbLoaiDV
            // 
            this.cbLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiDV.FormattingEnabled = true;
            this.cbLoaiDV.Location = new System.Drawing.Point(289, 38);
            this.cbLoaiDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLoaiDV.Name = "cbLoaiDV";
            this.cbLoaiDV.Size = new System.Drawing.Size(256, 38);
            this.cbLoaiDV.TabIndex = 30;
            this.cbLoaiDV.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDV_SelectedIndexChanged);
            // 
            // txtTongTienConLai
            // 
            this.txtTongTienConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienConLai.Location = new System.Drawing.Point(299, 137);
            this.txtTongTienConLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTienConLai.Name = "txtTongTienConLai";
            this.txtTongTienConLai.ReadOnly = true;
            this.txtTongTienConLai.Size = new System.Drawing.Size(256, 37);
            this.txtTongTienConLai.TabIndex = 13;
            this.txtTongTienConLai.TabStop = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(299, 44);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(256, 37);
            this.txtTongTien.TabIndex = 11;
            this.txtTongTien.TabStop = false;
            // 
            // txtTongTienTraTruoc
            // 
            this.txtTongTienTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienTraTruoc.Location = new System.Drawing.Point(299, 91);
            this.txtTongTienTraTruoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTienTraTruoc.Name = "txtTongTienTraTruoc";
            this.txtTongTienTraTruoc.ReadOnly = true;
            this.txtTongTienTraTruoc.Size = new System.Drawing.Size(256, 37);
            this.txtTongTienTraTruoc.TabIndex = 12;
            this.txtTongTienTraTruoc.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 139);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(243, 36);
            this.label16.TabIndex = 29;
            this.label16.Text = "Tổng tiền còn lại:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LemonChiffon;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 94);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(265, 36);
            this.label15.TabIndex = 28;
            this.label15.Text = "Tổng tiền trả trước:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 48);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 36);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tổng tiền:";
            // 
            // dtpNgayGiao
            // 
            this.dtpNgayGiao.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayGiao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgayGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGiao.Location = new System.Drawing.Point(289, 422);
            this.dtpNgayGiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayGiao.Name = "dtpNgayGiao";
            this.dtpNgayGiao.Size = new System.Drawing.Size(256, 41);
            this.dtpNgayGiao.TabIndex = 8;
            this.dtpNgayGiao.TabStop = false;
            this.dtpNgayGiao.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 422);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 36);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ngày giao:";
            // 
            // txtTraTruoc
            // 
            this.txtTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraTruoc.Location = new System.Drawing.Point(289, 366);
            this.txtTraTruoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTraTruoc.Name = "txtTraTruoc";
            this.txtTraTruoc.Size = new System.Drawing.Size(256, 37);
            this.txtTraTruoc.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 366);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 36);
            this.label13.TabIndex = 20;
            this.label13.Text = "Trả trước: ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(289, 308);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(256, 37);
            this.txtThanhTien.TabIndex = 8;
            this.txtThanhTien.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 308);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 36);
            this.label11.TabIndex = 18;
            this.label11.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chi phí riêng:";
            // 
            // nmSL
            // 
            this.nmSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSL.Location = new System.Drawing.Point(289, 249);
            this.nmSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmSL.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmSL.Name = "nmSL";
            this.nmSL.Size = new System.Drawing.Size(140, 37);
            this.nmSL.TabIndex = 8;
            this.nmSL.ValueChanged += new System.EventHandler(this.nmSL_ValueChanged);
            // 
            // txtChiPhiRieng
            // 
            this.txtChiPhiRieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiPhiRieng.Location = new System.Drawing.Point(289, 140);
            this.txtChiPhiRieng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChiPhiRieng.Name = "txtChiPhiRieng";
            this.txtChiPhiRieng.Size = new System.Drawing.Size(256, 37);
            this.txtChiPhiRieng.TabIndex = 8;
            this.txtChiPhiRieng.TextChanged += new System.EventHandler(this.txtChiPhiRieng_TextChanged);
            // 
            // txtDonGiaDuocTinh
            // 
            this.txtDonGiaDuocTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaDuocTinh.Location = new System.Drawing.Point(289, 193);
            this.txtDonGiaDuocTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGiaDuocTinh.Name = "txtDonGiaDuocTinh";
            this.txtDonGiaDuocTinh.ReadOnly = true;
            this.txtDonGiaDuocTinh.Size = new System.Drawing.Size(256, 37);
            this.txtDonGiaDuocTinh.TabIndex = 8;
            this.txtDonGiaDuocTinh.TabStop = false;
            // 
            // txtDonGiaDV
            // 
            this.txtDonGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaDV.Location = new System.Drawing.Point(289, 90);
            this.txtDonGiaDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGiaDV.Name = "txtDonGiaDV";
            this.txtDonGiaDV.ReadOnly = true;
            this.txtDonGiaDV.Size = new System.Drawing.Size(256, 37);
            this.txtDonGiaDV.TabIndex = 8;
            this.txtDonGiaDV.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(312, 543);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(209, 65);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(43, 543);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 65);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 36);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 36);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đơn giá được tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá dịch vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại dịch vụ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(801, 82);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(256, 37);
            this.txtSDT.TabIndex = 7;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(801, 31);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(256, 41);
            this.dtpNgayLap.TabIndex = 7;
            this.dtpNgayLap.TabStop = false;
            this.dtpNgayLap.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.Location = new System.Drawing.Point(216, 82);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(352, 37);
            this.txtKhachHang.TabIndex = 6;
            this.txtKhachHang.TextChanged += new System.EventHandler(this.txtKhachHang_TextChanged);
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieu.Location = new System.Drawing.Point(216, 31);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(352, 37);
            this.txtSoPhieu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Red;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(1431, 855);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(209, 65);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "Làm mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1161, 855);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 65);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoPhieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1095, 133);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTinhTrang);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDonGiaDV);
            this.groupBox2.Controls.Add(this.cbLoaiDV);
            this.groupBox2.Controls.Add(this.nmSL);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtChiPhiRieng);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpNgayGiao);
            this.groupBox2.Controls.Add(this.txtDonGiaDuocTinh);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTraTruoc);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1119, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(567, 618);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dịch vụ";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Chưa giao",
            "Đã giao"});
            this.cbTinhTrang.Location = new System.Drawing.Point(289, 482);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(256, 38);
            this.cbTinhTrang.TabIndex = 35;
            // 
            // dgvPhieuDichVu
            // 
            this.dgvPhieuDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiDV,
            this.DonGiaDV,
            this.ChiPhiRieng,
            this.DonGiaDuocTinh,
            this.SoLuong,
            this.ThanhTien,
            this.ThanhToanTraTruoc,
            this.ThanhToanTraSau,
            this.NgayGiao,
            this.TinhTrang});
            this.dgvPhieuDichVu.Location = new System.Drawing.Point(16, 199);
            this.dgvPhieuDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhieuDichVu.Name = "dgvPhieuDichVu";
            this.dgvPhieuDichVu.RowHeadersWidth = 62;
            this.dgvPhieuDichVu.Size = new System.Drawing.Size(1095, 721);
            this.dgvPhieuDichVu.TabIndex = 34;
            this.dgvPhieuDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDichVu_CellClick);
            this.dgvPhieuDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDichVu_CellContentClick);
            this.dgvPhieuDichVu.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDichVu_CellContentDoubleClick);
            this.dgvPhieuDichVu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDichVu_CellDoubleClick);
            // 
            // LoaiDV
            // 
            this.LoaiDV.HeaderText = "Loại dịch vụ";
            this.LoaiDV.MinimumWidth = 8;
            this.LoaiDV.Name = "LoaiDV";
            this.LoaiDV.Width = 150;
            // 
            // DonGiaDV
            // 
            this.DonGiaDV.HeaderText = "Đơn giá dịch vụ";
            this.DonGiaDV.MinimumWidth = 8;
            this.DonGiaDV.Name = "DonGiaDV";
            this.DonGiaDV.Width = 150;
            // 
            // ChiPhiRieng
            // 
            this.ChiPhiRieng.HeaderText = "Chi phí riêng";
            this.ChiPhiRieng.MinimumWidth = 8;
            this.ChiPhiRieng.Name = "ChiPhiRieng";
            this.ChiPhiRieng.Width = 150;
            // 
            // DonGiaDuocTinh
            // 
            this.DonGiaDuocTinh.HeaderText = "Đơn giá được tính";
            this.DonGiaDuocTinh.MinimumWidth = 8;
            this.DonGiaDuocTinh.Name = "DonGiaDuocTinh";
            this.DonGiaDuocTinh.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // ThanhToanTraTruoc
            // 
            this.ThanhToanTraTruoc.HeaderText = "Thanh toán (Trả trước)";
            this.ThanhToanTraTruoc.MinimumWidth = 8;
            this.ThanhToanTraTruoc.Name = "ThanhToanTraTruoc";
            this.ThanhToanTraTruoc.Width = 150;
            // 
            // ThanhToanTraSau
            // 
            this.ThanhToanTraSau.HeaderText = "Thanh toán (Còn lại)";
            this.ThanhToanTraSau.MinimumWidth = 8;
            this.ThanhToanTraSau.Name = "ThanhToanTraSau";
            this.ThanhToanTraSau.Width = 150;
            // 
            // NgayGiao
            // 
            this.NgayGiao.HeaderText = "Ngày giao";
            this.NgayGiao.MinimumWidth = 8;
            this.NgayGiao.Name = "NgayGiao";
            this.NgayGiao.Width = 150;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtTongTienTraTruoc);
            this.groupBox3.Controls.Add(this.txtTongTienConLai);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1119, 640);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(567, 196);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // PhieuDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1695, 938);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvPhieuDichVu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblPhieuDV);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PhieuDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            ((System.ComponentModel.ISupportInitialize)(this.nmSL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDichVu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieuDV;
        private System.Windows.Forms.NumericUpDown nmSL;
        private System.Windows.Forms.TextBox txtChiPhiRieng;
        private System.Windows.Forms.TextBox txtDonGiaDuocTinh;
        private System.Windows.Forms.TextBox txtDonGiaDV;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayGiao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTraTruoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongTienConLai;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTongTienTraTruoc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbLoaiDV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhieuDichVu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhiRieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDuocTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhToanTraTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhToanTraSau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}