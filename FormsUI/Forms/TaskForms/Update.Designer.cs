
namespace FormsUI.Forms.TaskForms
{
    partial class Update
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
            this.tbxStateId = new System.Windows.Forms.TextBox();
            this.lblStateId = new System.Windows.Forms.Label();
            this.tbxDetail = new System.Windows.Forms.TextBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTaskUpdate = new System.Windows.Forms.Panel();
            this.cbxTaskUpdate = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.panelTaskUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxStateId
            // 
            this.tbxStateId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStateId.Location = new System.Drawing.Point(120, 242);
            this.tbxStateId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxStateId.Name = "tbxStateId";
            this.tbxStateId.Size = new System.Drawing.Size(285, 20);
            this.tbxStateId.TabIndex = 19;
            // 
            // lblStateId
            // 
            this.lblStateId.AutoSize = true;
            this.lblStateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStateId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStateId.Location = new System.Drawing.Point(26, 238);
            this.lblStateId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStateId.Name = "lblStateId";
            this.lblStateId.Size = new System.Drawing.Size(71, 22);
            this.lblStateId.TabIndex = 18;
            this.lblStateId.Text = "State Id";
            // 
            // tbxDetail
            // 
            this.tbxDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxDetail.Location = new System.Drawing.Point(120, 115);
            this.tbxDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDetail.Multiline = true;
            this.tbxDetail.Name = "tbxDetail";
            this.tbxDetail.Size = new System.Drawing.Size(285, 73);
            this.tbxDetail.TabIndex = 17;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetail.Location = new System.Drawing.Point(26, 118);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(56, 22);
            this.lblDetail.TabIndex = 16;
            this.lblDetail.Text = "Detail";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDeadline.Enabled = false;
            this.dtpDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDeadline.Location = new System.Drawing.Point(120, 196);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(285, 23);
            this.dtpDeadline.TabIndex = 15;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeadline.ForeColor = System.Drawing.Color.Gray;
            this.lblDeadline.Location = new System.Drawing.Point(26, 196);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(81, 22);
            this.lblDeadline.TabIndex = 14;
            this.lblDeadline.Text = "Deadline";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(323, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 38);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOk.Location = new System.Drawing.Point(216, 278);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 38);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxTitle.Location = new System.Drawing.Point(120, 49);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxTitle.Multiline = true;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(285, 44);
            this.tbxTitle.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(26, 51);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 22);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            // 
            // panelTaskUpdate
            // 
            this.panelTaskUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTaskUpdate.Controls.Add(this.label);
            this.panelTaskUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskUpdate.Location = new System.Drawing.Point(0, 0);
            this.panelTaskUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTaskUpdate.Name = "panelTaskUpdate";
            this.panelTaskUpdate.Size = new System.Drawing.Size(437, 29);
            this.panelTaskUpdate.TabIndex = 22;
            this.panelTaskUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTaskUpdate_MouseDown);
            // 
            // cbxTaskUpdate
            // 
            this.cbxTaskUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTaskUpdate.AutoSize = true;
            this.cbxTaskUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTaskUpdate.Location = new System.Drawing.Point(409, 188);
            this.cbxTaskUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTaskUpdate.Name = "cbxTaskUpdate";
            this.cbxTaskUpdate.Size = new System.Drawing.Size(15, 14);
            this.cbxTaskUpdate.TabIndex = 23;
            this.cbxTaskUpdate.UseVisualStyleBackColor = true;
            this.cbxTaskUpdate.CheckedChanged += new System.EventHandler(this.cbxTaskUpdate_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.Gainsboro;
            this.label.Location = new System.Drawing.Point(11, 9);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 18);
            this.label.TabIndex = 25;
            this.label.Text = "label";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(437, 319);
            this.Controls.Add(this.cbxTaskUpdate);
            this.Controls.Add(this.panelTaskUpdate);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(394, 317);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.panelTaskUpdate.ResumeLayout(false);
            this.panelTaskUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxStateId;
        private System.Windows.Forms.Label lblStateId;
        private System.Windows.Forms.TextBox tbxDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTaskUpdate;
        private System.Windows.Forms.CheckBox cbxTaskUpdate;
        private System.Windows.Forms.Label label;
    }
}