using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace telaAi.Entidades
{
    internal class Validacoes
    {
        public static bool ValidarCPF(string cpf)
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
        public static bool ValidarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);

            //SIM EU TIREI ISSO DO CHAT GPT
               //░░░░░░░░░░░░▄▄░░░░░░░░░
               //░░░░░░░░░░░█░░█░░░░░░░░
               //░░░░░░░░░░░█░░█░░░░░░░░
               //░░░░░░░░░░█░░░█░░░░░░░░
               //░░░░░░░░░█░░░░█░░░░░░░░
               //███████▄▄█░░░░░██████▄░
               //▓▓▓▓▓▓█░░░░░░░░░░░░░░█░
               //▓▓▓▓▓▓█░░░░░░░░░░░░░░█░
               //▓▓▓▓▓▓█░░░░░░░░░░░░░░█░
               //▓▓▓▓▓▓█░░░░░░░░░░░░░░█░
               //▓▓▓▓▓▓█░░░░░░░░░░░░░░█░
               //▓▓▓▓▓▓█████░░░░░░░░░█░░
               //██████▀░░░░▀▀██████▀░░░
        }
    }
}
