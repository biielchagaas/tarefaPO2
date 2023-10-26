using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telaAi.Entidades;

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
            List<Funcionario> funcionarios = new List<Funcionario>();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string nome = tb_nome.Text;
            string email = tb_email.Text;
            string telefone = tb_telefone.Text;
            string cpf = maskedTextBox1.Text;
            string estadoCivil = tb_estCiv.Text;
            string rg = tb_rg.Text;
            DateTime dataNasc = DateTime.Parse(tb_nasc.Text);
            string endereco = tb_endereco.Text;
            string cidade = tb_cidade.Text;
            string estado = tb_estado.Text;
            string funcao = tb_funcao.Text;
            double salario = Double.Parse(tb_salario.Text);
            Funcionario funcionario = new Funcionario(id, nome, email, telefone, cpf, estadoCivil, rg, dataNasc, endereco, cidade, estado, funcao, salario);
        }
    }
}
