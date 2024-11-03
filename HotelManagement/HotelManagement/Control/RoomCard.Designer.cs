namespace HotelManagement
{
    partial class RoomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.palBackgroundCard = new System.Windows.Forms.Panel();
            this.labCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labStatusRoom = new System.Windows.Forms.Label();
            this.labNameRoom = new System.Windows.Forms.Label();
            this.picCard = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CheckOutDate = new System.Windows.Forms.Label();
            this.CheckInDate = new System.Windows.Forms.Label();
            this.palBackgroundCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // palBackgroundCard
            // 
            this.palBackgroundCard.BackColor = System.Drawing.Color.ForestGreen;
            this.palBackgroundCard.Controls.Add(this.labCustomer);
            this.palBackgroundCard.Controls.Add(this.labStatusRoom);
            this.palBackgroundCard.Controls.Add(this.labNameRoom);
            this.palBackgroundCard.Controls.Add(this.picCard);
            this.palBackgroundCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.palBackgroundCard.Location = new System.Drawing.Point(0, 0);
            this.palBackgroundCard.Name = "palBackgroundCard";
            this.palBackgroundCard.Size = new System.Drawing.Size(338, 124);
            this.palBackgroundCard.TabIndex = 0;
            this.palBackgroundCard.Click += new System.EventHandler(this.RoomCard_Click);
            // 
            // labCustomer
            // 
            this.labCustomer.AutoSize = false;
            this.labCustomer.AutoSizeHeightOnly = true;
            this.labCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCustomer.ForeColor = System.Drawing.Color.White;
            this.labCustomer.Location = new System.Drawing.Point(99, 59);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(207, 26);
            this.labCustomer.TabIndex = 4;
            this.labCustomer.Text = "Phòng trống";
            this.labCustomer.Click += new System.EventHandler(this.RoomCard_Click);
            // 
            // labStatusRoom
            // 
            this.labStatusRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatusRoom.AutoSize = true;
            this.labStatusRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStatusRoom.ForeColor = System.Drawing.Color.White;
            this.labStatusRoom.Location = new System.Drawing.Point(207, 13);
            this.labStatusRoom.Name = "labStatusRoom";
            this.labStatusRoom.Size = new System.Drawing.Size(57, 20);
            this.labStatusRoom.TabIndex = 1;
            this.labStatusRoom.Text = "label2";
            // 
            // labNameRoom
            // 
            this.labNameRoom.AutoSize = true;
            this.labNameRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNameRoom.ForeColor = System.Drawing.Color.White;
            this.labNameRoom.Location = new System.Drawing.Point(17, 13);
            this.labNameRoom.Name = "labNameRoom";
            this.labNameRoom.Size = new System.Drawing.Size(57, 20);
            this.labNameRoom.TabIndex = 0;
            this.labNameRoom.Text = "label1";
            // 
            // picCard
            // 
            this.picCard.FillColor = System.Drawing.Color.ForestGreen;
            this.picCard.Image = global::HotelManagement.Properties.Resources.icons8_check_50;
            this.picCard.ImageRotate = 0F;
            this.picCard.InitialImage = global::HotelManagement.Properties.Resources.icons8_check_50;
            this.picCard.Location = new System.Drawing.Point(24, 46);
            this.picCard.Name = "picCard";
            this.picCard.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picCard.Size = new System.Drawing.Size(50, 50);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard.TabIndex = 5;
            this.picCard.TabStop = false;
            this.picCard.Click += new System.EventHandler(this.RoomCard_Click);
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.AutoSize = true;
            this.CheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDate.Location = new System.Drawing.Point(196, 141);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(52, 17);
            this.CheckOutDate.TabIndex = 1;
            this.CheckOutDate.Text = "label1";
            this.CheckOutDate.Visible = false;
            // 
            // CheckInDate
            // 
            this.CheckInDate.AutoSize = true;
            this.CheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInDate.Location = new System.Drawing.Point(33, 141);
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Size = new System.Drawing.Size(52, 17);
            this.CheckInDate.TabIndex = 2;
            this.CheckInDate.Text = "label2";
            this.CheckInDate.Visible = false;
            // 
            // RoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.CheckInDate);
            this.Controls.Add(this.CheckOutDate);
            this.Controls.Add(this.palBackgroundCard);
            this.Name = "RoomCard";
            this.Size = new System.Drawing.Size(338, 170);
            this.Click += new System.EventHandler(this.RoomCard_Click);
            this.palBackgroundCard.ResumeLayout(false);
            this.palBackgroundCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel palBackgroundCard;
        private System.Windows.Forms.Label labStatusRoom;
        private System.Windows.Forms.Label labNameRoom;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCustomer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picCard;
        private System.Windows.Forms.Label CheckOutDate;
        private System.Windows.Forms.Label CheckInDate;
    }
}
