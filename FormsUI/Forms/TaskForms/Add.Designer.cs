
namespace FormsUI.Forms.TaskForms
{
    partial class Add
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblDetail = new System.Windows.Forms.Label();
            this.tbxDetail = new System.Windows.Forms.TextBox();
            this.lblStateId = new System.Windows.Forms.Label();
            this.tbxStateId = new System.Windows.Forms.TextBox();
            this.panelTaskAdd = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(45, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxTitle.Location = new System.Drawing.Point(170, 39);
            this.tbxTitle.Multiline = true;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(322, 51);
            this.tbxTitle.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOk.Location = new System.Drawing.Point(239, 337);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 47);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(382, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 47);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeadline.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDeadline.Location = new System.Drawing.Point(45, 220);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(98, 26);
            this.lblDeadline.TabIndex = 4;
            this.lblDeadline.Text = "Deadline";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDeadline.Location = new System.Drawing.Point(170, 220);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(322, 26);
            this.dtpDeadline.TabIndex = 5;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetail.Location = new System.Drawing.Point(45, 124);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(68, 26);
            this.lblDetail.TabIndex = 6;
            this.lblDetail.Text = "Detail";
            // 
            // tbxDetail
            // 
            this.tbxDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxDetail.Location = new System.Drawing.Point(170, 121);
            this.tbxDetail.Multiline = true;
            this.tbxDetail.Name = "tbxDetail";
            this.tbxDetail.Size = new System.Drawing.Size(322, 86);
            this.tbxDetail.TabIndex = 7;
            // 
            // lblStateId
            // 
            this.lblStateId.AutoSize = true;
            this.lblStateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStateId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStateId.Location = new System.Drawing.Point(45, 272);
            this.lblStateId.Name = "lblStateId";
            this.lblStateId.Size = new System.Drawing.Size(87, 26);
            this.lblStateId.TabIndex = 8;
            this.lblStateId.Text = "State Id";
            // 
            // tbxStateId
            // 
            this.tbxStateId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStateId.Location = new System.Drawing.Point(170, 277);
            this.tbxStateId.Name = "tbxStateId";
            this.tbxStateId.Size = new System.Drawing.Size(322, 22);
            this.tbxStateId.TabIndex = 9;
            // 
            // panelTaskAdd
            // 
            this.panelTaskAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTaskAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskAdd.Location = new System.Drawing.Point(0, 0);
            this.panelTaskAdd.Name = "panelTaskAdd";
            this.panelTaskAdd.Size = new System.Drawing.Size(526, 23);
            this.panelTaskAdd.TabIndex = 21;
            this.panelTaskAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTaskAdd_MouseDown);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(526, 390);
            this.Controls.Add(this.panelTaskAdd);
            this.Controls.Add(this.tbxStateId);
            this.Controls.Add(this.lblStateId);
            this.Controls.Add(this.tbxDetail);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(526, 390);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TextBox tbxDetail;
        private System.Windows.Forms.Label lblStateId;
        private System.Windows.Forms.TextBox tbxStateId;
        private System.Windows.Forms.Panel panelTaskAdd;
    }
}