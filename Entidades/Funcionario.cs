using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace telaAi.Entidades
{
    internal class Funcionario
    {
        private string _id;
        private string _nome;
        private string _email;
        private string _telefone;
        private string _cpf;
        private string _estadoCivil;
        private string _rg;
        private DateTime _dataNasc;
        private string _endereco;
        private string _cidade;
        private string _estado;
        private string _funcao;
        private double _salario;
        public Funcionario(string id, string nome, string email, string telefone, string cpf, string estadoCivil, string rg, DateTime dataNasc, string endereco, string cidade, string estado, string funcao, double salario)
        {
            _id = id;
            _nome = nome;
            _email = email;
            _telefone = telefone;
            _cpf = cpf;
            _estadoCivil = estadoCivil;
            _rg = rg;
            _dataNasc = dataNasc;
            _endereco = endereco;
            _cidade = cidade;
            _estado = estado;
            _funcao = funcao;
            _salario = salario;
        }
        public bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            int soma = 0;
            int cont = 0;
            int PNumV = 0;
            int SNumV = 0;
            if (cpf.Length != 11)
            {
                return false;
            }
            else
            {
                cont = 10;
                for (int i = 0; i < 9; i++)
                {
                    soma += Convert.ToInt32(cpf[i].ToString()) * cont;
                    cont--;
                }
                if (soma % 11 < 2)
                {
                    PNumV = 0;
                }
                else
                {
                    PNumV = 11 - (soma % 11);
                }
                soma = 0;
                cont = 11;
                for (int i = 0; i < 10; i++)
                {
                    soma += Convert.ToInt32(cpf[i].ToString()) * cont;
                    cont--;
                }
                if (soma % 11 < 2)
                {
                    SNumV = 0;
                }
                else
                {
                    SNumV = 11 - (soma % 11);
                }
                if (PNumV == Convert.ToInt32(cpf[9].ToString()) && SNumV == Convert.ToInt32(cpf[10].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool ValidarEmail(string email)
        {
            // Define a expressão regular para validar o e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Cria um objeto Regex com a expressão regular
            Regex regex = new Regex(pattern);

            // Verifica se o e-mail corresponde à expressão regular
            return regex.IsMatch(email);
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public string EstadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }
        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }
        public DateTime DataNasc
        {
            get { return _dataNasc; }
            set { _dataNasc = value; }
        }
        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }
        public double Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }
    }
}
