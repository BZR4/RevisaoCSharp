using System;

namespace RevisaoCSharp
{
    class Program
    {

        public static void Main(string[] args)
        {
            //TODO: Fazer cahamadas de teste de funcoes
        }

        public static double mediaAritmeticaDoisValores(double v1, double v2)
        {
            return (v1 + v2) / 2;
        }

        public static int dobro(int valor)
        {
            return valor * 2;
        }

        public static int triplo(int valor)
        {
            return valor * 3;
        }

        public static double mediaPonderadaPesoDez(double v1, double v2,
            double v3, double v4)
        {
            return ((v1 * 1) + (v2 * 3) + (v3 * 2) + (v4 * 4)) / 10D;
        }

        public static void escreverNomesGrupo(string[] grupo)
        {
            for (int i = 0; i < grupo.Length; i++)
            {
                dizerOla(grupo[i]);
            }
        }

        public static void dizerOla(string nome)
        {
            Console.WriteLine("Oi, {0}! E aí? Tudo bem?", nome);
        }

        public static void dizerTchau(string nome)
        {
            Console.WriteLine("Tchau, {0}; até breve!", nome);
        }

        public static void dizerBomDia(string nome)
        {
            Console.WriteLine("Bom dia, {0}! Tenha um ótimo dia!", nome);
        }
    }
}
