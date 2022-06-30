namespace CatBody
{
    partial class Form_Update_Data_Pegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update_Data_Pegawai));
            this.kucingviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catBodyDataSet = new CatBody.CatBodyDataSet();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kucing_viewTableAdapter = new CatBody.CatBodyDataSetTableAdapters.Kucing_viewTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_A = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLakilaki = new System.Windows.Forms.RadioButton();
            this.tb_NT = new System.Windows.Forms.TextBox();
            this.tb_JK = new System.Windows.Forms.TextBox();
            this.tb_NP = new System.Windows.Forms.TextBox();
            this.tb_IDPG = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pegawaiTableAdapter = new CatBody.CatBodyDataSetTableAdapters.PegawaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kucingviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 45);
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 45);
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 45);
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 40);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.White;
            this.bindingNavigator1.BindingSource = this.pegawaiBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(321, 70);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(344, 45);
            this.bindingNavigator1.TabIndex = 110;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "Pegawai";
            this.pegawaiBindingSource.DataSource = this.catBodyDataSet;
            // 
            // kucing_viewTableAdapter
            // 
            this.kucing_viewTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Update Data Pegawai";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.button2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(546, 737);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 56);
            this.button2.TabIndex = 107;
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
            this.button1.Location = new System.Drawing.Point(342, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 106;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 66);
            this.panel5.TabIndex = 89;
            // 
            // tb_A
            // 
            this.tb_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_A.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "Alamat", true));
            this.tb_A.Location = new System.Drawing.Point(191, 677);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(633, 26);
            this.tb_A.TabIndex = 122;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(185, 620);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 35);
            this.label13.TabIndex = 121;
            this.label13.Text = "Alamat";
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(288, 436);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(116, 24);
            this.rbPerempuan.TabIndex = 120;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLakilaki
            // 
            this.rbLakilaki.AutoSize = true;
            this.rbLakilaki.Location = new System.Drawing.Point(191, 436);
            this.rbLakilaki.Name = "rbLakilaki";
            this.rbLakilaki.Size = new System.Drawing.Size(91, 24);
            this.rbLakilaki.TabIndex = 119;
            this.rbLakilaki.TabStop = true;
            this.rbLakilaki.Text = "Laki-laki";
            this.rbLakilaki.UseVisualStyleBackColor = true;
            // 
            // tb_NT
            // 
            this.tb_NT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_NT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "No_Telepon", true));
            this.tb_NT.Location = new System.Drawing.Point(191, 558);
            this.tb_NT.Name = "tb_NT";
            this.tb_NT.Size = new System.Drawing.Size(633, 26);
            this.tb_NT.TabIndex = 118;
            // 
            // tb_JK
            // 
            this.tb_JK.BackColor = System.Drawing.Color.White;
            this.tb_JK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_JK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "Jenis_Kelamin", true));
            this.tb_JK.Location = new System.Drawing.Point(191, 436);
            this.tb_JK.Name = "tb_JK";
            this.tb_JK.Size = new System.Drawing.Size(633, 19);
            this.tb_JK.TabIndex = 117;
            // 
            // tb_NP
            // 
            this.tb_NP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_NP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "Nama_Pegawai", true));
            this.tb_NP.Location = new System.Drawing.Point(191, 325);
            this.tb_NP.Name = "tb_NP";
            this.tb_NP.Size = new System.Drawing.Size(633, 26);
            this.tb_NP.TabIndex = 116;
            // 
            // tb_IDPG
            // 
            this.tb_IDPG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_IDPG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "ID_Pegawai", true));
            this.tb_IDPG.Location = new System.Drawing.Point(191, 207);
            this.tb_IDPG.Name = "tb_IDPG";
            this.tb_IDPG.Size = new System.Drawing.Size(633, 26);
            this.tb_IDPG.TabIndex = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(185, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 35);
            this.label12.TabIndex = 114;
            this.label12.Text = "No. Telepon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(185, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 35);
            this.label11.TabIndex = 113;
            this.label11.Text = "Jenis Kelamin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 35);
            this.label10.TabIndex = 112;
            this.label10.Text = "Nama Pegawai";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 35);
            this.label9.TabIndex = 111;
            this.label9.Text = "ID Pegawai";
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Update_Data_Pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 840);
            this.Controls.Add(this.tb_A);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLakilaki);
            this.Controls.Add(this.tb_NT);
            this.Controls.Add(this.tb_JK);
            this.Controls.Add(this.tb_NP);
            this.Controls.Add(this.tb_IDPG);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Update_Data_Pegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Update Data Pegawai";
            this.Load += new System.EventHandler(this.Form_Update_Data_Pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kucingviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource kucingviewBindingSource;
        private CatBodyDataSet catBodyDataSet;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private CatBodyDataSetTableAdapters.Kucing_viewTableAdapter kucing_viewTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLakilaki;
        private System.Windows.Forms.TextBox tb_NT;
        private System.Windows.Forms.TextBox tb_JK;
        private System.Windows.Forms.TextBox tb_NP;
        private System.Windows.Forms.TextBox tb_IDPG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private CatBodyDataSetTableAdapters.PegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
    }
}