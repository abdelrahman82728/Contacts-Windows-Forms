namespace ContactsWindowsFormsApplication
{
    partial class frmAddContact
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
            this.components = new System.ComponentModel.Container();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblE_Mail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbCountryName = new System.Windows.Forms.ComboBox();
            this.lbWhatlID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.llblSetImage = new System.Windows.Forms.LinkLabel();
            this.llblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ofdSetImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(274, 247);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateText);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(274, 310);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateText);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(274, 373);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatePhoneNumber);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 422);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmail);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(263, 601);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 53);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateText);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(81, 247);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 16);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name : ";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(81, 311);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(81, 16);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "Last Name : ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(81, 375);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 16);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblE_Mail
            // 
            this.lblE_Mail.AutoSize = true;
            this.lblE_Mail.Location = new System.Drawing.Point(81, 425);
            this.lblE_Mail.Name = "lblE_Mail";
            this.lblE_Mail.Size = new System.Drawing.Size(54, 16);
            this.lblE_Mail.TabIndex = 8;
            this.lblE_Mail.Text = "E_Mail :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(75, 619);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 16);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address :";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.AutoSize = true;
            this.txtDateOfBirth.Location = new System.Drawing.Point(75, 552);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(88, 16);
            this.txtDateOfBirth.TabIndex = 10;
            this.txtDateOfBirth.Text = "Date of Birth : ";
            this.txtDateOfBirth.Click += new System.EventHandler(this.txtDateOfBirth_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(263, 552);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(232, 22);
            this.dtpDateOfBirth.TabIndex = 11;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(77, 486);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(58, 16);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "Country :";
            // 
            // cbCountryName
            // 
            this.cbCountryName.FormattingEnabled = true;
            this.cbCountryName.Location = new System.Drawing.Point(274, 478);
            this.cbCountryName.Name = "cbCountryName";
            this.cbCountryName.Size = new System.Drawing.Size(200, 24);
            this.cbCountryName.TabIndex = 13;
            // 
            // lbWhatlID
            // 
            this.lbWhatlID.AutoSize = true;
            this.lbWhatlID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhatlID.Location = new System.Drawing.Point(79, 154);
            this.lbWhatlID.Name = "lbWhatlID";
            this.lbWhatlID.Size = new System.Drawing.Size(46, 25);
            this.lbWhatlID.TabIndex = 14;
            this.lbWhatlID.Text = "ID :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(335, 163);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 16);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "????";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(565, 310);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(178, 148);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 16;
            this.pbImage.TabStop = false;
            // 
            // llblSetImage
            // 
            this.llblSetImage.AutoSize = true;
            this.llblSetImage.Location = new System.Drawing.Point(562, 195);
            this.llblSetImage.Name = "llblSetImage";
            this.llblSetImage.Size = new System.Drawing.Size(68, 16);
            this.llblSetImage.TabIndex = 17;
            this.llblSetImage.TabStop = true;
            this.llblSetImage.Text = "Set Image";
            this.llblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetImage_LinkClicked);
            // 
            // llblRemoveImage
            // 
            this.llblRemoveImage.AutoSize = true;
            this.llblRemoveImage.Location = new System.Drawing.Point(675, 195);
            this.llblRemoveImage.Name = "llblRemoveImage";
            this.llblRemoveImage.Size = new System.Drawing.Size(62, 16);
            this.llblRemoveImage.TabIndex = 18;
            this.llblRemoveImage.TabStop = true;
            this.llblRemoveImage.Text = "Remove ";
            this.llblRemoveImage.Visible = false;
            this.llblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemoveImage_LinkClicked);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(224, 56);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(287, 38);
            this.lblFormName.TabIndex = 19;
            this.lblFormName.Text = "Add New Contact";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(529, 591);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 43);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(652, 591);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdSetImageDialog
            // 
            this.ofdSetImageDialog.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 693);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.llblRemoveImage);
            this.Controls.Add(this.llblSetImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbWhatlID);
            this.Controls.Add(this.cbCountryName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblE_Mail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "frmAddContact";
            this.Text = "AddNew Form";
            this.Load += new System.EventHandler(this.frmAddContact_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.frmAddContact_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblE_Mail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label txtDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbCountryName;
        private System.Windows.Forms.Label lbWhatlID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.LinkLabel llblSetImage;
        private System.Windows.Forms.LinkLabel llblRemoveImage;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog ofdSetImageDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}