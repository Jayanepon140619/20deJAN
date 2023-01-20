namespace WindowsFormsApp1
{
    partial class Form1
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
            this.botaosoma = new System.Windows.Forms.Button();
            this.botaox = new System.Windows.Forms.Button();
            this.botao6 = new System.Windows.Forms.Button();
            this.botao9 = new System.Windows.Forms.Button();
            this.botao4 = new System.Windows.Forms.Button();
            this.botao5 = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.BOTAOCE = new System.Windows.Forms.Button();
            this.botaobarra = new System.Windows.Forms.Button();
            this.botaoresultado = new System.Windows.Forms.Button();
            this.botaoC = new System.Windows.Forms.Button();
            this.botao0 = new System.Windows.Forms.Button();
            this.botaomenos = new System.Windows.Forms.Button();
            this.botao8 = new System.Windows.Forms.Button();
            this.botao7 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaosoma
            // 
            this.botaosoma.BackColor = System.Drawing.Color.Cyan;
            this.botaosoma.Location = new System.Drawing.Point(180, 55);
            this.botaosoma.Name = "botaosoma";
            this.botaosoma.Size = new System.Drawing.Size(50, 54);
            this.botaosoma.TabIndex = 0;
            this.botaosoma.Text = "+";
            this.botaosoma.UseVisualStyleBackColor = false;
            this.botaosoma.Click += new System.EventHandler(this.botaosoma_Click);
            // 
            // botaox
            // 
            this.botaox.BackColor = System.Drawing.Color.DarkRed;
            this.botaox.Location = new System.Drawing.Point(180, 174);
            this.botaox.Name = "botaox";
            this.botaox.Size = new System.Drawing.Size(50, 54);
            this.botaox.TabIndex = 1;
            this.botaox.Text = "X";
            this.botaox.UseVisualStyleBackColor = false;
            this.botaox.Click += new System.EventHandler(this.botaox_Click);
            // 
            // botao6
            // 
            this.botao6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.botao6.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao6.Location = new System.Drawing.Point(124, 114);
            this.botao6.Name = "botao6";
            this.botao6.Size = new System.Drawing.Size(50, 54);
            this.botao6.TabIndex = 2;
            this.botao6.Text = "6";
            this.botao6.UseVisualStyleBackColor = false;
            this.botao6.Click += new System.EventHandler(this.button26Click);
            // 
            // botao9
            // 
            this.botao9.BackColor = System.Drawing.Color.DarkOrchid;
            this.botao9.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao9.Location = new System.Drawing.Point(124, 174);
            this.botao9.Name = "botao9";
            this.botao9.Size = new System.Drawing.Size(50, 54);
            this.botao9.TabIndex = 3;
            this.botao9.Text = "9";
            this.botao9.UseVisualStyleBackColor = false;
            this.botao9.Click += new System.EventHandler(this.button9_Click);
            // 
            // botao4
            // 
            this.botao4.BackColor = System.Drawing.Color.DarkBlue;
            this.botao4.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao4.Location = new System.Drawing.Point(12, 114);
            this.botao4.Name = "botao4";
            this.botao4.Size = new System.Drawing.Size(50, 54);
            this.botao4.TabIndex = 4;
            this.botao4.Text = "4";
            this.botao4.UseVisualStyleBackColor = false;
            this.botao4.Click += new System.EventHandler(this.button4_Click);
            // 
            // botao5
            // 
            this.botao5.BackColor = System.Drawing.Color.DarkCyan;
            this.botao5.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao5.Location = new System.Drawing.Point(68, 114);
            this.botao5.Name = "botao5";
            this.botao5.Size = new System.Drawing.Size(50, 54);
            this.botao5.TabIndex = 5;
            this.botao5.Text = "5";
            this.botao5.UseVisualStyleBackColor = false;
            this.botao5.Click += new System.EventHandler(this.button5_Click);
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.Color.Coral;
            this.botao1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.Location = new System.Drawing.Point(12, 52);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(50, 54);
            this.botao1.TabIndex = 6;
            this.botao1.Text = "1";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.button2Click);
            // 
            // BOTAOCE
            // 
            this.BOTAOCE.BackColor = System.Drawing.Color.Salmon;
            this.BOTAOCE.Location = new System.Drawing.Point(236, 55);
            this.BOTAOCE.Name = "BOTAOCE";
            this.BOTAOCE.Size = new System.Drawing.Size(50, 54);
            this.BOTAOCE.TabIndex = 7;
            this.BOTAOCE.Text = "CE";
            this.BOTAOCE.UseVisualStyleBackColor = false;
            this.BOTAOCE.Click += new System.EventHandler(this.BOTAOCE_Click);
            // 
            // botaobarra
            // 
            this.botaobarra.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaobarra.Location = new System.Drawing.Point(180, 234);
            this.botaobarra.Name = "botaobarra";
            this.botaobarra.Size = new System.Drawing.Size(50, 54);
            this.botaobarra.TabIndex = 8;
            this.botaobarra.Text = "/";
            this.botaobarra.UseVisualStyleBackColor = false;
            this.botaobarra.Click += new System.EventHandler(this.botaobarra_Click);
            // 
            // botaoresultado
            // 
            this.botaoresultado.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botaoresultado.Location = new System.Drawing.Point(236, 173);
            this.botaoresultado.Name = "botaoresultado";
            this.botaoresultado.Size = new System.Drawing.Size(50, 115);
            this.botaoresultado.TabIndex = 9;
            this.botaoresultado.Text = "=";
            this.botaoresultado.UseVisualStyleBackColor = false;
            this.botaoresultado.Click += new System.EventHandler(this.botaoresultado_Click);
            // 
            // botaoC
            // 
            this.botaoC.BackColor = System.Drawing.Color.DarkKhaki;
            this.botaoC.Location = new System.Drawing.Point(236, 113);
            this.botaoC.Name = "botaoC";
            this.botaoC.Size = new System.Drawing.Size(50, 54);
            this.botaoC.TabIndex = 10;
            this.botaoC.Text = "C";
            this.botaoC.UseVisualStyleBackColor = false;
            this.botaoC.Click += new System.EventHandler(this.botaoC_Click);
            // 
            // botao0
            // 
            this.botao0.BackColor = System.Drawing.Color.GreenYellow;
            this.botao0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botao0.Location = new System.Drawing.Point(12, 234);
            this.botao0.Name = "botao0";
            this.botao0.Size = new System.Drawing.Size(162, 54);
            this.botao0.TabIndex = 11;
            this.botao0.Text = "0";
            this.botao0.UseVisualStyleBackColor = false;
            this.botao0.Click += new System.EventHandler(this.botao0_Click);
            // 
            // botaomenos
            // 
            this.botaomenos.BackColor = System.Drawing.Color.DarkGreen;
            this.botaomenos.Location = new System.Drawing.Point(180, 115);
            this.botaomenos.Name = "botaomenos";
            this.botaomenos.Size = new System.Drawing.Size(50, 54);
            this.botaomenos.TabIndex = 12;
            this.botaomenos.Text = "-";
            this.botaomenos.UseVisualStyleBackColor = false;
            this.botaomenos.Click += new System.EventHandler(this.botaomenos_Click);
            // 
            // botao8
            // 
            this.botao8.BackColor = System.Drawing.Color.DeepPink;
            this.botao8.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao8.Location = new System.Drawing.Point(68, 174);
            this.botao8.Name = "botao8";
            this.botao8.Size = new System.Drawing.Size(50, 54);
            this.botao8.TabIndex = 13;
            this.botao8.Text = "8";
            this.botao8.UseVisualStyleBackColor = false;
            this.botao8.Click += new System.EventHandler(this.button8_Click);
            // 
            // botao7
            // 
            this.botao7.BackColor = System.Drawing.Color.DarkMagenta;
            this.botao7.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao7.Location = new System.Drawing.Point(12, 173);
            this.botao7.Name = "botao7";
            this.botao7.Size = new System.Drawing.Size(50, 54);
            this.botao7.TabIndex = 14;
            this.botao7.Text = "7";
            this.botao7.UseVisualStyleBackColor = false;
            this.botao7.Click += new System.EventHandler(this.button7_Click);
            // 
            // botao3
            // 
            this.botao3.BackColor = System.Drawing.Color.Crimson;
            this.botao3.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao3.Location = new System.Drawing.Point(124, 54);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(50, 54);
            this.botao3.TabIndex = 15;
            this.botao3.Text = "3";
            this.botao3.UseVisualStyleBackColor = false;
            this.botao3.Click += new System.EventHandler(this.button3Click);
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botao2.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.Location = new System.Drawing.Point(68, 54);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(50, 54);
            this.botao2.TabIndex = 16;
            this.botao2.Text = "2";
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.button15_Click);
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.Location = new System.Drawing.Point(9, 9);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(52, 13);
            this.labelOperacao.TabIndex = 17;
            this.labelOperacao.Text = "operacao";
            this.labelOperacao.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(12, 28);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(274, 20);
            this.resultado.TabIndex = 18;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.imagem_fundo_de_calculadora;
            this.ClientSize = new System.Drawing.Size(447, 408);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao7);
            this.Controls.Add(this.botao8);
            this.Controls.Add(this.botaomenos);
            this.Controls.Add(this.botao0);
            this.Controls.Add(this.botaoC);
            this.Controls.Add(this.botaoresultado);
            this.Controls.Add(this.botaobarra);
            this.Controls.Add(this.BOTAOCE);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.botao5);
            this.Controls.Add(this.botao4);
            this.Controls.Add(this.botao9);
            this.Controls.Add(this.botao6);
            this.Controls.Add(this.botaox);
            this.Controls.Add(this.botaosoma);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaosoma;
        private System.Windows.Forms.Button botaox;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botao9;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button BOTAOCE;
        private System.Windows.Forms.Button botaobarra;
        private System.Windows.Forms.Button botaoresultado;
        private System.Windows.Forms.Button botaoC;
        private System.Windows.Forms.Button botao0;
        private System.Windows.Forms.Button botaomenos;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Label labelOperacao;
        private System.Windows.Forms.TextBox resultado;
    }
}

