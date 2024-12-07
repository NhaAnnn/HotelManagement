namespace HotelManagement
{
    partial class AddRoom
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
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRooomCapa = new System.Windows.Forms.TextBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomSta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.ComboBox();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtRoomName
            // 
            this.txtRoomName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoomName.CausesValidation = false;
            this.txtRoomName.Location = new System.Drawing.Point(205, 97);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(194, 22);
            this.txtRoomName.TabIndex = 0;
            this.txtRoomName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyDown);
            // 
            // txtRooomCapa
            // 
            this.txtRooomCapa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRooomCapa.CausesValidation = false;
            this.txtRooomCapa.Location = new System.Drawing.Point(205, 173);
            this.txtRooomCapa.Name = "txtRooomCapa";
            this.txtRooomCapa.Size = new System.Drawing.Size(194, 22);
            this.txtRooomCapa.TabIndex = 2;
            this.txtRooomCapa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyDown);
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoomPrice.CausesValidation = false;
            this.txtRoomPrice.Location = new System.Drawing.Point(205, 211);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(194, 22);
            this.txtRoomPrice.TabIndex = 3;
            this.txtRoomPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số phòng:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại phòng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số người:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá tiền:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trạng thái:";
            // 
            // txtRoomSta
            // 
            this.txtRoomSta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoomSta.CausesValidation = false;
            this.txtRoomSta.Location = new System.Drawing.Point(205, 249);
            this.txtRoomSta.Name = "txtRoomSta";
            this.txtRoomSta.ReadOnly = true;
            this.txtRoomSta.Size = new System.Drawing.Size(194, 22);
            this.txtRoomSta.TabIndex = 4;
            this.txtRoomSta.Text = "Phòng trống";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thêm phòng mới";
            // 
            // txtRoomType
            // 
            this.txtRoomType.CausesValidation = false;
            this.txtRoomType.FormattingEnabled = true;
            this.txtRoomType.Items.AddRange(new object[] {
            "Phòng giường đơn",
            "Phòng giường đôi"});
            this.txtRoomType.Location = new System.Drawing.Point(205, 134);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(194, 24);
            this.txtRoomType.TabIndex = 1;
            this.txtRoomType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyDown);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddRoom.BorderRadius = 15;
            this.btnAddRoom.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.Lime;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnAddRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRoom.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddRoom.Location = new System.Drawing.Point(134, 319);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(84, 40);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Thêm";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(268, 319);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(84, 40);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Thoát";
            this.guna2Button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 402);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomSta);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.txtRooomCapa);
            this.Controls.Add(this.txtRoomName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtRooomCapa;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomSta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtRoomType;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}