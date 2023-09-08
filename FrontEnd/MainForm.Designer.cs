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
            this.EMainForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaButton();
            this.PMain = new Guna.UI.WinForms.GunaPanel();
            this.pDrag = new Guna.UI.WinForms.GunaPanel();
            this.btnSettings = new Guna.UI.WinForms.GunaButton();
            this.btnMetrics = new Guna.UI.WinForms.GunaButton();
            this.btnAllTasks = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblDateNow = new Guna.UI.WinForms.GunaLabel();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.gMain = new System.Windows.Forms.DataGridView();
            this.rzMainForm = new Guna.UI.WinForms.GunaResize(this.components);
            this.dcPDrag = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pDrag2 = new Guna.UI.WinForms.GunaPanel();
            this.dcPDrag2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentViewBindingSource)).BeginInit();
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
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.btnMinimize.BaseColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimize.ImageSize = new System.Drawing.Size(20, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // PMain
            // 
            this.PMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.PMain.Controls.Add(this.pDrag);
            this.PMain.Controls.Add(this.btnSettings);
            this.PMain.Controls.Add(this.btnMetrics);
            this.PMain.Controls.Add(this.btnAllTasks);
            this.PMain.Controls.Add(this.gunaPictureBox1);
            this.PMain.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PMain, "PMain");
            this.PMain.Name = "PMain";
            // 
            // pDrag
            // 
            this.pDrag.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pDrag, "pDrag");
            this.pDrag.Name = "pDrag";
            // 
            // btnSettings
            // 
            this.btnSettings.AnimationHoverSpeed = 0.07F;
            this.btnSettings.AnimationSpeed = 0.03F;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnSettings.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSettings.Image = null;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.ImageSize = new System.Drawing.Size(20, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnSettings.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSettings.OnHoverImage = null;
            this.btnSettings.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMetrics
            // 
            this.btnMetrics.AnimationHoverSpeed = 0.07F;
            this.btnMetrics.AnimationSpeed = 0.03F;
            this.btnMetrics.BackColor = System.Drawing.Color.Transparent;
            this.btnMetrics.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnMetrics.BorderColor = System.Drawing.Color.Transparent;
            this.btnMetrics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMetrics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMetrics.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnMetrics, "btnMetrics");
            this.btnMetrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnMetrics.Image = null;
            this.btnMetrics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMetrics.ImageSize = new System.Drawing.Size(20, 5);
            this.btnMetrics.Name = "btnMetrics";
            this.btnMetrics.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnMetrics.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMetrics.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnMetrics.OnHoverImage = null;
            this.btnMetrics.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnMetrics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.AnimationHoverSpeed = 0.07F;
            this.btnAllTasks.AnimationSpeed = 0.03F;
            this.btnAllTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAllTasks.BorderColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllTasks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAllTasks.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnAllTasks, "btnAllTasks");
            this.btnAllTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAllTasks.Image = null;
            this.btnAllTasks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAllTasks.ImageSize = new System.Drawing.Size(20, 5);
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAllTasks.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAllTasks.OnHoverImage = null;
            this.btnAllTasks.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnAllTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            resources.ApplyResources(this.gunaPictureBox1, "gunaPictureBox1");
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblDateNow
            // 
            resources.ApplyResources(this.lblDateNow, "lblDateNow");
            this.lblDateNow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDateNow.ForeColor = System.Drawing.Color.Black;
            this.lblDateNow.Name = "lblDateNow";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 1F;
            this.btnAdd.AnimationSpeed = 1F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAdd.Image = null;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gMain
            // 
            this.gMain.AutoGenerateColumns = false;
            this.gMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn});
            this.gMain.DataSource = this.currentViewBindingSource;
            resources.ApplyResources(this.gMain, "gMain");
            this.gMain.Name = "gMain";
            // 
            // rzMainForm
            // 
            this.rzMainForm.TargetForm = this;
            // 
            // dcPDrag
            // 
            this.dcPDrag.TargetControl = this.pDrag;
            // 
            // pDrag2
            // 
            this.pDrag2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pDrag2, "pDrag2");
            this.pDrag2.Name = "pDrag2";
            // 
            // dcPDrag2
            // 
            this.dcPDrag2.TargetControl = this.pDrag2;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // currentViewBindingSource
            // 
            this.currentViewBindingSource.DataSource = typeof(Models.CurrentView);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pDrag2);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gMain);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.PMain);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentViewBindingSource)).EndInit();
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
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.DataGridView gMain;
        private Guna.UI.WinForms.GunaResize rzMainForm;
        private Guna.UI.WinForms.GunaDragControl dcPDrag;
        private Guna.UI.WinForms.GunaPanel pDrag;
        private Guna.UI.WinForms.GunaPanel pDrag2;
        private Guna.UI.WinForms.GunaDragControl dcPDrag2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource currentViewBindingSource;
    }
}

