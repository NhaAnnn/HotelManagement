namespace HotelManagement
{
    partial class RoomManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.palSingleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.palDoubleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.palSingleRoom.SuspendLayout();
            this.palDoubleRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.label1.Size = new System.Drawing.Size(256, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng giường đơn:";
            // 
            // palSingleRoom
            // 
            this.palSingleRoom.AutoSize = true;
            this.palSingleRoom.Controls.Add(this.label2);
            this.palSingleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.palSingleRoom.Location = new System.Drawing.Point(0, 99);
            this.palSingleRoom.Name = "palSingleRoom";
            this.palSingleRoom.Size = new System.Drawing.Size(800, 16);
            this.palSingleRoom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Day la phong don";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 115);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20);
            this.label3.Size = new System.Drawing.Size(249, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng giường đôi:";
            // 
            // palDoubleRoom
            // 
            this.palDoubleRoom.AutoSize = true;
            this.palDoubleRoom.Controls.Add(this.label4);
            this.palDoubleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.palDoubleRoom.Location = new System.Drawing.Point(0, 184);
            this.palDoubleRoom.Name = "palDoubleRoom";
            this.palDoubleRoom.Size = new System.Drawing.Size(800, 16);
            this.palDoubleRoom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Day la phong doi";
            this.label4.Visible = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoom.AutoRoundedCorners = true;
            this.btnAddRoom.BorderRadius = 26;
            this.btnAddRoom.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRoom.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddRoom.Location = new System.Drawing.Point(515, 12);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(222, 54);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.TextOffset = new System.Drawing.Point(20, 0);
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.palDoubleRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.palSingleRoom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RoomManagement";
            this.Text = "RoomManagement";
            this.Load += new System.EventHandler(this.Room_Load);
            this.palSingleRoom.ResumeLayout(false);
            this.palSingleRoom.PerformLayout();
            this.palDoubleRoom.ResumeLayout(false);
            this.palDoubleRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel palSingleRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel palDoubleRoom;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
    }
}