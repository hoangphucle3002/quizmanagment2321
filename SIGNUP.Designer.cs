namespace Interface
{
    partial class SIGNUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNUP));
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtentaikhoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbmonhoc = new System.Windows.Forms.ComboBox();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.lbDayMon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdGiaovien = new System.Windows.Forms.RadioButton();
            this.rdThisinh = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hinhdangky = new System.Windows.Forms.PictureBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangky = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhdangky)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmatkhau.Location = new System.Drawing.Point(66, 411);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(179, 26);
            this.txtmatkhau.TabIndex = 15;
            // 
            // txtentaikhoan
            // 
            this.txtentaikhoan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtentaikhoan.Location = new System.Drawing.Point(66, 309);
            this.txtentaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtentaikhoan.Name = "txtentaikhoan";
            this.txtentaikhoan.Size = new System.Drawing.Size(177, 26);
            this.txtentaikhoan.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(96, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "USERNAME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(96, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "PASSWORD:";
            // 
            // cbmonhoc
            // 
            this.cbmonhoc.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbmonhoc.FormattingEnabled = true;
            this.cbmonhoc.Location = new System.Drawing.Point(112, 175);
            this.cbmonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbmonhoc.Name = "cbmonhoc";
            this.cbmonhoc.Size = new System.Drawing.Size(111, 28);
            this.cbmonhoc.TabIndex = 9;
            this.cbmonhoc.SelectedIndexChanged += new System.EventHandler(this.cbmonhoc_SelectedIndexChanged);
            this.cbmonhoc.Click += new System.EventHandler(this.cbmonhoc_Click);
            // 
            // datengaysinh
            // 
            this.datengaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(243, 134);
            this.datengaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(138, 26);
            this.datengaysinh.TabIndex = 8;
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(83, 132);
            this.cbgioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(76, 28);
            this.cbgioitinh.TabIndex = 7;
            // 
            // txtmaso
            // 
            this.txtmaso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtmaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmaso.Location = new System.Drawing.Point(83, 81);
            this.txtmaso.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.Size = new System.Drawing.Size(298, 26);
            this.txtmaso.TabIndex = 6;
            // 
            // txthovaten
            // 
            this.txthovaten.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txthovaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txthovaten.Location = new System.Drawing.Point(83, 37);
            this.txthovaten.Margin = new System.Windows.Forms.Padding(4);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(298, 26);
            this.txthovaten.TabIndex = 5;
            // 
            // lbDayMon
            // 
            this.lbDayMon.AutoSize = true;
            this.lbDayMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDayMon.Location = new System.Drawing.Point(13, 178);
            this.lbDayMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDayMon.Name = "lbDayMon";
            this.lbDayMon.Size = new System.Drawing.Size(91, 20);
            this.lbDayMon.TabIndex = 4;
            this.lbDayMon.Text = "SUBJECT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(180, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "BIRTH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "SEX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdGiaovien
            // 
            this.rdGiaovien.AutoSize = true;
            this.rdGiaovien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdGiaovien.Location = new System.Drawing.Point(303, 378);
            this.rdGiaovien.Margin = new System.Windows.Forms.Padding(4);
            this.rdGiaovien.Name = "rdGiaovien";
            this.rdGiaovien.Size = new System.Drawing.Size(110, 24);
            this.rdGiaovien.TabIndex = 3;
            this.rdGiaovien.TabStop = true;
            this.rdGiaovien.Text = "TEACHER";
            this.rdGiaovien.UseVisualStyleBackColor = true;
            this.rdGiaovien.CheckedChanged += new System.EventHandler(this.rdGiaovien_CheckedChanged);
            // 
            // rdThisinh
            // 
            this.rdThisinh.AutoSize = true;
            this.rdThisinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdThisinh.Location = new System.Drawing.Point(303, 332);
            this.rdThisinh.Margin = new System.Windows.Forms.Padding(4);
            this.rdThisinh.Name = "rdThisinh";
            this.rdThisinh.Size = new System.Drawing.Size(104, 24);
            this.rdThisinh.TabIndex = 2;
            this.rdThisinh.TabStop = true;
            this.rdThisinh.Text = "MEMBER";
            this.rdThisinh.UseVisualStyleBackColor = true;
            this.rdThisinh.CheckedChanged += new System.EventHandler(this.rdThisinh_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.hinhdangky);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(573, 112);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(187, 10);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn hình";
            // 
            // hinhdangky
            // 
            this.hinhdangky.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hinhdangky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hinhdangky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hinhdangky.Location = new System.Drawing.Point(4, 23);
            this.hinhdangky.Margin = new System.Windows.Forms.Padding(4);
            this.hinhdangky.Name = "hinhdangky";
            this.hinhdangky.Size = new System.Drawing.Size(179, 0);
            this.hinhdangky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhdangky.TabIndex = 0;
            this.hinhdangky.TabStop = false;
            this.hinhdangky.Click += new System.EventHandler(this.hinhdangky_Click);
            this.hinhdangky.MouseLeave += new System.EventHandler(this.hinhdangky_MouseLeave);
            this.hinhdangky.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hinhdangky_MouseMove);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthoat.Location = new System.Drawing.Point(484, 315);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(71, 59);
            this.btthoat.TabIndex = 1;
            this.btthoat.Text = "EXIT";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            this.btthoat.MouseLeave += new System.EventHandler(this.btthoat_MouseLeave);
            this.btthoat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btthoat_MouseMove);
            // 
            // btdangky
            // 
            this.btdangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btdangky.Location = new System.Drawing.Point(484, 382);
            this.btdangky.Margin = new System.Windows.Forms.Padding(4);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(71, 59);
            this.btdangky.TabIndex = 0;
            this.btdangky.Text = "SIGN UP";
            this.btdangky.UseVisualStyleBackColor = true;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            this.btdangky.MouseLeave += new System.EventHandler(this.btdangky_MouseLeave);
            this.btdangky.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btdangky_MouseMove);
            // 
            // SIGNUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 517);
            this.Controls.Add(this.rdGiaovien);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.rdThisinh);
            this.Controls.Add(this.txtentaikhoan);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.cbmonhoc);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lbDayMon);
            this.Controls.Add(this.datengaysinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbgioitinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthovaten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(607, 564);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(607, 564);
            this.Name = "SIGNUP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGN UP";
            this.Load += new System.EventHandler(this.DANGKY_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hinhdangky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaso;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.Label lbDayMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.ComboBox cbmonhoc;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.RadioButton rdGiaovien;
        private System.Windows.Forms.RadioButton rdThisinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox hinhdangky;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtentaikhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}