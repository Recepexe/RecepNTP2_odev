namespace listboxlistele
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxString = new System.Windows.Forms.ListBox();
            this.listBoxInt = new System.Windows.Forms.ListBox();
            this.listBoxFloat = new System.Windows.Forms.ListBox();
            this.listBoxBool = new System.Windows.Forms.ListBox();
            this.btnStringListele = new System.Windows.Forms.Button();
            this.btnIntListele = new System.Windows.Forms.Button();
            this.btnFloatListele = new System.Windows.Forms.Button();
            this.btnBoolListele = new System.Windows.Forms.Button();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.btnStringEkle = new System.Windows.Forms.Button();
            this.btnIntEkle = new System.Windows.Forms.Button();
            this.btnFloatEkle = new System.Windows.Forms.Button();
            this.btnBoolEkle = new System.Windows.Forms.Button();
            this.radioButtonFalse = new System.Windows.Forms.RadioButton();
            this.btnStringTemizle = new System.Windows.Forms.Button();
            this.btnIntTemizle = new System.Windows.Forms.Button();
            this.btnFloatTemizle = new System.Windows.Forms.Button();
            this.btnBoolTemizle = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtFloat = new System.Windows.Forms.TextBox();
            this.labelStringCount = new System.Windows.Forms.Label();
            this.labelIntCount = new System.Windows.Forms.Label();
            this.labelFloatCount = new System.Windows.Forms.Label();
            this.labelBoolCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "String Listeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İnt Listeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Float Listeler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bool Listeler";
            // 
            // listBoxString
            // 
            this.listBoxString.FormattingEnabled = true;
            this.listBoxString.ItemHeight = 16;
            this.listBoxString.Location = new System.Drawing.Point(12, 198);
            this.listBoxString.Name = "listBoxString";
            this.listBoxString.Size = new System.Drawing.Size(208, 164);
            this.listBoxString.TabIndex = 4;
            // 
            // listBoxInt
            // 
            this.listBoxInt.FormattingEnabled = true;
            this.listBoxInt.ItemHeight = 16;
            this.listBoxInt.Location = new System.Drawing.Point(288, 198);
            this.listBoxInt.Name = "listBoxInt";
            this.listBoxInt.Size = new System.Drawing.Size(211, 164);
            this.listBoxInt.TabIndex = 5;
            // 
            // listBoxFloat
            // 
            this.listBoxFloat.FormattingEnabled = true;
            this.listBoxFloat.ItemHeight = 16;
            this.listBoxFloat.Location = new System.Drawing.Point(550, 198);
            this.listBoxFloat.Name = "listBoxFloat";
            this.listBoxFloat.Size = new System.Drawing.Size(211, 164);
            this.listBoxFloat.TabIndex = 6;
            // 
            // listBoxBool
            // 
            this.listBoxBool.FormattingEnabled = true;
            this.listBoxBool.ItemHeight = 16;
            this.listBoxBool.Location = new System.Drawing.Point(819, 198);
            this.listBoxBool.Name = "listBoxBool";
            this.listBoxBool.Size = new System.Drawing.Size(214, 164);
            this.listBoxBool.TabIndex = 7;
            // 
            // btnStringListele
            // 
            this.btnStringListele.Location = new System.Drawing.Point(12, 415);
            this.btnStringListele.Name = "btnStringListele";
            this.btnStringListele.Size = new System.Drawing.Size(212, 23);
            this.btnStringListele.TabIndex = 8;
            this.btnStringListele.Text = "String Listesini ListBox\'a Listele";
            this.btnStringListele.UseVisualStyleBackColor = true;
            this.btnStringListele.Click += new System.EventHandler(this.btnStringListele_Click);
            // 
            // btnIntListele
            // 
            this.btnIntListele.Location = new System.Drawing.Point(288, 415);
            this.btnIntListele.Name = "btnIntListele";
            this.btnIntListele.Size = new System.Drawing.Size(211, 23);
            this.btnIntListele.TabIndex = 9;
            this.btnIntListele.Text = "int Listesini ListBox\'a Listele";
            this.btnIntListele.UseVisualStyleBackColor = true;
            this.btnIntListele.Click += new System.EventHandler(this.btnIntListele_Click);
            // 
            // btnFloatListele
            // 
            this.btnFloatListele.Location = new System.Drawing.Point(545, 415);
            this.btnFloatListele.Name = "btnFloatListele";
            this.btnFloatListele.Size = new System.Drawing.Size(216, 23);
            this.btnFloatListele.TabIndex = 10;
            this.btnFloatListele.Text = "float Listesini ListBox\'a Listele";
            this.btnFloatListele.UseVisualStyleBackColor = true;
            this.btnFloatListele.Click += new System.EventHandler(this.btnFloatListele_Click);
            // 
            // btnBoolListele
            // 
            this.btnBoolListele.Location = new System.Drawing.Point(819, 415);
            this.btnBoolListele.Name = "btnBoolListele";
            this.btnBoolListele.Size = new System.Drawing.Size(214, 23);
            this.btnBoolListele.TabIndex = 11;
            this.btnBoolListele.Text = "bool Listesini ListBox\'a Listele";
            this.btnBoolListele.UseVisualStyleBackColor = true;
            this.btnBoolListele.Click += new System.EventHandler(this.btnBoolListele_Click);
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Location = new System.Drawing.Point(890, 111);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(65, 20);
            this.radioButtonTrue.TabIndex = 12;
            this.radioButtonTrue.TabStop = true;
            this.radioButtonTrue.Text = "Yanlış";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // btnStringEkle
            // 
            this.btnStringEkle.Location = new System.Drawing.Point(12, 140);
            this.btnStringEkle.Name = "btnStringEkle";
            this.btnStringEkle.Size = new System.Drawing.Size(208, 23);
            this.btnStringEkle.TabIndex = 13;
            this.btnStringEkle.Text = "String Listesine Ekle";
            this.btnStringEkle.UseVisualStyleBackColor = true;
            this.btnStringEkle.Click += new System.EventHandler(this.btnStringEkle_Click);
            // 
            // btnIntEkle
            // 
            this.btnIntEkle.Location = new System.Drawing.Point(288, 140);
            this.btnIntEkle.Name = "btnIntEkle";
            this.btnIntEkle.Size = new System.Drawing.Size(211, 23);
            this.btnIntEkle.TabIndex = 14;
            this.btnIntEkle.Text = "int Listesine Ekle";
            this.btnIntEkle.UseVisualStyleBackColor = true;
            this.btnIntEkle.Click += new System.EventHandler(this.btnIntEkle_Click);
            // 
            // btnFloatEkle
            // 
            this.btnFloatEkle.Location = new System.Drawing.Point(545, 140);
            this.btnFloatEkle.Name = "btnFloatEkle";
            this.btnFloatEkle.Size = new System.Drawing.Size(216, 23);
            this.btnFloatEkle.TabIndex = 15;
            this.btnFloatEkle.Text = "Float Listesine Ekle";
            this.btnFloatEkle.UseVisualStyleBackColor = true;
            this.btnFloatEkle.Click += new System.EventHandler(this.btnFloatEkle_Click);
            // 
            // btnBoolEkle
            // 
            this.btnBoolEkle.Location = new System.Drawing.Point(819, 140);
            this.btnBoolEkle.Name = "btnBoolEkle";
            this.btnBoolEkle.Size = new System.Drawing.Size(200, 23);
            this.btnBoolEkle.TabIndex = 16;
            this.btnBoolEkle.Text = "Bool Listesine Ekle";
            this.btnBoolEkle.UseVisualStyleBackColor = true;
            this.btnBoolEkle.Click += new System.EventHandler(this.btnBoolEkle_Click);
            // 
            // radioButtonFalse
            // 
            this.radioButtonFalse.AutoSize = true;
            this.radioButtonFalse.Location = new System.Drawing.Point(819, 111);
            this.radioButtonFalse.Name = "radioButtonFalse";
            this.radioButtonFalse.Size = new System.Drawing.Size(65, 20);
            this.radioButtonFalse.TabIndex = 17;
            this.radioButtonFalse.TabStop = true;
            this.radioButtonFalse.Text = "Doğru";
            this.radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // btnStringTemizle
            // 
            this.btnStringTemizle.Location = new System.Drawing.Point(12, 377);
            this.btnStringTemizle.Name = "btnStringTemizle";
            this.btnStringTemizle.Size = new System.Drawing.Size(212, 23);
            this.btnStringTemizle.TabIndex = 18;
            this.btnStringTemizle.Text = "ListBox\'ı Temizle";
            this.btnStringTemizle.UseVisualStyleBackColor = true;
            this.btnStringTemizle.Click += new System.EventHandler(this.btnStringTemizle_Click);
            // 
            // btnIntTemizle
            // 
            this.btnIntTemizle.Location = new System.Drawing.Point(288, 377);
            this.btnIntTemizle.Name = "btnIntTemizle";
            this.btnIntTemizle.Size = new System.Drawing.Size(211, 23);
            this.btnIntTemizle.TabIndex = 19;
            this.btnIntTemizle.Text = "ListBox\'ı Temizle";
            this.btnIntTemizle.UseVisualStyleBackColor = true;
            this.btnIntTemizle.Click += new System.EventHandler(this.btnIntTemizle_Click);
            // 
            // btnFloatTemizle
            // 
            this.btnFloatTemizle.Location = new System.Drawing.Point(545, 377);
            this.btnFloatTemizle.Name = "btnFloatTemizle";
            this.btnFloatTemizle.Size = new System.Drawing.Size(216, 23);
            this.btnFloatTemizle.TabIndex = 20;
            this.btnFloatTemizle.Text = "ListBox\'ı Temizle";
            this.btnFloatTemizle.UseVisualStyleBackColor = true;
            this.btnFloatTemizle.Click += new System.EventHandler(this.btnFloatTemizle_Click);
            // 
            // btnBoolTemizle
            // 
            this.btnBoolTemizle.Location = new System.Drawing.Point(819, 377);
            this.btnBoolTemizle.Name = "btnBoolTemizle";
            this.btnBoolTemizle.Size = new System.Drawing.Size(214, 23);
            this.btnBoolTemizle.TabIndex = 21;
            this.btnBoolTemizle.Text = "ListBox\'ı Temizle";
            this.btnBoolTemizle.UseVisualStyleBackColor = true;
            this.btnBoolTemizle.Click += new System.EventHandler(this.btnBoolTemizle_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(16, 102);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(204, 22);
            this.txtString.TabIndex = 22;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(288, 102);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(211, 22);
            this.txtInt.TabIndex = 23;
            // 
            // txtFloat
            // 
            this.txtFloat.Location = new System.Drawing.Point(550, 102);
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.Size = new System.Drawing.Size(211, 22);
            this.txtFloat.TabIndex = 24;
            // 
            // labelStringCount
            // 
            this.labelStringCount.AutoSize = true;
            this.labelStringCount.Location = new System.Drawing.Point(9, 179);
            this.labelStringCount.Name = "labelStringCount";
            this.labelStringCount.Size = new System.Drawing.Size(174, 16);
            this.labelStringCount.TabIndex = 25;
            this.labelStringCount.Text = "String Listesi Eleman Sayısı:";
            // 
            // labelIntCount
            // 
            this.labelIntCount.AutoSize = true;
            this.labelIntCount.Location = new System.Drawing.Point(285, 179);
            this.labelIntCount.Name = "labelIntCount";
            this.labelIntCount.Size = new System.Drawing.Size(153, 16);
            this.labelIntCount.TabIndex = 26;
            this.labelIntCount.Text = "int Listesi Eleman Sayısı:";
            // 
            // labelFloatCount
            // 
            this.labelFloatCount.AutoSize = true;
            this.labelFloatCount.Location = new System.Drawing.Point(547, 179);
            this.labelFloatCount.Name = "labelFloatCount";
            this.labelFloatCount.Size = new System.Drawing.Size(165, 16);
            this.labelFloatCount.TabIndex = 27;
            this.labelFloatCount.Text = "float Listesi Eleman Sayısı:";
            // 
            // labelBoolCount
            // 
            this.labelBoolCount.AutoSize = true;
            this.labelBoolCount.Location = new System.Drawing.Point(816, 176);
            this.labelBoolCount.Name = "labelBoolCount";
            this.labelBoolCount.Size = new System.Drawing.Size(167, 16);
            this.labelBoolCount.TabIndex = 28;
            this.labelBoolCount.Text = "bool Listesi Eleman Sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 599);
            this.Controls.Add(this.labelBoolCount);
            this.Controls.Add(this.labelFloatCount);
            this.Controls.Add(this.labelIntCount);
            this.Controls.Add(this.labelStringCount);
            this.Controls.Add(this.txtFloat);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnBoolTemizle);
            this.Controls.Add(this.btnFloatTemizle);
            this.Controls.Add(this.btnIntTemizle);
            this.Controls.Add(this.btnStringTemizle);
            this.Controls.Add(this.radioButtonFalse);
            this.Controls.Add(this.btnBoolEkle);
            this.Controls.Add(this.btnFloatEkle);
            this.Controls.Add(this.btnIntEkle);
            this.Controls.Add(this.btnStringEkle);
            this.Controls.Add(this.radioButtonTrue);
            this.Controls.Add(this.btnBoolListele);
            this.Controls.Add(this.btnFloatListele);
            this.Controls.Add(this.btnIntListele);
            this.Controls.Add(this.btnStringListele);
            this.Controls.Add(this.listBoxBool);
            this.Controls.Add(this.listBoxFloat);
            this.Controls.Add(this.listBoxInt);
            this.Controls.Add(this.listBoxString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxString;
        private System.Windows.Forms.ListBox listBoxInt;
        private System.Windows.Forms.ListBox listBoxFloat;
        private System.Windows.Forms.ListBox listBoxBool;
        private System.Windows.Forms.Button btnStringListele;
        private System.Windows.Forms.Button btnIntListele;
        private System.Windows.Forms.Button btnFloatListele;
        private System.Windows.Forms.Button btnBoolListele;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.Button btnStringEkle;
        private System.Windows.Forms.Button btnIntEkle;
        private System.Windows.Forms.Button btnFloatEkle;
        private System.Windows.Forms.Button btnBoolEkle;
        private System.Windows.Forms.RadioButton radioButtonFalse;
        private System.Windows.Forms.Button btnStringTemizle;
        private System.Windows.Forms.Button btnIntTemizle;
        private System.Windows.Forms.Button btnFloatTemizle;
        private System.Windows.Forms.Button btnBoolTemizle;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtFloat;
        private System.Windows.Forms.Label labelStringCount;
        private System.Windows.Forms.Label labelIntCount;
        private System.Windows.Forms.Label labelFloatCount;
        private System.Windows.Forms.Label labelBoolCount;
    }
}

