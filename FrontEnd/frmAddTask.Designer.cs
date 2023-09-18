namespace FrontEnd
{
    partial class frmAddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTask));
            this.lblDateNow = new Guna.UI.WinForms.GunaLabel();
            this.lblDescription = new Guna.UI.WinForms.GunaLabel();
            this.lblArea = new Guna.UI.WinForms.GunaLabel();
            this.efrmAddTask = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnAddArea = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.rfrmAddTask = new Guna.UI.WinForms.GunaResize(this.components);
            this.pDrag = new Guna.UI.WinForms.GunaPanel();
            this.btnMinimize = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbDescription = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDateNow.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNow.ForeColor = System.Drawing.Color.Black;
            this.lblDateNow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDateNow.Location = new System.Drawing.Point(178, 44);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(123, 27);
            this.lblDateNow.TabIndex = 0;
            this.lblDateNow.Text = "Add Task";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDescription.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescription.Location = new System.Drawing.Point(31, 98);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 20);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblArea.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.Black;
            this.lblArea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblArea.Location = new System.Drawing.Point(31, 155);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(49, 20);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area";
            // 
            // efrmAddTask
            // 
            this.efrmAddTask.TargetControl = this;
            // 
            // btnAddArea
            // 
            this.btnAddArea.AnimationHoverSpeed = 1F;
            this.btnAddArea.AnimationSpeed = 1F;
            this.btnAddArea.BackColor = System.Drawing.Color.Transparent;
            this.btnAddArea.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAddArea.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddArea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddArea.FocusedColor = System.Drawing.Color.Transparent;
            this.btnAddArea.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F);
            this.btnAddArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAddArea.Image = null;
            this.btnAddArea.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddArea.ImageSize = new System.Drawing.Size(20, 5);
            this.btnAddArea.Location = new System.Drawing.Point(340, 154);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAddArea.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddArea.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAddArea.OnHoverImage = null;
            this.btnAddArea.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnAddArea.Size = new System.Drawing.Size(111, 23);
            this.btnAddArea.TabIndex = 0;
            this.btnAddArea.Text = "Add Area";
            this.btnAddArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 1F;
            this.btnSave.AnimationSpeed = 1F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 5);
            this.btnSave.Location = new System.Drawing.Point(189, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnSave.Size = new System.Drawing.Size(111, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rfrmAddTask
            // 
            this.rfrmAddTask.TargetForm = this;
            // 
            // pDrag
            // 
            this.pDrag.BackColor = System.Drawing.Color.Transparent;
            this.pDrag.ForeColor = System.Drawing.Color.Transparent;
            this.pDrag.Location = new System.Drawing.Point(0, 12);
            this.pDrag.Name = "pDrag";
            this.pDrag.Size = new System.Drawing.Size(411, 13);
            this.pDrag.TabIndex = 4;
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
            this.btnMinimize.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimize.ImageSize = new System.Drawing.Size(20, 5);
            this.btnMinimize.Location = new System.Drawing.Point(411, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnExit.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(451, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.pDrag;
            // 
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.cbArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbArea.Font = new System.Drawing.Font("Lucida Handwriting", 9F);
            this.cbArea.ForeColor = System.Drawing.Color.Black;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(155, 155);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(160, 24);
            this.cbArea.TabIndex = 2;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // cbDescription
            // 
            this.cbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.cbDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDescription.Font = new System.Drawing.Font("Lucida Handwriting", 9F);
            this.cbDescription.ForeColor = System.Drawing.Color.Black;
            this.cbDescription.FormattingEnabled = true;
            this.cbDescription.Location = new System.Drawing.Point(155, 98);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(160, 24);
            this.cbDescription.TabIndex = 1;
            // 
            // frmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(492, 254);
            this.Controls.Add(this.cbDescription);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pDrag);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDateNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblDateNow;
        private Guna.UI.WinForms.GunaLabel lblDescription;
        private Guna.UI.WinForms.GunaLabel lblArea;
        private Guna.UI.WinForms.GunaElipse efrmAddTask;
        private Guna.UI.WinForms.GunaPanel pDrag;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnAddArea;
        private Guna.UI.WinForms.GunaResize rfrmAddTask;
        private Guna.UI.WinForms.GunaButton btnMinimize;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbDescription;
    }
}