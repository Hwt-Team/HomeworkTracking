
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
            this.Search = new System.Windows.Forms.GroupBox();
            this.tbxExerciseIdSearch = new System.Windows.Forms.TextBox();
            this.tbxStudentIdSearch = new System.Windows.Forms.TextBox();
            this.tbxIdSearch = new System.Windows.Forms.TextBox();
            this.lblExerciseIdSearch = new System.Windows.Forms.Label();
            this.lblStudentIdSearch = new System.Windows.Forms.Label();
            this.lblIdSearch = new System.Windows.Forms.Label();
            this.chbxActive = new System.Windows.Forms.CheckBox();
            this.gbxOtherSearchOptions = new System.Windows.Forms.GroupBox();
            this.tbxExercise = new System.Windows.Forms.TextBox();
            this.lblExercise = new System.Windows.Forms.Label();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.chbxLastName = new System.Windows.Forms.CheckBox();
            this.chbxFirstName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxHelperGrids = new System.Windows.Forms.GroupBox();
            this.dgwExercises = new System.Windows.Forms.DataGridView();
            this.lblExercises = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.gbxOtherControlPanels = new System.Windows.Forms.GroupBox();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnExercises = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesAdmin)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.Search.SuspendLayout();
            this.gbxOtherSearchOptions.SuspendLayout();
            this.gbxHelperGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExercises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.gbxOtherControlPanels.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStudentExercisesUser
            // 
            this.dgwStudentExercisesUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgwStudentExercisesAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudentExercisesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentExercisesAdmin.Location = new System.Drawing.Point(22, 334);
            this.dgwStudentExercisesAdmin.Name = "dgwStudentExercisesAdmin";
            this.dgwStudentExercisesAdmin.RowHeadersWidth = 51;
            this.dgwStudentExercisesAdmin.RowTemplate.Height = 24;
            this.dgwStudentExercisesAdmin.Size = new System.Drawing.Size(1046, 247);
            this.dgwStudentExercisesAdmin.TabIndex = 1;
            this.dgwStudentExercisesAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudentExercisesAdmin_CellClick);
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
            this.gbxCrud.Controls.Add(this.btnDeleteAll);
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.Location = new System.Drawing.Point(22, 621);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(630, 304);
            this.gbxCrud.TabIndex = 4;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "CRUD";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(273, 247);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(112, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Search.Location = new System.Drawing.Point(698, 621);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(330, 304);
            this.Search.TabIndex = 5;
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
            this.tbxExerciseIdSearch.TextChanged += new System.EventHandler(this.tbxExerciseIdSearch_TextChanged);
            // 
            // tbxStudentIdSearch
            // 
            this.tbxStudentIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentIdSearch.Location = new System.Drawing.Point(181, 107);
            this.tbxStudentIdSearch.Name = "tbxStudentIdSearch";
            this.tbxStudentIdSearch.Size = new System.Drawing.Size(100, 30);
            this.tbxStudentIdSearch.TabIndex = 6;
            this.tbxStudentIdSearch.TextChanged += new System.EventHandler(this.tbxStudentIdSearch_TextChanged);
            // 
            // tbxIdSearch
            // 
            this.tbxIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxIdSearch.Location = new System.Drawing.Point(181, 55);
            this.tbxIdSearch.Name = "tbxIdSearch";
            this.tbxIdSearch.Size = new System.Drawing.Size(100, 30);
            this.tbxIdSearch.TabIndex = 5;
            this.tbxIdSearch.TextChanged += new System.EventHandler(this.tbxIdSearch_TextChanged);
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
            this.chbxActive.CheckedChanged += new System.EventHandler(this.chbxActive_CheckedChanged);
            // 
            // gbxOtherSearchOptions
            // 
            this.gbxOtherSearchOptions.Controls.Add(this.tbxExercise);
            this.gbxOtherSearchOptions.Controls.Add(this.lblExercise);
            this.gbxOtherSearchOptions.Controls.Add(this.tbxStudentName);
            this.gbxOtherSearchOptions.Controls.Add(this.chbxLastName);
            this.gbxOtherSearchOptions.Controls.Add(this.chbxFirstName);
            this.gbxOtherSearchOptions.Controls.Add(this.label1);
            this.gbxOtherSearchOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxOtherSearchOptions.Location = new System.Drawing.Point(1104, 32);
            this.gbxOtherSearchOptions.Name = "gbxOtherSearchOptions";
            this.gbxOtherSearchOptions.Size = new System.Drawing.Size(455, 549);
            this.gbxOtherSearchOptions.TabIndex = 6;
            this.gbxOtherSearchOptions.TabStop = false;
            this.gbxOtherSearchOptions.Text = "Other search options";
            // 
            // tbxExercise
            // 
            this.tbxExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExercise.Location = new System.Drawing.Point(167, 147);
            this.tbxExercise.Name = "tbxExercise";
            this.tbxExercise.Size = new System.Drawing.Size(184, 30);
            this.tbxExercise.TabIndex = 5;
            this.tbxExercise.TextChanged += new System.EventHandler(this.tbxExercise_TextChanged);
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExercise.Location = new System.Drawing.Point(24, 150);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(87, 25);
            this.lblExercise.TabIndex = 4;
            this.lblExercise.Text = "Exercise";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentName.Location = new System.Drawing.Point(301, 69);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(133, 30);
            this.tbxStudentName.TabIndex = 3;
            this.tbxStudentName.TextChanged += new System.EventHandler(this.tbxStudentName_TextChanged);
            // 
            // chbxLastName
            // 
            this.chbxLastName.AutoSize = true;
            this.chbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxLastName.Location = new System.Drawing.Point(188, 88);
            this.chbxLastName.Name = "chbxLastName";
            this.chbxLastName.Size = new System.Drawing.Size(84, 19);
            this.chbxLastName.TabIndex = 2;
            this.chbxLastName.Text = "Lastname";
            this.chbxLastName.UseVisualStyleBackColor = true;
            this.chbxLastName.CheckedChanged += new System.EventHandler(this.chbxLastName_CheckedChanged);
            // 
            // chbxFirstName
            // 
            this.chbxFirstName.AutoSize = true;
            this.chbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxFirstName.Location = new System.Drawing.Point(188, 63);
            this.chbxFirstName.Name = "chbxFirstName";
            this.chbxFirstName.Size = new System.Drawing.Size(84, 19);
            this.chbxFirstName.TabIndex = 1;
            this.chbxFirstName.Text = "Firstname";
            this.chbxFirstName.UseVisualStyleBackColor = true;
            this.chbxFirstName.CheckedChanged += new System.EventHandler(this.chbxFirstName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // gbxHelperGrids
            // 
            this.gbxHelperGrids.Controls.Add(this.dgwExercises);
            this.gbxHelperGrids.Controls.Add(this.lblExercises);
            this.gbxHelperGrids.Controls.Add(this.lblStudents);
            this.gbxHelperGrids.Controls.Add(this.dgwStudents);
            this.gbxHelperGrids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxHelperGrids.Location = new System.Drawing.Point(1565, 36);
            this.gbxHelperGrids.Name = "gbxHelperGrids";
            this.gbxHelperGrids.Size = new System.Drawing.Size(319, 883);
            this.gbxHelperGrids.TabIndex = 7;
            this.gbxHelperGrids.TabStop = false;
            this.gbxHelperGrids.Text = "Helper Grids";
            // 
            // dgwExercises
            // 
            this.dgwExercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExercises.Location = new System.Drawing.Point(6, 488);
            this.dgwExercises.Name = "dgwExercises";
            this.dgwExercises.RowHeadersWidth = 10;
            this.dgwExercises.RowTemplate.Height = 24;
            this.dgwExercises.Size = new System.Drawing.Size(307, 389);
            this.dgwExercises.TabIndex = 3;
            this.dgwExercises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwExercises_CellClick);
            // 
            // lblExercises
            // 
            this.lblExercises.AutoSize = true;
            this.lblExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExercises.Location = new System.Drawing.Point(6, 449);
            this.lblExercises.Name = "lblExercises";
            this.lblExercises.Size = new System.Drawing.Size(93, 24);
            this.lblExercises.TabIndex = 2;
            this.lblExercises.Text = "Exercises";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudents.Location = new System.Drawing.Point(10, 39);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(83, 24);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Students";
            // 
            // dgwStudents
            // 
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Location = new System.Drawing.Point(6, 68);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowHeadersWidth = 10;
            this.dgwStudents.RowTemplate.Height = 24;
            this.dgwStudents.Size = new System.Drawing.Size(307, 364);
            this.dgwStudents.TabIndex = 0;
            // 
            // gbxOtherControlPanels
            // 
            this.gbxOtherControlPanels.Controls.Add(this.btnGroups);
            this.gbxOtherControlPanels.Controls.Add(this.btnExercises);
            this.gbxOtherControlPanels.Controls.Add(this.btnStudents);
            this.gbxOtherControlPanels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxOtherControlPanels.Location = new System.Drawing.Point(1112, 611);
            this.gbxOtherControlPanels.Name = "gbxOtherControlPanels";
            this.gbxOtherControlPanels.Size = new System.Drawing.Size(408, 276);
            this.gbxOtherControlPanels.TabIndex = 8;
            this.gbxOtherControlPanels.TabStop = false;
            this.gbxOtherControlPanels.Text = "Other control panels";
            // 
            // btnGroups
            // 
            this.btnGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGroups.Location = new System.Drawing.Point(46, 141);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(131, 48);
            this.btnGroups.TabIndex = 9;
            this.btnGroups.Text = "Groups";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExercises.Location = new System.Drawing.Point(227, 58);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(131, 48);
            this.btnExercises.TabIndex = 1;
            this.btnExercises.Text = "Exercises";
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudents.Location = new System.Drawing.Point(46, 58);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(131, 48);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(427, 246);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(131, 46);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 937);
            this.Controls.Add(this.gbxOtherControlPanels);
            this.Controls.Add(this.gbxHelperGrids);
            this.Controls.Add(this.gbxOtherSearchOptions);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.lblAdminAppearance);
            this.Controls.Add(this.lblUserAppearance);
            this.Controls.Add(this.dgwStudentExercisesAdmin);
            this.Controls.Add(this.dgwStudentExercisesUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentExercisesAdmin)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.gbxOtherSearchOptions.ResumeLayout(false);
            this.gbxOtherSearchOptions.PerformLayout();
            this.gbxHelperGrids.ResumeLayout(false);
            this.gbxHelperGrids.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExercises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.gbxOtherControlPanels.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tbxExerciseIdUpdate;
        private System.Windows.Forms.Label lblStudentIdUpdate;
        private System.Windows.Forms.TextBox tbxStudentIdUpdate;
        private System.Windows.Forms.Label lblExerciseIdUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxExerciseIdAdd;
        private System.Windows.Forms.Label lblStudentIdAdd;
        private System.Windows.Forms.TextBox tbxStudentIdAdd;
        private System.Windows.Forms.Label lblExerciseIdAdd;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.TextBox tbxExerciseIdSearch;
        private System.Windows.Forms.TextBox tbxStudentIdSearch;
        private System.Windows.Forms.TextBox tbxIdSearch;
        private System.Windows.Forms.Label lblExerciseIdSearch;
        private System.Windows.Forms.Label lblStudentIdSearch;
        private System.Windows.Forms.Label lblIdSearch;
        private System.Windows.Forms.CheckBox chbxActive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chbxActiveUpdate;
        private System.Windows.Forms.GroupBox gbxOtherSearchOptions;
        private System.Windows.Forms.TextBox tbxExercise;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.CheckBox chbxLastName;
        private System.Windows.Forms.CheckBox chbxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxHelperGrids;
        private System.Windows.Forms.DataGridView dgwExercises;
        private System.Windows.Forms.Label lblExercises;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.GroupBox gbxOtherControlPanels;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnExercises;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

