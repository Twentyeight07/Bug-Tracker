namespace Presentation
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chtStateOfBugs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtWeekSummary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlExpiredBugs = new System.Windows.Forms.Panel();
            this.dgvExpiredBugs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtStateOfBugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtWeekSummary)).BeginInit();
            this.pnlExpiredBugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiredBugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // chtStateOfBugs
            // 
            this.chtStateOfBugs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chtStateOfBugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.chtStateOfBugs.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chtStateOfBugs.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.chtStateOfBugs.ChartAreas.Add(chartArea7);
            legend7.Alignment = System.Drawing.StringAlignment.Center;
            legend7.BackColor = System.Drawing.Color.Transparent;
            legend7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.chtStateOfBugs.Legends.Add(legend7);
            this.chtStateOfBugs.Location = new System.Drawing.Point(606, 27);
            this.chtStateOfBugs.Name = "chtStateOfBugs";
            series7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Color = System.Drawing.Color.Black;
            series7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.IsValueShownAsLabel = true;
            series7.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chtStateOfBugs.Series.Add(series7);
            this.chtStateOfBugs.Size = new System.Drawing.Size(465, 278);
            this.chtStateOfBugs.TabIndex = 0;
            title7.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            title7.Name = "Title1";
            title7.Text = "State of Bugs";
            this.chtStateOfBugs.Titles.Add(title7);
            // 
            // chtWeekSummary
            // 
            this.chtWeekSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.chtWeekSummary.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea8.AxisX.IsLabelAutoFit = false;
            chartArea8.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            chartArea8.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            chartArea8.AxisX.MajorGrid.LineWidth = 0;
            chartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            chartArea8.AxisX.MajorTickMark.LineWidth = 2;
            chartArea8.AxisX.MajorTickMark.Size = 2F;
            chartArea8.AxisX.TitleFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisY.IsLabelAutoFit = false;
            chartArea8.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            chartArea8.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            chartArea8.AxisY.MajorTickMark.LineWidth = 2;
            chartArea8.AxisY.MajorTickMark.Size = 2F;
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.chtWeekSummary.ChartAreas.Add(chartArea8);
            legend8.Alignment = System.Drawing.StringAlignment.Center;
            legend8.BackColor = System.Drawing.Color.Transparent;
            legend8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            legend8.HeaderSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            legend8.IsTextAutoFit = false;
            legend8.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            legend8.Name = "Legend1";
            legend8.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            legend8.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.chtWeekSummary.Legends.Add(legend8);
            this.chtWeekSummary.Location = new System.Drawing.Point(41, 27);
            this.chtWeekSummary.Name = "chtWeekSummary";
            series8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series8.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            series8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            series8.Legend = "Legend1";
            series8.Name = "Bugs";
            this.chtWeekSummary.Series.Add(series8);
            this.chtWeekSummary.Size = new System.Drawing.Size(528, 278);
            this.chtWeekSummary.TabIndex = 1;
            title8.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            title8.Name = "Title1";
            title8.Text = "Last 7 days";
            this.chtWeekSummary.Titles.Add(title8);
            // 
            // pnlExpiredBugs
            // 
            this.pnlExpiredBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExpiredBugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.pnlExpiredBugs.Controls.Add(this.label1);
            this.pnlExpiredBugs.Controls.Add(this.dgvExpiredBugs);
            this.pnlExpiredBugs.Location = new System.Drawing.Point(41, 337);
            this.pnlExpiredBugs.Name = "pnlExpiredBugs";
            this.pnlExpiredBugs.Size = new System.Drawing.Size(1030, 245);
            this.pnlExpiredBugs.TabIndex = 2;
            // 
            // dgvExpiredBugs
            // 
            this.dgvExpiredBugs.AllowUserToAddRows = false;
            this.dgvExpiredBugs.AllowUserToDeleteRows = false;
            this.dgvExpiredBugs.AllowUserToResizeColumns = false;
            this.dgvExpiredBugs.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.dgvExpiredBugs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvExpiredBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpiredBugs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvExpiredBugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpiredBugs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpiredBugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpiredBugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExpiredBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpiredBugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvExpiredBugs.EnableHeadersVisualStyles = false;
            this.dgvExpiredBugs.GridColor = System.Drawing.Color.White;
            this.dgvExpiredBugs.Location = new System.Drawing.Point(0, 45);
            this.dgvExpiredBugs.MultiSelect = false;
            this.dgvExpiredBugs.Name = "dgvExpiredBugs";
            this.dgvExpiredBugs.ReadOnly = true;
            this.dgvExpiredBugs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExpiredBugs.RowHeadersVisible = false;
            this.dgvExpiredBugs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.dgvExpiredBugs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpiredBugs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.dgvExpiredBugs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(104)))), ((int)(((byte)(70)))));
            this.dgvExpiredBugs.RowTemplate.Height = 35;
            this.dgvExpiredBugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpiredBugs.Size = new System.Drawing.Size(1030, 200);
            this.dgvExpiredBugs.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Expired Bugs";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Presentation.Properties.Resources.cerrar1;
            this.BtnClose.Location = new System.Drawing.Point(1074, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pnlExpiredBugs);
            this.Controls.Add(this.chtWeekSummary);
            this.Controls.Add(this.chtStateOfBugs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtStateOfBugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtWeekSummary)).EndInit();
            this.pnlExpiredBugs.ResumeLayout(false);
            this.pnlExpiredBugs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiredBugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtStateOfBugs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtWeekSummary;
        private System.Windows.Forms.Panel pnlExpiredBugs;
        private System.Windows.Forms.DataGridView dgvExpiredBugs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnClose;
    }
}