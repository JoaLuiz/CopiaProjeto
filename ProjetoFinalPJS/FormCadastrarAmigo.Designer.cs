﻿namespace ProjetoFinalPJS
{
    partial class FormCadastrarAmigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarAmigo));
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxBairro = new System.Windows.Forms.TextBox();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbUf = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.tbxTelefoneMasc = new System.Windows.Forms.MaskedTextBox();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.tbxCelularMasc = new System.Windows.Forms.MaskedTextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(15, 39);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(484, 20);
            this.tbxNome.TabIndex = 0;
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(15, 78);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(483, 20);
            this.tbxEndereco.TabIndex = 1;
            // 
            // tbxBairro
            // 
            this.tbxBairro.Location = new System.Drawing.Point(15, 117);
            this.tbxBairro.Name = "tbxBairro";
            this.tbxBairro.Size = new System.Drawing.Size(483, 20);
            this.tbxBairro.TabIndex = 4;
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(15, 156);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(427, 20);
            this.tbxCidade.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 23);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(12, 62);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 7;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(12, 101);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 8;
            this.lbBairro.Text = "Bairro";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(12, 140);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 9;
            this.lbCidade.Text = "Cidade";
            // 
            // lbUf
            // 
            this.lbUf.AutoSize = true;
            this.lbUf.Location = new System.Drawing.Point(445, 140);
            this.lbUf.Name = "lbUf";
            this.lbUf.Size = new System.Drawing.Size(21, 13);
            this.lbUf.TabIndex = 10;
            this.lbUf.Text = "UF";
            // 
            // btSalvar
            // 
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalvar.Location = new System.Drawing.Point(261, 240);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btGravar
            // 
            this.btGravar.Image = ((System.Drawing.Image)(resources.GetObject("btGravar.Image")));
            this.btGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.Location = new System.Drawing.Point(342, 240);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 12;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpar.Location = new System.Drawing.Point(423, 240);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(13, 227);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 14;
            this.lbTelefone.Text = "Telefone";
            // 
            // tbxTelefoneMasc
            // 
            this.tbxTelefoneMasc.Location = new System.Drawing.Point(16, 243);
            this.tbxTelefoneMasc.Name = "tbxTelefoneMasc";
            this.tbxTelefoneMasc.PromptChar = '0';
            this.tbxTelefoneMasc.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefoneMasc.TabIndex = 15;
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Location = new System.Drawing.Point(448, 155);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(50, 21);
            this.cbxUF.TabIndex = 16;
            // 
            // tbxCelularMasc
            // 
            this.tbxCelularMasc.Location = new System.Drawing.Point(122, 243);
            this.tbxCelularMasc.Name = "tbxCelularMasc";
            this.tbxCelularMasc.Size = new System.Drawing.Size(100, 20);
            this.tbxCelularMasc.TabIndex = 17;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(119, 228);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 18;
            this.lbCelular.Text = "Celular";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(15, 183);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 13);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "E - mail";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(18, 200);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(480, 20);
            this.tbxEmail.TabIndex = 20;
            // 
            // FormCadastrarAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 276);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.tbxCelularMasc);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.tbxTelefoneMasc);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbUf);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbxCidade);
            this.Controls.Add(this.tbxBairro);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxNome);
            this.Name = "FormCadastrarAmigo";
            this.Text = "Cadatro de Amigo";
            this.Load += new System.EventHandler(this.FormCadastrarAmigo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxBairro;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbUf;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.MaskedTextBox tbxTelefoneMasc;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.MaskedTextBox tbxCelularMasc;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbxEmail;
    }
}