
namespace ThucTapCM
{
    partial class FormTTNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTTNCC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMNCC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdressNCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhoneNCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameNCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dtGVNCC = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1119, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Gray;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 35;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSave.Location = new System.Drawing.Point(725, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 49);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.FilePrescription;
            this.btnHuy.IconColor = System.Drawing.Color.Gray;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.IconSize = 35;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHuy.Location = new System.Drawing.Point(975, 268);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(157, 49);
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnReset.IconColor = System.Drawing.Color.Gray;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 35;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReset.Location = new System.Drawing.Point(975, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 49);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Sửa";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Gray;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 35;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAdd.Location = new System.Drawing.Point(725, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 49);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Địa chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Số điện thoại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tên nhà cung cấp :";
            // 
            // lbMNCC
            // 
            this.lbMNCC.AutoSize = true;
            this.lbMNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNCC.Location = new System.Drawing.Point(392, 88);
            this.lbMNCC.Name = "lbMNCC";
            this.lbMNCC.Size = new System.Drawing.Size(0, 29);
            this.lbMNCC.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã nhà cung cấp :";
            // 
            // txtAdressNCC
            // 
            this.txtAdressNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdressNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdressNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdressNCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtAdressNCC.HintText = "";
            this.txtAdressNCC.isPassword = false;
            this.txtAdressNCC.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAdressNCC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAdressNCC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAdressNCC.LineThickness = 4;
            this.txtAdressNCC.Location = new System.Drawing.Point(262, 274);
            this.txtAdressNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdressNCC.Name = "txtAdressNCC";
            this.txtAdressNCC.Size = new System.Drawing.Size(425, 40);
            this.txtAdressNCC.TabIndex = 40;
            this.txtAdressNCC.Text = "Type supplier adress";
            this.txtAdressNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhoneNCC
            // 
            this.txtPhoneNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhoneNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhoneNCC.HintText = "";
            this.txtPhoneNCC.isPassword = false;
            this.txtPhoneNCC.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPhoneNCC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhoneNCC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPhoneNCC.LineThickness = 4;
            this.txtPhoneNCC.Location = new System.Drawing.Point(262, 210);
            this.txtPhoneNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNCC.Name = "txtPhoneNCC";
            this.txtPhoneNCC.Size = new System.Drawing.Size(425, 40);
            this.txtPhoneNCC.TabIndex = 47;
            this.txtPhoneNCC.Text = "Type supplier phone number ";
            this.txtPhoneNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNCC_KeyPress);
            // 
            // txtNameNCC
            // 
            this.txtNameNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameNCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameNCC.HintText = "";
            this.txtNameNCC.isPassword = false;
            this.txtNameNCC.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNameNCC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNameNCC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNameNCC.LineThickness = 4;
            this.txtNameNCC.Location = new System.Drawing.Point(262, 145);
            this.txtNameNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameNCC.Name = "txtNameNCC";
            this.txtNameNCC.Size = new System.Drawing.Size(425, 40);
            this.txtNameNCC.TabIndex = 48;
            this.txtNameNCC.Text = "Type supplier name";
            this.txtNameNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Gray;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 35;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.Location = new System.Drawing.Point(854, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 49);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(247, 357);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox1.TabIndex = 53;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(122, 355);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // dtGVNCC
            // 
            this.dtGVNCC.AllowUserToAddRows = false;
            this.dtGVNCC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGVNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVNCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGVNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGVNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGVNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGVNCC.ColumnHeadersHeight = 40;
            this.dtGVNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVNCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGVNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVNCC.DoubleBuffered = true;
            this.dtGVNCC.EnableHeadersVisualStyles = false;
            this.dtGVNCC.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtGVNCC.HeaderForeColor = System.Drawing.Color.White;
            this.dtGVNCC.Location = new System.Drawing.Point(0, 412);
            this.dtGVNCC.Name = "dtGVNCC";
            this.dtGVNCC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGVNCC.RowHeadersVisible = false;
            this.dtGVNCC.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dtGVNCC.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtGVNCC.RowTemplate.Height = 24;
            this.dtGVNCC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGVNCC.Size = new System.Drawing.Size(1162, 371);
            this.dtGVNCC.TabIndex = 137;
            this.dtGVNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVNCC_CellClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(310, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 55);
            this.label2.TabIndex = 138;
            this.label2.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // FormTTNCC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1162, 783);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGVNCC);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtNameNCC);
            this.Controls.Add(this.txtAdressNCC);
            this.Controls.Add(this.txtPhoneNCC);
            this.Controls.Add(this.lbMNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTTNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTTNCC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMNCC;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAdressNCC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhoneNCC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameNCC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtGVNCC;
        private System.Windows.Forms.Label label2;
    }
}