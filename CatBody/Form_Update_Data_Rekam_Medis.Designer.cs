namespace CatBody
{
    partial class Form_Update_Data_Rekam_Medis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update_Data_Rekam_Medis));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.rekamMedisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catBodyDataSet = new CatBody.CatBodyDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_IDRM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rekam_MedisTableAdapter = new CatBody.CatBodyDataSetTableAdapters.Rekam_MedisTableAdapter();
            this.cb_IDV = new System.Windows.Forms.ComboBox();
            this.vaksinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_IDK = new System.Windows.Forms.ComboBox();
            this.kucingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kucingTableAdapter = new CatBody.CatBodyDataSetTableAdapters.KucingTableAdapter();
            this.vaksinTableAdapter = new CatBody.CatBodyDataSetTableAdapters.VaksinTableAdapter();
            this.dtp_V1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_V2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekamMedisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaksinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.White;
            this.bindingNavigator1.BindingSource = this.rekamMedisBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(321, 69);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(344, 45);
            this.bindingNavigator1.TabIndex = 128;
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
            // rekamMedisBindingSource
            // 
            this.rekamMedisBindingSource.DataMember = "Rekam_Medis";
            this.rekamMedisBindingSource.DataSource = this.catBodyDataSet;
            // 
            // catBodyDataSet
            // 
            this.catBodyDataSet.DataSetName = "CatBodyDataSet";
            this.catBodyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 66);
            this.panel5.TabIndex = 127;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Update Data Rekam Medis";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.button2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(553, 728);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 56);
            this.button2.TabIndex = 140;
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
            this.button1.Location = new System.Drawing.Point(349, 728);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 139;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_IDRM
            // 
            this.tb_IDRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_IDRM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rekamMedisBindingSource, "ID_RM", true));
            this.tb_IDRM.Location = new System.Drawing.Point(199, 201);
            this.tb_IDRM.Name = "tb_IDRM";
            this.tb_IDRM.Size = new System.Drawing.Size(644, 26);
            this.tb_IDRM.TabIndex = 134;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(190, 575);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 35);
            this.label13.TabIndex = 133;
            this.label13.Text = "Vaksin Kedua";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 35);
            this.label12.TabIndex = 132;
            this.label12.Text = "Vaksin Pertama";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(190, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 35);
            this.label11.TabIndex = 131;
            this.label11.Text = "ID Vaksin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(193, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 35);
            this.label10.TabIndex = 130;
            this.label10.Text = "ID Kucing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(190, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 35);
            this.label9.TabIndex = 129;
            this.label9.Text = "ID Rekam Medis";
            // 
            // rekam_MedisTableAdapter
            // 
            this.rekam_MedisTableAdapter.ClearBeforeFill = true;
            // 
            // cb_IDV
            // 
            this.cb_IDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.cb_IDV.DataSource = this.vaksinBindingSource;
            this.cb_IDV.DisplayMember = "ID_Vaksin";
            this.cb_IDV.FormattingEnabled = true;
            this.cb_IDV.Location = new System.Drawing.Point(199, 406);
            this.cb_IDV.Name = "cb_IDV";
            this.cb_IDV.Size = new System.Drawing.Size(644, 28);
            this.cb_IDV.TabIndex = 142;
            // 
            // vaksinBindingSource
            // 
            this.vaksinBindingSource.DataMember = "Vaksin";
            this.vaksinBindingSource.DataSource = this.catBodyDataSet;
            // 
            // cb_IDK
            // 
            this.cb_IDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.cb_IDK.DataSource = this.kucingBindingSource;
            this.cb_IDK.DisplayMember = "ID_Kucing";
            this.cb_IDK.FormattingEnabled = true;
            this.cb_IDK.Location = new System.Drawing.Point(196, 299);
            this.cb_IDK.Name = "cb_IDK";
            this.cb_IDK.Size = new System.Drawing.Size(647, 28);
            this.cb_IDK.TabIndex = 141;
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
            // vaksinTableAdapter
            // 
            this.vaksinTableAdapter.ClearBeforeFill = true;
            // 
            // dtp_V1
            // 
            this.dtp_V1.CalendarFont = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_V1.Checked = false;
            this.dtp_V1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rekamMedisBindingSource, "Vaksin_Pertama", true));
            this.dtp_V1.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.dtp_V1.Location = new System.Drawing.Point(199, 526);
            this.dtp_V1.Name = "dtp_V1";
            this.dtp_V1.Size = new System.Drawing.Size(644, 27);
            this.dtp_V1.TabIndex = 143;
            // 
            // dtp_V2
            // 
            this.dtp_V2.CalendarFont = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_V2.Checked = false;
            this.dtp_V2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rekamMedisBindingSource, "Vaksin_Berikutnya", true));
            this.dtp_V2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.dtp_V2.Location = new System.Drawing.Point(199, 643);
            this.dtp_V2.Name = "dtp_V2";
            this.dtp_V2.Size = new System.Drawing.Size(644, 27);
            this.dtp_V2.TabIndex = 144;
            // 
            // Form_Update_Data_Rekam_Medis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 840);
            this.Controls.Add(this.dtp_V2);
            this.Controls.Add(this.dtp_V1);
            this.Controls.Add(this.cb_IDV);
            this.Controls.Add(this.cb_IDK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_IDRM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Update_Data_Rekam_Medis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Update Data Rekam Medis";
            this.Load += new System.EventHandler(this.Form_Update_Data_Rekam_Medis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekamMedisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaksinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_IDRM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private CatBodyDataSet catBodyDataSet;
        private System.Windows.Forms.BindingSource rekamMedisBindingSource;
        private CatBodyDataSetTableAdapters.Rekam_MedisTableAdapter rekam_MedisTableAdapter;
        private System.Windows.Forms.ComboBox cb_IDV;
        private System.Windows.Forms.ComboBox cb_IDK;
        private System.Windows.Forms.BindingSource kucingBindingSource;
        private CatBodyDataSetTableAdapters.KucingTableAdapter kucingTableAdapter;
        private System.Windows.Forms.BindingSource vaksinBindingSource;
        private CatBodyDataSetTableAdapters.VaksinTableAdapter vaksinTableAdapter;
        private System.Windows.Forms.DateTimePicker dtp_V1;
        private System.Windows.Forms.DateTimePicker dtp_V2;
    }
}