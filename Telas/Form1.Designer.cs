namespace telaAi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_estCiv = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_funcao = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.mtb_nasc = new System.Windows.Forms.MaskedTextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_id.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.SystemColors.Control;
            this.tb_id.Location = new System.Drawing.Point(18, 52);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 19);
            this.tb_id.TabIndex = 0;
            this.tb_id.Text = "\r\n\r\n";
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // tb_estCiv
            // 
            this.tb_estCiv.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_estCiv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_estCiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_estCiv.Location = new System.Drawing.Point(279, 52);
            this.tb_estCiv.Name = "tb_estCiv";
            this.tb_estCiv.Size = new System.Drawing.Size(100, 19);
            this.tb_estCiv.TabIndex = 2;
            this.tb_estCiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_estCiv_KeyPress);
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_nome.Location = new System.Drawing.Point(17, 113);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(361, 19);
            this.tb_nome.TabIndex = 3;
            this.tb_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nome_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(147, 236);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 4;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_email.Location = new System.Drawing.Point(17, 176);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(361, 19);
            this.tb_email.TabIndex = 5;
            // 
            // tb_funcao
            // 
            this.tb_funcao.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_funcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_funcao.Location = new System.Drawing.Point(17, 361);
            this.tb_funcao.Name = "tb_funcao";
            this.tb_funcao.Size = new System.Drawing.Size(100, 19);
            this.tb_funcao.TabIndex = 9;
            this.tb_funcao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_funcao_KeyPress);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(279, 298);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 23);
            this.textBox12.TabIndex = 11;
            // 
            // tb_estado
            // 
            this.tb_estado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_estado.Location = new System.Drawing.Point(278, 300);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(100, 19);
            this.tb_estado.TabIndex = 12;
            this.tb_estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_estado_KeyPress);
            // 
            // tb_cidade
            // 
            this.tb_cidade.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(146, 300);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(100, 19);
            this.tb_cidade.TabIndex = 13;
            this.tb_cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cidade_KeyPress);
            // 
            // tb_endereco
            // 
            this.tb_endereco.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(17, 300);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(100, 19);
            this.tb_endereco.TabIndex = 14;
            this.tb_endereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_endereco_KeyPress);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_limpar.Location = new System.Drawing.Point(9, 395);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(97, 23);
            this.btn_limpar.TabIndex = 16;
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(617, 394);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(97, 23);
            this.btn_Salvar.TabIndex = 15;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtb_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpf.Location = new System.Drawing.Point(17, 239);
            this.mtb_cpf.Mask = "000,000,000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(100, 19);
            this.mtb_cpf.TabIndex = 17;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Location = new System.Drawing.Point(701, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(18, 19);
            this.btn_close.TabIndex = 18;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // mtb_nasc
            // 
            this.mtb_nasc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtb_nasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtb_nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_nasc.Location = new System.Drawing.Point(148, 239);
            this.mtb_nasc.Mask = "00/00/0000";
            this.mtb_nasc.Name = "mtb_nasc";
            this.mtb_nasc.Size = new System.Drawing.Size(100, 19);
            this.mtb_nasc.TabIndex = 19;
            this.mtb_nasc.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtb_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_telefone.Location = new System.Drawing.Point(278, 238);
            this.mtb_telefone.Mask = "00000-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(100, 19);
            this.mtb_telefone.TabIndex = 20;
            // 
            // tb_rg
            // 
            this.tb_rg.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rg.Location = new System.Drawing.Point(147, 53);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(100, 19);
            this.tb_rg.TabIndex = 1;
            this.tb_rg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_rg_KeyPress);
            // 
            // tb_salario
            // 
            this.tb_salario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salario.Location = new System.Drawing.Point(278, 361);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(100, 19);
            this.tb_salario.TabIndex = 21;
            this.tb_salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_salario_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(726, 427);
            this.ControlBox = false;
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.mtb_nasc);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.tb_funcao);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_estCiv);
            this.Controls.Add(this.tb_rg);
            this.Controls.Add(this.tb_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_estCiv;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_funcao;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.MaskedTextBox mtb_nasc;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.TextBox tb_rg;
        private System.Windows.Forms.TextBox tb_salario;
    }
}

