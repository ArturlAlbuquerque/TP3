namespace TP3___Atividade_4
{
    public class Usuario
    {
        private string username;
        private string senha;
        private string email;
        public Usuario()
        {
            username = string.Empty;
            senha = string.Empty;
            email = string.Empty;
        }
        public Usuario(string username, string senha, string email)
        {
            this.username = username;
            this.senha = senha;
            this.email = email;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public bool ValidarLogin(string username, string senha)
        {
            return this.username == username && this.senha == senha;
        }
        public override string ToString()
        {
            return $"Username: {username}\nEmail: {email}";
        }
    }
}