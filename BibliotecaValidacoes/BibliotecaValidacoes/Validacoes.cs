using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BibliotecaValidacoes
{
    public static class Validacoes//ATIVIDADE 7
    {
        public static bool ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            if (cpf.All(c => c == cpf[0]))
                return false;

            int[] nums = cpf.Select(c => int.Parse(c.ToString())).ToArray();

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += nums[i] * (10 - i);

            int resto = soma % 11;
            int dig1 = resto < 2 ? 0 : 11 - resto;

            if (nums[9] != dig1)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += nums[i] * (11 - i);

            resto = soma % 11;
            int dig2 = resto < 2 ? 0 : 11 - resto;

            return nums[10] == dig2;
        }

        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool ValidarSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                return false;

            if (senha.Length < 8)
                return false;

            if (!senha.Any(char.IsUpper))
                return false;

            if (!senha.Any(char.IsDigit))
                return false;

            return true;
        }
    }
}