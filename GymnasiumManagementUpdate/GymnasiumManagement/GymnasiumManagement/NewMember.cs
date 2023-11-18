using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymnasiumManagement
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                
                string fname = txtFirstName.Text;
            string Lname = txtFirstName.Text;

            string gender = "";

            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radiioButton2.Text;
            }

            string dob = dateTimePicker1.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string gymTime = ComboGymTime.Text;
            }
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();

            radioButton1.Checked = false;
            radiioButton2.Checked = false;

            dateTimePicker1.Value = DateTime.Now;

            txtMobile.Clear();
            ComboGymTime.ResetText();

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "Please Enter Your First Name ");
            }
            else
            {
                errorProvider1.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider2.SetError(txtLastName, "Please Enter Your Last Name ");
            }
            else
            {
                errorProvider2.SetError(txtLastName, null);
            }
        }

        private void txtMobile_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                e.Cancel = true;
                txtMobile.Focus();
                errorProvider3.SetError(txtMobile, "Please Enter Your Mobile Number ");
            }
            else
            {
                errorProvider3.SetError(txtMobile, null);
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                e.Cancel = true;
                dateTimePicker1.Focus();
                errorProvider4.SetError(dateTimePicker1, "Please Enter Your DOB");
            }
            else
            {
                errorProvider4.SetError(dateTimePicker1, null);
            }
        }

        private void ComboGymTime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ComboGymTime.Text))
            {
                e.Cancel = true;
                ComboGymTime.Focus();
                errorProvider5.SetError(ComboGymTime, "Please Enter Gym Time ");
            }
            else
            {
                errorProvider5.SetError(ComboGymTime, null);
            }
        }
    }
}