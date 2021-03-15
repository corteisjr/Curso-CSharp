
namespace JokenPo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicResultado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.BtnPedra = new System.Windows.Forms.Button();
            this.BtnPapel = new System.Windows.Forms.Button();
            this.BtnTesoura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitulo.Location = new System.Drawing.Point(13, 13);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(587, 75);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "Escolha: Pedra, Papel ou Tesoura...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(301, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PicResultado
            // 
            this.PicResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicResultado.Location = new System.Drawing.Point(569, 91);
            this.PicResultado.Name = "PicResultado";
            this.PicResultado.Size = new System.Drawing.Size(200, 200);
            this.PicResultado.TabIndex = 3;
            this.PicResultado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(63, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Você";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(357, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "pc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(240, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "vs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(520, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultado.Location = new System.Drawing.Point(644, 166);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(22, 30);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "?";
            // 
            // BtnPedra
            // 
            this.BtnPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPedra.BackgroundImage")));
            this.BtnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPedra.Location = new System.Drawing.Point(12, 297);
            this.BtnPedra.Name = "BtnPedra";
            this.BtnPedra.Size = new System.Drawing.Size(200, 200);
            this.BtnPedra.TabIndex = 9;
            this.BtnPedra.UseVisualStyleBackColor = true;
            this.BtnPedra.Click += new System.EventHandler(this.BtnPedra_Click);
            // 
            // BtnPapel
            // 
            this.BtnPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPapel.BackgroundImage")));
            this.BtnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPapel.Location = new System.Drawing.Point(301, 297);
            this.BtnPapel.Name = "BtnPapel";
            this.BtnPapel.Size = new System.Drawing.Size(200, 200);
            this.BtnPapel.TabIndex = 10;
            this.BtnPapel.UseVisualStyleBackColor = true;
            this.BtnPapel.Click += new System.EventHandler(this.BtnPapel_Click);
            // 
            // BtnTesoura
            // 
            this.BtnTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTesoura.BackgroundImage")));
            this.BtnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTesoura.Location = new System.Drawing.Point(569, 297);
            this.BtnTesoura.Name = "BtnTesoura";
            this.BtnTesoura.Size = new System.Drawing.Size(200, 200);
            this.BtnTesoura.TabIndex = 11;
            this.BtnTesoura.UseVisualStyleBackColor = true;
            this.BtnTesoura.Click += new System.EventHandler(this.BtnTesoura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 547);
            this.Controls.Add(this.BtnTesoura);
            this.Controls.Add(this.BtnPapel);
            this.Controls.Add(this.BtnPedra);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicResultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PicResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button BtnPedra;
        private System.Windows.Forms.Button BtnPapel;
        private System.Windows.Forms.Button BtnTesoura;
    }
}

