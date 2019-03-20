namespace AnalisadorLexico
{
    partial class frmAnalisadorLexico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbCodigo = new System.Windows.Forms.RichTextBox();
            this.btnGeradorLexico = new System.Windows.Forms.Button();
            this.btnCarregarCodigo = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbToken = new System.Windows.Forms.Label();
            this.txbToken = new System.Windows.Forms.RichTextBox();
            this.openArqCod = new System.Windows.Forms.OpenFileDialog();
            this.lbTabSimbolos = new System.Windows.Forms.Label();
            this.txbTabSimbolos = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(11, 50);
            this.txbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(467, 384);
            this.txbCodigo.TabIndex = 0;
            this.txbCodigo.Text = "";
            // 
            // btnGeradorLexico
            // 
            this.btnGeradorLexico.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGeradorLexico.FlatAppearance.BorderSize = 0;
            this.btnGeradorLexico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeradorLexico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeradorLexico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeradorLexico.Location = new System.Drawing.Point(517, 224);
            this.btnGeradorLexico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeradorLexico.Name = "btnGeradorLexico";
            this.btnGeradorLexico.Size = new System.Drawing.Size(191, 66);
            this.btnGeradorLexico.TabIndex = 1;
            this.btnGeradorLexico.Text = "GERAR TOKENS";
            this.btnGeradorLexico.UseVisualStyleBackColor = false;
            this.btnGeradorLexico.Click += new System.EventHandler(this.btnGeradorLexico_Click);
            // 
            // btnCarregarCodigo
            // 
            this.btnCarregarCodigo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCarregarCodigo.FlatAppearance.BorderSize = 0;
            this.btnCarregarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCarregarCodigo.Location = new System.Drawing.Point(279, 455);
            this.btnCarregarCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarregarCodigo.Name = "btnCarregarCodigo";
            this.btnCarregarCodigo.Size = new System.Drawing.Size(199, 43);
            this.btnCarregarCodigo.TabIndex = 2;
            this.btnCarregarCodigo.Text = "Carregar Código";
            this.btnCarregarCodigo.UseVisualStyleBackColor = false;
            this.btnCarregarCodigo.Click += new System.EventHandler(this.btnCarregarCodigo_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(8, 20);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(185, 25);
            this.lbCodigo.TabIndex = 3;
            this.lbCodigo.Text = "Digite seu código:";
            // 
            // lbToken
            // 
            this.lbToken.AutoSize = true;
            this.lbToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToken.Location = new System.Drawing.Point(739, 25);
            this.lbToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbToken.Name = "lbToken";
            this.lbToken.Size = new System.Drawing.Size(179, 25);
            this.lbToken.TabIndex = 4;
            this.lbToken.Text = "Tokens Gerados:";
            // 
            // txbToken
            // 
            this.txbToken.Location = new System.Drawing.Point(733, 54);
            this.txbToken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbToken.Name = "txbToken";
            this.txbToken.Size = new System.Drawing.Size(223, 380);
            this.txbToken.TabIndex = 5;
            this.txbToken.Text = "";
            // 
            // openArqCod
            // 
            this.openArqCod.FileName = "openArqCod";
            // 
            // lbTabSimbolos
            // 
            this.lbTabSimbolos.AutoSize = true;
            this.lbTabSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabSimbolos.Location = new System.Drawing.Point(987, 25);
            this.lbTabSimbolos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTabSimbolos.Name = "lbTabSimbolos";
            this.lbTabSimbolos.Size = new System.Drawing.Size(211, 25);
            this.lbTabSimbolos.TabIndex = 7;
            this.lbTabSimbolos.Text = "Tabela de Simbolos:";
            // 
            // txbTabSimbolos
            // 
            this.txbTabSimbolos.Location = new System.Drawing.Point(980, 54);
            this.txbTabSimbolos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTabSimbolos.Name = "txbTabSimbolos";
            this.txbTabSimbolos.Size = new System.Drawing.Size(223, 380);
            this.txbTabSimbolos.TabIndex = 8;
            this.txbTabSimbolos.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(13, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpar Código";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(832, 454);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar Tokens e Simbolos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAnalisadorLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1231, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbTabSimbolos);
            this.Controls.Add(this.lbTabSimbolos);
            this.Controls.Add(this.txbToken);
            this.Controls.Add(this.lbToken);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btnCarregarCodigo);
            this.Controls.Add(this.btnGeradorLexico);
            this.Controls.Add(this.txbCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmAnalisadorLexico";
            this.Text = "Analisador Léxico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbCodigo;
        private System.Windows.Forms.Button btnGeradorLexico;
        private System.Windows.Forms.Button btnCarregarCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbToken;
        private System.Windows.Forms.RichTextBox txbToken;
        private System.Windows.Forms.OpenFileDialog openArqCod;
        private System.Windows.Forms.Label lbTabSimbolos;
        private System.Windows.Forms.RichTextBox txbTabSimbolos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

