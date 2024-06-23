namespace TP3___Atividade_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco1 = new Endereco("Rua A", 123, "Apto 1", "Bairro A", "Município A", "Estado A", "00000-000");
            Endereco endereco2 = new Endereco("Rua B", 456, "Casa 2", "Bairro B", "Município B", "Estado B", "11111-111");

            Aluno aluno1 = new Aluno(1, "João Silva", "1234-5678", endereco1);
            Aluno aluno2 = new Aluno(2, "Maria Oliveira", "8765-4321", endereco2);

            Console.WriteLine("Aluno 1");
            Console.WriteLine(aluno1);

            Console.WriteLine();

            Console.WriteLine("Aluno 2");
            Console.WriteLine(aluno2);
        }
    }
}
