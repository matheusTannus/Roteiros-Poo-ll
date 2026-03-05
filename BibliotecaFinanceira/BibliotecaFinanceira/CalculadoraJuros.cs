namespace BibliotecaFinanceira//ATIVIDADE 6
{
    public class CalculadoraJuros
    {
        public double JurosSimples(double capital, double taxa, double tempo)
        {
            return CalculoInterno(capital, taxa, tempo);
        }

        internal double CalculoInterno(double capital, double taxa, double tempo)
        {
            return capital * taxa * tempo;//O método internal não aparece porque ele possui acesso restrito ao assembly onde foi criado.
        }
    }
}