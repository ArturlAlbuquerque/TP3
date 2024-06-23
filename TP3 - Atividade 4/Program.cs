namespace TP3___Atividade_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("admin", "123456", "admin@example.com");

            Console.Write("Digite o username: ");
            string inputUsername = Console.ReadLine();
            Console.Write("Digite a senha: ");
            string inputSenha = Console.ReadLine();

            VerificarLogin(usuario, inputUsername, inputSenha);
        }

        static void VerificarLogin(Usuario usuario, string username, string senha)
        {
            bool loginValido = usuario.ValidarLogin(username, senha);

            if (loginValido)
            {
                Console.WriteLine("Login válido!");
            }
            else
            {
                Console.WriteLine("Login inválido!");
            }
        }
    }
}