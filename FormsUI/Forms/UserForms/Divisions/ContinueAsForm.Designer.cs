
namespace FormsUI.Forms.UserForms.Divisions
{
    partial class ContinueAsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContinueAsForm));
            this.lblContinueAs = new System.Windows.Forms.Label();
            this.btnContinue = new FontAwesome.Sharp.IconButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.panelContinueAs = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.cmbUserType = new FormsUI.UserControls.HwtComboBox();
            this.cmbGender = new FormsUI.UserControls.HwtComboBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.lblAdminInformation = new System.Windows.Forms.Label();
            this.dtpGraduateDate = new System.Windows.Forms.DateTimePicker();
            this.panelContinueAs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContinueAs
            // 
            this.lblContinueAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContinueAs.BackColor = System.Drawing.Color.Transparent;
            this.lblContinueAs.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContinueAs.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContinueAs.Location = new System.Drawing.Point(12, 40);
            this.lblContinueAs.Name = "lblContinueAs";
            this.lblContinueAs.Size = new System.Drawing.Size(451, 110);
            this.lblContinueAs.TabIndex = 1;
            this.lblContinueAs.Text = "Complete account";
            this.lblContinueAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContinue.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnContinue.IconColor = System.Drawing.Color.Gainsboro;
            this.btnContinue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContinue.IconSize = 50;
            this.btnContinue.Location = new System.Drawing.Point(383, 249);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(80, 63);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGender.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGender.Location = new System.Drawing.Point(83, 175);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(75, 29);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContinueAs
            // 
            this.panelContinueAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelContinueAs.Controls.Add(this.btnClose);
            this.panelContinueAs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContinueAs.Location = new System.Drawing.Point(0, 0);
            this.panelContinueAs.Name = "panelContinueAs";
            this.panelContinueAs.Size = new System.Drawing.Size(475, 37);
            this.panelContinueAs.TabIndex = 6;
            this.panelContinueAs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContinueAs_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DimGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(449, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUserType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbUserType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cmbUserType.BorderSize = 1;
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbUserType.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbUserType.ForeColor = System.Drawing.Color.DimGray;
            this.cmbUserType.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbUserType.Items.AddRange(new object[] {
            "",
            "Graduate",
            "Studying",
            "Admin"});
            this.cmbUserType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbUserType.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbUserType.Location = new System.Drawing.Point(190, 241);
            this.cmbUserType.MinimumSize = new System.Drawing.Size(100, 30);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Padding = new System.Windows.Forms.Padding(1);
            this.cmbUserType.Size = new System.Drawing.Size(131, 30);
            this.cmbUserType.TabIndex = 5;
            this.cmbUserType.Texts = "";
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cmbGender.BorderSize = 1;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGender.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGender.ForeColor = System.Drawing.Color.DimGray;
            this.cmbGender.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cmbGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbGender.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbGender.Location = new System.Drawing.Point(190, 174);
            this.cmbGender.MinimumSize = new System.Drawing.Size(100, 30);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Padding = new System.Windows.Forms.Padding(1);
            this.cmbGender.Size = new System.Drawing.Size(131, 30);
            this.cmbGender.TabIndex = 4;
            this.cmbGender.Texts = "";
            // 
            // tbxCode
            // 
            this.tbxCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCode.Location = new System.Drawing.Point(192, 177);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(100, 26);
            this.tbxCode.TabIndex = 7;
            // 
            // lblAdminInformation
            // 
            this.lblAdminInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminInformation.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdminInformation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAdminInformation.Location = new System.Drawing.Point(67, 249);
            this.lblAdminInformation.Name = "lblAdminInformation";
            this.lblAdminInformation.Size = new System.Drawing.Size(287, 49);
            this.lblAdminInformation.TabIndex = 8;
            this.lblAdminInformation.Text = "Contact with system administrators for code and to continue as admin.";
            this.lblAdminInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpGraduateDate
            // 
            this.dtpGraduateDate.Location = new System.Drawing.Point(192, 180);
            this.dtpGraduateDate.Name = "dtpGraduateDate";
            this.dtpGraduateDate.Size = new System.Drawing.Size(200, 22);
            this.dtpGraduateDate.TabIndex = 9;
            // 
            // ContinueAsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(475, 324);
            this.Controls.Add(this.dtpGraduateDate);
            this.Controls.Add(this.lblAdminInformation);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.panelContinueAs);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblContinueAs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContinueAsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContinueAsForm";
            this.Load += new System.EventHandler(this.ContinueAsForm_Load);
            this.panelContinueAs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContinueAs;
        private FontAwesome.Sharp.IconButton btnContinue;
        private System.Windows.Forms.Label lblGender;
        private UserControls.HwtComboBox cmbGender;
        private UserControls.HwtComboBox cmbUserType;
        private System.Windows.Forms.Panel panelContinueAs;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label lblAdminInformation;
        private System.Windows.Forms.DateTimePicker dtpGraduateDate;
    }
}