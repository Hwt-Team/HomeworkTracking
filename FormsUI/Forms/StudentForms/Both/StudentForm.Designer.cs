
namespace FormsUI.Forms.StudentForms.Both
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.btnStudiesDgw = new System.Windows.Forms.Button();
            this.btnGraduatesDgw = new System.Windows.Forms.Button();
            this.btnBothDgw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStudents
            // 
            this.dgwStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStudents.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgwStudents.Location = new System.Drawing.Point(21, 58);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.ReadOnly = true;
            this.dgwStudents.RowHeadersWidth = 51;
            this.dgwStudents.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgwStudents.RowTemplate.Height = 40;
            this.dgwStudents.Size = new System.Drawing.Size(470, 466);
            this.dgwStudents.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnReload.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 32;
            this.btnReload.Location = new System.Drawing.Point(498, 476);
            this.btnReload.MinimumSize = new System.Drawing.Size(97, 48);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(133, 48);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnStudiesDgw
            // 
            this.btnStudiesDgw.FlatAppearance.BorderSize = 0;
            this.btnStudiesDgw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnStudiesDgw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnStudiesDgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudiesDgw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudiesDgw.Location = new System.Drawing.Point(30, 12);
            this.btnStudiesDgw.MinimumSize = new System.Drawing.Size(50, 40);
            this.btnStudiesDgw.Name = "btnStudiesDgw";
            this.btnStudiesDgw.Size = new System.Drawing.Size(100, 40);
            this.btnStudiesDgw.TabIndex = 18;
            this.btnStudiesDgw.Text = "Studies";
            this.btnStudiesDgw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudiesDgw.UseVisualStyleBackColor = true;
            this.btnStudiesDgw.Click += new System.EventHandler(this.btnStudiesDgw_Click);
            // 
            // btnGraduatesDgw
            // 
            this.btnGraduatesDgw.FlatAppearance.BorderSize = 0;
            this.btnGraduatesDgw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnGraduatesDgw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnGraduatesDgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraduatesDgw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGraduatesDgw.Location = new System.Drawing.Point(136, 12);
            this.btnGraduatesDgw.MinimumSize = new System.Drawing.Size(50, 40);
            this.btnGraduatesDgw.Name = "btnGraduatesDgw";
            this.btnGraduatesDgw.Size = new System.Drawing.Size(120, 40);
            this.btnGraduatesDgw.TabIndex = 19;
            this.btnGraduatesDgw.Text = "Graduates";
            this.btnGraduatesDgw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraduatesDgw.UseVisualStyleBackColor = true;
            this.btnGraduatesDgw.Click += new System.EventHandler(this.btnGraduatesDgw_Click);
            // 
            // btnBothDgw
            // 
            this.btnBothDgw.FlatAppearance.BorderSize = 0;
            this.btnBothDgw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnBothDgw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnBothDgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBothDgw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBothDgw.Location = new System.Drawing.Point(262, 12);
            this.btnBothDgw.MinimumSize = new System.Drawing.Size(50, 40);
            this.btnBothDgw.Name = "btnBothDgw";
            this.btnBothDgw.Size = new System.Drawing.Size(100, 40);
            this.btnBothDgw.TabIndex = 20;
            this.btnBothDgw.Text = "Both";
            this.btnBothDgw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBothDgw.UseVisualStyleBackColor = true;
            this.btnBothDgw.Click += new System.EventHandler(this.btnBothDgw_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(669, 536);
            this.Controls.Add(this.btnBothDgw);
            this.Controls.Add(this.btnGraduatesDgw);
            this.Controls.Add(this.btnStudiesDgw);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgwStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(669, 536);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudents;
        private FontAwesome.Sharp.IconButton btnReload;
        private System.Windows.Forms.Button btnStudiesDgw;
        private System.Windows.Forms.Button btnGraduatesDgw;
        private System.Windows.Forms.Button btnBothDgw;
    }
}