﻿
namespace FormsUI.Forms.StudentExerciseForms
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
            this.tbxExerciseId = new System.Windows.Forms.TextBox();
            this.tbxStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblExerciseId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chbxActive = new System.Windows.Forms.CheckBox();
            this.panelStudentExerciseUpdate = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbxExerciseId
            // 
            this.tbxExerciseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExerciseId.Location = new System.Drawing.Point(218, 102);
            this.tbxExerciseId.Name = "tbxExerciseId";
            this.tbxExerciseId.Size = new System.Drawing.Size(151, 32);
            this.tbxExerciseId.TabIndex = 15;
            // 
            // tbxStudentId
            // 
            this.tbxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentId.Location = new System.Drawing.Point(218, 35);
            this.tbxStudentId.Name = "tbxStudentId";
            this.tbxStudentId.Size = new System.Drawing.Size(151, 32);
            this.tbxStudentId.TabIndex = 14;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStudentId.Location = new System.Drawing.Point(41, 38);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(111, 26);
            this.lblStudentId.TabIndex = 13;
            this.lblStudentId.Text = "Student Id";
            // 
            // lblExerciseId
            // 
            this.lblExerciseId.AutoSize = true;
            this.lblExerciseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExerciseId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblExerciseId.Location = new System.Drawing.Point(41, 105);
            this.lblExerciseId.Name = "lblExerciseId";
            this.lblExerciseId.Size = new System.Drawing.Size(120, 26);
            this.lblExerciseId.TabIndex = 12;
            this.lblExerciseId.Text = "Exercise Id";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(323, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 47);
            this.btnCancel.TabIndex = 11;
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
            this.btnOk.Location = new System.Drawing.Point(180, 211);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 47);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chbxActive
            // 
            this.chbxActive.AutoSize = true;
            this.chbxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.chbxActive.Location = new System.Drawing.Point(218, 158);
            this.chbxActive.Name = "chbxActive";
            this.chbxActive.Size = new System.Drawing.Size(94, 30);
            this.chbxActive.TabIndex = 16;
            this.chbxActive.Text = "Active";
            this.chbxActive.UseVisualStyleBackColor = true;
            // 
            // panelStudentExerciseUpdate
            // 
            this.panelStudentExerciseUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelStudentExerciseUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentExerciseUpdate.Location = new System.Drawing.Point(0, 0);
            this.panelStudentExerciseUpdate.Name = "panelStudentExerciseUpdate";
            this.panelStudentExerciseUpdate.Size = new System.Drawing.Size(475, 23);
            this.panelStudentExerciseUpdate.TabIndex = 17;
            this.panelStudentExerciseUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelStudentExerciseUpdate_MouseDown);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(475, 292);
            this.Controls.Add(this.panelStudentExerciseUpdate);
            this.Controls.Add(this.chbxActive);
            this.Controls.Add(this.tbxExerciseId);
            this.Controls.Add(this.tbxStudentId);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblExerciseId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(475, 292);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxExerciseId;
        private System.Windows.Forms.TextBox tbxStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblExerciseId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chbxActive;
        private System.Windows.Forms.Panel panelStudentExerciseUpdate;
    }
}