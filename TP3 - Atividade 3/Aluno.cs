namespace TP3___Atividade_3
{
    public class Aluno
    {
        private int matricula;
        private string nome;
        private string telefone;
        private Endereco endereco;
        public Aluno()
        {
            matricula = 0;
            nome = string.Empty;
            telefone = string.Empty;
            endereco = new Endereco();
        }
        public Aluno(int matricula, string nome, string telefone, Endereco endereco)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
        }
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public override string ToString()
        {
            return $"  Matrícula: {matricula}\n  Nome: {nome}\n  Telefone: {telefone}\n  Endereço:\n{endereco}";
        }
    }
}
