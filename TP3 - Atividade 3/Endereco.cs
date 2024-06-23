namespace TP3___Atividade_3
{
    public class Endereco
    {
        private string rua;
        private int numero;
        private string complemento;
        private string bairro;
        private string municipio;
        private string estado;
        private string cep;
        public Endereco()
        {
            rua = string.Empty;
            numero = 0;
            complemento = string.Empty;
            bairro = string.Empty;
            municipio = string.Empty;
            estado = string.Empty;
            cep = string.Empty;
        }
        public Endereco(string rua, int numero, string complemento, string bairro, string municipio, string estado, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.municipio = municipio;
            this.estado = estado;
            this.cep = cep;
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public override string ToString()
        {
            return $"    {rua}\n    Número: {numero}\n    Complemento: {complemento}\n    Bairro: {bairro}\n    Município: {municipio}\n    Estado: {estado}\n    CEP: {cep}";
        }
    }
}
