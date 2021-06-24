namespace picturebox_e_openfiledialog
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
            this.picimagem = new System.Windows.Forms.PictureBox();
            this.dglabrir = new System.Windows.Forms.OpenFileDialog();
            this.btnabrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picimagem
            // 
            this.picimagem.Location = new System.Drawing.Point(12, 12);
            this.picimagem.Name = "picimagem";
            this.picimagem.Size = new System.Drawing.Size(283, 281);
            this.picimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimagem.TabIndex = 0;
            this.picimagem.TabStop = false;
            // 
            // dglabrir
            // 
            this.dglabrir.FileName = "openFileDialog1";
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(301, 25);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(93, 29);
            this.btnabrir.TabIndex = 1;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 305);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.picimagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picimagem;
        private System.Windows.Forms.OpenFileDialog dglabrir;
        private System.Windows.Forms.Button btnabrir;
    }
}

