namespace BibliotecaConversao//atividade 1
{
    public class Conversao
    {
        public float Graus(float graus)
        {

            return (graus * 1.8f)+32;
        }
        public float Metros(float metros)
        {
            return (metros / 1000);
        }
        public float Moeda(float valor, float taxa) //atividade 3
        {
            return valor / (taxa*100); //real para dolar
        }
    }

}
