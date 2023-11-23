using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using telaAi.Configuracao;
using telaAi.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace telaAi
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
            btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Salvar.FlatAppearance.BorderSize = 0;
            btn_Salvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Salvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Salvar.BackColor = Color.Transparent;
            btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_limpar.FlatAppearance.BorderSize = 0;
            btn_limpar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_limpar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_limpar.BackColor = Color.Transparent;
            btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_close.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_close.BackColor = Color.Transparent;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            string id = tb_id.Text;
            string nome = tb_nome.Text;
            string email = tb_email.Text;
            string telefone = mtb_telefone.Text;
            string cpf = mtb_cpf.Text;
            string estadoCivil = tb_estCiv.Text;
            string rg = tb_rg.Text;
            DateTime dataNasc = DateTime.Parse(mtb_nasc.Text);
            string endereco = tb_endereco.Text;
            string cidade = tb_cidade.Text;
            string estado = tb_estado.Text;
            string funcao = tb_funcao.Text;
            double salario = Double.Parse(tb_salario.Text);

            Funcionario funcionario = new Funcionario(id, nome, email, telefone, cpf, estadoCivil, rg, dataNasc, endereco, cidade, estado, funcao, salario);

            bool cpfValido = Validacoes.ValidarCPF(mtb_cpf.Text);
            bool emailValido = Validacoes.ValidarEmail(tb_email.Text);

            if (tb_id.Text == "" || tb_nome.Text == "" || tb_email.Text == "" || mtb_telefone.Text == "" || mtb_cpf.Text == "" || tb_estCiv.Text == "" || tb_rg.Text == "" || mtb_nasc.Text == "" || tb_endereco.Text == "" || tb_cidade.Text == "" || tb_estado.Text == "" || tb_funcao.Text == "" || tb_salario.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!!");
            }
            else
            {
                if (cpfValido && emailValido)
                {
                    funcionarios.Add(funcionario);
                    MessageBox.Show("Salvo");
                    Inserir();
                    Consultar();
                    this.Dispose();
                }
                if (!cpfValido)
                {
                    MessageBox.Show("Por favor, insira um CPF valido!!!");
                }
                if (!emailValido)
                {
                    MessageBox.Show("Por favor, insira um E-Mail valido!!!");
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_nome.Text = "";
            tb_email.Text = "";
            mtb_telefone.Text = "";
            mtb_cpf.Text = "";
            tb_estCiv.Text = "";
            tb_rg.Text = "";
            tb_endereco.Text = "";
            tb_cidade.Text = "";
            tb_estado.Text = "";
            tb_funcao.Text = "";
            mtb_nasc.Text = "";
            tb_salario.Text = "";

        }

        private void tb_rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tb_salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tb_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tb_endereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tb_funcao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tb_cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Subtract)
            {
                e.Handled = true;
            }
        }

        private void tb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tb_estCiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        void Inserir()
        {
            string id = tb_id.Text;
            string nome = tb_nome.Text;
            string email = tb_email.Text;
            string telefone = mtb_telefone.Text;
            string cpf = mtb_cpf.Text;
            string estadoCivil = tb_estCiv.Text;
            string rg = tb_rg.Text;
            DateTime dataNasc = DateTime.Parse(mtb_nasc.Text);
            string endereco = tb_endereco.Text;
            string cidade = tb_cidade.Text;
            string estado = tb_estado.Text;
            string funcao = tb_funcao.Text;
            double salario = Double.Parse(tb_salario.Text);

            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");

            telefone = telefone.Replace("-", "");
            telefone = telefone.Replace(".", "");

            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Funcionario (id_fun, nome_fun, dataNasc_fun, cpf_fun, rg_fun, telefone_fun, email_fun, endereco_fun," +
                    " estado_fun, cidade_fun, estado_civil_fun, funcao_fun, salario_fun)" +
                    " VALUES (@id ,@nome, @dataNasc, @cpf, @rg, @telefone, @email, @endereco, @estado, @cidade, @estadoCivil, @funcao, @salario);");

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@dataNasc", dataNasc.Date);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@rg", rg);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("email", email);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                comando.Parameters.AddWithValue("@funcao", funcao);
                comando.Parameters.AddWithValue("@salario", salario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Funcionario");

                var leitor = comando.ExecuteReader();

                string resultado = null;

                while (leitor.Read())
                {
                    resultado += "\n" + leitor.GetString("nome_fun");
                }

                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
