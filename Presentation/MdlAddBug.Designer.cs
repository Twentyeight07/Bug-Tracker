namespace Presentation
{
    partial class MdlAddBug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdlAddBug));
            this.BtnCancelProject = new System.Windows.Forms.Button();
            this.BtnSaveProject = new System.Windows.Forms.Button();
            this.lblMembers = new System.Windows.Forms.Label();
            this.chkMembers = new System.Windows.Forms.CheckedListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.DateTimePicker();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.txtBugTitle = new System.Windows.Forms.TextBox();
            this.lblNewProject = new System.Windows.Forms.Label();
            this.chkDeadline = new System.Windows.Forms.CheckBox();
            this.cmbSevere = new System.Windows.Forms.ComboBox();
            this.lblSevere = new System.Windows.Forms.Label();
            this.modalEffect_timer = new System.Windows.Forms.Timer(this.components);
            this.lblProjectName = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelProject
            // 
            this.BtnCancelProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnCancelProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelProject.FlatAppearance.BorderSize = 0;
            this.BtnCancelProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnCancelProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnCancelProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelProject.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnCancelProject.Location = new System.Drawing.Point(344, 492);
            this.BtnCancelProject.Name = "BtnCancelProject";
            this.BtnCancelProject.Size = new System.Drawing.Size(93, 40);
            this.BtnCancelProject.TabIndex = 48;
            this.BtnCancelProject.Text = "Cancel";
            this.BtnCancelProject.UseVisualStyleBackColor = false;
            this.BtnCancelProject.Click += new System.EventHandler(this.BtnCancelProject_Click);
            // 
            // BtnSaveProject
            // 
            this.BtnSaveProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnSaveProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveProject.FlatAppearance.BorderSize = 0;
            this.BtnSaveProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnSaveProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnSaveProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveProject.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnSaveProject.Location = new System.Drawing.Point(443, 492);
            this.BtnSaveProject.Name = "BtnSaveProject";
            this.BtnSaveProject.Size = new System.Drawing.Size(93, 40);
            this.BtnSaveProject.TabIndex = 49;
            this.BtnSaveProject.Text = "Save";
            this.BtnSaveProject.UseVisualStyleBackColor = false;
            this.BtnSaveProject.Click += new System.EventHandler(this.BtnSaveProject_Click);
            // 
            // lblMembers
            // 
            this.lblMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblMembers.Location = new System.Drawing.Point(575, 209);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(86, 19);
            this.lblMembers.TabIndex = 47;
            this.lblMembers.Text = "Members *";
            // 
            // chkMembers
            // 
            this.chkMembers.CheckOnClick = true;
            this.chkMembers.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.chkMembers.FormattingEnabled = true;
            this.chkMembers.IntegralHeight = false;
            this.chkMembers.Location = new System.Drawing.Point(579, 231);
            this.chkMembers.Name = "chkMembers";
            this.chkMembers.Size = new System.Drawing.Size(239, 175);
            this.chkMembers.TabIndex = 46;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtDescription.Location = new System.Drawing.Point(49, 231);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(485, 175);
            this.txtDescription.TabIndex = 45;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblDescription.Location = new System.Drawing.Point(45, 209);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 19);
            this.lblDescription.TabIndex = 44;
            this.lblDescription.Text = "Description";
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblDeadline.Location = new System.Drawing.Point(45, 417);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(71, 19);
            this.lblDeadline.TabIndex = 43;
            this.lblDeadline.Text = "Deadline";
            // 
            // Deadline
            // 
            this.Deadline.CalendarFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadline.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.Deadline.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.Deadline.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.Deadline.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.Deadline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deadline.Enabled = false;
            this.Deadline.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Deadline.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Deadline.Location = new System.Drawing.Point(49, 439);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(141, 32);
            this.Deadline.TabIndex = 42;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblProjectTitle.Location = new System.Drawing.Point(45, 120);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(83, 19);
            this.lblProjectTitle.TabIndex = 39;
            this.lblProjectTitle.Text = "Bug Title *";
            // 
            // txtBugTitle
            // 
            this.txtBugTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtBugTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBugTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtBugTitle.Location = new System.Drawing.Point(49, 142);
            this.txtBugTitle.Name = "txtBugTitle";
            this.txtBugTitle.Size = new System.Drawing.Size(363, 27);
            this.txtBugTitle.TabIndex = 38;
            // 
            // lblNewProject
            // 
            this.lblNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewProject.AutoSize = true;
            this.lblNewProject.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblNewProject.Location = new System.Drawing.Point(377, 11);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(95, 25);
            this.lblNewProject.TabIndex = 37;
            this.lblNewProject.Text = "New Bug";
            // 
            // chkDeadline
            // 
            this.chkDeadline.AutoSize = true;
            this.chkDeadline.Location = new System.Drawing.Point(122, 421);
            this.chkDeadline.Name = "chkDeadline";
            this.chkDeadline.Size = new System.Drawing.Size(15, 14);
            this.chkDeadline.TabIndex = 50;
            this.chkDeadline.UseVisualStyleBackColor = true;
            this.chkDeadline.CheckedChanged += new System.EventHandler(this.ChkDeadline_CheckedChanged);
            // 
            // cmbSevere
            // 
            this.cmbSevere.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSevere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.cmbSevere.FormattingEnabled = true;
            this.cmbSevere.Items.AddRange(new object[] {
            "None",
            "Critical",
            "Major",
            "Minor"});
            this.cmbSevere.Location = new System.Drawing.Point(235, 439);
            this.cmbSevere.Name = "cmbSevere";
            this.cmbSevere.Size = new System.Drawing.Size(121, 32);
            this.cmbSevere.TabIndex = 51;
            // 
            // lblSevere
            // 
            this.lblSevere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSevere.AutoSize = true;
            this.lblSevere.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSevere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblSevere.Location = new System.Drawing.Point(231, 417);
            this.lblSevere.Name = "lblSevere";
            this.lblSevere.Size = new System.Drawing.Size(56, 19);
            this.lblSevere.TabIndex = 52;
            this.lblSevere.Text = "Severe";
            // 
            // modalEffect_timer
            // 
            this.modalEffect_timer.Enabled = true;
            this.modalEffect_timer.Interval = 1;
            this.modalEffect_timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblProjectName.Location = new System.Drawing.Point(45, 46);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(69, 19);
            this.lblProjectName.TabIndex = 54;
            this.lblProjectName.Text = "Project *";
            // 
            // cmbProject
            // 
            this.cmbProject.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(49, 68);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(363, 32);
            this.cmbProject.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(613, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 14);
            this.label1.TabIndex = 55;
            this.label1.Text = "These fields (*) are mandatory";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(46, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 14);
            this.label3.TabIndex = 59;
            this.label3.Text = "(No special caracters allowed)";
            // 
            // MdlAddBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(870, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.lblSevere);
            this.Controls.Add(this.cmbSevere);
            this.Controls.Add(this.chkDeadline);
            this.Controls.Add(this.BtnCancelProject);
            this.Controls.Add(this.BtnSaveProject);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.chkMembers);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.lblProjectTitle);
            this.Controls.Add(this.txtBugTitle);
            this.Controls.Add(this.lblNewProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MdlAddBug";
            this.Opacity = 0D;
            this.Text = "MdlAddBug";
            this.Load += new System.EventHandler(this.MdlAddBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelProject;
        private System.Windows.Forms.Button BtnSaveProject;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.CheckedListBox chkMembers;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker Deadline;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.TextBox txtBugTitle;
        private System.Windows.Forms.Label lblNewProject;
        private System.Windows.Forms.CheckBox chkDeadline;
        private System.Windows.Forms.ComboBox cmbSevere;
        private System.Windows.Forms.Label lblSevere;
        private System.Windows.Forms.Timer modalEffect_timer;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}