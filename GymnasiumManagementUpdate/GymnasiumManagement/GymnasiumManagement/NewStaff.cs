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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string fname = txtFName.Text;
                string lname = txtFName.Text;

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

                string dob = dateTimePicker2.Text;
                Int64 mobile = Int64.Parse(txtMobile2.Text);

                string city = comboBoxCity.Text;
                string WorkType = comboBoxWorkType.Text;
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            radioButton1.Checked = false;
            radiioButton2.Checked = false;
            txtMobile2.Clear();
            comboBoxWorkType.ResetText();
            comboBoxCity.ResetText();
            dateTimePicker2.Value = DateTime.Now;
        }

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFName.Text))
            {
                e.Cancel = true;
                txtFName.Focus();
                errorProvider1.SetError(txtFName, "Please Enter Your First Name");
            }
            else
            {
                errorProvider1.SetError(txtFName, null);
            }
        }

        private void txtLName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLName.Text))
            {
                e.Cancel = true;
                txtLName.Focus();
                errorProvider2.SetError(txtLName, "Please Enter Your Last Name");
            }
            else
            {
                errorProvider2.SetError(txtLName, null);
            }
        }

        private void txtMobile2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobile2.Text))
            {
                e.Cancel = true;
                txtMobile2.Focus();
                errorProvider3.SetError(txtMobile2, "Please Enter Your Mobile Number");
            }
            else
            {
                errorProvider3.SetError(txtMobile2, null);
            }
        }

        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dateTimePicker2.Text))
            {
                e.Cancel = true;
                dateTimePicker2.Focus();
                errorProvider4.SetError(dateTimePicker2, "Please Enter Your DOB ");
            }
            else
            {
                errorProvider4.SetError(dateTimePicker2, null);
            }
        }

        private void comboBoxWorkType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxWorkType.Text))
            {
                e.Cancel = true;
                comboBoxWorkType.Focus();
                errorProvider5.SetError(comboBoxWorkType, "Please Enter Your Work Type");
            }
            else
            {
                errorProvider5.SetError(comboBoxWorkType, null);
            }
        }

        private void comboBoxCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxCity.Text))
            {
                e.Cancel = true;
                comboBoxCity.Focus();
                errorProvider6.SetError(comboBoxCity, "Please Enter Your City ");
            }
            else
            {
                errorProvider6.SetError(comboBoxCity, null);
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}