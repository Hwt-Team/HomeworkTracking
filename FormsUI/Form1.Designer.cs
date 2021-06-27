
namespace FormsUI
{
    partial class Form1
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
            this.dgwStudentExercisesUser = new System.Windows.Forms.DataGridView();
            this.dgwStudentExercisesAdmin = new System.Windows.Forms.DataGridView();
            this.lblUserAppearance = new System.Windows.Forms.Label();
            this.lblAdminAppearance = new System.Windows.Forms.Label();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStudentIdAdd = new System.Windows.Forms.Label();
            this.lblExerciseIdAdd = new System.Windows.Forms.Label();
            this.lblActiveAdd = new System.Windows.Forms.Label();
            this.tbxStudentIdAdd = new System.Windows.Forms.TextBox();
            this.tbxExerciseIdAdd = new System.Windows.Forms.TextBox();
            this.tbxActiveAdd = new System.Windows.Forms.TextBox();
            this.tbxActiveUpdate = new System.Windows.Forms.TextBox();
            this.lblActiveUpdate = new System.Windows.Forms.Label();
            this.tbxExerciseIdUpdate = new System.Windows.Forms.TextBox();
            this.lblStudentIdUpdate = new System.Windows.Forms.Label();
            this.tbxStudentIdUpdate = new System.Windows.Forms.TextBox();
            this.lblExerciseIdUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesAdmin)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStudentExercisesUser
            // 
            this.dgwStudentExercisesUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentExercisesUser.Location = new System.Drawing.Point(22, 36);
            this.dgwStudentExercisesUser.Name = "dgwStudentExercisesUser";
            this.dgwStudentExercisesUser.RowHeadersWidth = 51;
            this.dgwStudentExercisesUser.RowTemplate.Height = 24;
            this.dgwStudentExercisesUser.Size = new System.Drawing.Size(1046, 247);
            this.dgwStudentExercisesUser.TabIndex = 0;
            // 
            // dgwStudentExercisesAdmin
            // 
            this.dgwStudentExercisesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentExercisesAdmin.Location = new System.Drawing.Point(22, 334);
            this.dgwStudentExercisesAdmin.Name = "dgwStudentExercisesAdmin";
            this.dgwStudentExercisesAdmin.RowHeadersWidth = 51;
            this.dgwStudentExercisesAdmin.RowTemplate.Height = 24;
            this.dgwStudentExercisesAdmin.Size = new System.Drawing.Size(1046, 247);
            this.dgwStudentExercisesAdmin.TabIndex = 1;
            // 
            // lblUserAppearance
            // 
            this.lblUserAppearance.AutoSize = true;
            this.lblUserAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserAppearance.Location = new System.Drawing.Point(33, 9);
            this.lblUserAppearance.Name = "lblUserAppearance";
            this.lblUserAppearance.Size = new System.Drawing.Size(169, 24);
            this.lblUserAppearance.TabIndex = 2;
            this.lblUserAppearance.Text = "User Appeareance";
            // 
            // lblAdminAppearance
            // 
            this.lblAdminAppearance.AutoSize = true;
            this.lblAdminAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdminAppearance.Location = new System.Drawing.Point(33, 295);
            this.lblAdminAppearance.Name = "lblAdminAppearance";
            this.lblAdminAppearance.Size = new System.Drawing.Size(174, 24);
            this.lblAdminAppearance.TabIndex = 3;
            this.lblAdminAppearance.Text = "Admin Appearance";
            // 
            // gbxCrud
            // 
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.Location = new System.Drawing.Point(22, 621);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(630, 281);
            this.gbxCrud.TabIndex = 4;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "CRUD";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxActiveAdd);
            this.gbxAdd.Controls.Add(this.lblActiveAdd);
            this.gbxAdd.Controls.Add(this.tbxExerciseIdAdd);
            this.gbxAdd.Controls.Add(this.lblStudentIdAdd);
            this.gbxAdd.Controls.Add(this.tbxStudentIdAdd);
            this.gbxAdd.Controls.Add(this.lblExerciseIdAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(26, 38);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(232, 167);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.tbxActiveUpdate);
            this.gbxUpdate.Controls.Add(this.lblActiveUpdate);
            this.gbxUpdate.Controls.Add(this.tbxExerciseIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblStudentIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStudentIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblExerciseIdUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(346, 38);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(232, 167);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(425, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblStudentIdAdd
            // 
            this.lblStudentIdAdd.AutoSize = true;
            this.lblStudentIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentIdAdd.Location = new System.Drawing.Point(10, 41);
            this.lblStudentIdAdd.Name = "lblStudentIdAdd";
            this.lblStudentIdAdd.Size = new System.Drawing.Size(94, 24);
            this.lblStudentIdAdd.TabIndex = 5;
            this.lblStudentIdAdd.Text = "Student Id";
            // 
            // lblExerciseIdAdd
            // 
            this.lblExerciseIdAdd.AutoSize = true;
            this.lblExerciseIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExerciseIdAdd.Location = new System.Drawing.Point(10, 82);
            this.lblExerciseIdAdd.Name = "lblExerciseIdAdd";
            this.lblExerciseIdAdd.Size = new System.Drawing.Size(104, 24);
            this.lblExerciseIdAdd.TabIndex = 6;
            this.lblExerciseIdAdd.Text = "Exercise Id";
            // 
            // lblActiveAdd
            // 
            this.lblActiveAdd.AutoSize = true;
            this.lblActiveAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveAdd.Location = new System.Drawing.Point(10, 118);
            this.lblActiveAdd.Name = "lblActiveAdd";
            this.lblActiveAdd.Size = new System.Drawing.Size(61, 24);
            this.lblActiveAdd.TabIndex = 7;
            this.lblActiveAdd.Text = "Active";
            // 
            // tbxStudentIdAdd
            // 
            this.tbxStudentIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentIdAdd.Location = new System.Drawing.Point(126, 36);
            this.tbxStudentIdAdd.Name = "tbxStudentIdAdd";
            this.tbxStudentIdAdd.Size = new System.Drawing.Size(100, 28);
            this.tbxStudentIdAdd.TabIndex = 5;
            // 
            // tbxExerciseIdAdd
            // 
            this.tbxExerciseIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExerciseIdAdd.Location = new System.Drawing.Point(126, 77);
            this.tbxExerciseIdAdd.Name = "tbxExerciseIdAdd";
            this.tbxExerciseIdAdd.Size = new System.Drawing.Size(100, 28);
            this.tbxExerciseIdAdd.TabIndex = 6;
            // 
            // tbxActiveAdd
            // 
            this.tbxActiveAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxActiveAdd.Location = new System.Drawing.Point(126, 113);
            this.tbxActiveAdd.Name = "tbxActiveAdd";
            this.tbxActiveAdd.Size = new System.Drawing.Size(100, 28);
            this.tbxActiveAdd.TabIndex = 7;
            // 
            // tbxActiveUpdate
            // 
            this.tbxActiveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxActiveUpdate.Location = new System.Drawing.Point(124, 107);
            this.tbxActiveUpdate.Name = "tbxActiveUpdate";
            this.tbxActiveUpdate.Size = new System.Drawing.Size(100, 28);
            this.tbxActiveUpdate.TabIndex = 12;
            // 
            // lblActiveUpdate
            // 
            this.lblActiveUpdate.AutoSize = true;
            this.lblActiveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveUpdate.Location = new System.Drawing.Point(8, 112);
            this.lblActiveUpdate.Name = "lblActiveUpdate";
            this.lblActiveUpdate.Size = new System.Drawing.Size(61, 24);
            this.lblActiveUpdate.TabIndex = 13;
            this.lblActiveUpdate.Text = "Active";
            // 
            // tbxExerciseIdUpdate
            // 
            this.tbxExerciseIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExerciseIdUpdate.Location = new System.Drawing.Point(124, 71);
            this.tbxExerciseIdUpdate.Name = "tbxExerciseIdUpdate";
            this.tbxExerciseIdUpdate.Size = new System.Drawing.Size(100, 28);
            this.tbxExerciseIdUpdate.TabIndex = 10;
            // 
            // lblStudentIdUpdate
            // 
            this.lblStudentIdUpdate.AutoSize = true;
            this.lblStudentIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentIdUpdate.Location = new System.Drawing.Point(8, 35);
            this.lblStudentIdUpdate.Name = "lblStudentIdUpdate";
            this.lblStudentIdUpdate.Size = new System.Drawing.Size(94, 24);
            this.lblStudentIdUpdate.TabIndex = 8;
            this.lblStudentIdUpdate.Text = "Student Id";
            // 
            // tbxStudentIdUpdate
            // 
            this.tbxStudentIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentIdUpdate.Location = new System.Drawing.Point(124, 30);
            this.tbxStudentIdUpdate.Name = "tbxStudentIdUpdate";
            this.tbxStudentIdUpdate.Size = new System.Drawing.Size(100, 28);
            this.tbxStudentIdUpdate.TabIndex = 9;
            // 
            // lblExerciseIdUpdate
            // 
            this.lblExerciseIdUpdate.AutoSize = true;
            this.lblExerciseIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExerciseIdUpdate.Location = new System.Drawing.Point(8, 76);
            this.lblExerciseIdUpdate.Name = "lblExerciseIdUpdate";
            this.lblExerciseIdUpdate.Size = new System.Drawing.Size(104, 24);
            this.lblExerciseIdUpdate.TabIndex = 11;
            this.lblExerciseIdUpdate.Text = "Exercise Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 932);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.lblAdminAppearance);
            this.Controls.Add(this.lblUserAppearance);
            this.Controls.Add(this.dgwStudentExercisesAdmin);
            this.Controls.Add(this.dgwStudentExercisesUser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesAdmin)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudentExercisesUser;
        private System.Windows.Forms.DataGridView dgwStudentExercisesAdmin;
        private System.Windows.Forms.Label lblUserAppearance;
        private System.Windows.Forms.Label lblAdminAppearance;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox tbxActiveUpdate;
        private System.Windows.Forms.Label lblActiveUpdate;
        private System.Windows.Forms.TextBox tbxExerciseIdUpdate;
        private System.Windows.Forms.Label lblStudentIdUpdate;
        private System.Windows.Forms.TextBox tbxStudentIdUpdate;
        private System.Windows.Forms.Label lblExerciseIdUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxActiveAdd;
        private System.Windows.Forms.Label lblActiveAdd;
        private System.Windows.Forms.TextBox tbxExerciseIdAdd;
        private System.Windows.Forms.Label lblStudentIdAdd;
        private System.Windows.Forms.TextBox tbxStudentIdAdd;
        private System.Windows.Forms.Label lblExerciseIdAdd;
    }
}

