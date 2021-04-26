namespace BACKUP_RESTORE
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TaoDivine = new System.Windows.Forms.Button();
            this.chk_PhucHoi = new System.Windows.Forms.CheckBox();
            this.btnPhucHoi = new System.Windows.Forms.Button();
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.dataGridView_database = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_PhienBan = new System.Windows.Forms.TextBox();
            this.panel_Hien = new System.Windows.Forms.Panel();
            this.dtp_Gio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_Xoabansao = new System.Windows.Forms.CheckBox();
            this.dataGridView_divine = new System.Windows.Forms.DataGridView();
            this.lbl_PhienBan = new System.Windows.Forms.Label();
            this.lbl_TenCSDL = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPSTTBACKUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new BACKUP_RESTORE.DS();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasesTableAdapter = new BACKUP_RESTORE.DSTableAdapters.databasesTableAdapter();
            this.sP_STT_BACKUPTableAdapter = new BACKUP_RESTORE.DSTableAdapters.SP_STT_BACKUPTableAdapter();
            this.getBSId_TheoPositionTableAdapter1 = new BACKUP_RESTORE.DSTableAdapters.getBSId_TheoPositionTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_database)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_Hien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_divine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSTTBACKUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_TaoDivine);
            this.panel1.Controls.Add(this.chk_PhucHoi);
            this.panel1.Controls.Add(this.btnPhucHoi);
            this.panel1.Controls.Add(this.btn_SaoLuu);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 49);
            this.panel1.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(701, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(89, 45);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TaoDivine
            // 
            this.btn_TaoDivine.FlatAppearance.BorderSize = 0;
            this.btn_TaoDivine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoDivine.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoDivine.Image")));
            this.btn_TaoDivine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoDivine.Location = new System.Drawing.Point(451, 3);
            this.btn_TaoDivine.Name = "btn_TaoDivine";
            this.btn_TaoDivine.Size = new System.Drawing.Size(135, 45);
            this.btn_TaoDivine.TabIndex = 3;
            this.btn_TaoDivine.Text = "Tạo divine sao lưu";
            this.btn_TaoDivine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoDivine.UseVisualStyleBackColor = true;
            this.btn_TaoDivine.Click += new System.EventHandler(this.btn_TaoDivine_Click);
            // 
            // chk_PhucHoi
            // 
            this.chk_PhucHoi.Image = ((System.Drawing.Image)(resources.GetObject("chk_PhucHoi.Image")));
            this.chk_PhucHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chk_PhucHoi.Location = new System.Drawing.Point(229, 3);
            this.chk_PhucHoi.Name = "chk_PhucHoi";
            this.chk_PhucHoi.Size = new System.Drawing.Size(216, 45);
            this.chk_PhucHoi.TabIndex = 2;
            this.chk_PhucHoi.Text = "Tham số phục hồi theo thời gian";
            this.chk_PhucHoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_PhucHoi.UseVisualStyleBackColor = true;
            this.chk_PhucHoi.CheckedChanged += new System.EventHandler(this.chk_PhucHoi_CheckedChanged);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.FlatAppearance.BorderSize = 0;
            this.btnPhucHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhucHoi.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.Image")));
            this.btnPhucHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhucHoi.Location = new System.Drawing.Point(115, 3);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(101, 45);
            this.btnPhucHoi.TabIndex = 1;
            this.btnPhucHoi.Text = "Phục Hồi";
            this.btnPhucHoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhucHoi.UseVisualStyleBackColor = true;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_SaoLuu.FlatAppearance.BorderSize = 0;
            this.btn_SaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaoLuu.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaoLuu.Image")));
            this.btn_SaoLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaoLuu.Location = new System.Drawing.Point(0, 3);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(98, 45);
            this.btn_SaoLuu.TabIndex = 0;
            this.btn_SaoLuu.Text = "Sao Lưu";
            this.btn_SaoLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaoLuu.UseVisualStyleBackColor = true;
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // dataGridView_database
            // 
            this.dataGridView_database.AllowUserToAddRows = false;
            this.dataGridView_database.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_database.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_database.AutoGenerateColumns = false;
            this.dataGridView_database.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_database.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_database.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView_database.DataSource = this.databasesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_database.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_database.Location = new System.Drawing.Point(9, 63);
            this.dataGridView_database.Name = "dataGridView_database";
            this.dataGridView_database.ReadOnly = true;
            this.dataGridView_database.Size = new System.Drawing.Size(216, 573);
            this.dataGridView_database.TabIndex = 1;
            this.dataGridView_database.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_database_CellClick);
            this.dataGridView_database.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_database_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_PhienBan);
            this.panel2.Controls.Add(this.panel_Hien);
            this.panel2.Controls.Add(this.chk_Xoabansao);
            this.panel2.Controls.Add(this.dataGridView_divine);
            this.panel2.Controls.Add(this.lbl_PhienBan);
            this.panel2.Controls.Add(this.lbl_TenCSDL);
            this.panel2.Location = new System.Drawing.Point(231, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 573);
            this.panel2.TabIndex = 2;
            // 
            // txt_PhienBan
            // 
            this.txt_PhienBan.Enabled = false;
            this.txt_PhienBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhienBan.Location = new System.Drawing.Point(399, 5);
            this.txt_PhienBan.Name = "txt_PhienBan";
            this.txt_PhienBan.Size = new System.Drawing.Size(53, 29);
            this.txt_PhienBan.TabIndex = 5;
            // 
            // panel_Hien
            // 
            this.panel_Hien.Controls.Add(this.dtp_Gio);
            this.panel_Hien.Controls.Add(this.label2);
            this.panel_Hien.Controls.Add(this.dtp_Ngay);
            this.panel_Hien.Controls.Add(this.label1);
            this.panel_Hien.Location = new System.Drawing.Point(170, 401);
            this.panel_Hien.Name = "panel_Hien";
            this.panel_Hien.Size = new System.Drawing.Size(573, 169);
            this.panel_Hien.TabIndex = 4;
            // 
            // dtp_Gio
            // 
            this.dtp_Gio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Gio.Location = new System.Drawing.Point(378, 12);
            this.dtp_Gio.Name = "dtp_Gio";
            this.dtp_Gio.Size = new System.Drawing.Size(85, 20);
            this.dtp_Gio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 71);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngay.Location = new System.Drawing.Point(247, 12);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(125, 20);
            this.dtp_Ngay.TabIndex = 2;
            this.dtp_Ngay.Value = new System.DateTime(2021, 4, 4, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày giờ phục hồi tới thời điểm đó";
            // 
            // chk_Xoabansao
            // 
            this.chk_Xoabansao.AutoSize = true;
            this.chk_Xoabansao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Xoabansao.Location = new System.Drawing.Point(237, 362);
            this.chk_Xoabansao.Name = "chk_Xoabansao";
            this.chk_Xoabansao.Padding = new System.Windows.Forms.Padding(5);
            this.chk_Xoabansao.Size = new System.Drawing.Size(442, 33);
            this.chk_Xoabansao.TabIndex = 3;
            this.chk_Xoabansao.Text = " Xoá tất cả các bản sao lưu cũ trong File trước khi sao lưu bản mới";
            this.chk_Xoabansao.UseVisualStyleBackColor = true;
            // 
            // dataGridView_divine
            // 
            this.dataGridView_divine.AllowUserToAddRows = false;
            this.dataGridView_divine.AllowUserToDeleteRows = false;
            this.dataGridView_divine.AutoGenerateColumns = false;
            this.dataGridView_divine.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_divine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_divine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_divine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.backupstartdateDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView_divine.DataSource = this.sPSTTBACKUPBindingSource;
            this.dataGridView_divine.Location = new System.Drawing.Point(2, 37);
            this.dataGridView_divine.Name = "dataGridView_divine";
            this.dataGridView_divine.ReadOnly = true;
            this.dataGridView_divine.Size = new System.Drawing.Size(1015, 308);
            this.dataGridView_divine.TabIndex = 2;
            this.dataGridView_divine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_divine_CellClick);
            this.dataGridView_divine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_divine_CellContentClick);
            // 
            // lbl_PhienBan
            // 
            this.lbl_PhienBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_PhienBan.Location = new System.Drawing.Point(329, 5);
            this.lbl_PhienBan.Name = "lbl_PhienBan";
            this.lbl_PhienBan.Size = new System.Drawing.Size(70, 29);
            this.lbl_PhienBan.TabIndex = 1;
            this.lbl_PhienBan.Text = "Phiên bản : ";
            this.lbl_PhienBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TenCSDL
            // 
            this.lbl_TenCSDL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_TenCSDL.Location = new System.Drawing.Point(4, 5);
            this.lbl_TenCSDL.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TenCSDL.Name = "lbl_TenCSDL";
            this.lbl_TenCSDL.Size = new System.Drawing.Size(313, 29);
            this.lbl_TenCSDL.TabIndex = 0;
            this.lbl_TenCSDL.Text = "Tên cơ sở dữ liệu : ";
            this.lbl_TenCSDL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(597, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(77, 45);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Bản sao lưu thứ #";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 250;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Diễn giải";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // backupstartdateDataGridViewTextBoxColumn
            // 
            this.backupstartdateDataGridViewTextBoxColumn.DataPropertyName = "backup_start_date";
            this.backupstartdateDataGridViewTextBoxColumn.HeaderText = "Ngày sao lưu";
            this.backupstartdateDataGridViewTextBoxColumn.Name = "backupstartdateDataGridViewTextBoxColumn";
            this.backupstartdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.backupstartdateDataGridViewTextBoxColumn.Width = 250;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User sao lưu";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPSTTBACKUPBindingSource
            // 
            this.sPSTTBACKUPBindingSource.DataMember = "SP_STT_BACKUP";
            this.sPSTTBACKUPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Cơ Sở Dữ Liệu";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "databases";
            this.databasesBindingSource.DataSource = this.dS;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // sP_STT_BACKUPTableAdapter
            // 
            this.sP_STT_BACKUPTableAdapter.ClearBeforeFill = true;
            // 
            // getBSId_TheoPositionTableAdapter1
            // 
            this.getBSId_TheoPositionTableAdapter1.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1263, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_database);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu và phục hồi cơ sở dư liệu trong SQL SERVER";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_database)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Hien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_divine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSTTBACKUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SaoLuu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TaoDivine;
        private System.Windows.Forms.CheckBox chk_PhucHoi;
        private System.Windows.Forms.Button btnPhucHoi;
        private System.Windows.Forms.DataGridView dataGridView_database;
        private DS dS;
        private System.Windows.Forms.BindingSource databasesBindingSource;
        private DSTableAdapters.databasesTableAdapter databasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_PhienBan;
        private System.Windows.Forms.Label lbl_TenCSDL;
        private System.Windows.Forms.DataGridView dataGridView_divine;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPSTTBACKUPBindingSource;
        private DSTableAdapters.SP_STT_BACKUPTableAdapter sP_STT_BACKUPTableAdapter;
        private System.Windows.Forms.CheckBox chk_Xoabansao;
        private System.Windows.Forms.Panel panel_Hien;
        private System.Windows.Forms.DateTimePicker dtp_Gio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PhienBan;
        private System.Windows.Forms.Button btn_xoa;
        private DSTableAdapters.getBSId_TheoPositionTableAdapter getBSId_TheoPositionTableAdapter1;
    }
}

