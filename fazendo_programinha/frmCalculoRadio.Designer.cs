
namespace fazendo_programinha
{
    partial class frmCalculoRadio
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
            this.gbOperacoes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSegundoValor = new System.Windows.Forms.TextBox();
            this.rbPotenciacao = new System.Windows.Forms.RadioButton();
            this.tbPrimeiroValor = new System.Windows.Forms.TextBox();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.lbResultado = new System.Windows.Forms.Label();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbSubtrair = new System.Windows.Forms.RadioButton();
            this.lbSigla = new System.Windows.Forms.Label();
            this.rbSomar = new System.Windows.Forms.RadioButton();
            this.calcular = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.bIfElseIf = new System.Windows.Forms.Button();
            this.gbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperacoes
            // 
            this.gbOperacoes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbOperacoes.Controls.Add(this.label2);
            this.gbOperacoes.Controls.Add(this.tbSegundoValor);
            this.gbOperacoes.Controls.Add(this.rbPotenciacao);
            this.gbOperacoes.Controls.Add(this.tbPrimeiroValor);
            this.gbOperacoes.Controls.Add(this.rbDividir);
            this.gbOperacoes.Controls.Add(this.lbResultado);
            this.gbOperacoes.Controls.Add(this.rbMultiplicar);
            this.gbOperacoes.Controls.Add(this.rbSubtrair);
            this.gbOperacoes.Controls.Add(this.lbSigla);
            this.gbOperacoes.Controls.Add(this.rbSomar);
            this.gbOperacoes.ForeColor = System.Drawing.Color.White;
            this.gbOperacoes.Location = new System.Drawing.Point(32, 23);
            this.gbOperacoes.Name = "gbOperacoes";
            this.gbOperacoes.Size = new System.Drawing.Size(751, 308);
            this.gbOperacoes.TabIndex = 0;
            this.gbOperacoes.TabStop = false;
            this.gbOperacoes.Text = "Operações";
            this.gbOperacoes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSegundoValor
            // 
            this.tbSegundoValor.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSegundoValor.Location = new System.Drawing.Point(488, 141);
            this.tbSegundoValor.Name = "tbSegundoValor";
            this.tbSegundoValor.Size = new System.Drawing.Size(59, 42);
            this.tbSegundoValor.TabIndex = 8;
            this.tbSegundoValor.TextChanged += new System.EventHandler(this.tbSegundoValor_TextChanged);
            // 
            // rbPotenciacao
            // 
            this.rbPotenciacao.AutoSize = true;
            this.rbPotenciacao.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPotenciacao.Location = new System.Drawing.Point(140, 179);
            this.rbPotenciacao.Name = "rbPotenciacao";
            this.rbPotenciacao.Size = new System.Drawing.Size(92, 24);
            this.rbPotenciacao.TabIndex = 4;
            this.rbPotenciacao.TabStop = true;
            this.rbPotenciacao.Text = "Potência ";
            this.rbPotenciacao.UseVisualStyleBackColor = true;
            this.rbPotenciacao.CheckedChanged += new System.EventHandler(this.rbPotenciacao_CheckedChanged);
            // 
            // tbPrimeiroValor
            // 
            this.tbPrimeiroValor.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrimeiroValor.Location = new System.Drawing.Point(350, 141);
            this.tbPrimeiroValor.Name = "tbPrimeiroValor";
            this.tbPrimeiroValor.Size = new System.Drawing.Size(59, 42);
            this.tbPrimeiroValor.TabIndex = 7;
            this.tbPrimeiroValor.TextChanged += new System.EventHandler(this.tbPrimeiroValor_TextChanged);
            // 
            // rbDividir
            // 
            this.rbDividir.AutoSize = true;
            this.rbDividir.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDividir.Location = new System.Drawing.Point(111, 149);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(75, 24);
            this.rbDividir.TabIndex = 3;
            this.rbDividir.TabStop = true;
            this.rbDividir.Text = "Dividir";
            this.rbDividir.UseVisualStyleBackColor = true;
            this.rbDividir.CheckedChanged += new System.EventHandler(this.rbDividir_CheckedChanged);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(620, 137);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(40, 46);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "?";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiplicar.Location = new System.Drawing.Point(82, 119);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(104, 24);
            this.rbMultiplicar.TabIndex = 2;
            this.rbMultiplicar.TabStop = true;
            this.rbMultiplicar.Text = "Multiplicar ";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            this.rbMultiplicar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbSubtrair
            // 
            this.rbSubtrair.AutoSize = true;
            this.rbSubtrair.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubtrair.Location = new System.Drawing.Point(54, 89);
            this.rbSubtrair.Name = "rbSubtrair";
            this.rbSubtrair.Size = new System.Drawing.Size(88, 24);
            this.rbSubtrair.TabIndex = 1;
            this.rbSubtrair.TabStop = true;
            this.rbSubtrair.Text = "Subtrair ";
            this.rbSubtrair.UseVisualStyleBackColor = true;
            this.rbSubtrair.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbSigla
            // 
            this.lbSigla.AutoSize = true;
            this.lbSigla.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSigla.Location = new System.Drawing.Point(428, 137);
            this.lbSigla.Name = "lbSigla";
            this.lbSigla.Size = new System.Drawing.Size(40, 46);
            this.lbSigla.TabIndex = 4;
            this.lbSigla.Text = "?";
            this.lbSigla.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbSomar
            // 
            this.rbSomar.AutoSize = true;
            this.rbSomar.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSomar.Location = new System.Drawing.Point(25, 59);
            this.rbSomar.Name = "rbSomar";
            this.rbSomar.Size = new System.Drawing.Size(79, 24);
            this.rbSomar.TabIndex = 0;
            this.rbSomar.TabStop = true;
            this.rbSomar.Text = "Somar ";
            this.rbSomar.UseVisualStyleBackColor = true;
            this.rbSomar.CheckedChanged += new System.EventHandler(this.rbSomar_CheckedChanged);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calcular.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calcular.Location = new System.Drawing.Point(77, 337);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(191, 49);
            this.calcular.TabIndex = 1;
            this.calcular.Text = "&CALCULAR(switch...case) ";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(622, 380);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(131, 49);
            this.exit.TabIndex = 2;
            this.exit.Text = "&FECHAR";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.limpar.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.limpar.Location = new System.Drawing.Point(356, 380);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(129, 49);
            this.limpar.TabIndex = 3;
            this.limpar.Text = "&LIMPAR";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // bIfElseIf
            // 
            this.bIfElseIf.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bIfElseIf.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIfElseIf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bIfElseIf.Location = new System.Drawing.Point(77, 392);
            this.bIfElseIf.Name = "bIfElseIf";
            this.bIfElseIf.Size = new System.Drawing.Size(191, 49);
            this.bIfElseIf.TabIndex = 5;
            this.bIfElseIf.Text = "&CALCULAR(if...else if) ";
            this.bIfElseIf.UseVisualStyleBackColor = false;
            this.bIfElseIf.Click += new System.EventHandler(this.bIfElseIf_Click);
            // 
            // frmCalculoRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.bIfElseIf);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.gbOperacoes);
            this.Name = "frmCalculoRadio";
            this.Text = "frmCalculoRadio";
            this.Load += new System.EventHandler(this.frmCalculoRadio_Load);
            this.gbOperacoes.ResumeLayout(false);
            this.gbOperacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperacoes;
        private System.Windows.Forms.RadioButton rbPotenciacao;
        private System.Windows.Forms.RadioButton rbDividir;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbSubtrair;
        private System.Windows.Forms.RadioButton rbSomar;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Label lbSigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox tbPrimeiroValor;
        private System.Windows.Forms.TextBox tbSegundoValor;
        private System.Windows.Forms.Button bIfElseIf;
    }
}