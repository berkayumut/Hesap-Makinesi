namespace Hesap_Makinemiz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngerial = new System.Windows.Forms.Button();
            this.btneksi = new System.Windows.Forms.Button();
            this.btnarti = new System.Windows.Forms.Button();
            this.btncarpi = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.btnvirgul = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnesittir = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.txtgecmis = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cikisBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArkaMavi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArkaYesil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYaziKirmizi = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntemizle);
            this.panel1.Controls.Add(this.btngerial);
            this.panel1.Controls.Add(this.btneksi);
            this.panel1.Controls.Add(this.btnarti);
            this.panel1.Controls.Add(this.btncarpi);
            this.panel1.Controls.Add(this.btnbolme);
            this.panel1.Controls.Add(this.btnvirgul);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnesittir);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Location = new System.Drawing.Point(11, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 252);
            this.panel1.TabIndex = 0;
            // 
            // btntemizle
            // 
            this.btntemizle.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Location = new System.Drawing.Point(254, 125);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(55, 116);
            this.btntemizle.TabIndex = 17;
            this.btntemizle.Text = "C";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btngerial
            // 
            this.btngerial.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngerial.Location = new System.Drawing.Point(254, 3);
            this.btngerial.Name = "btngerial";
            this.btngerial.Size = new System.Drawing.Size(55, 116);
            this.btngerial.TabIndex = 16;
            this.btngerial.Text = "Geri Al";
            this.btngerial.UseVisualStyleBackColor = true;
            this.btngerial.Click += new System.EventHandler(this.btngerial_Click);
            // 
            // btneksi
            // 
            this.btneksi.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneksi.Location = new System.Drawing.Point(193, 186);
            this.btneksi.Name = "btneksi";
            this.btneksi.Size = new System.Drawing.Size(55, 55);
            this.btneksi.TabIndex = 15;
            this.btneksi.Text = "-";
            this.btneksi.UseVisualStyleBackColor = true;
            this.btneksi.Click += new System.EventHandler(this.btneksi_Click);
            // 
            // btnarti
            // 
            this.btnarti.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnarti.Location = new System.Drawing.Point(193, 125);
            this.btnarti.Name = "btnarti";
            this.btnarti.Size = new System.Drawing.Size(55, 55);
            this.btnarti.TabIndex = 14;
            this.btnarti.Text = "+";
            this.btnarti.UseVisualStyleBackColor = true;
            this.btnarti.Click += new System.EventHandler(this.btnarti_Click);
            // 
            // btncarpi
            // 
            this.btncarpi.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncarpi.Location = new System.Drawing.Point(193, 64);
            this.btncarpi.Name = "btncarpi";
            this.btncarpi.Size = new System.Drawing.Size(55, 55);
            this.btncarpi.TabIndex = 13;
            this.btncarpi.Text = "x";
            this.btncarpi.UseVisualStyleBackColor = true;
            this.btncarpi.Click += new System.EventHandler(this.btncarpi_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbolme.Location = new System.Drawing.Point(193, 3);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(55, 55);
            this.btnbolme.TabIndex = 12;
            this.btnbolme.Text = "/";
            this.btnbolme.UseVisualStyleBackColor = true;
            this.btnbolme.Click += new System.EventHandler(this.btnbolme_Click);
            // 
            // btnvirgul
            // 
            this.btnvirgul.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvirgul.Location = new System.Drawing.Point(71, 186);
            this.btnvirgul.Name = "btnvirgul";
            this.btnvirgul.Size = new System.Drawing.Size(55, 55);
            this.btnvirgul.TabIndex = 11;
            this.btnvirgul.Text = ",";
            this.btnvirgul.UseVisualStyleBackColor = true;
            this.btnvirgul.Click += new System.EventHandler(this.btnvirgul_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(10, 186);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 55);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnesittir
            // 
            this.btnesittir.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnesittir.Location = new System.Drawing.Point(132, 186);
            this.btnesittir.Name = "btnesittir";
            this.btnesittir.Size = new System.Drawing.Size(55, 55);
            this.btnesittir.TabIndex = 9;
            this.btnesittir.Text = "=";
            this.btnesittir.UseVisualStyleBackColor = true;
            this.btnesittir.Click += new System.EventHandler(this.btnesittir_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(132, 125);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 55);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(71, 125);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 55);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(10, 125);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 55);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(132, 64);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 55);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(71, 64);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 55);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(10, 64);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 55);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(132, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 55);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(71, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 55);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(10, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 55);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(21, 52);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(299, 35);
            this.txtSonuc.TabIndex = 18;
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged);
            // 
            // txtgecmis
            // 
            this.txtgecmis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgecmis.Enabled = false;
            this.txtgecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgecmis.Location = new System.Drawing.Point(205, 26);
            this.txtgecmis.Multiline = true;
            this.txtgecmis.Name = "txtgecmis";
            this.txtgecmis.Size = new System.Drawing.Size(113, 20);
            this.txtgecmis.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikisBtn,
            this.araçlarToolStripMenuItem,
            this.bilgiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cikisBtn
            // 
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(44, 20);
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArkaMavi,
            this.btnArkaYesil,
            this.btnYaziKirmizi});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // btnArkaMavi
            // 
            this.btnArkaMavi.Name = "btnArkaMavi";
            this.btnArkaMavi.Size = new System.Drawing.Size(191, 22);
            this.btnArkaMavi.Text = "Arka Plan Rengi(Mavi)";
            this.btnArkaMavi.Click += new System.EventHandler(this.btnArkaMavi_Click);
            // 
            // btnArkaYesil
            // 
            this.btnArkaYesil.Name = "btnArkaYesil";
            this.btnArkaYesil.Size = new System.Drawing.Size(191, 22);
            this.btnArkaYesil.Text = "Arka Plan Rengi (Yeşil)";
            this.btnArkaYesil.Click += new System.EventHandler(this.btnArkaYesil_Click);
            // 
            // btnYaziKirmizi
            // 
            this.btnYaziKirmizi.Name = "btnYaziKirmizi";
            this.btnYaziKirmizi.Size = new System.Drawing.Size(191, 22);
            this.btnYaziKirmizi.Text = "Yazı Rengi (Kırmızı)";
            this.btnYaziKirmizi.Click += new System.EventHandler(this.btnYaziKirmizi_Click);
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.bilgiToolStripMenuItem.Text = "Bilgi";
            this.bilgiToolStripMenuItem.Click += new System.EventHandler(this.bilgiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 341);
            this.Controls.Add(this.txtgecmis);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngerial;
        private System.Windows.Forms.Button btneksi;
        private System.Windows.Forms.Button btnarti;
        private System.Windows.Forms.Button btncarpi;
        private System.Windows.Forms.Button btnbolme;
        private System.Windows.Forms.Button btnvirgul;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnesittir;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TextBox txtgecmis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cikisBtn;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnArkaMavi;
        private System.Windows.Forms.ToolStripMenuItem btnArkaYesil;
        private System.Windows.Forms.ToolStripMenuItem btnYaziKirmizi;
    }
}

