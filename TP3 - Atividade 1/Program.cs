namespace TP3___Atividade_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();
            Retangulo retangulo2 = new Retangulo(20.5, 10);

            retangulo1.Base = 20.5;
            retangulo1.Altura = 10;

            Console.WriteLine("Retângulo 1:");
            Console.WriteLine(retangulo1);

            Console.WriteLine("Retângulo 2:");
            Console.WriteLine(retangulo2);
        }
    }
}
