namespace CatBody
{
    partial class Form_Update_Data_Pemilik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update_Data_Pemilik));
            this.catBodyDataSet = new CatBody.CatBodyDataSet();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_A = new System.Windows.Forms.TextBox();
            this.pemilikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_NT = new System.Windows.Forms.TextBox();
            this.tb_JK = new System.Windows.Forms.TextBox();
            this.tb_NP = new System.Windows.Forms.TextBox();
            this.tb_IDP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pemilik_viewTableAdapter = new CatBody.CatBodyDataSetTableAdapters.Pemilik_viewTableAdapter();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLakilaki = new System.Windows.Forms.RadioButton();
            this.pemilikTableAdapter = new CatBody.CatBodyDataSetTableAdapters.PemilikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // catBodyDataSet
            // 
            this.catBodyDataSet.DataSetName = "CatBodyDataSet";
            this.catBodyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 66);
            this.panel5.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Update Data Pemilik";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.button2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(557, 743);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 56);
            this.button2.TabIndex = 138;
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
            this.button1.Location = new System.Drawing.Point(353, 743);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 137;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_A
            // 
            this.tb_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_A.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pemilikBindingSource, "Alamat", true));
            this.tb_A.Location = new System.Drawing.Point(165, 678);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(687, 26);
            this.tb_A.TabIndex = 136;
            // 
            // pemilikBindingSource
            // 
            this.pemilikBindingSource.DataMember = "Pemilik";
            this.pemilikBindingSource.DataSource = this.catBodyDataSet;
            // 
            // tb_NT
            // 
            this.tb_NT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_NT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pemilikBindingSource, "No_Telepon", true));
            this.tb_NT.Location = new System.Drawing.Point(165, 550);
            this.tb_NT.Name = "tb_NT";
            this.tb_NT.Size = new System.Drawing.Size(687, 26);
            this.tb_NT.TabIndex = 135;
            // 
            // tb_JK
            // 
            this.tb_JK.BackColor = System.Drawing.Color.White;
            this.tb_JK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_JK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pemilikBindingSource, "Jenis_Kelamin", true));
            this.tb_JK.Location = new System.Drawing.Point(165, 424);
            this.tb_JK.Name = "tb_JK";
            this.tb_JK.Size = new System.Drawing.Size(687, 19);
            this.tb_JK.TabIndex = 134;
            // 
            // tb_NP
            // 
            this.tb_NP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_NP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pemilikBindingSource, "Nama_Pemilik", true));
            this.tb_NP.Location = new System.Drawing.Point(165, 311);
            this.tb_NP.Name = "tb_NP";
            this.tb_NP.Size = new System.Drawing.Size(687, 26);
            this.tb_NP.TabIndex = 133;
            // 
            // tb_IDP
            // 
            this.tb_IDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(170)))));
            this.tb_IDP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pemilikBindingSource, "ID_Pemilik", true));
            this.tb_IDP.Location = new System.Drawing.Point(165, 187);
            this.tb_IDP.Name = "tb_IDP";
            this.tb_IDP.Size = new System.Drawing.Size(687, 26);
            this.tb_IDP.TabIndex = 132;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(159, 621);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 35);
            this.label13.TabIndex = 131;
            this.label13.Text = "Alamat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(159, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 35);
            this.label12.TabIndex = 130;
            this.label12.Text = "No. Telepon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(159, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 35);
            this.label11.TabIndex = 129;
            this.label11.Text = "Jenis Kelamin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(159, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 35);
            this.label10.TabIndex = 128;
            this.label10.Text = "Nama Pemilik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 35);
            this.label9.TabIndex = 127;
            this.label9.Text = "ID Pemilik";
            // 
            // pemilik_viewTableAdapter
            // 
            this.pemilik_viewTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton1;
            this.bindingNavigator2.BackColor = System.Drawing.Color.White;
            this.bindingNavigator2.BindingSource = this.pemilikBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 9F);
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.bindingNavigator2.Location = new System.Drawing.Point(307, 72);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(344, 45);
            this.bindingNavigator2.TabIndex = 139;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 40);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton2.Text = "Move first";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton3.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 29);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton4.Text = "Move next";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton5.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(262, 426);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(116, 24);
            this.rbPerempuan.TabIndex = 141;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLakilaki
            // 
            this.rbLakilaki.AutoSize = true;
            this.rbLakilaki.Location = new System.Drawing.Point(165, 426);
            this.rbLakilaki.Name = "rbLakilaki";
            this.rbLakilaki.Size = new System.Drawing.Size(91, 24);
            this.rbLakilaki.TabIndex = 140;
            this.rbLakilaki.TabStop = true;
            this.rbLakilaki.Text = "Laki-laki";
            this.rbLakilaki.UseVisualStyleBackColor = true;
            // 
            // pemilikTableAdapter
            // 
            this.pemilikTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Update_Data_Pemilik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 840);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLakilaki);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_A);
            this.Controls.Add(this.tb_NT);
            this.Controls.Add(this.tb_JK);
            this.Controls.Add(this.tb_NP);
            this.Controls.Add(this.tb_IDP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Update_Data_Pemilik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Update Data Pemilik";
            this.Load += new System.EventHandler(this.Form_Update_Data_Pemilik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CatBodyDataSet catBodyDataSet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_NT;
        private System.Windows.Forms.TextBox tb_JK;
        private System.Windows.Forms.TextBox tb_NP;
        private System.Windows.Forms.TextBox tb_IDP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private CatBodyDataSetTableAdapters.Pemilik_viewTableAdapter pemilik_viewTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLakilaki;
        private System.Windows.Forms.BindingSource pemilikBindingSource;
        private CatBodyDataSetTableAdapters.PemilikTableAdapter pemilikTableAdapter;
    }
}