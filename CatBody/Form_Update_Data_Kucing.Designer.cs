namespace CatBody
{
    partial class Form_Update_Data_Kucing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update_Data_Kucing));
            this.rbBetina = new System.Windows.Forms.RadioButton();
            this.rbJantan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_UK = new System.Windows.Forms.TextBox();
            this.kucingviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catBodyDataSet = new CatBody.CatBodyDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_W = new System.Windows.Forms.TextBox();
            this.tb_R = new System.Windows.Forms.TextBox();
            this.tb_JK = new System.Windows.Forms.TextBox();
            this.tb_NK = new System.Windows.Forms.TextBox();
            this.tb_IDK = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kucing_viewTableAdapter = new CatBody.CatBodyDataSetTableAdapters.Kucing_viewTableAdapter();
            this.cb_IDPG = new System.Windows.Forms.ComboBox();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_IDPM = new System.Windows.Forms.ComboBox();
            this.pemilikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kucingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kucingTableAdapter = new CatBody.CatBodyDataSetTableAdapters.KucingTableAdapter();
            this.pegawaiTableAdapter = new CatBody.CatBodyDataSetTableAdapters.PegawaiTableAdapter();
            this.pemilikTableAdapter = new CatBody.CatBodyDataSetTableAdapters.PemilikTableAdapter();
            this.pemilikviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemilik_viewTableAdapter = new CatBody.CatBodyDataSetTableAdapters.Pemilik_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kucingviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBetina
            // 
            this.rbBetina.AutoSize = true;
            this.rbBetina.BackColor = System.Drawing.Color.Transparent;
            this.rbBetina.Location = new System.Drawing.Point(250, 599);
            this.rbBetina.Name = "rbBetina";
            this.rbBetina.Size = new System.Drawing.Size(80, 24);
            this.rbBetina.TabIndex = 87;
            this.rbBetina.TabStop = true;
            this.rbBetina.Text = "Betina";
            this.rbBetina.UseVisualStyleBackColor = false;
            // 
            // rbJantan
            // 
            this.rbJantan.AutoSize = true;
            this.rbJantan.BackColor = System.Drawing.Color.Transparent;
            this.rbJantan.Location = new System.Drawing.Point(161, 599);
            this.rbJantan.Name = "rbJantan";
            this.rbJantan.Size = new System.Drawing.Size(83, 24);
            this.rbJantan.TabIndex = 86;
            this.rbJantan.TabStop = true;
            this.rbJantan.Text = "Jantan";
            this.rbJantan.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Update Data Kucing";
            // 
            // tb_UK
            // 
            this.tb_UK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_UK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kucingviewBindingSource, "Umur", true));
            this.tb_UK.Location = new System.Drawing.Point(157, 513);
            this.tb_UK.Name = "tb_UK";
            this.tb_UK.Size = new System.Drawing.Size(701, 26);
            this.tb_UK.TabIndex = 80;
            // 
            // kucingviewBindingSource
            // 
            this.kucingviewBindingSource.DataMember = "Kucing_view";
            this.kucingviewBindingSource.DataSource = this.catBodyDataSet;
            // 
            // catBodyDataSet
            // 
            this.catBodyDataSet.DataSetName = "CatBodyDataSet";
            this.catBodyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.button2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(516, 835);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 56);
            this.button2.TabIndex = 85;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(312, 835);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 84;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_W
            // 
            this.tb_W.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_W.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kucingviewBindingSource, "Warna_Kucing", true));
            this.tb_W.Location = new System.Drawing.Point(161, 769);
            this.tb_W.Name = "tb_W";
            this.tb_W.Size = new System.Drawing.Size(697, 26);
            this.tb_W.TabIndex = 83;
            // 
            // tb_R
            // 
            this.tb_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_R.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kucingviewBindingSource, "Ras", true));
            this.tb_R.Location = new System.Drawing.Point(161, 679);
            this.tb_R.Name = "tb_R";
            this.tb_R.Size = new System.Drawing.Size(697, 26);
            this.tb_R.TabIndex = 82;
            // 
            // tb_JK
            // 
            this.tb_JK.BackColor = System.Drawing.Color.White;
            this.tb_JK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_JK.Location = new System.Drawing.Point(157, 597);
            this.tb_JK.Name = "tb_JK";
            this.tb_JK.Size = new System.Drawing.Size(701, 19);
            this.tb_JK.TabIndex = 81;
            // 
            // tb_NK
            // 
            this.tb_NK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_NK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kucingviewBindingSource, "Nama_Kucing", true));
            this.tb_NK.Location = new System.Drawing.Point(157, 435);
            this.tb_NK.Name = "tb_NK";
            this.tb_NK.Size = new System.Drawing.Size(701, 26);
            this.tb_NK.TabIndex = 79;
            // 
            // tb_IDK
            // 
            this.tb_IDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_IDK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kucingviewBindingSource, "ID_Kucing", true));
            this.tb_IDK.Location = new System.Drawing.Point(157, 176);
            this.tb_IDK.Name = "tb_IDK";
            this.tb_IDK.Size = new System.Drawing.Size(701, 26);
            this.tb_IDK.TabIndex = 76;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(155, 722);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 35);
            this.label16.TabIndex = 75;
            this.label16.Text = "Warna";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(155, 559);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 35);
            this.label14.TabIndex = 73;
            this.label14.Text = "Jenis Kelamin";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(155, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 35);
            this.label13.TabIndex = 72;
            this.label13.Text = "Umur Kucing";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 35);
            this.label12.TabIndex = 71;
            this.label12.Text = "Nama Kucing";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(151, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 35);
            this.label11.TabIndex = 70;
            this.label11.Text = "ID Pegawai";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 35);
            this.label10.TabIndex = 69;
            this.label10.Text = "ID Pemilik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 35);
            this.label9.TabIndex = 68;
            this.label9.Text = "ID Kucing";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 66);
            this.panel5.TabIndex = 67;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(155, 641);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 35);
            this.label15.TabIndex = 74;
            this.label15.Text = "Ras";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.White;
            this.bindingNavigator1.BindingSource = this.kucingviewBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 9F);
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(312, 69);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(344, 45);
            this.bindingNavigator1.TabIndex = 88;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 40);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 29);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // kucing_viewTableAdapter
            // 
            this.kucing_viewTableAdapter.ClearBeforeFill = true;
            // 
            // cb_IDPG
            // 
            this.cb_IDPG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.cb_IDPG.DataSource = this.pegawaiBindingSource;
            this.cb_IDPG.DisplayMember = "ID_Pegawai";
            this.cb_IDPG.FormattingEnabled = true;
            this.cb_IDPG.Location = new System.Drawing.Point(157, 353);
            this.cb_IDPG.Name = "cb_IDPG";
            this.cb_IDPG.Size = new System.Drawing.Size(701, 28);
            this.cb_IDPG.TabIndex = 90;
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "Pegawai";
            this.pegawaiBindingSource.DataSource = this.catBodyDataSet;
            // 
            // cb_IDPM
            // 
            this.cb_IDPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.cb_IDPM.DataSource = this.pemilikBindingSource;
            this.cb_IDPM.DisplayMember = "ID_Pemilik";
            this.cb_IDPM.FormattingEnabled = true;
            this.cb_IDPM.Location = new System.Drawing.Point(157, 266);
            this.cb_IDPM.Name = "cb_IDPM";
            this.cb_IDPM.Size = new System.Drawing.Size(701, 28);
            this.cb_IDPM.TabIndex = 89;
            // 
            // pemilikBindingSource
            // 
            this.pemilikBindingSource.DataMember = "Pemilik";
            this.pemilikBindingSource.DataSource = this.catBodyDataSet;
            // 
            // kucingBindingSource
            // 
            this.kucingBindingSource.DataMember = "Kucing";
            this.kucingBindingSource.DataSource = this.catBodyDataSet;
            // 
            // kucingTableAdapter
            // 
            this.kucingTableAdapter.ClearBeforeFill = true;
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // pemilikTableAdapter
            // 
            this.pemilikTableAdapter.ClearBeforeFill = true;
            // 
            // pemilikviewBindingSource
            // 
            this.pemilikviewBindingSource.DataMember = "Pemilik_view";
            this.pemilikviewBindingSource.DataSource = this.catBodyDataSet;
            // 
            // pemilik_viewTableAdapter
            // 
            this.pemilik_viewTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Update_Data_Kucing
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 943);
            this.Controls.Add(this.cb_IDPG);
            this.Controls.Add(this.cb_IDPM);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.rbBetina);
            this.Controls.Add(this.rbJantan);
            this.Controls.Add(this.tb_UK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_W);
            this.Controls.Add(this.tb_R);
            this.Controls.Add(this.tb_JK);
            this.Controls.Add(this.tb_NK);
            this.Controls.Add(this.tb_IDK);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Update_Data_Kucing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Update Data Kucing";
            this.Load += new System.EventHandler(this.Form_Update_Data_Kucing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kucingviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBetina;
        private System.Windows.Forms.RadioButton rbJantan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_UK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_W;
        private System.Windows.Forms.TextBox tb_R;
        private System.Windows.Forms.TextBox tb_JK;
        private System.Windows.Forms.TextBox tb_NK;
        private System.Windows.Forms.TextBox tb_IDK;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private CatBodyDataSet catBodyDataSet;
        private CatBodyDataSetTableAdapters.Kucing_viewTableAdapter kucing_viewTableAdapter;
        private System.Windows.Forms.BindingSource kucingviewBindingSource;
        private System.Windows.Forms.ComboBox cb_IDPG;
        private System.Windows.Forms.ComboBox cb_IDPM;
        private System.Windows.Forms.BindingSource kucingBindingSource;
        private CatBodyDataSetTableAdapters.KucingTableAdapter kucingTableAdapter;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private CatBodyDataSetTableAdapters.PegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.BindingSource pemilikBindingSource;
        private CatBodyDataSetTableAdapters.PemilikTableAdapter pemilikTableAdapter;
        private System.Windows.Forms.BindingSource pemilikviewBindingSource;
        private CatBodyDataSetTableAdapters.Pemilik_viewTableAdapter pemilik_viewTableAdapter;
    }
}