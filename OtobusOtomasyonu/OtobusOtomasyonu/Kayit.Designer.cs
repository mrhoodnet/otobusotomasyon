
namespace OtobusOtomasyonu
{
    partial class Kayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskftelefon = new System.Windows.Forms.MaskedTextBox();
            this.rdbbay = new System.Windows.Forms.RadioButton();
            this.rtbbayan = new System.Windows.Forms.RadioButton();
            this.btniptal = new System.Windows.Forms.Button();
            this.btntamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(205, 12);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(151, 20);
            this.txtisim.TabIndex = 1;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(205, 59);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(151, 20);
            this.txtsoyisim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // mskftelefon
            // 
            this.mskftelefon.Location = new System.Drawing.Point(205, 96);
            this.mskftelefon.Mask = "(999) 000-0000";
            this.mskftelefon.Name = "mskftelefon";
            this.mskftelefon.Size = new System.Drawing.Size(151, 20);
            this.mskftelefon.TabIndex = 5;
            // 
            // rdbbay
            // 
            this.rdbbay.AutoSize = true;
            this.rdbbay.Checked = true;
            this.rdbbay.Location = new System.Drawing.Point(153, 148);
            this.rdbbay.Name = "rdbbay";
            this.rdbbay.Size = new System.Drawing.Size(46, 17);
            this.rdbbay.TabIndex = 6;
            this.rdbbay.TabStop = true;
            this.rdbbay.Text = "Bay";
            this.rdbbay.UseVisualStyleBackColor = true;
            this.rdbbay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rtbbayan
            // 
            this.rtbbayan.AutoSize = true;
            this.rtbbayan.Location = new System.Drawing.Point(259, 148);
            this.rtbbayan.Name = "rtbbayan";
            this.rtbbayan.Size = new System.Drawing.Size(60, 17);
            this.rtbbayan.TabIndex = 7;
            this.rtbbayan.Text = "Bayan";
            this.rtbbayan.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(153, 180);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(99, 23);
            this.btniptal.TabIndex = 8;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btntamam
            // 
            this.btntamam.Location = new System.Drawing.Point(259, 180);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(99, 23);
            this.btntamam.TabIndex = 9;
            this.btntamam.Text = "Tamam";
            this.btntamam.UseVisualStyleBackColor = true;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 297);
            this.Controls.Add(this.btntamam);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.rtbbayan);
            this.Controls.Add(this.rdbbay);
            this.Controls.Add(this.mskftelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btntamam;
        public System.Windows.Forms.TextBox txtisim;
        public System.Windows.Forms.TextBox txtsoyisim;
        public System.Windows.Forms.MaskedTextBox mskftelefon;
        public System.Windows.Forms.RadioButton rdbbay;
        public System.Windows.Forms.RadioButton rtbbayan;
    }
}