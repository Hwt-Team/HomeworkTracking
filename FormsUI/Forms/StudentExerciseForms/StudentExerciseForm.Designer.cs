
namespace FormsUI.Forms.StudentExerciseForms
{
    partial class StudentExerciseForm
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
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxExerciseIdSearch = new System.Windows.Forms.TextBox();
            this.tbxStudentIdSearch = new System.Windows.Forms.TextBox();
            this.tbxIdSearch = new System.Windows.Forms.TextBox();
            this.lblExerciseIdSearch = new System.Windows.Forms.Label();
            this.lblStudentIdSearch = new System.Windows.Forms.Label();
            this.lblIdSearch = new System.Windows.Forms.Label();
            this.chbxActive = new System.Windows.Forms.CheckBox();
            this.tbxExercise = new System.Windows.Forms.TextBox();
            this.lblExercise = new System.Windows.Forms.Label();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.chbxLastName = new System.Windows.Forms.CheckBox();
            this.chbxFirstName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblAdminAppearance = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesAdmin)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStudentExercisesUser
            // 
            this.dgwStudentExercisesUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwStudentExercisesUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudentExercisesUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dgwStudentExercisesUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentExercisesUser.Location = new System.Drawing.Point(7, 37);
            this.dgwStudentExercisesUser.MaximumSize = new System.Drawing.Size(1347, 465);
            this.dgwStudentExercisesUser.MinimumSize = new System.Drawing.Size(305, 210);
            this.dgwStudentExercisesUser.Name = "dgwStudentExercisesUser";
            this.dgwStudentExercisesUser.RowHeadersWidth = 51;
            this.dgwStudentExercisesUser.RowTemplate.Height = 24;
            this.dgwStudentExercisesUser.Size = new System.Drawing.Size(305, 213);
            this.dgwStudentExercisesUser.TabIndex = 0;
            // 
            // dgwStudentExercisesAdmin
            // 
            this.dgwStudentExercisesAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwStudentExercisesAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudentExercisesAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dgwStudentExercisesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentExercisesAdmin.Location = new System.Drawing.Point(7, 288);
            this.dgwStudentExercisesAdmin.MaximumSize = new System.Drawing.Size(1347, 465);
            this.dgwStudentExercisesAdmin.MinimumSize = new System.Drawing.Size(305, 210);
            this.dgwStudentExercisesAdmin.Name = "dgwStudentExercisesAdmin";
            this.dgwStudentExercisesAdmin.RowHeadersWidth = 51;
            this.dgwStudentExercisesAdmin.RowTemplate.Height = 24;
            this.dgwStudentExercisesAdmin.Size = new System.Drawing.Size(305, 239);
            this.dgwStudentExercisesAdmin.TabIndex = 1;
            // 
            // lblUserAppearance
            // 
            this.lblUserAppearance.AutoSize = true;
            this.lblUserAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserAppearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserAppearance.Location = new System.Drawing.Point(3, 10);
            this.lblUserAppearance.Name = "lblUserAppearance";
            this.lblUserAppearance.Size = new System.Drawing.Size(169, 24);
            this.lblUserAppearance.TabIndex = 2;
            this.lblUserAppearance.Text = "User Appeareance";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteAll.Location = new System.Drawing.Point(339, 133);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(339, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Location = new System.Drawing.Point(339, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(339, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxExerciseIdSearch
            // 
            this.tbxExerciseIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExerciseIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExerciseIdSearch.Location = new System.Drawing.Point(432, 306);
            this.tbxExerciseIdSearch.Name = "tbxExerciseIdSearch";
            this.tbxExerciseIdSearch.Size = new System.Drawing.Size(100, 22);
            this.tbxExerciseIdSearch.TabIndex = 7;
            this.tbxExerciseIdSearch.TextChanged += new System.EventHandler(this.tbxExerciseIdSearch_TextChanged);
            // 
            // tbxStudentIdSearch
            // 
            this.tbxStudentIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStudentIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentIdSearch.Location = new System.Drawing.Point(432, 262);
            this.tbxStudentIdSearch.Name = "tbxStudentIdSearch";
            this.tbxStudentIdSearch.Size = new System.Drawing.Size(100, 22);
            this.tbxStudentIdSearch.TabIndex = 6;
            this.tbxStudentIdSearch.TextChanged += new System.EventHandler(this.tbxStudentIdSearch_TextChanged);
            // 
            // tbxIdSearch
            // 
            this.tbxIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxIdSearch.Location = new System.Drawing.Point(432, 218);
            this.tbxIdSearch.Name = "tbxIdSearch";
            this.tbxIdSearch.Size = new System.Drawing.Size(100, 22);
            this.tbxIdSearch.TabIndex = 5;
            this.tbxIdSearch.TextChanged += new System.EventHandler(this.tbxIdSearch_TextChanged);
            // 
            // lblExerciseIdSearch
            // 
            this.lblExerciseIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExerciseIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExerciseIdSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblExerciseIdSearch.Location = new System.Drawing.Point(352, 309);
            this.lblExerciseIdSearch.Name = "lblExerciseIdSearch";
            this.lblExerciseIdSearch.Size = new System.Drawing.Size(76, 17);
            this.lblExerciseIdSearch.TabIndex = 4;
            this.lblExerciseIdSearch.Text = "Exercise Id";
            // 
            // lblStudentIdSearch
            // 
            this.lblStudentIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentIdSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStudentIdSearch.Location = new System.Drawing.Point(352, 265);
            this.lblStudentIdSearch.Name = "lblStudentIdSearch";
            this.lblStudentIdSearch.Size = new System.Drawing.Size(72, 17);
            this.lblStudentIdSearch.TabIndex = 3;
            this.lblStudentIdSearch.Text = "Student Id";
            // 
            // lblIdSearch
            // 
            this.lblIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIdSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdSearch.Location = new System.Drawing.Point(352, 221);
            this.lblIdSearch.Name = "lblIdSearch";
            this.lblIdSearch.Size = new System.Drawing.Size(19, 17);
            this.lblIdSearch.TabIndex = 2;
            this.lblIdSearch.Text = "Id";
            // 
            // chbxActive
            // 
            this.chbxActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.chbxActive.Location = new System.Drawing.Point(561, 263);
            this.chbxActive.Name = "chbxActive";
            this.chbxActive.Size = new System.Drawing.Size(68, 21);
            this.chbxActive.TabIndex = 1;
            this.chbxActive.Text = "Active";
            this.chbxActive.UseVisualStyleBackColor = true;
            this.chbxActive.CheckedChanged += new System.EventHandler(this.chbxActive_CheckedChanged);
            // 
            // tbxExercise
            // 
            this.tbxExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExercise.Location = new System.Drawing.Point(432, 436);
            this.tbxExercise.Multiline = true;
            this.tbxExercise.Name = "tbxExercise";
            this.tbxExercise.Size = new System.Drawing.Size(175, 78);
            this.tbxExercise.TabIndex = 5;
            this.tbxExercise.TextChanged += new System.EventHandler(this.tbxExercise_TextChanged);
            // 
            // lblExercise
            // 
            this.lblExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExercise.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblExercise.Location = new System.Drawing.Point(352, 439);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(61, 17);
            this.lblExercise.TabIndex = 4;
            this.lblExercise.Text = "Exercise";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentName.Location = new System.Drawing.Point(462, 363);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(133, 22);
            this.tbxStudentName.TabIndex = 3;
            this.tbxStudentName.TextChanged += new System.EventHandler(this.tbxStudentName_TextChanged);
            // 
            // chbxLastName
            // 
            this.chbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.chbxLastName.Location = new System.Drawing.Point(496, 391);
            this.chbxLastName.Name = "chbxLastName";
            this.chbxLastName.Size = new System.Drawing.Size(84, 19);
            this.chbxLastName.TabIndex = 2;
            this.chbxLastName.Text = "Lastname";
            this.chbxLastName.UseVisualStyleBackColor = true;
            this.chbxLastName.CheckedChanged += new System.EventHandler(this.chbxLastName_CheckedChanged);
            // 
            // chbxFirstName
            // 
            this.chbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.chbxFirstName.Location = new System.Drawing.Point(382, 391);
            this.chbxFirstName.Name = "chbxFirstName";
            this.chbxFirstName.Size = new System.Drawing.Size(84, 19);
            this.chbxFirstName.TabIndex = 1;
            this.chbxFirstName.Text = "Firstname";
            this.chbxFirstName.UseVisualStyleBackColor = true;
            this.chbxFirstName.CheckedChanged += new System.EventHandler(this.chbxFirstName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(352, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.lblUserAppearance);
            this.panelGrid.Controls.Add(this.dgwStudentExercisesUser);
            this.panelGrid.Controls.Add(this.dgwStudentExercisesAdmin);
            this.panelGrid.Controls.Add(this.lblAdminAppearance);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(317, 536);
            this.panelGrid.TabIndex = 15;
            // 
            // lblAdminAppearance
            // 
            this.lblAdminAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdminAppearance.AutoSize = true;
            this.lblAdminAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdminAppearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAdminAppearance.Location = new System.Drawing.Point(8, 257);
            this.lblAdminAppearance.Name = "lblAdminAppearance";
            this.lblAdminAppearance.Size = new System.Drawing.Size(174, 24);
            this.lblAdminAppearance.TabIndex = 3;
            this.lblAdminAppearance.Text = "Admin Appearance";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSearch.Location = new System.Drawing.Point(335, 188);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 24);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search";
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnReload.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 32;
            this.btnReload.Location = new System.Drawing.Point(524, 12);
            this.btnReload.MinimumSize = new System.Drawing.Size(97, 48);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(133, 48);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // StudentExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(669, 536);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.tbxExercise);
            this.Controls.Add(this.lblExercise);
            this.Controls.Add(this.tbxExerciseIdSearch);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.chbxLastName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.chbxFirstName);
            this.Controls.Add(this.tbxStudentIdSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.tbxIdSearch);
            this.Controls.Add(this.lblExerciseIdSearch);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.lblStudentIdSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblIdSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chbxActive);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1711, 1038);
            this.MinimumSize = new System.Drawing.Size(669, 536);
            this.Name = "StudentExerciseForm";
            this.Text = "Student Exercise Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentExerciseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesAdmin)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudentExercisesUser;
        private System.Windows.Forms.DataGridView dgwStudentExercisesAdmin;
        private System.Windows.Forms.Label lblUserAppearance;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxExerciseIdSearch;
        private System.Windows.Forms.TextBox tbxStudentIdSearch;
        private System.Windows.Forms.TextBox tbxIdSearch;
        private System.Windows.Forms.Label lblExerciseIdSearch;
        private System.Windows.Forms.Label lblStudentIdSearch;
        private System.Windows.Forms.Label lblIdSearch;
        private System.Windows.Forms.CheckBox chbxActive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxExercise;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.CheckBox chbxLastName;
        private System.Windows.Forms.CheckBox chbxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblAdminAppearance;
        private System.Windows.Forms.Label lblSearch;
        private FontAwesome.Sharp.IconButton btnReload;
    }
}

