using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace ContactsWindowsFormsApplication
{
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
        }

        private void _RefreshContacts()
        {
            dgvContacts.DataSource = clsContact.GetAllContacts();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshContacts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmAddNew = new frmAddContact(-1);
            frmAddNew.ShowDialog();
            _RefreshContacts();

        }

        private void EditContact(object sender, EventArgs e)
        {
            Form frmAddNew = new frmAddContact((int)dgvContacts.CurrentRow.Cells[0].Value);
            frmAddNew.ShowDialog();
            _RefreshContacts();

        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete contact [" + dgvContacts.CurrentRow.Cells[0].Value + "]"
                , "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsContact.DeleteContact((int)dgvContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully");
                }

            }

            _RefreshContacts() ;

        }
    }
}
