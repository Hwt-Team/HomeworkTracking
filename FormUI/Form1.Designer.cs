
namespace FormUI
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
            this.Search = new System.Windows.Forms.GroupBox();
            this.tbxExerciseIdSearch = new System.Windows.Forms.TextBox();
            this.tbxStudentIdSearch = new System.Windows.Forms.TextBox();
            this.tbxIdSearch = new System.Windows.Forms.TextBox();
            this.lblExerciseIdSearch = new System.Windows.Forms.Label();
            this.lblStudentIdSearch = new System.Windows.Forms.Label();
            this.lblIdSearch = new System.Windows.Forms.Label();
            this.chbxActive = new System.Windows.Forms.CheckBox();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.chbxActiveUpdate = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxExerciseIdUpdate = new System.Windows.Forms.TextBox();
            this.lblStudentIdUpdate = new System.Windows.Forms.Label();
            this.tbxStudentIdUpdate = new System.Windows.Forms.TextBox();
            this.lblExerciseIdUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxExerciseIdAdd = new System.Windows.Forms.TextBox();
            this.lblStudentIdAdd = new System.Windows.Forms.Label();
            this.tbxStudentIdAdd = new System.Windows.Forms.TextBox();
            this.lblExerciseIdAdd = new System.Windows.Forms.Label();
            this.lblAdminAppearance = new System.Windows.Forms.Label();
            this.dgwStudentExercisesAdmin = new System.Windows.Forms.DataGridView();
            this.dgwStudentExercisesUser = new System.Windows.Forms.DataGridView();
            this.lblUserAppearance = new System.Windows.Forms.Label();
            this.Search.SuspendLayout();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.tbxExerciseIdSearch);
            this.Search.Controls.Add(this.tbxStudentIdSearch);
            this.Search.Controls.Add(this.tbxIdSearch);
            this.Search.Controls.Add(this.lblExerciseIdSearch);
            this.Search.Controls.Add(this.lblStudentIdSearch);
            this.Search.Controls.Add(this.lblIdSearch);
            this.Search.Controls.Add(this.chbxActive);
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(705, 631);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(330, 281);
            this.Search.TabIndex = 10;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // tbxExerciseIdSearch
            // 
            this.tbxExerciseIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExerciseIdSearch.Location = new System.Drawing.Point(181, 149);
            this.tbxExerciseIdSearch.Name = "tbxExerciseIdSearch";
            this.tbxExerciseIdSearch.Size = new System.Drawing.Size(100, 30);
            this.tbxExerciseIdSearch.TabIndex = 7;
            // 
            // tbxStudentIdSearch
            // 
            this.tbxStudentIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentIdSearch.Location = new System.Drawing.Point(181, 107);
            this.tbxStudentIdSearch.Name = "tbxStudentIdSearch";
            this.tbxStudentIdSearch.Size = new System.Drawing.Size(100, 30);
            this.tbxStudentIdSearch.TabIndex = 6;
            // 
            // tbxIdSearch
            // 
            this.tbxIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxIdSearch.Location = new System.Drawing.Point(181, 55);
            this.tbxIdSearch.Name = "tbxIdSearch";
            this.tbxIdSearch.Size = new System.Drawing.Size(100, 30);
            this.tbxIdSearch.TabIndex = 5;
            // 
            // lblExerciseIdSearch
            // 
            this.lblExerciseIdSearch.AutoSize = true;
            this.lblExerciseIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExerciseIdSearch.Location = new System.Drawing.Point(31, 154);
            this.lblExerciseIdSearch.Name = "lblExerciseIdSearch";
            this.lblExerciseIdSearch.Size = new System.Drawing.Size(108, 25);
            this.lblExerciseIdSearch.TabIndex = 4;
            this.lblExerciseIdSearch.Text = "Exercise Id";
            // 
            // lblStudentIdSearch
            // 
            this.lblStudentIdSearch.AutoSize = true;
            this.lblStudentIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentIdSearch.Location = new System.Drawing.Point(31, 109);
            this.lblStudentIdSearch.Name = "lblStudentIdSearch";
            this.lblStudentIdSearch.Size = new System.Drawing.Size(101, 25);
            this.lblStudentIdSearch.TabIndex = 3;
            this.lblStudentIdSearch.Text = "Student Id";
            // 
            // lblIdSearch
            // 
            this.lblIdSearch.AutoSize = true;
            this.lblIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIdSearch.Location = new System.Drawing.Point(31, 58);
            this.lblIdSearch.Name = "lblIdSearch";
            this.lblIdSearch.Size = new System.Drawing.Size(28, 25);
            this.lblIdSearch.TabIndex = 2;
            this.lblIdSearch.Text = "Id";
            // 
            // chbxActive
            // 
            this.chbxActive.AutoSize = true;
            this.chbxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxActive.Location = new System.Drawing.Point(222, 211);
            this.chbxActive.Name = "chbxActive";
            this.chbxActive.Size = new System.Drawing.Size(88, 29);
            this.chbxActive.TabIndex = 1;
            this.chbxActive.Text = "Active";
            this.chbxActive.UseVisualStyleBackColor = true;
            // 
            // gbxCrud
            // 
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.Location = new System.Drawing.Point(29, 631);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(630, 304);
            this.gbxCrud.TabIndex = 9;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "CRUD";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(439, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.chbxActiveUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxExerciseIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblStudentIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStudentIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblExerciseIdUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(346, 38);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(232, 202);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // chbxActiveUpdate
            // 
            this.chbxActiveUpdate.AutoSize = true;
            this.chbxActiveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxActiveUpdate.Location = new System.Drawing.Point(129, 117);
            this.chbxActiveUpdate.Name = "chbxActiveUpdate";
            this.chbxActiveUpdate.Size = new System.Drawing.Size(83, 28);
            this.chbxActiveUpdate.TabIndex = 15;
            this.chbxActiveUpdate.Text = "Active";
            this.chbxActiveUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
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
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxExerciseIdAdd);
            this.gbxAdd.Controls.Add(this.lblStudentIdAdd);
            this.gbxAdd.Controls.Add(this.tbxStudentIdAdd);
            this.gbxAdd.Controls.Add(this.lblExerciseIdAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(26, 38);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(232, 202);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 45);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbxExerciseIdAdd
            // 
            this.tbxExerciseIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExerciseIdAdd.Location = new System.Drawing.Point(126, 77);
            this.tbxExerciseIdAdd.Name = "tbxExerciseIdAdd";
            this.tbxExerciseIdAdd.Size = new System.Drawing.Size(100, 28);
            this.tbxExerciseIdAdd.TabIndex = 6;
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
            // tbxStudentIdAdd
            // 
            this.tbxStudentIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentIdAdd.Location = new System.Drawing.Point(126, 36);
            this.tbxStudentIdAdd.Name = "tbxStudentIdAdd";
            this.tbxStudentIdAdd.Size = new System.Drawing.Size(100, 28);
            this.tbxStudentIdAdd.TabIndex = 5;
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
            // lblAdminAppearance
            // 
            this.lblAdminAppearance.AutoSize = true;
            this.lblAdminAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdminAppearance.Location = new System.Drawing.Point(40, 305);
            this.lblAdminAppearance.Name = "lblAdminAppearance";
            this.lblAdminAppearance.Size = new System.Drawing.Size(174, 24);
            this.lblAdminAppearance.TabIndex = 8;
            this.lblAdminAppearance.Text = "Admin Appearance";
            // 
            // dgwStudentExercisesAdmin
            // 
            this.dgwStudentExercisesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentExercisesAdmin.Location = new System.Drawing.Point(29, 344);
            this.dgwStudentExercisesAdmin.Name = "dgwStudentExercisesAdmin";
            this.dgwStudentExercisesAdmin.RowHeadersWidth = 51;
            this.dgwStudentExercisesAdmin.RowTemplate.Height = 24;
            this.dgwStudentExercisesAdmin.Size = new System.Drawing.Size(1046, 247);
            this.dgwStudentExercisesAdmin.TabIndex = 7;
            // 
            // dgwStudentExercisesUser
            // 
            this.dgwStudentExercisesUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentExercisesUser.Location = new System.Drawing.Point(29, 46);
            this.dgwStudentExercisesUser.Name = "dgwStudentExercisesUser";
            this.dgwStudentExercisesUser.RowHeadersWidth = 51;
            this.dgwStudentExercisesUser.RowTemplate.Height = 24;
            this.dgwStudentExercisesUser.Size = new System.Drawing.Size(1046, 247);
            this.dgwStudentExercisesUser.TabIndex = 6;
            // 
            // lblUserAppearance
            // 
            this.lblUserAppearance.AutoSize = true;
            this.lblUserAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserAppearance.Location = new System.Drawing.Point(40, 9);
            this.lblUserAppearance.Name = "lblUserAppearance";
            this.lblUserAppearance.Size = new System.Drawing.Size(169, 24);
            this.lblUserAppearance.TabIndex = 11;
            this.lblUserAppearance.Text = "User Appeareance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 959);
            this.Controls.Add(this.lblUserAppearance);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.lblAdminAppearance);
            this.Controls.Add(this.dgwStudentExercisesAdmin);
            this.Controls.Add(this.dgwStudentExercisesUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.gbxCrud.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.TextBox tbxExerciseIdSearch;
        private System.Windows.Forms.TextBox tbxStudentIdSearch;
        private System.Windows.Forms.TextBox tbxIdSearch;
        private System.Windows.Forms.Label lblExerciseIdSearch;
        private System.Windows.Forms.Label lblStudentIdSearch;
        private System.Windows.Forms.Label lblIdSearch;
        private System.Windows.Forms.CheckBox chbxActive;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.CheckBox chbxActiveUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxExerciseIdUpdate;
        private System.Windows.Forms.Label lblStudentIdUpdate;
        private System.Windows.Forms.TextBox tbxStudentIdUpdate;
        private System.Windows.Forms.Label lblExerciseIdUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxExerciseIdAdd;
        private System.Windows.Forms.Label lblStudentIdAdd;
        private System.Windows.Forms.TextBox tbxStudentIdAdd;
        private System.Windows.Forms.Label lblExerciseIdAdd;
        private System.Windows.Forms.Label lblAdminAppearance;
        private System.Windows.Forms.DataGridView dgwStudentExercisesAdmin;
        private System.Windows.Forms.DataGridView dgwStudentExercisesUser;
        private System.Windows.Forms.Label lblUserAppearance;
    }
}

