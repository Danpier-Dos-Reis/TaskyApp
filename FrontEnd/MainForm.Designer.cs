namespace FrontEnd
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EMainForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaButton();
            this.PMain = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnAllTasks = new Guna.UI.WinForms.GunaButton();
            this.btnMetrics = new Guna.UI.WinForms.GunaButton();
            this.btnSettings = new Guna.UI.WinForms.GunaButton();
            this.gAllTasks = new Guna.UI.WinForms.GunaDataGridView();
            this.lblDateNow = new Guna.UI.WinForms.GunaLabel();
            this.PMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAllTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // EMainForm
            // 
            this.EMainForm.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(805, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.btnMinimize.BaseColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimize.ImageSize = new System.Drawing.Size(20, 5);
            this.btnMinimize.Location = new System.Drawing.Point(765, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 0;
            // 
            // PMain
            // 
            this.PMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.PMain.Controls.Add(this.btnSettings);
            this.PMain.Controls.Add(this.btnMetrics);
            this.PMain.Controls.Add(this.btnAllTasks);
            this.PMain.Controls.Add(this.gunaPictureBox1);
            this.PMain.ForeColor = System.Drawing.Color.Transparent;
            this.PMain.Location = new System.Drawing.Point(0, 0);
            this.PMain.Name = "PMain";
            this.PMain.Size = new System.Drawing.Size(231, 487);
            this.PMain.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(58, 25);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.AnimationHoverSpeed = 0.07F;
            this.btnAllTasks.AnimationSpeed = 0.03F;
            this.btnAllTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAllTasks.BaseColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.BorderColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAllTasks.FocusedColor = System.Drawing.Color.Empty;
            this.btnAllTasks.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAllTasks.Image = null;
            this.btnAllTasks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAllTasks.ImageSize = new System.Drawing.Size(20, 5);
            this.btnAllTasks.Location = new System.Drawing.Point(0, 167);
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.OnHoverImage = null;
            this.btnAllTasks.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.Size = new System.Drawing.Size(231, 52);
            this.btnAllTasks.TabIndex = 0;
            this.btnAllTasks.Text = "All Tasks";
            this.btnAllTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMetrics
            // 
            this.btnMetrics.AnimationHoverSpeed = 0.07F;
            this.btnMetrics.AnimationSpeed = 0.03F;
            this.btnMetrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnMetrics.BaseColor = System.Drawing.Color.Transparent;
            this.btnMetrics.BorderColor = System.Drawing.Color.Transparent;
            this.btnMetrics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMetrics.FocusedColor = System.Drawing.Color.Empty;
            this.btnMetrics.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnMetrics.Image = null;
            this.btnMetrics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMetrics.ImageSize = new System.Drawing.Size(20, 5);
            this.btnMetrics.Location = new System.Drawing.Point(0, 228);
            this.btnMetrics.Name = "btnMetrics";
            this.btnMetrics.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnMetrics.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMetrics.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnMetrics.OnHoverImage = null;
            this.btnMetrics.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnMetrics.Size = new System.Drawing.Size(231, 52);
            this.btnMetrics.TabIndex = 0;
            this.btnMetrics.Text = "Metrics";
            this.btnMetrics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSettings
            // 
            this.btnSettings.AnimationHoverSpeed = 0.07F;
            this.btnSettings.AnimationSpeed = 0.03F;
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnSettings.BaseColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.FocusedColor = System.Drawing.Color.Empty;
            this.btnSettings.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSettings.Image = null;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.ImageSize = new System.Drawing.Size(20, 5);
            this.btnSettings.Location = new System.Drawing.Point(0, 289);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnHoverImage = null;
            this.btnSettings.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnSettings.Size = new System.Drawing.Size(231, 52);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gAllTasks
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gAllTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gAllTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gAllTasks.BackgroundColor = System.Drawing.Color.White;
            this.gAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gAllTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gAllTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gAllTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gAllTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gAllTasks.DefaultCellStyle = dataGridViewCellStyle6;
            this.gAllTasks.EnableHeadersVisualStyles = false;
            this.gAllTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.gAllTasks.Location = new System.Drawing.Point(240, 167);
            this.gAllTasks.Name = "gAllTasks";
            this.gAllTasks.RowHeadersVisible = false;
            this.gAllTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gAllTasks.Size = new System.Drawing.Size(595, 194);
            this.gAllTasks.TabIndex = 1;
            this.gAllTasks.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gAllTasks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gAllTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gAllTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gAllTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gAllTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gAllTasks.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gAllTasks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.gAllTasks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gAllTasks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gAllTasks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gAllTasks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gAllTasks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gAllTasks.ThemeStyle.HeaderStyle.Height = 4;
            this.gAllTasks.ThemeStyle.ReadOnly = false;
            this.gAllTasks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gAllTasks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gAllTasks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gAllTasks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Transparent;
            this.gAllTasks.ThemeStyle.RowsStyle.Height = 22;
            this.gAllTasks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gAllTasks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F);
            this.lblDateNow.ForeColor = System.Drawing.Color.Black;
            this.lblDateNow.Location = new System.Drawing.Point(254, 25);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(85, 20);
            this.lblDateNow.TabIndex = 2;
            this.lblDateNow.Text = "DateNow";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(846, 488);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.gAllTasks);
            this.Controls.Add(this.PMain);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAllTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse EMainForm;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaButton btnMinimize;
        private Guna.UI.WinForms.GunaPanel PMain;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnAllTasks;
        private Guna.UI.WinForms.GunaButton btnSettings;
        private Guna.UI.WinForms.GunaButton btnMetrics;
        private Guna.UI.WinForms.GunaLabel lblDateNow;
        private Guna.UI.WinForms.GunaDataGridView gAllTasks;
    }
}

