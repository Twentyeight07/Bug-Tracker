namespace Presentation
{
    partial class FrmEditProfile
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
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.linkEditPass = new System.Windows.Forms.LinkLabel();
            this.lblMandatory = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblEditRepeatPass = new System.Windows.Forms.Label();
            this.lblEditPass = new System.Windows.Forms.Label();
            this.txtRepeatPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.pnlCompanyName = new System.Windows.Forms.Panel();
            this.lblPassCompany = new System.Windows.Forms.Label();
            this.BtnCancelCompnay = new System.Windows.Forms.Button();
            this.txtPassCompany = new System.Windows.Forms.TextBox();
            this.BtnEditCompany = new System.Windows.Forms.Button();
            this.BtnSaveCompany = new System.Windows.Forms.Button();
            this.lblEditCompany = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyProfile = new System.Windows.Forms.Label();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.pnlCompanyName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfile
            // 
            this.pnlProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.pnlProfile.Controls.Add(this.linkEditPass);
            this.pnlProfile.Controls.Add(this.lblMandatory);
            this.pnlProfile.Controls.Add(this.lblCurrentPass);
            this.pnlProfile.Controls.Add(this.txtCurrentPass);
            this.pnlProfile.Controls.Add(this.lblEditRepeatPass);
            this.pnlProfile.Controls.Add(this.lblEditPass);
            this.pnlProfile.Controls.Add(this.txtRepeatPass);
            this.pnlProfile.Controls.Add(this.txtNewPass);
            this.pnlProfile.Controls.Add(this.BtnCancel);
            this.pnlProfile.Controls.Add(this.BtnSave);
            this.pnlProfile.Controls.Add(this.lblEditEmail);
            this.pnlProfile.Controls.Add(this.txtEmail);
            this.pnlProfile.Controls.Add(this.BtnEdit);
            this.pnlProfile.Controls.Add(this.lblEmail);
            this.pnlProfile.Controls.Add(this.lblName);
            this.pnlProfile.Location = new System.Drawing.Point(50, 52);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(1000, 295);
            this.pnlProfile.TabIndex = 0;
            // 
            // linkEditPass
            // 
            this.linkEditPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkEditPass.AutoSize = true;
            this.linkEditPass.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEditPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.linkEditPass.Location = new System.Drawing.Point(734, 74);
            this.linkEditPass.Name = "linkEditPass";
            this.linkEditPass.Size = new System.Drawing.Size(26, 13);
            this.linkEditPass.TabIndex = 19;
            this.linkEditPass.TabStop = true;
            this.linkEditPass.Text = "Edit";
            this.linkEditPass.Visible = false;
            this.linkEditPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEditPass_LinkClicked);
            // 
            // lblMandatory
            // 
            this.lblMandatory.AutoSize = true;
            this.lblMandatory.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMandatory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblMandatory.Location = new System.Drawing.Point(108, 187);
            this.lblMandatory.Name = "lblMandatory";
            this.lblMandatory.Size = new System.Drawing.Size(161, 14);
            this.lblMandatory.TabIndex = 0;
            this.lblMandatory.Text = "This fields are mandatory (*)";
            this.lblMandatory.Visible = false;
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblCurrentPass.Location = new System.Drawing.Point(616, 204);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(145, 19);
            this.lblCurrentPass.TabIndex = 18;
            this.lblCurrentPass.Text = "Current Password *";
            this.lblCurrentPass.Visible = false;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtCurrentPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtCurrentPass.Location = new System.Drawing.Point(620, 226);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(357, 27);
            this.txtCurrentPass.TabIndex = 6;
            this.txtCurrentPass.Visible = false;
            // 
            // lblEditRepeatPass
            // 
            this.lblEditRepeatPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditRepeatPass.AutoSize = true;
            this.lblEditRepeatPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditRepeatPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblEditRepeatPass.Location = new System.Drawing.Point(616, 137);
            this.lblEditRepeatPass.Name = "lblEditRepeatPass";
            this.lblEditRepeatPass.Size = new System.Drawing.Size(167, 19);
            this.lblEditRepeatPass.TabIndex = 16;
            this.lblEditRepeatPass.Text = "Repeat your Password";
            this.lblEditRepeatPass.Visible = false;
            // 
            // lblEditPass
            // 
            this.lblEditPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditPass.AutoSize = true;
            this.lblEditPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblEditPass.Location = new System.Drawing.Point(616, 72);
            this.lblEditPass.Name = "lblEditPass";
            this.lblEditPass.Size = new System.Drawing.Size(114, 19);
            this.lblEditPass.TabIndex = 15;
            this.lblEditPass.Text = "New Password";
            this.lblEditPass.Visible = false;
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepeatPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtRepeatPass.Enabled = false;
            this.txtRepeatPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtRepeatPass.Location = new System.Drawing.Point(620, 159);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(357, 27);
            this.txtRepeatPass.TabIndex = 5;
            this.txtRepeatPass.Visible = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtNewPass.Enabled = false;
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtNewPass.Location = new System.Drawing.Point(620, 94);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(357, 27);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnCancel.Location = new System.Drawing.Point(90, 213);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(93, 40);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnSave.Location = new System.Drawing.Point(189, 213);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(93, 40);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblEditEmail.Location = new System.Drawing.Point(28, 72);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(60, 19);
            this.lblEditEmail.TabIndex = 6;
            this.lblEditEmail.Text = "Email *";
            this.lblEditEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtEmail.Location = new System.Drawing.Point(32, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 27);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Visible = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnEdit.Location = new System.Drawing.Point(884, 16);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(93, 40);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "EDIT";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblEmail.Location = new System.Drawing.Point(28, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblName.Location = new System.Drawing.Point(28, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblProfile.Location = new System.Drawing.Point(46, 24);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(72, 25);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Profile";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Presentation.Properties.Resources.cerrar1;
            this.BtnClose.Location = new System.Drawing.Point(1079, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pnlCompanyName
            // 
            this.pnlCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.pnlCompanyName.Controls.Add(this.lblPassCompany);
            this.pnlCompanyName.Controls.Add(this.BtnCancelCompnay);
            this.pnlCompanyName.Controls.Add(this.txtPassCompany);
            this.pnlCompanyName.Controls.Add(this.BtnEditCompany);
            this.pnlCompanyName.Controls.Add(this.BtnSaveCompany);
            this.pnlCompanyName.Controls.Add(this.lblEditCompany);
            this.pnlCompanyName.Controls.Add(this.txtCompanyName);
            this.pnlCompanyName.Location = new System.Drawing.Point(50, 403);
            this.pnlCompanyName.Name = "pnlCompanyName";
            this.pnlCompanyName.Size = new System.Drawing.Size(1000, 167);
            this.pnlCompanyName.TabIndex = 8;
            // 
            // lblPassCompany
            // 
            this.lblPassCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassCompany.AutoSize = true;
            this.lblPassCompany.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblPassCompany.Location = new System.Drawing.Point(423, 19);
            this.lblPassCompany.Name = "lblPassCompany";
            this.lblPassCompany.Size = new System.Drawing.Size(145, 19);
            this.lblPassCompany.TabIndex = 21;
            this.lblPassCompany.Text = "Current Password *";
            this.lblPassCompany.Visible = false;
            // 
            // BtnCancelCompnay
            // 
            this.BtnCancelCompnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnCancelCompnay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelCompnay.FlatAppearance.BorderSize = 0;
            this.BtnCancelCompnay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnCancelCompnay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnCancelCompnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelCompnay.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelCompnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnCancelCompnay.Location = new System.Drawing.Point(91, 93);
            this.BtnCancelCompnay.Name = "BtnCancelCompnay";
            this.BtnCancelCompnay.Size = new System.Drawing.Size(93, 40);
            this.BtnCancelCompnay.TabIndex = 11;
            this.BtnCancelCompnay.Text = "Cancel";
            this.BtnCancelCompnay.UseVisualStyleBackColor = false;
            this.BtnCancelCompnay.Visible = false;
            this.BtnCancelCompnay.Click += new System.EventHandler(this.BtnCancelCompnay_Click);
            // 
            // txtPassCompany
            // 
            this.txtPassCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtPassCompany.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtPassCompany.Location = new System.Drawing.Point(427, 41);
            this.txtPassCompany.Name = "txtPassCompany";
            this.txtPassCompany.Size = new System.Drawing.Size(357, 27);
            this.txtPassCompany.TabIndex = 10;
            this.txtPassCompany.Visible = false;
            // 
            // BtnEditCompany
            // 
            this.BtnEditCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnEditCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditCompany.FlatAppearance.BorderSize = 0;
            this.BtnEditCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnEditCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnEditCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditCompany.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnEditCompany.Location = new System.Drawing.Point(885, 15);
            this.BtnEditCompany.Name = "BtnEditCompany";
            this.BtnEditCompany.Size = new System.Drawing.Size(93, 40);
            this.BtnEditCompany.TabIndex = 19;
            this.BtnEditCompany.Text = "EDIT";
            this.BtnEditCompany.UseVisualStyleBackColor = false;
            this.BtnEditCompany.Click += new System.EventHandler(this.BtnEditCompany_Click);
            // 
            // BtnSaveCompany
            // 
            this.BtnSaveCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnSaveCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveCompany.FlatAppearance.BorderSize = 0;
            this.BtnSaveCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnSaveCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnSaveCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveCompany.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnSaveCompany.Location = new System.Drawing.Point(190, 93);
            this.BtnSaveCompany.Name = "BtnSaveCompany";
            this.BtnSaveCompany.Size = new System.Drawing.Size(93, 40);
            this.BtnSaveCompany.TabIndex = 12;
            this.BtnSaveCompany.Text = "Save";
            this.BtnSaveCompany.UseVisualStyleBackColor = false;
            this.BtnSaveCompany.Visible = false;
            this.BtnSaveCompany.Click += new System.EventHandler(this.BtnSaveCompany_Click);
            // 
            // lblEditCompany
            // 
            this.lblEditCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditCompany.AutoSize = true;
            this.lblEditCompany.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblEditCompany.Location = new System.Drawing.Point(29, 19);
            this.lblEditCompany.Name = "lblEditCompany";
            this.lblEditCompany.Size = new System.Drawing.Size(127, 19);
            this.lblEditCompany.TabIndex = 22;
            this.lblEditCompany.Text = "Company Name ";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtCompanyName.Location = new System.Drawing.Point(33, 41);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(319, 27);
            this.txtCompanyName.TabIndex = 9;
            // 
            // lblCompanyProfile
            // 
            this.lblCompanyProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyProfile.AutoSize = true;
            this.lblCompanyProfile.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblCompanyProfile.Location = new System.Drawing.Point(46, 375);
            this.lblCompanyProfile.Name = "lblCompanyProfile";
            this.lblCompanyProfile.Size = new System.Drawing.Size(161, 25);
            this.lblCompanyProfile.TabIndex = 9;
            this.lblCompanyProfile.Text = "Company Name";
            // 
            // FrmEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.lblCompanyProfile);
            this.Controls.Add(this.pnlCompanyName);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.pnlProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditProfile";
            this.Text = "FrmEditProfile";
            this.Load += new System.EventHandler(this.FrmEditProfile_Load);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.pnlCompanyName.ResumeLayout(false);
            this.pnlCompanyName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lblMandatory;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Label lblEditRepeatPass;
        private System.Windows.Forms.Label lblEditPass;
        private System.Windows.Forms.TextBox txtRepeatPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Panel pnlCompanyName;
        private System.Windows.Forms.Label lblEditCompany;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyProfile;
        private System.Windows.Forms.Button BtnCancelCompnay;
        private System.Windows.Forms.Button BtnEditCompany;
        private System.Windows.Forms.Button BtnSaveCompany;
        private System.Windows.Forms.LinkLabel linkEditPass;
        private System.Windows.Forms.Label lblPassCompany;
        private System.Windows.Forms.TextBox txtPassCompany;
    }
}