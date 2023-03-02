namespace Presentation
{
    partial class FrmProjectPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectPage));
            this.lblProjectName = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.BtnAddBug = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.PnlNewBug = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSevere = new System.Windows.Forms.Label();
            this.cmbSevere = new System.Windows.Forms.ComboBox();
            this.chkDeadline = new System.Windows.Forms.CheckBox();
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
            this.pnlBugDetails = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBugState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BugDetails = new System.Windows.Forms.ImageList(this.components);
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblBugTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBugDescription = new System.Windows.Forms.TextBox();
            this.BtnCnlUptDescpBug = new System.Windows.Forms.Button();
            this.BtnUpdateBugDescp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.txtModifiedBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEditBugDescription = new System.Windows.Forms.PictureBox();
            this.BtnCloseBugDetails = new System.Windows.Forms.PictureBox();
            this.lblProjectForBugPnl = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.PnlNewBug.SuspendLayout();
            this.pnlBugDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditBugDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseBugDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblProjectName.Location = new System.Drawing.Point(48, 38);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(60, 25);
            this.lblProjectName.TabIndex = 13;
            this.lblProjectName.Text = "Bugs";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.pnlPrincipal.Controls.Add(this.BtnAddBug);
            this.pnlPrincipal.Controls.Add(this.dgvPrincipal);
            this.pnlPrincipal.Controls.Add(this.TxtSearch);
            this.pnlPrincipal.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrincipal.Location = new System.Drawing.Point(53, 63);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.pnlPrincipal.Size = new System.Drawing.Size(1000, 510);
            this.pnlPrincipal.TabIndex = 14;
            // 
            // BtnAddBug
            // 
            this.BtnAddBug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnAddBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddBug.FlatAppearance.BorderSize = 0;
            this.BtnAddBug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnAddBug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnAddBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBug.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnAddBug.Location = new System.Drawing.Point(916, 16);
            this.BtnAddBug.Name = "BtnAddBug";
            this.BtnAddBug.Size = new System.Drawing.Size(74, 40);
            this.BtnAddBug.TabIndex = 7;
            this.BtnAddBug.Text = "Add Bug";
            this.BtnAddBug.UseVisualStyleBackColor = false;
            this.BtnAddBug.Click += new System.EventHandler(this.BtnAddBug_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AllowUserToResizeColumns = false;
            this.dgvPrincipal.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.dgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPrincipal.EnableHeadersVisualStyles = false;
            this.dgvPrincipal.GridColor = System.Drawing.Color.White;
            this.dgvPrincipal.Location = new System.Drawing.Point(0, 80);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrincipal.RowHeadersVisible = false;
            this.dgvPrincipal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.dgvPrincipal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrincipal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.dgvPrincipal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.dgvPrincipal.RowTemplate.Height = 35;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(1000, 430);
            this.dgvPrincipal.TabIndex = 6;
            this.dgvPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrincipal_CellClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.TxtSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtSearch.Location = new System.Drawing.Point(22, 23);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(319, 27);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.Text = "Search by Title";
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // PnlNewBug
            // 
            this.PnlNewBug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNewBug.Controls.Add(this.label3);
            this.PnlNewBug.Controls.Add(this.lblSevere);
            this.PnlNewBug.Controls.Add(this.cmbSevere);
            this.PnlNewBug.Controls.Add(this.chkDeadline);
            this.PnlNewBug.Controls.Add(this.BtnCancelProject);
            this.PnlNewBug.Controls.Add(this.BtnSaveProject);
            this.PnlNewBug.Controls.Add(this.lblMembers);
            this.PnlNewBug.Controls.Add(this.chkMembers);
            this.PnlNewBug.Controls.Add(this.txtDescription);
            this.PnlNewBug.Controls.Add(this.lblDescription);
            this.PnlNewBug.Controls.Add(this.lblDeadline);
            this.PnlNewBug.Controls.Add(this.Deadline);
            this.PnlNewBug.Controls.Add(this.lblProjectTitle);
            this.PnlNewBug.Controls.Add(this.txtBugTitle);
            this.PnlNewBug.Controls.Add(this.lblNewProject);
            this.PnlNewBug.Location = new System.Drawing.Point(1000, 38);
            this.PnlNewBug.Name = "PnlNewBug";
            this.PnlNewBug.Size = new System.Drawing.Size(858, 480);
            this.PnlNewBug.TabIndex = 15;
            this.PnlNewBug.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(46, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 14);
            this.label3.TabIndex = 75;
            this.label3.Text = "(No special caracters allowed)";
            // 
            // lblSevere
            // 
            this.lblSevere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSevere.AutoSize = true;
            this.lblSevere.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSevere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblSevere.Location = new System.Drawing.Point(231, 346);
            this.lblSevere.Name = "lblSevere";
            this.lblSevere.Size = new System.Drawing.Size(56, 19);
            this.lblSevere.TabIndex = 73;
            this.lblSevere.Text = "Severe";
            // 
            // cmbSevere
            // 
            this.cmbSevere.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSevere.FormattingEnabled = true;
            this.cmbSevere.Items.AddRange(new object[] {
            "None",
            "Critical",
            "Major",
            "Minor"});
            this.cmbSevere.Location = new System.Drawing.Point(235, 368);
            this.cmbSevere.Name = "cmbSevere";
            this.cmbSevere.Size = new System.Drawing.Size(121, 32);
            this.cmbSevere.TabIndex = 72;
            // 
            // chkDeadline
            // 
            this.chkDeadline.AutoSize = true;
            this.chkDeadline.Location = new System.Drawing.Point(122, 350);
            this.chkDeadline.Name = "chkDeadline";
            this.chkDeadline.Size = new System.Drawing.Size(15, 14);
            this.chkDeadline.TabIndex = 71;
            this.chkDeadline.UseVisualStyleBackColor = true;
            this.chkDeadline.CheckedChanged += new System.EventHandler(this.ChkDeadline_CheckedChanged);
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
            this.BtnCancelProject.Location = new System.Drawing.Point(344, 421);
            this.BtnCancelProject.Name = "BtnCancelProject";
            this.BtnCancelProject.Size = new System.Drawing.Size(93, 40);
            this.BtnCancelProject.TabIndex = 69;
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
            this.BtnSaveProject.Location = new System.Drawing.Point(443, 421);
            this.BtnSaveProject.Name = "BtnSaveProject";
            this.BtnSaveProject.Size = new System.Drawing.Size(93, 40);
            this.BtnSaveProject.TabIndex = 70;
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
            this.lblMembers.Location = new System.Drawing.Point(575, 138);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(86, 19);
            this.lblMembers.TabIndex = 68;
            this.lblMembers.Text = "Members *";
            // 
            // chkMembers
            // 
            this.chkMembers.CheckOnClick = true;
            this.chkMembers.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.chkMembers.FormattingEnabled = true;
            this.chkMembers.IntegralHeight = false;
            this.chkMembers.Location = new System.Drawing.Point(579, 160);
            this.chkMembers.Name = "chkMembers";
            this.chkMembers.Size = new System.Drawing.Size(239, 175);
            this.chkMembers.TabIndex = 67;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(49, 160);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(485, 175);
            this.txtDescription.TabIndex = 66;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblDescription.Location = new System.Drawing.Point(45, 138);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 19);
            this.lblDescription.TabIndex = 65;
            this.lblDescription.Text = "Description";
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblDeadline.Location = new System.Drawing.Point(45, 346);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(71, 19);
            this.lblDeadline.TabIndex = 64;
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
            this.Deadline.Location = new System.Drawing.Point(49, 368);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(141, 32);
            this.Deadline.TabIndex = 63;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblProjectTitle.Location = new System.Drawing.Point(45, 49);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(83, 19);
            this.lblProjectTitle.TabIndex = 62;
            this.lblProjectTitle.Text = "Bug Title *";
            // 
            // txtBugTitle
            // 
            this.txtBugTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtBugTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBugTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtBugTitle.Location = new System.Drawing.Point(49, 71);
            this.txtBugTitle.Name = "txtBugTitle";
            this.txtBugTitle.Size = new System.Drawing.Size(363, 27);
            this.txtBugTitle.TabIndex = 61;
            // 
            // lblNewProject
            // 
            this.lblNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewProject.AutoSize = true;
            this.lblNewProject.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblNewProject.Location = new System.Drawing.Point(393, 14);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(95, 25);
            this.lblNewProject.TabIndex = 60;
            this.lblNewProject.Text = "New Bug";
            // 
            // pnlBugDetails
            // 
            this.pnlBugDetails.AutoScroll = true;
            this.pnlBugDetails.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.pnlBugDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBugDetails.Controls.Add(this.panel3);
            this.pnlBugDetails.Controls.Add(this.panel1);
            this.pnlBugDetails.Controls.Add(this.BtnCloseBugDetails);
            this.pnlBugDetails.Controls.Add(this.panel2);
            this.pnlBugDetails.Controls.Add(this.lblProjectForBugPnl);
            this.pnlBugDetails.Controls.Add(this.lblCreatedBy);
            this.pnlBugDetails.Controls.Add(this.lblBugTitle);
            this.pnlBugDetails.Location = new System.Drawing.Point(90, 13);
            this.pnlBugDetails.Name = "pnlBugDetails";
            this.pnlBugDetails.Size = new System.Drawing.Size(950, 560);
            this.pnlBugDetails.TabIndex = 8;
            this.pnlBugDetails.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.cmbBugState);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(35, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 100);
            this.panel2.TabIndex = 18;
            // 
            // cmbBugState
            // 
            this.cmbBugState.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBugState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.cmbBugState.FormattingEnabled = true;
            this.cmbBugState.Location = new System.Drawing.Point(17, 33);
            this.cmbBugState.Name = "cmbBugState";
            this.cmbBugState.Size = new System.Drawing.Size(139, 26);
            this.cmbBugState.TabIndex = 67;
            this.cmbBugState.DropDown += new System.EventHandler(this.CmbBugState_DropDown);
            this.cmbBugState.SelectedIndexChanged += new System.EventHandler(this.CmbBugState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Actual State";
            // 
            // BugDetails
            // 
            this.BugDetails.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BugDetails.ImageStream")));
            this.BugDetails.TransparentColor = System.Drawing.Color.Transparent;
            this.BugDetails.Images.SetKeyName(0, "projects - Light.png");
            this.BugDetails.Images.SetKeyName(1, "projects.png");
            this.BugDetails.Images.SetKeyName(2, "edit.png");
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(12, 138);
            this.lblCreatedBy.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(94, 22);
            this.lblCreatedBy.TabIndex = 16;
            this.lblCreatedBy.Text = "CreatedBy";
            // 
            // lblBugTitle
            // 
            this.lblBugTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBugTitle.AutoSize = true;
            this.lblBugTitle.Font = new System.Drawing.Font("Roboto", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBugTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblBugTitle.Location = new System.Drawing.Point(12, 106);
            this.lblBugTitle.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblBugTitle.Name = "lblBugTitle";
            this.lblBugTitle.Size = new System.Drawing.Size(99, 28);
            this.lblBugTitle.TabIndex = 16;
            this.lblBugTitle.Text = "BugTitle";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.BtnUpdateBugDescp);
            this.panel1.Controls.Add(this.BtnCnlUptDescpBug);
            this.panel1.Controls.Add(this.BtnEditBugDescription);
            this.panel1.Controls.Add(this.txtBugDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(35, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 159);
            this.panel1.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBugDescription
            // 
            this.txtBugDescription.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBugDescription.Location = new System.Drawing.Point(17, 54);
            this.txtBugDescription.Multiline = true;
            this.txtBugDescription.Name = "txtBugDescription";
            this.txtBugDescription.ReadOnly = true;
            this.txtBugDescription.Size = new System.Drawing.Size(850, 91);
            this.txtBugDescription.TabIndex = 67;
            // 
            // BtnCnlUptDescpBug
            // 
            this.BtnCnlUptDescpBug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCnlUptDescpBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnCnlUptDescpBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCnlUptDescpBug.FlatAppearance.BorderSize = 0;
            this.BtnCnlUptDescpBug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnCnlUptDescpBug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnCnlUptDescpBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCnlUptDescpBug.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCnlUptDescpBug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnCnlUptDescpBug.Location = new System.Drawing.Point(184, 6);
            this.BtnCnlUptDescpBug.Name = "BtnCnlUptDescpBug";
            this.BtnCnlUptDescpBug.Size = new System.Drawing.Size(74, 30);
            this.BtnCnlUptDescpBug.TabIndex = 69;
            this.BtnCnlUptDescpBug.Text = "Cancel";
            this.BtnCnlUptDescpBug.UseVisualStyleBackColor = false;
            this.BtnCnlUptDescpBug.Visible = false;
            this.BtnCnlUptDescpBug.Click += new System.EventHandler(this.BtnCnlUptDescpBug_Click);
            // 
            // BtnUpdateBugDescp
            // 
            this.BtnUpdateBugDescp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateBugDescp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnUpdateBugDescp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateBugDescp.FlatAppearance.BorderSize = 0;
            this.BtnUpdateBugDescp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(79)))), ((int)(((byte)(53)))));
            this.BtnUpdateBugDescp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.BtnUpdateBugDescp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateBugDescp.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateBugDescp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.BtnUpdateBugDescp.Location = new System.Drawing.Point(264, 6);
            this.BtnUpdateBugDescp.Name = "BtnUpdateBugDescp";
            this.BtnUpdateBugDescp.Size = new System.Drawing.Size(74, 30);
            this.BtnUpdateBugDescp.TabIndex = 70;
            this.BtnUpdateBugDescp.Text = "Update";
            this.BtnUpdateBugDescp.UseVisualStyleBackColor = false;
            this.BtnUpdateBugDescp.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.listBox2);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.txtModifiedAt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCreatedAt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtModifiedBy);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtCreatedBy);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(35, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 191);
            this.panel3.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(13, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 66;
            this.label4.Text = "Bug Information";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label5.ImageKey = "(none)";
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "User Assigned";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 23);
            this.comboBox1.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label6.ImageKey = "(none)";
            this.label6.Location = new System.Drawing.Point(364, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Created by";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtCreatedBy.Location = new System.Drawing.Point(368, 66);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(144, 24);
            this.txtCreatedBy.TabIndex = 70;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.Enabled = false;
            this.txtModifiedBy.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifiedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtModifiedBy.Location = new System.Drawing.Point(538, 66);
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(144, 24);
            this.txtModifiedBy.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label7.ImageKey = "(none)";
            this.label7.Location = new System.Drawing.Point(534, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 71;
            this.label7.Text = "Modified by";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtCreatedAt.Location = new System.Drawing.Point(368, 137);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(132, 24);
            this.txtCreatedAt.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label8.ImageKey = "(none)";
            this.label8.Location = new System.Drawing.Point(364, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 73;
            this.label8.Text = "Created at";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.Enabled = false;
            this.txtModifiedAt.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifiedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtModifiedAt.Location = new System.Drawing.Point(538, 137);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(132, 24);
            this.txtModifiedAt.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label9.ImageKey = "(none)";
            this.label9.Location = new System.Drawing.Point(534, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 75;
            this.label9.Text = "Modified at";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(740, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 23);
            this.comboBox2.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label10.ImageKey = "(none)";
            this.label10.Location = new System.Drawing.Point(736, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 78;
            this.label10.Text = "Severe";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Member 1",
            "Member 2",
            "Member 3",
            "Member 4",
            "Member 5"});
            this.listBox1.Location = new System.Drawing.Point(17, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 108);
            this.listBox1.TabIndex = 79;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Member 1",
            "Member 2",
            "Member 3",
            "Member 4",
            "Member 5"});
            this.listBox2.Location = new System.Drawing.Point(171, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(107, 108);
            this.listBox2.TabIndex = 80;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Presentation.Properties.Resources.arrow_right;
            this.pictureBox3.Location = new System.Drawing.Point(140, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Presentation.Properties.Resources.left_arrow;
            this.pictureBox4.Location = new System.Drawing.Point(140, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Presentation.Properties.Resources._checked;
            this.pictureBox2.Location = new System.Drawing.Point(285, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(285, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BtnEditBugDescription
            // 
            this.BtnEditBugDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditBugDescription.Image = global::Presentation.Properties.Resources.edit;
            this.BtnEditBugDescription.Location = new System.Drawing.Point(108, 6);
            this.BtnEditBugDescription.Name = "BtnEditBugDescription";
            this.BtnEditBugDescription.Size = new System.Drawing.Size(16, 16);
            this.BtnEditBugDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEditBugDescription.TabIndex = 68;
            this.BtnEditBugDescription.TabStop = false;
            this.BtnEditBugDescription.Click += new System.EventHandler(this.BtnEditBugDescription_Click);
            // 
            // BtnCloseBugDetails
            // 
            this.BtnCloseBugDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseBugDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseBugDetails.Image = global::Presentation.Properties.Resources.cerrar1;
            this.BtnCloseBugDetails.Location = new System.Drawing.Point(908, 103);
            this.BtnCloseBugDetails.Name = "BtnCloseBugDetails";
            this.BtnCloseBugDetails.Size = new System.Drawing.Size(16, 16);
            this.BtnCloseBugDetails.TabIndex = 19;
            this.BtnCloseBugDetails.TabStop = false;
            this.BtnCloseBugDetails.Click += new System.EventHandler(this.BtnCloseBugDetails_Click);
            // 
            // lblProjectForBugPnl
            // 
            this.lblProjectForBugPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectForBugPnl.AutoSize = true;
            this.lblProjectForBugPnl.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectForBugPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblProjectForBugPnl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProjectForBugPnl.ImageIndex = 1;
            this.lblProjectForBugPnl.ImageList = this.BugDetails;
            this.lblProjectForBugPnl.Location = new System.Drawing.Point(132, 138);
            this.lblProjectForBugPnl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblProjectForBugPnl.Name = "lblProjectForBugPnl";
            this.lblProjectForBugPnl.Size = new System.Drawing.Size(121, 22);
            this.lblProjectForBugPnl.TabIndex = 17;
            this.lblProjectForBugPnl.Text = "     ProjectTitle";
            this.lblProjectForBugPnl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Presentation.Properties.Resources.cerrar1;
            this.BtnClose.Location = new System.Drawing.Point(1074, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.pnlBugDetails);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PnlNewBug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1074, 6);
            this.Name = "FrmProjectPage";
            this.Text = "FrmProjectPage";
            this.Load += new System.EventHandler(this.FrmProjectPage_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.PnlNewBug.ResumeLayout(false);
            this.PnlNewBug.PerformLayout();
            this.pnlBugDetails.ResumeLayout(false);
            this.pnlBugDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditBugDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseBugDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button BtnAddBug;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Panel PnlNewBug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSevere;
        private System.Windows.Forms.ComboBox cmbSevere;
        private System.Windows.Forms.CheckBox chkDeadline;
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
        private System.Windows.Forms.Panel pnlBugDetails;
        private System.Windows.Forms.Label lblBugTitle;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblProjectForBugPnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBugState;
        private System.Windows.Forms.ImageList BugDetails;
        private System.Windows.Forms.PictureBox BtnCloseBugDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBugDescription;
        private System.Windows.Forms.PictureBox BtnEditBugDescription;
        private System.Windows.Forms.Button BtnUpdateBugDescp;
        private System.Windows.Forms.Button BtnCnlUptDescpBug;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModifiedAt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCreatedAt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModifiedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}