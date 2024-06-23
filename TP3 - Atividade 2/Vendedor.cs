namespace TP3___Atividade_2
{
    public class Vendedor
    {
        private int matricula;
        private string nome;
        private string sobrenome;
        private double salario;
        private double comissao;

        public Vendedor()
        {
            matricula = 0;
            nome = string.Empty;
            sobrenome = string.Empty;
            salario = 0;
            comissao = 0;
        }
        public Vendedor(int matricula, string nome, string sobrenome, double salario, double comissao)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.salario = salario;
            this.comissao = comissao;
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

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        public double CalcularSalarioComComissao()
        {
            return salario + comissao;
        }
        public string NomeFormatado()
        {
            return $"{nome} {sobrenome}";
        }
        public override string ToString()
        {
            return $"Matrícula: {matricula}\nNome: {NomeFormatado()}\nSalário: {salario:C}\nComissão: {comissao:C}\nSalário com Comissão: {CalcularSalarioComComissao():C}\n";
        }
    }
}
