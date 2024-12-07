namespace HotelManagement
{
    partial class AddBooking
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkIn = new System.Windows.Forms.DateTimePicker();
            this.checkOut = new System.Windows.Forms.DateTimePicker();
            this.btnAddBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.txtRoomType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày nhận:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tiền cọc:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "SĐT:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Loại phòng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên khách hàng:";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeposit.CausesValidation = false;
            this.txtDeposit.Location = new System.Drawing.Point(203, 209);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(194, 22);
            this.txtDeposit.TabIndex = 15;
            this.txtDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhone.CausesValidation = false;
            this.txtPhone.Location = new System.Drawing.Point(203, 133);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 22);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // txtCusName
            // 
            this.txtCusName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCusName.CausesValidation = false;
            this.txtCusName.Location = new System.Drawing.Point(203, 95);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(194, 22);
            this.txtCusName.TabIndex = 12;
            this.txtCusName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đặt phòng";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ngày trả:";
            // 
            // checkIn
            // 
            this.checkIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkIn.CausesValidation = false;
            this.checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkIn.Location = new System.Drawing.Point(203, 243);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(194, 22);
            this.checkIn.TabIndex = 27;
            this.checkIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // checkOut
            // 
            this.checkOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkOut.CausesValidation = false;
            this.checkOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkOut.Location = new System.Drawing.Point(203, 280);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(194, 22);
            this.checkOut.TabIndex = 28;
            this.checkOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBooking.BorderRadius = 15;
            this.btnAddBooking.CausesValidation = false;
            this.btnAddBooking.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBooking.FillColor = System.Drawing.Color.Lime;
            this.btnAddBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnAddBooking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddBooking.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddBooking.Location = new System.Drawing.Point(111, 350);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(112, 40);
            this.btnAddBooking.TabIndex = 29;
            this.btnAddBooking.Text = "Thêm";
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CausesValidation = false;
            this.btnCancel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(264, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 40);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRoomType
            // 
            this.txtRoomType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoomType.CausesValidation = false;
            this.txtRoomType.FormattingEnabled = true;
            this.txtRoomType.Items.AddRange(new object[] {
            "Phòng giường đơn",
            "Phòng giường đôi"});
            this.txtRoomType.Location = new System.Drawing.Point(203, 171);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(194, 24);
            this.txtRoomType.TabIndex = 31;
            this.txtRoomType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCusName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBooking";
            this.Text = "AddBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker checkIn;
        private System.Windows.Forms.DateTimePicker checkOut;
        private Guna.UI2.WinForms.Guna2Button btnAddBooking;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.ComboBox txtRoomType;
    }
}