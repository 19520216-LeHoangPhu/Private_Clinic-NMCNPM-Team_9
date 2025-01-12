﻿
namespace GUI
{
    partial class FormInputMedical
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicalList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLeTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbSellMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.bRefeshAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMedicalName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPupMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMedicalNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMedicalUnit = new System.Windows.Forms.ComboBox();
            this.bAddUnit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bFind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bRefreshFind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbNameMedical = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbIdMedical = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bDeleteMedical = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bEditMedical = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalList)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dgvMedicalList);
            this.panel4.Location = new System.Drawing.Point(34, 482);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1863, 409);
            this.panel4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 139;
            this.label1.Text = "Danh sách thuốc điều trị";
            // 
            // dgvMedicalList
            // 
            this.dgvMedicalList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicalList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicalList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicalList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicalList.ColumnHeadersHeight = 29;
            this.dgvMedicalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaThuoc,
            this.TenThuoc,
            this.DonViTinh,
            this.SoLuong,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.TyLeTinh});
            this.dgvMedicalList.Location = new System.Drawing.Point(8, 46);
            this.dgvMedicalList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicalList.Name = "dgvMedicalList";
            this.dgvMedicalList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicalList.RowHeadersWidth = 51;
            this.dgvMedicalList.RowTemplate.Height = 24;
            this.dgvMedicalList.Size = new System.Drawing.Size(1836, 346);
            this.dgvMedicalList.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 64;
            // 
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 104;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 93;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.MinimumWidth = 6;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 122;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.HeaderText = "Đơn giá bán";
            this.DonGiaBan.MinimumWidth = 6;
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.ReadOnly = true;
            // 
            // TyLeTinh
            // 
            this.TyLeTinh.HeaderText = "Tỷ lệ tính";
            this.TyLeTinh.MinimumWidth = 6;
            this.TyLeTinh.Name = "TyLeTinh";
            this.TyLeTinh.ReadOnly = true;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 921);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1924, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 30;
            this.progressBar1.Value = 50;
            // 
            // bReturn
            // 
            this.bReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bReturn.BackColor = System.Drawing.Color.Transparent;
            this.bReturn.BackgroundImage = global::GUI.Properties.Resources.button3;
            this.bReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReturn.FlatAppearance.BorderSize = 0;
            this.bReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bReturn.Location = new System.Drawing.Point(1777, 4);
            this.bReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(137, 79);
            this.bReturn.TabIndex = 29;
            this.bReturn.Text = "QUAY LẠI";
            this.bReturn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(34, 200);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 274);
            this.panel1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bSave);
            this.groupBox1.Controls.Add(this.tbSellMoney);
            this.groupBox1.Controls.Add(this.bRefeshAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbMedicalName);
            this.groupBox1.Controls.Add(this.tbPupMoney);
            this.groupBox1.Controls.Add(this.tbMedicalNum);
            this.groupBox1.Controls.Add(this.tbMedicalUnit);
            this.groupBox1.Controls.Add(this.bAddUnit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thuốc chữa bệnh";
            // 
            // tbRate
            // 
            this.tbRate.AutoSize = true;
            this.tbRate.BorderRadius = 6;
            this.tbRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRate.DefaultText = "";
            this.tbRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRate.DisabledState.Parent = this.tbRate;
            this.tbRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRate.FocusedState.Parent = this.tbRate;
            this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRate.ForeColor = System.Drawing.Color.Black;
            this.tbRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRate.HoverState.Parent = this.tbRate;
            this.tbRate.Location = new System.Drawing.Point(523, 174);
            this.tbRate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbRate.Name = "tbRate";
            this.tbRate.PasswordChar = '\0';
            this.tbRate.PlaceholderText = "";
            this.tbRate.SelectedText = "";
            this.tbRate.ShadowDecoration.Parent = this.tbRate;
            this.tbRate.Size = new System.Drawing.Size(153, 43);
            this.tbRate.TabIndex = 148;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(362, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 26);
            this.label9.TabIndex = 147;
            this.label9.Text = "Tý lệ tính:";
            // 
            // bSave
            // 
            this.bSave.Animated = true;
            this.bSave.BackColor = System.Drawing.Color.Transparent;
            this.bSave.BorderRadius = 6;
            this.bSave.CheckedState.Parent = this.bSave;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.CustomImages.Parent = this.bSave;
            this.bSave.FillColor = System.Drawing.Color.Ivory;
            this.bSave.FillColor2 = System.Drawing.Color.Ivory;
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bSave.HoverState.Parent = this.bSave;
            this.bSave.Location = new System.Drawing.Point(542, 62);
            this.bSave.Name = "bSave";
            this.bSave.ShadowDecoration.Parent = this.bSave;
            this.bSave.Size = new System.Drawing.Size(134, 37);
            this.bSave.TabIndex = 143;
            this.bSave.Text = "Lưu lại";
            // 
            // tbSellMoney
            // 
            this.tbSellMoney.AutoSize = true;
            this.tbSellMoney.BorderRadius = 6;
            this.tbSellMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSellMoney.DefaultText = "";
            this.tbSellMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSellMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSellMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellMoney.DisabledState.Parent = this.tbSellMoney;
            this.tbSellMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellMoney.FocusedState.Parent = this.tbSellMoney;
            this.tbSellMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellMoney.ForeColor = System.Drawing.Color.Black;
            this.tbSellMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellMoney.HoverState.Parent = this.tbSellMoney;
            this.tbSellMoney.Location = new System.Drawing.Point(523, 122);
            this.tbSellMoney.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbSellMoney.Name = "tbSellMoney";
            this.tbSellMoney.PasswordChar = '\0';
            this.tbSellMoney.PlaceholderText = "";
            this.tbSellMoney.SelectedText = "";
            this.tbSellMoney.ShadowDecoration.Parent = this.tbSellMoney;
            this.tbSellMoney.Size = new System.Drawing.Size(153, 43);
            this.tbSellMoney.TabIndex = 146;
            // 
            // bRefeshAdd
            // 
            this.bRefeshAdd.Animated = true;
            this.bRefeshAdd.BackColor = System.Drawing.Color.Transparent;
            this.bRefeshAdd.BorderRadius = 6;
            this.bRefeshAdd.CheckedState.Parent = this.bRefeshAdd;
            this.bRefeshAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRefeshAdd.CustomImages.Parent = this.bRefeshAdd;
            this.bRefeshAdd.FillColor = System.Drawing.Color.Ivory;
            this.bRefeshAdd.FillColor2 = System.Drawing.Color.Ivory;
            this.bRefeshAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefeshAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bRefeshAdd.HoverState.Parent = this.bRefeshAdd;
            this.bRefeshAdd.Location = new System.Drawing.Point(542, 19);
            this.bRefeshAdd.Name = "bRefeshAdd";
            this.bRefeshAdd.ShadowDecoration.Parent = this.bRefeshAdd;
            this.bRefeshAdd.Size = new System.Drawing.Size(134, 37);
            this.bRefeshAdd.TabIndex = 144;
            this.bRefeshAdd.Text = "Thêm mới";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(362, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 26);
            this.label7.TabIndex = 145;
            this.label7.Text = "Đơn giá bán:";
            // 
            // tbMedicalName
            // 
            this.tbMedicalName.AutoSize = true;
            this.tbMedicalName.BorderRadius = 6;
            this.tbMedicalName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMedicalName.DefaultText = "";
            this.tbMedicalName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMedicalName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMedicalName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMedicalName.DisabledState.Parent = this.tbMedicalName;
            this.tbMedicalName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMedicalName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMedicalName.FocusedState.Parent = this.tbMedicalName;
            this.tbMedicalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedicalName.ForeColor = System.Drawing.Color.Black;
            this.tbMedicalName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMedicalName.HoverState.Parent = this.tbMedicalName;
            this.tbMedicalName.Location = new System.Drawing.Point(186, 24);
            this.tbMedicalName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbMedicalName.Name = "tbMedicalName";
            this.tbMedicalName.PasswordChar = '\0';
            this.tbMedicalName.PlaceholderText = "";
            this.tbMedicalName.SelectedText = "";
            this.tbMedicalName.ShadowDecoration.Parent = this.tbMedicalName;
            this.tbMedicalName.Size = new System.Drawing.Size(310, 43);
            this.tbMedicalName.TabIndex = 142;
            // 
            // tbPupMoney
            // 
            this.tbPupMoney.AutoSize = true;
            this.tbPupMoney.BorderRadius = 6;
            this.tbPupMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPupMoney.DefaultText = "";
            this.tbPupMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPupMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPupMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPupMoney.DisabledState.Parent = this.tbPupMoney;
            this.tbPupMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPupMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPupMoney.FocusedState.Parent = this.tbPupMoney;
            this.tbPupMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPupMoney.ForeColor = System.Drawing.Color.Black;
            this.tbPupMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPupMoney.HoverState.Parent = this.tbPupMoney;
            this.tbPupMoney.Location = new System.Drawing.Point(186, 174);
            this.tbPupMoney.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPupMoney.Name = "tbPupMoney";
            this.tbPupMoney.PasswordChar = '\0';
            this.tbPupMoney.PlaceholderText = "";
            this.tbPupMoney.SelectedText = "";
            this.tbPupMoney.ShadowDecoration.Parent = this.tbPupMoney;
            this.tbPupMoney.Size = new System.Drawing.Size(153, 43);
            this.tbPupMoney.TabIndex = 141;
            // 
            // tbMedicalNum
            // 
            this.tbMedicalNum.AutoSize = true;
            this.tbMedicalNum.BorderRadius = 6;
            this.tbMedicalNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMedicalNum.DefaultText = "";
            this.tbMedicalNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMedicalNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMedicalNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMedicalNum.DisabledState.Parent = this.tbMedicalNum;
            this.tbMedicalNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMedicalNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMedicalNum.FocusedState.Parent = this.tbMedicalNum;
            this.tbMedicalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedicalNum.ForeColor = System.Drawing.Color.Black;
            this.tbMedicalNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMedicalNum.HoverState.Parent = this.tbMedicalNum;
            this.tbMedicalNum.Location = new System.Drawing.Point(186, 122);
            this.tbMedicalNum.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbMedicalNum.Name = "tbMedicalNum";
            this.tbMedicalNum.PasswordChar = '\0';
            this.tbMedicalNum.PlaceholderText = "";
            this.tbMedicalNum.SelectedText = "";
            this.tbMedicalNum.ShadowDecoration.Parent = this.tbMedicalNum;
            this.tbMedicalNum.Size = new System.Drawing.Size(153, 43);
            this.tbMedicalNum.TabIndex = 140;
            // 
            // tbMedicalUnit
            // 
            this.tbMedicalUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbMedicalUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbMedicalUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbMedicalUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbMedicalUnit.FormattingEnabled = true;
            this.tbMedicalUnit.Location = new System.Drawing.Point(186, 76);
            this.tbMedicalUnit.Name = "tbMedicalUnit";
            this.tbMedicalUnit.Size = new System.Drawing.Size(153, 37);
            this.tbMedicalUnit.TabIndex = 139;
            // 
            // bAddUnit
            // 
            this.bAddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bAddUnit.BackgroundImage = global::GUI.Properties.Resources.button_add1;
            this.bAddUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddUnit.FlatAppearance.BorderSize = 0;
            this.bAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddUnit.Location = new System.Drawing.Point(345, 75);
            this.bAddUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAddUnit.Name = "bAddUnit";
            this.bAddUnit.Size = new System.Drawing.Size(37, 36);
            this.bAddUnit.TabIndex = 56;
            this.bAddUnit.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên thuốc:";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.Controls.Add(this.bCancel);
            this.guna2GradientPanel1.Controls.Add(this.label14);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1924, 92);
            this.guna2GradientPanel1.TabIndex = 71;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Animated = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderColor = System.Drawing.Color.White;
            this.bCancel.BorderRadius = 6;
            this.bCancel.BorderThickness = 1;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.Transparent;
            this.bCancel.FillColor2 = System.Drawing.Color.Transparent;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(1797, 12);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(115, 36);
            this.bCancel.TabIndex = 115;
            this.bCancel.Text = "THOÁT";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1924, 92);
            this.label14.TabIndex = 113;
            this.label14.Text = "NHẬP THUỐC";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(781, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 274);
            this.panel3.TabIndex = 123;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bFind);
            this.groupBox2.Controls.Add(this.bRefreshFind);
            this.groupBox2.Controls.Add(this.tbNameMedical);
            this.groupBox2.Controls.Add(this.cbIdMedical);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Location = new System.Drawing.Point(13, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 235);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm thuốc";
            // 
            // bFind
            // 
            this.bFind.Animated = true;
            this.bFind.BackColor = System.Drawing.Color.Transparent;
            this.bFind.BorderRadius = 6;
            this.bFind.CheckedState.Parent = this.bFind;
            this.bFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFind.CustomImages.Parent = this.bFind;
            this.bFind.FillColor = System.Drawing.Color.Ivory;
            this.bFind.FillColor2 = System.Drawing.Color.Ivory;
            this.bFind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bFind.HoverState.Parent = this.bFind;
            this.bFind.Location = new System.Drawing.Point(347, 158);
            this.bFind.Name = "bFind";
            this.bFind.ShadowDecoration.Parent = this.bFind;
            this.bFind.Size = new System.Drawing.Size(112, 37);
            this.bFind.TabIndex = 140;
            this.bFind.Text = "Tìm kiếm";
            // 
            // bRefreshFind
            // 
            this.bRefreshFind.Animated = true;
            this.bRefreshFind.BackColor = System.Drawing.Color.Transparent;
            this.bRefreshFind.BorderRadius = 6;
            this.bRefreshFind.CheckedState.Parent = this.bRefreshFind;
            this.bRefreshFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRefreshFind.CustomImages.Parent = this.bRefreshFind;
            this.bRefreshFind.FillColor = System.Drawing.Color.Ivory;
            this.bRefreshFind.FillColor2 = System.Drawing.Color.Ivory;
            this.bRefreshFind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefreshFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bRefreshFind.HoverState.Parent = this.bRefreshFind;
            this.bRefreshFind.Location = new System.Drawing.Point(226, 158);
            this.bRefreshFind.Name = "bRefreshFind";
            this.bRefreshFind.ShadowDecoration.Parent = this.bRefreshFind;
            this.bRefreshFind.Size = new System.Drawing.Size(115, 37);
            this.bRefreshFind.TabIndex = 139;
            this.bRefreshFind.Text = "Làm mới";
            // 
            // tbNameMedical
            // 
            this.tbNameMedical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameMedical.AutoSize = true;
            this.tbNameMedical.BorderRadius = 6;
            this.tbNameMedical.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameMedical.DefaultText = "";
            this.tbNameMedical.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNameMedical.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNameMedical.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameMedical.DisabledState.Parent = this.tbNameMedical;
            this.tbNameMedical.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameMedical.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameMedical.FocusedState.Parent = this.tbNameMedical;
            this.tbNameMedical.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameMedical.ForeColor = System.Drawing.Color.Black;
            this.tbNameMedical.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameMedical.HoverState.Parent = this.tbNameMedical;
            this.tbNameMedical.Location = new System.Drawing.Point(141, 93);
            this.tbNameMedical.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbNameMedical.Name = "tbNameMedical";
            this.tbNameMedical.PasswordChar = '\0';
            this.tbNameMedical.PlaceholderText = "";
            this.tbNameMedical.SelectedText = "";
            this.tbNameMedical.ShadowDecoration.Parent = this.tbNameMedical;
            this.tbNameMedical.Size = new System.Drawing.Size(312, 43);
            this.tbNameMedical.TabIndex = 138;
            // 
            // cbIdMedical
            // 
            this.cbIdMedical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIdMedical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbIdMedical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIdMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIdMedical.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbIdMedical.FormattingEnabled = true;
            this.cbIdMedical.Location = new System.Drawing.Point(141, 47);
            this.cbIdMedical.Name = "cbIdMedical";
            this.cbIdMedical.Size = new System.Drawing.Size(153, 37);
            this.cbIdMedical.TabIndex = 137;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(8, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 26);
            this.label8.TabIndex = 136;
            this.label8.Text = "Mã thuốc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(8, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 135;
            this.label6.Text = "Tên thuốc:";
            // 
            // bDeleteMedical
            // 
            this.bDeleteMedical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteMedical.Animated = true;
            this.bDeleteMedical.BackColor = System.Drawing.Color.Transparent;
            this.bDeleteMedical.BorderRadius = 6;
            this.bDeleteMedical.CheckedState.Parent = this.bDeleteMedical;
            this.bDeleteMedical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteMedical.CustomImages.Parent = this.bDeleteMedical;
            this.bDeleteMedical.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bDeleteMedical.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bDeleteMedical.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteMedical.ForeColor = System.Drawing.Color.Ivory;
            this.bDeleteMedical.HoverState.Parent = this.bDeleteMedical;
            this.bDeleteMedical.Location = new System.Drawing.Point(1787, 432);
            this.bDeleteMedical.Name = "bDeleteMedical";
            this.bDeleteMedical.ShadowDecoration.Parent = this.bDeleteMedical;
            this.bDeleteMedical.Size = new System.Drawing.Size(110, 43);
            this.bDeleteMedical.TabIndex = 126;
            this.bDeleteMedical.Text = "Xóa";
            // 
            // bEditMedical
            // 
            this.bEditMedical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditMedical.Animated = true;
            this.bEditMedical.BackColor = System.Drawing.Color.Transparent;
            this.bEditMedical.BorderRadius = 6;
            this.bEditMedical.CheckedState.Parent = this.bEditMedical;
            this.bEditMedical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditMedical.CustomImages.Parent = this.bEditMedical;
            this.bEditMedical.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bEditMedical.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bEditMedical.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditMedical.ForeColor = System.Drawing.Color.Ivory;
            this.bEditMedical.HoverState.Parent = this.bEditMedical;
            this.bEditMedical.Location = new System.Drawing.Point(1671, 432);
            this.bEditMedical.Name = "bEditMedical";
            this.bEditMedical.ShadowDecoration.Parent = this.bEditMedical;
            this.bEditMedical.Size = new System.Drawing.Size(110, 43);
            this.bEditMedical.TabIndex = 127;
            this.bEditMedical.Text = "Chỉnh sửa";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.panel4;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.tbMedicalUnit;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.cbIdMedical;
            // 
            // FormInputMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 933);
            this.Controls.Add(this.bEditMedical);
            this.Controls.Add(this.bDeleteMedical);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInputMedical";
            this.Text = "Nhập thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvMedicalList;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAddUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tbMedicalUnit;
        private Guna.UI2.WinForms.Guna2TextBox tbMedicalName;
        private Guna.UI2.WinForms.Guna2TextBox tbPupMoney;
        private Guna.UI2.WinForms.Guna2TextBox tbMedicalNum;
        private Guna.UI2.WinForms.Guna2GradientButton bRefeshAdd;
        private Guna.UI2.WinForms.Guna2GradientButton bSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLeTinh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2GradientButton bFind;
        private Guna.UI2.WinForms.Guna2TextBox tbNameMedical;
        private System.Windows.Forms.ComboBox cbIdMedical;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton bDeleteMedical;
        private Guna.UI2.WinForms.Guna2GradientButton bEditMedical;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2TextBox tbRate;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox tbSellMoney;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        public Guna.UI2.WinForms.Guna2GradientButton bRefreshFind;
    }
}