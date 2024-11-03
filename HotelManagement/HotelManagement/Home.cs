using Guna.UI2.WinForms;
using HotelManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Home : Form
    {
        private Form activeForm = null;
        public Home()
        {
            InitializeComponent();
            panelChildForm.Visible = false;
           
        }

       
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) 
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Visible = true;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }       
        private void btnRoom_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnRoom.FillColor = Color.White;
            openChildForm(new RoomManagement());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnReport.FillColor = Color.White;
            openChildForm(new Report());
        }

        private void picDashboard_Click(object sender, EventArgs e)
        {
            if (panelSlider.Visible)
            {
                panelSlider.Visible = false;
            } else { panelSlider.Visible = true; }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnHome.FillColor = Color.White;
            if (activeForm != null)
                activeForm.Close();
            panelChildForm.Visible = false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnBooking.FillColor = Color.White;
            openChildForm(new BookingRoom());
        }

        private void ResetButtonColors()
        {
           
            btnHome.FillColor = Color.DodgerBlue; 
            btnRoom.FillColor = Color.DodgerBlue; 
            btnBooking.FillColor = Color.DodgerBlue;
            btnReport.FillColor= Color.DodgerBlue;
        }
    }
}
