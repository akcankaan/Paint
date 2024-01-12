namespace CASE
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_Altigen = new System.Windows.Forms.PictureBox();
            this.pb_Ucgen = new System.Windows.Forms.PictureBox();
            this.pb_Cember = new System.Windows.Forms.PictureBox();
            this.pb_Dikdortgen = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pb_White = new System.Windows.Forms.PictureBox();
            this.Pb_Brown = new System.Windows.Forms.PictureBox();
            this.Pb_Purple = new System.Windows.Forms.PictureBox();
            this.Pb_Yellow = new System.Windows.Forms.PictureBox();
            this.Pb_Black = new System.Windows.Forms.PictureBox();
            this.Pb_Orange = new System.Windows.Forms.PictureBox();
            this.Pb_Green = new System.Windows.Forms.PictureBox();
            this.Pb_Blue = new System.Windows.Forms.PictureBox();
            this.Pb_Red = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_Clear = new System.Windows.Forms.PictureBox();
            this.pb_Cop = new System.Windows.Forms.PictureBox();
            this.pb_Select = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pb_Open = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Altigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ucgen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dikdortgen)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_White)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Brown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Red)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Select)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_Altigen);
            this.groupBox1.Controls.Add(this.pb_Ucgen);
            this.groupBox1.Controls.Add(this.pb_Cember);
            this.groupBox1.Controls.Add(this.pb_Dikdortgen);
            this.groupBox1.Location = new System.Drawing.Point(1080, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÇİZİM ŞEKLİ";
            // 
            // pb_Altigen
            // 
            this.pb_Altigen.Image = global::CASE.Properties.Resources.altigenicon;
            this.pb_Altigen.Location = new System.Drawing.Point(85, 75);
            this.pb_Altigen.Name = "pb_Altigen";
            this.pb_Altigen.Size = new System.Drawing.Size(47, 40);
            this.pb_Altigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Altigen.TabIndex = 3;
            this.pb_Altigen.TabStop = false;
            this.pb_Altigen.Click += new System.EventHandler(this.pb_Altigen_Click);
            // 
            // pb_Ucgen
            // 
            this.pb_Ucgen.Image = global::CASE.Properties.Resources.triangleicon;
            this.pb_Ucgen.Location = new System.Drawing.Point(7, 75);
            this.pb_Ucgen.Name = "pb_Ucgen";
            this.pb_Ucgen.Size = new System.Drawing.Size(47, 40);
            this.pb_Ucgen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Ucgen.TabIndex = 2;
            this.pb_Ucgen.TabStop = false;
            this.pb_Ucgen.Click += new System.EventHandler(this.pb_Ucgen_Click);
            // 
            // pb_Cember
            // 
            this.pb_Cember.Image = global::CASE.Properties.Resources.cembericon2;
            this.pb_Cember.Location = new System.Drawing.Point(85, 22);
            this.pb_Cember.Name = "pb_Cember";
            this.pb_Cember.Size = new System.Drawing.Size(47, 40);
            this.pb_Cember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cember.TabIndex = 1;
            this.pb_Cember.TabStop = false;
            this.pb_Cember.Click += new System.EventHandler(this.pb_Cember_Click);
            // 
            // pb_Dikdortgen
            // 
            this.pb_Dikdortgen.Image = global::CASE.Properties.Resources.rection2;
            this.pb_Dikdortgen.Location = new System.Drawing.Point(7, 22);
            this.pb_Dikdortgen.Name = "pb_Dikdortgen";
            this.pb_Dikdortgen.Size = new System.Drawing.Size(47, 40);
            this.pb_Dikdortgen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Dikdortgen.TabIndex = 0;
            this.pb_Dikdortgen.TabStop = false;
            this.pb_Dikdortgen.Click += new System.EventHandler(this.pb_Dikdortgen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pb_White);
            this.groupBox2.Controls.Add(this.Pb_Brown);
            this.groupBox2.Controls.Add(this.Pb_Purple);
            this.groupBox2.Controls.Add(this.Pb_Yellow);
            this.groupBox2.Controls.Add(this.Pb_Black);
            this.groupBox2.Controls.Add(this.Pb_Orange);
            this.groupBox2.Controls.Add(this.Pb_Green);
            this.groupBox2.Controls.Add(this.Pb_Blue);
            this.groupBox2.Controls.Add(this.Pb_Red);
            this.groupBox2.Location = new System.Drawing.Point(1080, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RENK SEÇİMİ";
            // 
            // Pb_White
            // 
            this.Pb_White.BackColor = System.Drawing.Color.White;
            this.Pb_White.Location = new System.Drawing.Point(137, 116);
            this.Pb_White.Name = "Pb_White";
            this.Pb_White.Size = new System.Drawing.Size(35, 41);
            this.Pb_White.TabIndex = 8;
            this.Pb_White.TabStop = false;
            this.Pb_White.Click += new System.EventHandler(this.Pb_White_Click);
            // 
            // Pb_Brown
            // 
            this.Pb_Brown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Pb_Brown.Location = new System.Drawing.Point(72, 116);
            this.Pb_Brown.Name = "Pb_Brown";
            this.Pb_Brown.Size = new System.Drawing.Size(35, 41);
            this.Pb_Brown.TabIndex = 7;
            this.Pb_Brown.TabStop = false;
            this.Pb_Brown.Click += new System.EventHandler(this.Pb_Brown_Click);
            // 
            // Pb_Purple
            // 
            this.Pb_Purple.BackColor = System.Drawing.Color.Purple;
            this.Pb_Purple.Location = new System.Drawing.Point(8, 116);
            this.Pb_Purple.Name = "Pb_Purple";
            this.Pb_Purple.Size = new System.Drawing.Size(35, 41);
            this.Pb_Purple.TabIndex = 6;
            this.Pb_Purple.TabStop = false;
            this.Pb_Purple.Click += new System.EventHandler(this.Pb_Purple_Click);
            // 
            // Pb_Yellow
            // 
            this.Pb_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Pb_Yellow.Location = new System.Drawing.Point(137, 69);
            this.Pb_Yellow.Name = "Pb_Yellow";
            this.Pb_Yellow.Size = new System.Drawing.Size(35, 41);
            this.Pb_Yellow.TabIndex = 5;
            this.Pb_Yellow.TabStop = false;
            this.Pb_Yellow.Click += new System.EventHandler(this.Pb_Yellow_Click);
            // 
            // Pb_Black
            // 
            this.Pb_Black.BackColor = System.Drawing.Color.Black;
            this.Pb_Black.Location = new System.Drawing.Point(72, 69);
            this.Pb_Black.Name = "Pb_Black";
            this.Pb_Black.Size = new System.Drawing.Size(35, 41);
            this.Pb_Black.TabIndex = 4;
            this.Pb_Black.TabStop = false;
            this.Pb_Black.Click += new System.EventHandler(this.Pb_Black_Click);
            // 
            // Pb_Orange
            // 
            this.Pb_Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pb_Orange.Location = new System.Drawing.Point(8, 69);
            this.Pb_Orange.Name = "Pb_Orange";
            this.Pb_Orange.Size = new System.Drawing.Size(35, 41);
            this.Pb_Orange.TabIndex = 3;
            this.Pb_Orange.TabStop = false;
            this.Pb_Orange.Click += new System.EventHandler(this.Pb_Orange_Click);
            // 
            // Pb_Green
            // 
            this.Pb_Green.BackColor = System.Drawing.Color.Green;
            this.Pb_Green.Location = new System.Drawing.Point(137, 22);
            this.Pb_Green.Name = "Pb_Green";
            this.Pb_Green.Size = new System.Drawing.Size(35, 41);
            this.Pb_Green.TabIndex = 2;
            this.Pb_Green.TabStop = false;
            this.Pb_Green.Click += new System.EventHandler(this.Pb_Green_Click);
            // 
            // Pb_Blue
            // 
            this.Pb_Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Pb_Blue.Location = new System.Drawing.Point(72, 22);
            this.Pb_Blue.Name = "Pb_Blue";
            this.Pb_Blue.Size = new System.Drawing.Size(35, 41);
            this.Pb_Blue.TabIndex = 1;
            this.Pb_Blue.TabStop = false;
            this.Pb_Blue.Click += new System.EventHandler(this.Pb_Blue_Click);
            // 
            // Pb_Red
            // 
            this.Pb_Red.BackColor = System.Drawing.Color.Red;
            this.Pb_Red.Location = new System.Drawing.Point(8, 22);
            this.Pb_Red.Name = "Pb_Red";
            this.Pb_Red.Size = new System.Drawing.Size(35, 41);
            this.Pb_Red.TabIndex = 0;
            this.Pb_Red.TabStop = false;
            this.Pb_Red.Click += new System.EventHandler(this.Pb_Red_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb_Clear);
            this.groupBox3.Controls.Add(this.pb_Cop);
            this.groupBox3.Controls.Add(this.pb_Select);
            this.groupBox3.Location = new System.Drawing.Point(1080, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ŞEKİL İŞLEMLERİ";
            // 
            // pb_Clear
            // 
            this.pb_Clear.Image = global::CASE.Properties.Resources.Temizle;
            this.pb_Clear.Location = new System.Drawing.Point(137, 22);
            this.pb_Clear.Name = "pb_Clear";
            this.pb_Clear.Size = new System.Drawing.Size(41, 43);
            this.pb_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Clear.TabIndex = 2;
            this.pb_Clear.TabStop = false;
            this.pb_Clear.Click += new System.EventHandler(this.pb_Clear_Click);
            // 
            // pb_Cop
            // 
            this.pb_Cop.Image = global::CASE.Properties.Resources.Copicon;
            this.pb_Cop.Location = new System.Drawing.Point(72, 22);
            this.pb_Cop.Name = "pb_Cop";
            this.pb_Cop.Size = new System.Drawing.Size(48, 43);
            this.pb_Cop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cop.TabIndex = 1;
            this.pb_Cop.TabStop = false;
            this.pb_Cop.Click += new System.EventHandler(this.pb_Cop_Click);
            this.pb_Cop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Cop_MouseDown);
            this.pb_Cop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_Cop_MouseUp);
            // 
            // pb_Select
            // 
            this.pb_Select.Image = global::CASE.Properties.Resources.Selecticon;
            this.pb_Select.Location = new System.Drawing.Point(7, 22);
            this.pb_Select.Name = "pb_Select";
            this.pb_Select.Size = new System.Drawing.Size(47, 43);
            this.pb_Select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Select.TabIndex = 0;
            this.pb_Select.TabStop = false;
            this.pb_Select.Click += new System.EventHandler(this.pb_Select_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox14);
            this.groupBox4.Controls.Add(this.pb_Open);
            this.groupBox4.Location = new System.Drawing.Point(1080, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 79);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DOSYA İŞLEMLERİ";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::CASE.Properties.Resources.Save;
            this.pictureBox14.Location = new System.Drawing.Point(72, 21);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(48, 51);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 1;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pb_Open
            // 
            this.pb_Open.Image = global::CASE.Properties.Resources.Openfolder;
            this.pb_Open.Location = new System.Drawing.Point(7, 22);
            this.pb_Open.Name = "pb_Open";
            this.pb_Open.Size = new System.Drawing.Size(47, 50);
            this.pb_Open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Open.TabIndex = 0;
            this.pb_Open.TabStop = false;
            this.pb_Open.Click += new System.EventHandler(this.pb_Open_Click);
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(13, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1044, 492);
            this.Panel.TabIndex = 0;
            this.Panel.TabStop = false;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1080, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mouse Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1186, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Altigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ucgen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dikdortgen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_White)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Brown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Red)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Select)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_Altigen;
        private System.Windows.Forms.PictureBox pb_Ucgen;
        private System.Windows.Forms.PictureBox pb_Cember;
        private System.Windows.Forms.PictureBox pb_Dikdortgen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Pb_White;
        private System.Windows.Forms.PictureBox Pb_Brown;
        private System.Windows.Forms.PictureBox Pb_Purple;
        private System.Windows.Forms.PictureBox Pb_Yellow;
        private System.Windows.Forms.PictureBox Pb_Black;
        private System.Windows.Forms.PictureBox Pb_Orange;
        private System.Windows.Forms.PictureBox Pb_Green;
        private System.Windows.Forms.PictureBox Pb_Blue;
        private System.Windows.Forms.PictureBox Pb_Red;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pb_Clear;
        private System.Windows.Forms.PictureBox pb_Cop;
        private System.Windows.Forms.PictureBox pb_Select;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pb_Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

