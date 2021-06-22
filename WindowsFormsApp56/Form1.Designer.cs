namespace WindowsFormsApp56
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEgitilenAdet = new System.Windows.Forms.Label();
            this.YüzKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TXT_AD = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TXT_SOYAD = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TXT_NO = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresimyol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CekılenFotograf = new System.Windows.Forms.PictureBox();
            this.YUZ_SIL = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KameradakiSonYuz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CekılenFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KameradakiSonYuz)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 461);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEgitilenAdet
            // 
            this.lblEgitilenAdet.AutoSize = true;
            this.lblEgitilenAdet.BackColor = System.Drawing.Color.Transparent;
            this.lblEgitilenAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEgitilenAdet.Location = new System.Drawing.Point(721, 571);
            this.lblEgitilenAdet.Name = "lblEgitilenAdet";
            this.lblEgitilenAdet.Size = new System.Drawing.Size(33, 13);
            this.lblEgitilenAdet.TabIndex = 2;
            this.lblEgitilenAdet.Text = "Adet";
            // 
            // YüzKaydet
            // 
            this.YüzKaydet.Activecolor = System.Drawing.Color.Transparent;
            this.YüzKaydet.BackColor = System.Drawing.Color.Transparent;
            this.YüzKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YüzKaydet.BorderRadius = 0;
            this.YüzKaydet.ButtonText = "Yüzü Kaydet";
            this.YüzKaydet.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.YüzKaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.YüzKaydet.Iconimage = ((System.Drawing.Image)(resources.GetObject("YüzKaydet.Iconimage")));
            this.YüzKaydet.Iconimage_right = null;
            this.YüzKaydet.Iconimage_right_Selected = null;
            this.YüzKaydet.Iconimage_Selected = null;
            this.YüzKaydet.IconZoom = 80D;
            this.YüzKaydet.IsTab = false;
            this.YüzKaydet.Location = new System.Drawing.Point(721, 513);
            this.YüzKaydet.Name = "YüzKaydet";
            this.YüzKaydet.Normalcolor = System.Drawing.Color.Transparent;
            this.YüzKaydet.OnHovercolor = System.Drawing.Color.Transparent;
            this.YüzKaydet.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(0)))), ((int)(((byte)(164)))));
            this.YüzKaydet.selected = false;
            this.YüzKaydet.Size = new System.Drawing.Size(199, 39);
            this.YüzKaydet.TabIndex = 57;
            this.YüzKaydet.Textcolor = System.Drawing.Color.Black;
            this.YüzKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YüzKaydet.UseWaitCursor = true;
            this.YüzKaydet.Click += new System.EventHandler(this.YüzKaydet_Click);
            // 
            // TXT_AD
            // 
            this.TXT_AD.BackColor = System.Drawing.Color.Silver;
            this.TXT_AD.BorderColor = System.Drawing.Color.SeaGreen;
            this.TXT_AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXT_AD.Location = new System.Drawing.Point(721, 385);
            this.TXT_AD.Name = "TXT_AD";
            this.TXT_AD.Size = new System.Drawing.Size(199, 23);
            this.TXT_AD.TabIndex = 68;
            this.TXT_AD.UseWaitCursor = true;
            // 
            // TXT_SOYAD
            // 
            this.TXT_SOYAD.BackColor = System.Drawing.Color.Silver;
            this.TXT_SOYAD.BorderColor = System.Drawing.Color.SeaGreen;
            this.TXT_SOYAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXT_SOYAD.Location = new System.Drawing.Point(721, 438);
            this.TXT_SOYAD.Name = "TXT_SOYAD";
            this.TXT_SOYAD.Size = new System.Drawing.Size(199, 23);
            this.TXT_SOYAD.TabIndex = 67;
            this.TXT_SOYAD.UseWaitCursor = true;
            // 
            // TXT_NO
            // 
            this.TXT_NO.BackColor = System.Drawing.Color.Silver;
            this.TXT_NO.BorderColor = System.Drawing.Color.SeaGreen;
            this.TXT_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXT_NO.Location = new System.Drawing.Point(721, 339);
            this.TXT_NO.Name = "TXT_NO";
            this.TXT_NO.Size = new System.Drawing.Size(199, 23);
            this.TXT_NO.TabIndex = 66;
            this.TXT_NO.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(718, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "RESİM YOLU:";
            this.label4.UseWaitCursor = true;
            // 
            // txtresimyol
            // 
            this.txtresimyol.BackColor = System.Drawing.Color.Silver;
            this.txtresimyol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtresimyol.ForeColor = System.Drawing.Color.Black;
            this.txtresimyol.Location = new System.Drawing.Point(721, 484);
            this.txtresimyol.Name = "txtresimyol";
            this.txtresimyol.Size = new System.Drawing.Size(199, 23);
            this.txtresimyol.TabIndex = 64;
            this.txtresimyol.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(718, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "SOYAD:";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(718, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "AD:";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(718, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "NO:";
            this.label1.UseWaitCursor = true;
            // 
            // CekılenFotograf
            // 
            this.CekılenFotograf.BackColor = System.Drawing.Color.Transparent;
            this.CekılenFotograf.Location = new System.Drawing.Point(718, 182);
            this.CekılenFotograf.Name = "CekılenFotograf";
            this.CekılenFotograf.Size = new System.Drawing.Size(202, 134);
            this.CekılenFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CekılenFotograf.TabIndex = 6;
            this.CekılenFotograf.TabStop = false;
            // 
            // YUZ_SIL
            // 
            this.YUZ_SIL.Activecolor = System.Drawing.Color.Transparent;
            this.YUZ_SIL.BackColor = System.Drawing.Color.Transparent;
            this.YUZ_SIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YUZ_SIL.BorderRadius = 0;
            this.YUZ_SIL.ButtonText = "Kaydedilen Yüzleri Sil";
            this.YUZ_SIL.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.YUZ_SIL.Iconcolor = System.Drawing.Color.Transparent;
            this.YUZ_SIL.Iconimage = ((System.Drawing.Image)(resources.GetObject("YUZ_SIL.Iconimage")));
            this.YUZ_SIL.Iconimage_right = null;
            this.YUZ_SIL.Iconimage_right_Selected = null;
            this.YUZ_SIL.Iconimage_Selected = null;
            this.YUZ_SIL.IconZoom = 80D;
            this.YUZ_SIL.IsTab = false;
            this.YUZ_SIL.Location = new System.Drawing.Point(718, 137);
            this.YUZ_SIL.Name = "YUZ_SIL";
            this.YUZ_SIL.Normalcolor = System.Drawing.Color.Transparent;
            this.YUZ_SIL.OnHovercolor = System.Drawing.Color.Transparent;
            this.YUZ_SIL.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(0)))), ((int)(((byte)(164)))));
            this.YUZ_SIL.selected = false;
            this.YUZ_SIL.Size = new System.Drawing.Size(216, 39);
            this.YUZ_SIL.TabIndex = 58;
            this.YUZ_SIL.Textcolor = System.Drawing.Color.Black;
            this.YUZ_SIL.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YUZ_SIL.UseWaitCursor = true;
            this.YUZ_SIL.Click += new System.EventHandler(this.YUZ_SIL_Click);
            // 
            // KameradakiSonYuz
            // 
            this.KameradakiSonYuz.BackColor = System.Drawing.Color.Transparent;
            this.KameradakiSonYuz.Location = new System.Drawing.Point(718, 12);
            this.KameradakiSonYuz.Name = "KameradakiSonYuz";
            this.KameradakiSonYuz.Size = new System.Drawing.Size(202, 119);
            this.KameradakiSonYuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KameradakiSonYuz.TabIndex = 3;
            this.KameradakiSonYuz.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(932, 700);
            this.Controls.Add(this.TXT_AD);
            this.Controls.Add(this.TXT_SOYAD);
            this.Controls.Add(this.TXT_NO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtresimyol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YUZ_SIL);
            this.Controls.Add(this.YüzKaydet);
            this.Controls.Add(this.CekılenFotograf);
            this.Controls.Add(this.KameradakiSonYuz);
            this.Controls.Add(this.lblEgitilenAdet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Yetkili Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CekılenFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KameradakiSonYuz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEgitilenAdet;
        private Bunifu.Framework.UI.BunifuFlatButton YüzKaydet;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TXT_AD;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TXT_SOYAD;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TXT_NO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtresimyol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CekılenFotograf;
        private Bunifu.Framework.UI.BunifuFlatButton YUZ_SIL;
        private System.Windows.Forms.PictureBox KameradakiSonYuz;
    }
}

