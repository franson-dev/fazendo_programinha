
namespace fazendo_programinha
{
    partial class form_calculos_botoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_calculos_botoes));
            this.Limpar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.lblSinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Limpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(342, 365);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(179, 54);
            this.Limpar.TabIndex = 0;
            this.Limpar.Text = "&Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Fechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.Location = new System.Drawing.Point(75, 365);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(179, 54);
            this.Fechar.TabIndex = 1;
            this.Fechar.Text = "&Fechar";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // adicao
            // 
            this.adicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adicao.Cursor = System.Windows.Forms.Cursors.Default;
            this.adicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicao.Location = new System.Drawing.Point(75, 101);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(151, 70);
            this.adicao.TabIndex = 2;
            this.adicao.Text = "&SOMAR";
            this.adicao.UseVisualStyleBackColor = false;
            this.adicao.Click += new System.EventHandler(this.Somar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(671, 209);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 77);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox2.Location = new System.Drawing.Point(670, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 77);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResultado.Location = new System.Drawing.Point(692, 375);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(53, 58);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "?";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 13;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.equal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.equal.Location = new System.Drawing.Point(700, 307);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(45, 48);
            this.equal.TabIndex = 14;
            this.equal.Text = "=";
            this.equal.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // subtracao
            // 
            this.subtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subtracao.Cursor = System.Windows.Forms.Cursors.Default;
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(389, 102);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(151, 71);
            this.subtracao.TabIndex = 15;
            this.subtracao.Text = "&SUBTRAIR";
            this.subtracao.UseVisualStyleBackColor = false;
            this.subtracao.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.multiplicacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(232, 101);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(151, 71);
            this.multiplicacao.TabIndex = 16;
            this.multiplicacao.Text = "&MULTIPLICAR";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(232, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 71);
            this.button3.TabIndex = 23;
            this.button3.Text = "&POTENCIAÇÃO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(389, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 71);
            this.button4.TabIndex = 22;
            this.button4.Text = "&PAR IMPAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.divisao.Cursor = System.Windows.Forms.Cursors.Default;
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(75, 187);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(151, 70);
            this.divisao.TabIndex = 21;
            this.divisao.Text = "&DIVIDIR";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click_1);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BackColor = System.Drawing.Color.Cyan;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSinal.Location = new System.Drawing.Point(692, 134);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(53, 58);
            this.lblSinal.TabIndex = 27;
            this.lblSinal.Text = "?";
            this.lblSinal.Click += new System.EventHandler(this.lblSinal_Click_1);
            // 
            // form_calculos_botoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.Fechar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Limpar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_calculos_botoes";
            this.Text = "CÁRCULUS";
            this.Load += new System.EventHandler(this.form_calculos_botoes_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Label lblSinal;
    }
}

