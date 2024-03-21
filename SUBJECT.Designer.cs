namespace Interface
{
    partial class SUBJECT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.txttenmonhoc = new System.Windows.Forms.TextBox();
            this.txtmamonhoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg_monhoc = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_monhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtrangthai);
            this.groupBox1.Controls.Add(this.txttenmonhoc);
            this.groupBox1.Controls.Add(this.txtmamonhoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(110, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(320, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.AutoSize = true;
            this.lbtrangthai.Location = new System.Drawing.Point(8, 138);
            this.lbtrangthai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(0, 16);
            this.lbtrangthai.TabIndex = 4;
            // 
            // txttenmonhoc
            // 
            this.txttenmonhoc.Location = new System.Drawing.Point(51, 86);
            this.txttenmonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.txttenmonhoc.Name = "txttenmonhoc";
            this.txttenmonhoc.Size = new System.Drawing.Size(241, 22);
            this.txttenmonhoc.TabIndex = 3;
            // 
            // txtmamonhoc
            // 
            this.txtmamonhoc.Location = new System.Drawing.Point(51, 33);
            this.txtmamonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtmamonhoc.Name = "txtmamonhoc";
            this.txtmamonhoc.Size = new System.Drawing.Size(241, 22);
            this.txtmamonhoc.TabIndex = 2;
            this.txtmamonhoc.TextChanged += new System.EventHandler(this.txtmamonhoc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(392, 153);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 28);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Exit";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(149, 153);
            this.btxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(100, 28);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "-";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(273, 153);
            this.btsua.Margin = new System.Windows.Forms.Padding(4);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(100, 28);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "Change";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(27, 153);
            this.btthem.Margin = new System.Windows.Forms.Padding(4);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(100, 28);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "+";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dg_monhoc);
            this.groupBox3.Location = new System.Drawing.Point(16, 187);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(476, 314);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List";
            // 
            // dg_monhoc
            // 
            this.dg_monhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_monhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_monhoc.Location = new System.Drawing.Point(4, 19);
            this.dg_monhoc.Margin = new System.Windows.Forms.Padding(4);
            this.dg_monhoc.Name = "dg_monhoc";
            this.dg_monhoc.RowHeadersWidth = 51;
            this.dg_monhoc.Size = new System.Drawing.Size(468, 291);
            this.dg_monhoc.TabIndex = 0;
            this.dg_monhoc.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg_monhoc_DataError);
            this.dg_monhoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_monhoc_RowEnter);
            // 
            // SUBJECT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 516);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btthem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SUBJECT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.MONHOC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_monhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtrangthai;
        private System.Windows.Forms.TextBox txttenmonhoc;
        private System.Windows.Forms.TextBox txtmamonhoc;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_monhoc;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}