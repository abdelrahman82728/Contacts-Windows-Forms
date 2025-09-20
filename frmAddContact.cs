using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ContactsBusinessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace ContactsWindowsFormsApplication
{
    public partial class frmAddContact : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _ID;
        private clsContact _Contact;

        public frmAddContact(int ID)
        {
            InitializeComponent();

            _ID = ID;


            if (ID == -1)
            {
                _Contact = new clsContact();
                _Mode = enMode.AddNew;
            }

            else
            {
                _Contact = clsContact.Find(ID);
                _Mode = enMode.Update;

            }


        }

        private void _LoadContant()
        {

            _FillCountriesInComboBox();
            cbCountryName.SelectedIndex = 0;


            if (_Mode == enMode.AddNew)
            {
                lblFormName.Text = "Add New Contact";
                return;
            }

            if(_Contact == null)
            {

                MessageBox.Show("This form will be closed because No Contact with ID = " + _ID);
                this.Close();

                return;
            }

            lblFormName.Text = "Update Contact";

            lblID.Text = _ID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtEmail.Text = _Contact.Email;
            txtPhoneNumber.Text = _Contact.Phone;
            txtAddress.Text = _Contact.Address;
            dtpDateOfBirth.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath != "" && File.Exists(_Contact.ImagePath))
            {
                pbImage.Load(_Contact.ImagePath);
            }

            llblRemoveImage.Visible = (_Contact.ImagePath != "");

            cbCountryName.SelectedIndex = cbCountryName.FindString(clsCountry.Find(_Contact.CountryID).CountryName);

        }

        private void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountryName.Items.Add(row["CountryName"]);
            }
        }

        private void txtDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void frmAddContact_Load(object sender, EventArgs e)
        {
            _LoadContant();
        }


      

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateSave()) {
                MessageBox.Show("Failed to save , please enter the fields in a valid format");
                return;
            }

            _Contact.FirstName = txtFirstName.Text.Trim();
            _Contact.LastName = txtLastName.Text.Trim();
            _Contact.Email = txtEmail.Text.Trim();
            _Contact.Phone = txtPhoneNumber.Text.Trim();
            _Contact.Address = txtAddress.Text.Trim();
            _Contact.DateOfBirth = dtpDateOfBirth.Value;
            _Contact.CountryID = clsCountry.Find(cbCountryName.Text).ID;



            if (pbImage.ImageLocation != null && File.Exists(pbImage.ImageLocation))
            {
                _Contact.ImagePath = pbImage.ImageLocation.ToString();
            }

            else
            {
                _Contact.ImagePath = "";

            }


            if (_Contact.Save())
            {
                MessageBox.Show("Data has been saved");
            }

            else
            {
                MessageBox.Show("Couldn't save the data");

            }

            _Mode = enMode.Update;

            lblFormName.Text = "Update Contact";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          ofdSetImageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
          ofdSetImageDialog.FilterIndex = 1;
            ofdSetImageDialog.RestoreDirectory = true;


            if (ofdSetImageDialog.ShowDialog() == DialogResult.OK)
            {
               string ImagePath =  ofdSetImageDialog.FileName;

                pbImage.Load(ImagePath);
            }

        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            llblRemoveImage.Visible = false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e) {
        

        
        }


        private bool ValidateSave()
        {
            string Text = "";

            Text = txtFirstName.Text.Trim();
            if(string.IsNullOrEmpty(Text))
            {
                MessageBox.Show(Text + " Must Not be Empty");
                return false;
            }

            Text = txtLastName.Text.Trim();
            if (string.IsNullOrEmpty(Text))
            {
                MessageBox.Show(Text + " Must Not be Empty");
                return false;
            }

            Text = txtAddress.Text.Trim();
            if (string.IsNullOrEmpty(Text))
            {
                MessageBox.Show("Invalid Format " + Text + "  Must Not be Empty");
                return false;
            }

            Text = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(Text))
            {
                MessageBox.Show("Invalid Format " + Text + " Must Not be Empty");
                return false;
            }

            if (Text.Contains(" "))
            {
                MessageBox.Show("Invalid Format " + Text + " Must Not Contain Spaces");
                return false;
            }

            Text = txtEmail.Text.Trim();


            if (string.IsNullOrEmpty(Text))
            {
                MessageBox.Show("Invalid Format " + Text + " Must Not be Empty");
                return false;
            }

            if (Text.Contains(" "))
            {
                MessageBox.Show("Invalid Format  " + Text + " Must Not Contain Spaces");
                return false;
            }

            if (!Text.Contains("@"))
            {
                MessageBox.Show("Invalid Format  " + Text + " Must  Contains '@' ");
                return false;
            }



            return true;
        }

       

            
        private void ValidateText(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;

            string s = txt.Text.Trim();
            if (s == "")
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This must not be empty");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }

        }

        private void frmAddContact_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ValidatePhoneNumber(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;

            string s = txt.Text.Trim();


            if (string.IsNullOrEmpty(s))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This field must not be empty.");
            }
            else if (s.Contains(" "))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This field must not contain spaces.");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
        }

        private void ValidateEmail(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string s = txt.Text.Trim();

            if (string.IsNullOrEmpty(s))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This field must not be empty.");
            }
            else if (s.Contains(" "))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This field must not contain spaces.");
            }
            else if (!s.Contains("@"))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "Invalid format: must contain '@'.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }

        }
    }
}

