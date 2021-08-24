
namespace APS
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
            this.linkPrimeiraImagem = new System.Windows.Forms.LinkLabel();
            this.linkSegundaImagem = new System.Windows.Forms.LinkLabel();
            this.picImagem1 = new System.Windows.Forms.PictureBox();
            this.picImagem2 = new System.Windows.Forms.PictureBox();
            this.pgbarBarraDeProgresso = new System.Windows.Forms.ProgressBar();
            this.btnCampararImagens = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.ofd2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkPrimeiraImagem
            // 
            this.linkPrimeiraImagem.AutoSize = true;
            this.linkPrimeiraImagem.Location = new System.Drawing.Point(32, 67);
            this.linkPrimeiraImagem.Name = "linkPrimeiraImagem";
            this.linkPrimeiraImagem.Size = new System.Drawing.Size(141, 13);
            this.linkPrimeiraImagem.TabIndex = 0;
            this.linkPrimeiraImagem.TabStop = true;
            this.linkPrimeiraImagem.Text = "Selecione a primeira imagem";
            this.linkPrimeiraImagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrimeiraImagem_LinkClicked);
            // 
            // linkSegundaImagem
            // 
            this.linkSegundaImagem.AutoSize = true;
            this.linkSegundaImagem.Location = new System.Drawing.Point(350, 67);
            this.linkSegundaImagem.Name = "linkSegundaImagem";
            this.linkSegundaImagem.Size = new System.Drawing.Size(146, 13);
            this.linkSegundaImagem.TabIndex = 1;
            this.linkSegundaImagem.TabStop = true;
            this.linkSegundaImagem.Text = "Selecione a segunda imagem";
            this.linkSegundaImagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSegundaImagem_LinkClicked);
            // 
            // picImagem1
            // 
            this.picImagem1.Location = new System.Drawing.Point(35, 83);
            this.picImagem1.Name = "picImagem1";
            this.picImagem1.Size = new System.Drawing.Size(244, 232);
            this.picImagem1.TabIndex = 2;
            this.picImagem1.TabStop = false;
            // 
            // picImagem2
            // 
            this.picImagem2.Location = new System.Drawing.Point(353, 83);
            this.picImagem2.Name = "picImagem2";
            this.picImagem2.Size = new System.Drawing.Size(230, 232);
            this.picImagem2.TabIndex = 3;
            this.picImagem2.TabStop = false;
            // 
            // pgbarBarraDeProgresso
            // 
            this.pgbarBarraDeProgresso.Location = new System.Drawing.Point(182, 321);
            this.pgbarBarraDeProgresso.Name = "pgbarBarraDeProgresso";
            this.pgbarBarraDeProgresso.Size = new System.Drawing.Size(269, 23);
            this.pgbarBarraDeProgresso.TabIndex = 4;
            // 
            // btnCampararImagens
            // 
            this.btnCampararImagens.Location = new System.Drawing.Point(59, 381);
            this.btnCampararImagens.Name = "btnCampararImagens";
            this.btnCampararImagens.Size = new System.Drawing.Size(166, 40);
            this.btnCampararImagens.TabIndex = 5;
            this.btnCampararImagens.Text = "Comparar imagens";
            this.btnCampararImagens.UseVisualStyleBackColor = true;
            this.btnCampararImagens.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(256, 390);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(376, 390);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(111, 23);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // ofd2
            // 
            this.ofd2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCampararImagens);
            this.Controls.Add(this.pgbarBarraDeProgresso);
            this.Controls.Add(this.picImagem2);
            this.Controls.Add(this.picImagem1);
            this.Controls.Add(this.linkSegundaImagem);
            this.Controls.Add(this.linkPrimeiraImagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkPrimeiraImagem;
        private System.Windows.Forms.LinkLabel linkSegundaImagem;
        private System.Windows.Forms.PictureBox picImagem1;
        private System.Windows.Forms.PictureBox picImagem2;
        private System.Windows.Forms.ProgressBar pgbarBarraDeProgresso;
        private System.Windows.Forms.Button btnCampararImagens;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.OpenFileDialog ofd2;
    }
}

