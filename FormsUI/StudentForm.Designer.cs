
namespace FormsUI
{
    partial class StudentForm
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
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.lblFirstNameAdd = new System.Windows.Forms.Label();
            this.lblLastNameAdd = new System.Windows.Forms.Label();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.tbxFirstNameAdd = new System.Windows.Forms.TextBox();
            this.tbxLastNameAdd = new System.Windows.Forms.TextBox();
            this.tbxGroupIdAdd = new System.Windows.Forms.TextBox();
            this.tbxGroupIdUpdate = new System.Windows.Forms.TextBox();
            this.tbxLastNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.lblGroupIdUpdate = new System.Windows.Forms.Label();
            this.lblLastNameUpdate = new System.Windows.Forms.Label();
            this.lblFirstNameUpdate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStudents
            // 
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Location = new System.Drawing.Point(45, 50);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowHeadersWidth = 51;
            this.dgwStudents.RowTemplate.Height = 24;
            this.dgwStudents.Size = new System.Drawing.Size(1216, 299);
            this.dgwStudents.TabIndex = 0;
            // 
            // gbxCrud
            // 
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.Location = new System.Drawing.Point(45, 401);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(653, 319);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "Crud";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxGroupIdAdd);
            this.gbxAdd.Controls.Add(this.tbxLastNameAdd);
            this.gbxAdd.Controls.Add(this.tbxFirstNameAdd);
            this.gbxAdd.Controls.Add(this.lblGroupId);
            this.gbxAdd.Controls.Add(this.lblLastNameAdd);
            this.gbxAdd.Controls.Add(this.lblFirstNameAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(21, 43);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(296, 259);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxGroupIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxFirstNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblGroupIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblFirstNameUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(338, 43);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(296, 259);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // lblFirstNameAdd
            // 
            this.lblFirstNameAdd.AutoSize = true;
            this.lblFirstNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameAdd.Location = new System.Drawing.Point(19, 48);
            this.lblFirstNameAdd.Name = "lblFirstNameAdd";
            this.lblFirstNameAdd.Size = new System.Drawing.Size(93, 24);
            this.lblFirstNameAdd.TabIndex = 0;
            this.lblFirstNameAdd.Text = "Firstname";
            // 
            // lblLastNameAdd
            // 
            this.lblLastNameAdd.AutoSize = true;
            this.lblLastNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameAdd.Location = new System.Drawing.Point(19, 99);
            this.lblLastNameAdd.Name = "lblLastNameAdd";
            this.lblLastNameAdd.Size = new System.Drawing.Size(91, 24);
            this.lblLastNameAdd.TabIndex = 1;
            this.lblLastNameAdd.Text = "Lastname";
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupId.Location = new System.Drawing.Point(19, 149);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(83, 24);
            this.lblGroupId.TabIndex = 2;
            this.lblGroupId.Text = "Group id";
            // 
            // tbxFirstNameAdd
            // 
            this.tbxFirstNameAdd.Location = new System.Drawing.Point(164, 43);
            this.tbxFirstNameAdd.Name = "tbxFirstNameAdd";
            this.tbxFirstNameAdd.Size = new System.Drawing.Size(126, 30);
            this.tbxFirstNameAdd.TabIndex = 3;
            // 
            // tbxLastNameAdd
            // 
            this.tbxLastNameAdd.Location = new System.Drawing.Point(164, 94);
            this.tbxLastNameAdd.Name = "tbxLastNameAdd";
            this.tbxLastNameAdd.Size = new System.Drawing.Size(126, 30);
            this.tbxLastNameAdd.TabIndex = 4;
            // 
            // tbxGroupIdAdd
            // 
            this.tbxGroupIdAdd.Location = new System.Drawing.Point(164, 144);
            this.tbxGroupIdAdd.Name = "tbxGroupIdAdd";
            this.tbxGroupIdAdd.Size = new System.Drawing.Size(126, 30);
            this.tbxGroupIdAdd.TabIndex = 5;
            // 
            // tbxGroupIdUpdate
            // 
            this.tbxGroupIdUpdate.Location = new System.Drawing.Point(164, 144);
            this.tbxGroupIdUpdate.Name = "tbxGroupIdUpdate";
            this.tbxGroupIdUpdate.Size = new System.Drawing.Size(126, 30);
            this.tbxGroupIdUpdate.TabIndex = 11;
            // 
            // tbxLastNameUpdate
            // 
            this.tbxLastNameUpdate.Location = new System.Drawing.Point(164, 94);
            this.tbxLastNameUpdate.Name = "tbxLastNameUpdate";
            this.tbxLastNameUpdate.Size = new System.Drawing.Size(126, 30);
            this.tbxLastNameUpdate.TabIndex = 10;
            // 
            // tbxFirstNameUpdate
            // 
            this.tbxFirstNameUpdate.Location = new System.Drawing.Point(164, 43);
            this.tbxFirstNameUpdate.Name = "tbxFirstNameUpdate";
            this.tbxFirstNameUpdate.Size = new System.Drawing.Size(126, 30);
            this.tbxFirstNameUpdate.TabIndex = 9;
            // 
            // lblGroupIdUpdate
            // 
            this.lblGroupIdUpdate.AutoSize = true;
            this.lblGroupIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupIdUpdate.Location = new System.Drawing.Point(19, 149);
            this.lblGroupIdUpdate.Name = "lblGroupIdUpdate";
            this.lblGroupIdUpdate.Size = new System.Drawing.Size(83, 24);
            this.lblGroupIdUpdate.TabIndex = 8;
            this.lblGroupIdUpdate.Text = "Group id";
            // 
            // lblLastNameUpdate
            // 
            this.lblLastNameUpdate.AutoSize = true;
            this.lblLastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameUpdate.Location = new System.Drawing.Point(19, 99);
            this.lblLastNameUpdate.Name = "lblLastNameUpdate";
            this.lblLastNameUpdate.Size = new System.Drawing.Size(91, 24);
            this.lblLastNameUpdate.TabIndex = 7;
            this.lblLastNameUpdate.Text = "Lastname";
            // 
            // lblFirstNameUpdate
            // 
            this.lblFirstNameUpdate.AutoSize = true;
            this.lblFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameUpdate.Location = new System.Drawing.Point(19, 48);
            this.lblFirstNameUpdate.Name = "lblFirstNameUpdate";
            this.lblFirstNameUpdate.Size = new System.Drawing.Size(93, 24);
            this.lblFirstNameUpdate.TabIndex = 6;
            this.lblFirstNameUpdate.Text = "Firstname";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(164, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 44);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 44);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 767);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.dgwStudents);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxGroupIdUpdate;
        private System.Windows.Forms.TextBox tbxLastNameUpdate;
        private System.Windows.Forms.TextBox tbxFirstNameUpdate;
        private System.Windows.Forms.Label lblGroupIdUpdate;
        private System.Windows.Forms.Label lblLastNameUpdate;
        private System.Windows.Forms.Label lblFirstNameUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxGroupIdAdd;
        private System.Windows.Forms.TextBox tbxLastNameAdd;
        private System.Windows.Forms.TextBox tbxFirstNameAdd;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblLastNameAdd;
        private System.Windows.Forms.Label lblFirstNameAdd;
    }
}