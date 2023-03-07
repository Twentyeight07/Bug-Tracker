namespace Presentation
{
    partial class FrmBugsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.BtnAddBug = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.lblBugs = new System.Windows.Forms.Label();
            this.pnlBugDetails = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lstbxUsersAssigned = new System.Windows.Forms.ListBox();
            this.lstbxMembers = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUpdateSevere = new System.Windows.Forms.ComboBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModifiedBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUpdateBugDescp = new System.Windows.Forms.Button();
            this.BtnCnlUptDescpBug = new System.Windows.Forms.Button();
            this.txtBugDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBugState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProjectForBugPnl = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblBugTitle = new System.Windows.Forms.Label();
            this.BtnAddMemberToBug = new System.Windows.Forms.PictureBox();
            this.BtnRemoveMember = new System.Windows.Forms.PictureBox();
            this.BtnUpdateMembers = new System.Windows.Forms.PictureBox();
            this.BtnCnlEditMembers = new System.Windows.Forms.PictureBox();
            this.BtnEditBugDescription = new System.Windows.Forms.PictureBox();
            this.BtnCloseBugDetails = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.pnlBugDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddMemberToBug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRemoveMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUpdateMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCnlEditMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditBugDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseBugDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
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
            this.pnlPrincipal.Location = new System.Drawing.Point(50, 60);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.pnlPrincipal.Size = new System.Drawing.Size(1000, 506);
            this.pnlPrincipal.TabIndex = 9;
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
            this.BtnAddBug.Location = new System.Drawing.Point(898, 16);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.dgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            // lblBugs
            // 
            this.lblBugs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBugs.AutoSize = true;
            this.lblBugs.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBugs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblBugs.Location = new System.Drawing.Point(45, 35);
            this.lblBugs.Name = "lblBugs";
            this.lblBugs.Size = new System.Drawing.Size(60, 25);
            this.lblBugs.TabIndex = 0;
            this.lblBugs.Text = "Bugs";
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
            this.pnlBugDetails.Location = new System.Drawing.Point(1062, 60);
            this.pnlBugDetails.Name = "pnlBugDetails";
            this.pnlBugDetails.Size = new System.Drawing.Size(950, 560);
            this.pnlBugDetails.TabIndex = 10;
            this.pnlBugDetails.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.BtnAddMemberToBug);
            this.panel3.Controls.Add(this.BtnRemoveMember);
            this.panel3.Controls.Add(this.BtnUpdateMembers);
            this.panel3.Controls.Add(this.BtnCnlEditMembers);
            this.panel3.Controls.Add(this.lstbxUsersAssigned);
            this.panel3.Controls.Add(this.lstbxMembers);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cmbUpdateSevere);
            this.panel3.Controls.Add(this.txtModifiedAt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCreatedAt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtModifiedBy);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtCreatedBy);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(35, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 191);
            this.panel3.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label11.ImageKey = "(none)";
            this.label11.Location = new System.Drawing.Point(13, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 85;
            this.label11.Text = "Members";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstbxUsersAssigned
            // 
            this.lstbxUsersAssigned.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxUsersAssigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lstbxUsersAssigned.FormattingEnabled = true;
            this.lstbxUsersAssigned.ItemHeight = 15;
            this.lstbxUsersAssigned.Location = new System.Drawing.Point(178, 67);
            this.lstbxUsersAssigned.Name = "lstbxUsersAssigned";
            this.lstbxUsersAssigned.Size = new System.Drawing.Size(120, 109);
            this.lstbxUsersAssigned.TabIndex = 80;
            // 
            // lstbxMembers
            // 
            this.lstbxMembers.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lstbxMembers.FormattingEnabled = true;
            this.lstbxMembers.ItemHeight = 15;
            this.lstbxMembers.Location = new System.Drawing.Point(17, 67);
            this.lstbxMembers.Name = "lstbxMembers";
            this.lstbxMembers.Size = new System.Drawing.Size(120, 109);
            this.lstbxMembers.TabIndex = 79;
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
            // cmbUpdateSevere
            // 
            this.cmbUpdateSevere.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateSevere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.cmbUpdateSevere.FormattingEnabled = true;
            this.cmbUpdateSevere.Location = new System.Drawing.Point(740, 67);
            this.cmbUpdateSevere.Name = "cmbUpdateSevere";
            this.cmbUpdateSevere.Size = new System.Drawing.Size(128, 23);
            this.cmbUpdateSevere.TabIndex = 77;
            this.cmbUpdateSevere.DropDown += new System.EventHandler(this.CmbUpdateSevere_DropDown);
            this.cmbUpdateSevere.SelectedIndexChanged += new System.EventHandler(this.CmbUpdateSevere_SelectedIndexChanged);
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label5.ImageKey = "(none)";
            this.label5.Location = new System.Drawing.Point(174, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "Users Assigned";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel1.Location = new System.Drawing.Point(35, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 159);
            this.panel1.TabIndex = 68;
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
            this.BtnUpdateBugDescp.Click += new System.EventHandler(this.BtnUpdateBugDescp_Click);
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
            // txtBugDescription
            // 
            this.txtBugDescription.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBugDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtBugDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtBugDescription.Location = new System.Drawing.Point(17, 54);
            this.txtBugDescription.Multiline = true;
            this.txtBugDescription.Name = "txtBugDescription";
            this.txtBugDescription.ReadOnly = true;
            this.txtBugDescription.Size = new System.Drawing.Size(850, 91);
            this.txtBugDescription.TabIndex = 67;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.cmbBugState);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(35, 88);
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
            // lblProjectForBugPnl
            // 
            this.lblProjectForBugPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectForBugPnl.AutoSize = true;
            this.lblProjectForBugPnl.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectForBugPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblProjectForBugPnl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProjectForBugPnl.ImageIndex = 1;
            this.lblProjectForBugPnl.Location = new System.Drawing.Point(132, 44);
            this.lblProjectForBugPnl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblProjectForBugPnl.Name = "lblProjectForBugPnl";
            this.lblProjectForBugPnl.Size = new System.Drawing.Size(121, 22);
            this.lblProjectForBugPnl.TabIndex = 17;
            this.lblProjectForBugPnl.Text = "     ProjectTitle";
            this.lblProjectForBugPnl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(12, 44);
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
            this.lblBugTitle.Location = new System.Drawing.Point(12, 12);
            this.lblBugTitle.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblBugTitle.Name = "lblBugTitle";
            this.lblBugTitle.Size = new System.Drawing.Size(99, 28);
            this.lblBugTitle.TabIndex = 16;
            this.lblBugTitle.Text = "BugTitle";
            // 
            // BtnAddMemberToBug
            // 
            this.BtnAddMemberToBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddMemberToBug.Image = global::Presentation.Properties.Resources.arrow_right;
            this.BtnAddMemberToBug.Location = new System.Drawing.Point(149, 122);
            this.BtnAddMemberToBug.Name = "BtnAddMemberToBug";
            this.BtnAddMemberToBug.Size = new System.Drawing.Size(16, 16);
            this.BtnAddMemberToBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAddMemberToBug.TabIndex = 84;
            this.BtnAddMemberToBug.TabStop = false;
            this.BtnAddMemberToBug.Click += new System.EventHandler(this.BtnAddMemberToBug_Click);
            // 
            // BtnRemoveMember
            // 
            this.BtnRemoveMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveMember.Image = global::Presentation.Properties.Resources.left_arrow;
            this.BtnRemoveMember.Location = new System.Drawing.Point(149, 100);
            this.BtnRemoveMember.Name = "BtnRemoveMember";
            this.BtnRemoveMember.Size = new System.Drawing.Size(16, 16);
            this.BtnRemoveMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRemoveMember.TabIndex = 83;
            this.BtnRemoveMember.TabStop = false;
            this.BtnRemoveMember.Click += new System.EventHandler(this.BtnRemoveMember_Click);
            // 
            // BtnUpdateMembers
            // 
            this.BtnUpdateMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateMembers.Image = global::Presentation.Properties.Resources._checked;
            this.BtnUpdateMembers.Location = new System.Drawing.Point(304, 159);
            this.BtnUpdateMembers.Name = "BtnUpdateMembers";
            this.BtnUpdateMembers.Size = new System.Drawing.Size(16, 16);
            this.BtnUpdateMembers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnUpdateMembers.TabIndex = 82;
            this.BtnUpdateMembers.TabStop = false;
            this.BtnUpdateMembers.Visible = false;
            this.BtnUpdateMembers.Click += new System.EventHandler(this.BtnUpdateMembers_Click);
            // 
            // BtnCnlEditMembers
            // 
            this.BtnCnlEditMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCnlEditMembers.Image = global::Presentation.Properties.Resources.cancel;
            this.BtnCnlEditMembers.Location = new System.Drawing.Point(304, 137);
            this.BtnCnlEditMembers.Name = "BtnCnlEditMembers";
            this.BtnCnlEditMembers.Size = new System.Drawing.Size(16, 16);
            this.BtnCnlEditMembers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCnlEditMembers.TabIndex = 81;
            this.BtnCnlEditMembers.TabStop = false;
            this.BtnCnlEditMembers.Visible = false;
            this.BtnCnlEditMembers.Click += new System.EventHandler(this.BtnCnlEditMembers_Click);
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
            this.BtnCloseBugDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCloseBugDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseBugDetails.Image = global::Presentation.Properties.Resources.cerrar1;
            this.BtnCloseBugDetails.Location = new System.Drawing.Point(904, 11);
            this.BtnCloseBugDetails.Name = "BtnCloseBugDetails";
            this.BtnCloseBugDetails.Size = new System.Drawing.Size(16, 16);
            this.BtnCloseBugDetails.TabIndex = 19;
            this.BtnCloseBugDetails.TabStop = false;
            this.BtnCloseBugDetails.Click += new System.EventHandler(this.BtnCloseBugDetails_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Presentation.Properties.Resources.cerrar1;
            this.BtnClose.Location = new System.Drawing.Point(1062, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmBugsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.pnlBugDetails);
            this.Controls.Add(this.lblBugs);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBugsList";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmBugsList_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.pnlBugDetails.ResumeLayout(false);
            this.pnlBugDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddMemberToBug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRemoveMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUpdateMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCnlEditMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditBugDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseBugDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblBugs;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Button BtnAddBug;
        private System.Windows.Forms.Panel pnlBugDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox BtnAddMemberToBug;
        private System.Windows.Forms.PictureBox BtnRemoveMember;
        private System.Windows.Forms.PictureBox BtnUpdateMembers;
        private System.Windows.Forms.PictureBox BtnCnlEditMembers;
        private System.Windows.Forms.ListBox lstbxUsersAssigned;
        private System.Windows.Forms.ListBox lstbxMembers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUpdateSevere;
        private System.Windows.Forms.TextBox txtModifiedAt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCreatedAt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModifiedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnUpdateBugDescp;
        private System.Windows.Forms.Button BtnCnlUptDescpBug;
        private System.Windows.Forms.PictureBox BtnEditBugDescription;
        private System.Windows.Forms.TextBox txtBugDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnCloseBugDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBugState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjectForBugPnl;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblBugTitle;
    }
}