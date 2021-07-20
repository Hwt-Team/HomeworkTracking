
namespace FormsUI.Forms.StudentExerciseForms
{
    partial class Search
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
            this.tbxExercise = new System.Windows.Forms.TextBox();
            this.lblExercise = new System.Windows.Forms.Label();
            this.tbxExerciseIdSearch = new System.Windows.Forms.TextBox();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.chbxLastName = new System.Windows.Forms.CheckBox();
            this.chbxFirstName = new System.Windows.Forms.CheckBox();
            this.tbxStudentIdSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIdSearch = new System.Windows.Forms.TextBox();
            this.lblExerciseIdSearch = new System.Windows.Forms.Label();
            this.lblStudentIdSearch = new System.Windows.Forms.Label();
            this.lblIdSearch = new System.Windows.Forms.Label();
            this.chbxActive = new System.Windows.Forms.CheckBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxExercise
            // 
            this.tbxExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExercise.Location = new System.Drawing.Point(210, 254);
            this.tbxExercise.Multiline = true;
            this.tbxExercise.Name = "tbxExercise";
            this.tbxExercise.Size = new System.Drawing.Size(198, 106);
            this.tbxExercise.TabIndex = 17;
            this.tbxExercise.TextChanged += new System.EventHandler(this.tbxExercise_TextChanged);
            // 
            // lblExercise
            // 
            this.lblExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExercise.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblExercise.Location = new System.Drawing.Point(68, 254);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(93, 35);
            this.lblExercise.TabIndex = 15;
            this.lblExercise.Text = "Exercise";
            // 
            // tbxExerciseIdSearch
            // 
            this.tbxExerciseIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExerciseIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExerciseIdSearch.Location = new System.Drawing.Point(210, 151);
            this.tbxExerciseIdSearch.Name = "tbxExerciseIdSearch";
            this.tbxExerciseIdSearch.Size = new System.Drawing.Size(100, 30);
            this.tbxExerciseIdSearch.TabIndex = 20;
            this.tbxExerciseIdSearch.TextChanged += new System.EventHandler(this.tbxExerciseIdSearch_TextChanged);
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentName.Location = new System.Drawing.Point(210, 200);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(121, 30);
            this.tbxStudentName.TabIndex = 13;
            this.tbxStudentName.TextChanged += new System.EventHandler(this.tbxStudentName_TextChanged);
            // 
            // chbxLastName
            // 
            this.chbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.chbxLastName.Location = new System.Drawing.Point(344, 214);
            this.chbxLastName.Name = "chbxLastName";
            this.chbxLastName.Size = new System.Drawing.Size(111, 25);
            this.chbxLastName.TabIndex = 11;
            this.chbxLastName.Text = "Lastname";
            this.chbxLastName.UseVisualStyleBackColor = true;
            this.chbxLastName.CheckedChanged += new System.EventHandler(this.chbxLastName_CheckedChanged);
            // 
            // chbxFirstName
            // 
            this.chbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.chbxFirstName.Location = new System.Drawing.Point(344, 191);
            this.chbxFirstName.Name = "chbxFirstName";
            this.chbxFirstName.Size = new System.Drawing.Size(111, 25);
            this.chbxFirstName.TabIndex = 9;
            this.chbxFirstName.Text = "Firstname";
            this.chbxFirstName.UseVisualStyleBackColor = true;
            this.chbxFirstName.CheckedChanged += new System.EventHandler(this.chbxFirstName_CheckedChanged);
            // 
            // tbxStudentIdSearch
            // 
            this.tbxStudentIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStudentIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentIdSearch.Location = new System.Drawing.Point(210, 102);
            this.tbxStudentIdSearch.Name = "tbxStudentIdSearch";
            this.tbxStudentIdSearch.Size = new System.Drawing.Size(100, 30);
            this.tbxStudentIdSearch.TabIndex = 19;
            this.tbxStudentIdSearch.TextChanged += new System.EventHandler(this.tbxStudentIdSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(68, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Name";
            // 
            // tbxIdSearch
            // 
            this.tbxIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxIdSearch.Location = new System.Drawing.Point(210, 53);
            this.tbxIdSearch.Name = "tbxIdSearch";
            this.tbxIdSearch.Size = new System.Drawing.Size(100, 30);
            this.tbxIdSearch.TabIndex = 18;
            this.tbxIdSearch.TextChanged += new System.EventHandler(this.tbxIdSearch_TextChanged);
            // 
            // lblExerciseIdSearch
            // 
            this.lblExerciseIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExerciseIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExerciseIdSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblExerciseIdSearch.Location = new System.Drawing.Point(68, 154);
            this.lblExerciseIdSearch.Name = "lblExerciseIdSearch";
            this.lblExerciseIdSearch.Size = new System.Drawing.Size(110, 26);
            this.lblExerciseIdSearch.TabIndex = 16;
            this.lblExerciseIdSearch.Text = "Exercise Id";
            // 
            // lblStudentIdSearch
            // 
            this.lblStudentIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentIdSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStudentIdSearch.Location = new System.Drawing.Point(68, 105);
            this.lblStudentIdSearch.Name = "lblStudentIdSearch";
            this.lblStudentIdSearch.Size = new System.Drawing.Size(110, 26);
            this.lblStudentIdSearch.TabIndex = 14;
            this.lblStudentIdSearch.Text = "Student Id";
            // 
            // lblIdSearch
            // 
            this.lblIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIdSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdSearch.Location = new System.Drawing.Point(68, 56);
            this.lblIdSearch.Name = "lblIdSearch";
            this.lblIdSearch.Size = new System.Drawing.Size(41, 26);
            this.lblIdSearch.TabIndex = 12;
            this.lblIdSearch.Text = "Id";
            // 
            // chbxActive
            // 
            this.chbxActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.chbxActive.Location = new System.Drawing.Point(349, 105);
            this.chbxActive.Name = "chbxActive";
            this.chbxActive.Size = new System.Drawing.Size(86, 29);
            this.chbxActive.TabIndex = 10;
            this.chbxActive.Text = "Active";
            this.chbxActive.UseVisualStyleBackColor = true;
            this.chbxActive.CheckedChanged += new System.EventHandler(this.chbxActive_CheckedChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.DimGray;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(456, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DimGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(482, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 21;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(514, 441);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxExercise);
            this.Controls.Add(this.lblExercise);
            this.Controls.Add(this.tbxExerciseIdSearch);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.chbxLastName);
            this.Controls.Add(this.chbxFirstName);
            this.Controls.Add(this.tbxStudentIdSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIdSearch);
            this.Controls.Add(this.lblExerciseIdSearch);
            this.Controls.Add(this.lblStudentIdSearch);
            this.Controls.Add(this.lblIdSearch);
            this.Controls.Add(this.chbxActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxExercise;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.TextBox tbxExerciseIdSearch;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.CheckBox chbxLastName;
        private System.Windows.Forms.CheckBox chbxFirstName;
        private System.Windows.Forms.TextBox tbxStudentIdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIdSearch;
        private System.Windows.Forms.Label lblExerciseIdSearch;
        private System.Windows.Forms.Label lblStudentIdSearch;
        private System.Windows.Forms.Label lblIdSearch;
        private System.Windows.Forms.CheckBox chbxActive;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnClose;
    }
}