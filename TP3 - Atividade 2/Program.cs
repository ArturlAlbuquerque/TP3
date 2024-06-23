namespace TP3___Atividade_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor1 = new Vendedor();
            Vendedor vendedor2 = new Vendedor(123, "Ana", "Silva", 2501.45, 180.78);

            vendedor1.Matricula = 456;
            vendedor1.Nome = "Carlos";
            vendedor1.Sobrenome = "Santos";
            vendedor1.Salario = 5500.67;
            vendedor1.Comissao = 380.46;

            Console.WriteLine("Vendedor 1:");
            Console.WriteLine(vendedor1);

            Console.WriteLine("Vendedor 2:");
            Console.WriteLine(vendedor2);
        }
    }
}
