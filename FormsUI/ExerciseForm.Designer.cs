
namespace FormsUI
{
    partial class ExerciseForm
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
            this.dgwExercises = new System.Windows.Forms.DataGridView();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.dtpDeadlineUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxTitleUpdate = new System.Windows.Forms.TextBox();
            this.lblDeadlineUpdate = new System.Windows.Forms.Label();
            this.lblTitleUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.dtpDeadlineAdd = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxTitleAdd = new System.Windows.Forms.TextBox();
            this.lblDeadLineAdd = new System.Windows.Forms.Label();
            this.lblTitleAdd = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExercises)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwExercises
            // 
            this.dgwExercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExercises.Location = new System.Drawing.Point(32, 74);
            this.dgwExercises.Name = "dgwExercises";
            this.dgwExercises.RowHeadersWidth = 51;
            this.dgwExercises.RowTemplate.Height = 24;
            this.dgwExercises.Size = new System.Drawing.Size(1249, 308);
            this.dgwExercises.TabIndex = 0;
            this.dgwExercises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwExercises_CellClick);
            // 
            // gbxCrud
            // 
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.Location = new System.Drawing.Point(32, 409);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(853, 379);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "Crud";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(691, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 58);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.dtpDeadlineUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxTitleUpdate);
            this.gbxUpdate.Controls.Add(this.lblDeadlineUpdate);
            this.gbxUpdate.Controls.Add(this.lblTitleUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(442, 48);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(388, 261);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // dtpDeadlineUpdate
            // 
            this.dtpDeadlineUpdate.Location = new System.Drawing.Point(147, 113);
            this.dtpDeadlineUpdate.Name = "dtpDeadlineUpdate";
            this.dtpDeadlineUpdate.Size = new System.Drawing.Size(235, 30);
            this.dtpDeadlineUpdate.TabIndex = 7;
            this.dtpDeadlineUpdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDeadlineUpdate_KeyDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(176, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 44);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxTitleUpdate
            // 
            this.tbxTitleUpdate.Location = new System.Drawing.Point(176, 46);
            this.tbxTitleUpdate.Name = "tbxTitleUpdate";
            this.tbxTitleUpdate.Size = new System.Drawing.Size(104, 30);
            this.tbxTitleUpdate.TabIndex = 5;
            // 
            // lblDeadlineUpdate
            // 
            this.lblDeadlineUpdate.AutoSize = true;
            this.lblDeadlineUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeadlineUpdate.Location = new System.Drawing.Point(28, 113);
            this.lblDeadlineUpdate.Name = "lblDeadlineUpdate";
            this.lblDeadlineUpdate.Size = new System.Drawing.Size(95, 24);
            this.lblDeadlineUpdate.TabIndex = 4;
            this.lblDeadlineUpdate.Text = "Deadline :";
            // 
            // lblTitleUpdate
            // 
            this.lblTitleUpdate.AutoSize = true;
            this.lblTitleUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleUpdate.Location = new System.Drawing.Point(28, 51);
            this.lblTitleUpdate.Name = "lblTitleUpdate";
            this.lblTitleUpdate.Size = new System.Drawing.Size(45, 24);
            this.lblTitleUpdate.TabIndex = 3;
            this.lblTitleUpdate.Text = "Title";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.dtpDeadlineAdd);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxTitleAdd);
            this.gbxAdd.Controls.Add(this.lblDeadLineAdd);
            this.gbxAdd.Controls.Add(this.lblTitleAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(22, 48);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(379, 261);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // dtpDeadlineAdd
            // 
            this.dtpDeadlineAdd.Location = new System.Drawing.Point(125, 113);
            this.dtpDeadlineAdd.Name = "dtpDeadlineAdd";
            this.dtpDeadlineAdd.Size = new System.Drawing.Size(248, 30);
            this.dtpDeadlineAdd.TabIndex = 4;
            this.dtpDeadlineAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDeadlineAdd_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxTitleAdd
            // 
            this.tbxTitleAdd.Location = new System.Drawing.Point(172, 46);
            this.tbxTitleAdd.Name = "tbxTitleAdd";
            this.tbxTitleAdd.Size = new System.Drawing.Size(104, 30);
            this.tbxTitleAdd.TabIndex = 2;
            // 
            // lblDeadLineAdd
            // 
            this.lblDeadLineAdd.AutoSize = true;
            this.lblDeadLineAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeadLineAdd.Location = new System.Drawing.Point(24, 113);
            this.lblDeadLineAdd.Name = "lblDeadLineAdd";
            this.lblDeadLineAdd.Size = new System.Drawing.Size(95, 24);
            this.lblDeadLineAdd.TabIndex = 1;
            this.lblDeadLineAdd.Text = "Deadline :";
            // 
            // lblTitleAdd
            // 
            this.lblTitleAdd.AutoSize = true;
            this.lblTitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleAdd.Location = new System.Drawing.Point(24, 51);
            this.lblTitleAdd.Name = "lblTitleAdd";
            this.lblTitleAdd.Size = new System.Drawing.Size(45, 24);
            this.lblTitleAdd.TabIndex = 0;
            this.lblTitleAdd.Text = "Title";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 39);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 832);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.dgwExercises);
            this.Name = "ExerciseForm";
            this.Text = "ExerciseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExerciseForm_FormClosing);
            this.Load += new System.EventHandler(this.ExerciseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwExercises)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwExercises;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.DateTimePicker dtpDeadlineUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxTitleUpdate;
        private System.Windows.Forms.Label lblDeadlineUpdate;
        private System.Windows.Forms.Label lblTitleUpdate;
        private System.Windows.Forms.DateTimePicker dtpDeadlineAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxTitleAdd;
        private System.Windows.Forms.Label lblDeadLineAdd;
        private System.Windows.Forms.Label lblTitleAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMenu;
    }
}