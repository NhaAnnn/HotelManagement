namespace HotelManagement
{
    partial class RoomDetail
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.checkInDate = new System.Windows.Forms.DateTimePicker();
            this.checkOutDate = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCusCCCD = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRent = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescrip = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.CausesValidation = false;
            this.txtName.Location = new System.Drawing.Point(122, 43);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(183, 30);
            this.txtName.TabIndex = 0;
            // 
            // txtCapacity
            // 
            this.txtCapacity.CausesValidation = false;
            this.txtCapacity.Location = new System.Drawing.Point(122, 123);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(183, 30);
            this.txtCapacity.TabIndex = 2;
            // 
            // checkInDate
            // 
            this.checkInDate.CausesValidation = false;
            this.checkInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkInDate.Location = new System.Drawing.Point(124, 48);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(183, 22);
            this.checkInDate.TabIndex = 9;
            // 
            // checkOutDate
            // 
            this.checkOutDate.CausesValidation = false;
            this.checkOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkOutDate.Location = new System.Drawing.Point(124, 85);
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.Size = new System.Drawing.Size(183, 22);
            this.checkOutDate.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.CausesValidation = false;
            this.txtPrice.Location = new System.Drawing.Point(122, 163);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(183, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Loại phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số người:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Location = new System.Drawing.Point(25, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(26, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày nhận:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Location = new System.Drawing.Point(26, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày trả:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.txtDescrip);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtBookingID);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtCapacity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(53, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 409);
            this.panel1.TabIndex = 20;
            // 
            // txtType
            // 
            this.txtType.CausesValidation = false;
            this.txtType.Location = new System.Drawing.Point(122, 83);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(183, 30);
            this.txtType.TabIndex = 1;
            // 
            // txtBookingID
            // 
            this.txtBookingID.CausesValidation = false;
            this.txtBookingID.Location = new System.Drawing.Point(122, 352);
            this.txtBookingID.Multiline = true;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(183, 30);
            this.txtBookingID.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.CausesValidation = false;
            this.label14.Location = new System.Drawing.Point(25, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Mã booking:";
            // 
            // txtStatus
            // 
            this.txtStatus.CausesValidation = false;
            this.txtStatus.Location = new System.Drawing.Point(122, 203);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(183, 30);
            this.txtStatus.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin phòng:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.txtCusCCCD);
            this.panel2.Controls.Add(this.txtCusName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(446, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 170);
            this.panel2.TabIndex = 21;
            // 
            // txtSDT
            // 
            this.txtSDT.CausesValidation = false;
            this.txtSDT.Location = new System.Drawing.Point(104, 107);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(157, 30);
            this.txtSDT.TabIndex = 8;
            // 
            // txtCusCCCD
            // 
            this.txtCusCCCD.CausesValidation = false;
            this.txtCusCCCD.Location = new System.Drawing.Point(104, 72);
            this.txtCusCCCD.Multiline = true;
            this.txtCusCCCD.Name = "txtCusCCCD";
            this.txtCusCCCD.Size = new System.Drawing.Size(157, 30);
            this.txtCusCCCD.TabIndex = 7;
            // 
            // txtCusName
            // 
            this.txtCusName.CausesValidation = false;
            this.txtCusName.Location = new System.Drawing.Point(104, 37);
            this.txtCusName.Multiline = true;
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(157, 30);
            this.txtCusName.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thông tin khách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Location = new System.Drawing.Point(34, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "SDT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.CausesValidation = false;
            this.label11.Location = new System.Drawing.Point(34, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tên:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.CausesValidation = false;
            this.label12.Location = new System.Drawing.Point(34, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "CCCD:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.CausesValidation = false;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.checkInDate);
            this.panel3.Controls.Add(this.checkOutDate);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(446, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 147);
            this.panel3.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.CausesValidation = false;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Thông tin thuê phòng:";
            // 
            // btnRent
            // 
            this.btnRent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRent.AutoRoundedCorners = true;
            this.btnRent.BorderRadius = 19;
            this.btnRent.CausesValidation = false;
            this.btnRent.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRent.FillColor = System.Drawing.Color.LimeGreen;
            this.btnRent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnRent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRent.Location = new System.Drawing.Point(108, 474);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(84, 40);
            this.btnRent.TabIndex = 11;
            this.btnRent.Text = "Thuê";
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 19;
            this.btnSave.CausesValidation = false;
            this.btnSave.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(245, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderRadius = 19;
            this.btnUpdate.CausesValidation = false;
            this.btnUpdate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(382, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 19;
            this.btnDelete.CausesValidation = false;
            this.btnDelete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(519, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 19;
            this.btnCancel.CausesValidation = false;
            this.btnCancel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(656, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.CausesValidation = false;
            this.label15.Location = new System.Drawing.Point(25, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mô tả:";
            // 
            // txtDescrip
            // 
            this.txtDescrip.AllowDrop = true;
            this.txtDescrip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescrip.DefaultText = "";
            this.txtDescrip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescrip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescrip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescrip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescrip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescrip.ForeColor = System.Drawing.Color.Black;
            this.txtDescrip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescrip.Location = new System.Drawing.Point(122, 250);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasswordChar = '\0';
            this.txtDescrip.PlaceholderText = "";
            this.txtDescrip.ReadOnly = true;
            this.txtDescrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescrip.SelectedText = "";
            this.txtDescrip.Size = new System.Drawing.Size(183, 84);
            this.txtDescrip.TabIndex = 19;
            // 
            // RoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 545);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RoomDetail";
            this.Text = "RoomDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.DateTimePicker checkInDate;
        private System.Windows.Forms.DateTimePicker checkOutDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCusCCCD;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button btnRent;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.TextBox txtType;
        private Guna.UI2.WinForms.Guna2TextBox txtDescrip;
        private System.Windows.Forms.Label label15;
    }
}