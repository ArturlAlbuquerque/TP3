namespace TP3___Atividade_1
{
    public class Retangulo
    {
        private double baseRetangulo;
        private double alturaRetangulo;

        public Retangulo()
        {
            baseRetangulo = 0.0;
            alturaRetangulo = 0.0;
        }

        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            this.baseRetangulo = baseRetangulo;
            this.alturaRetangulo = alturaRetangulo;
        }

        public double Base
        {
            get { return baseRetangulo; }
            set { baseRetangulo = value; }
        }

        public double Altura
        {
            get { return alturaRetangulo; }
            set { alturaRetangulo = value; }
        }


        public double CalcularArea()
        {
            return baseRetangulo * alturaRetangulo;
        }


        public double CalcularPerimetro()
        {
            return 2 * (baseRetangulo + alturaRetangulo);
        }


        public override string ToString()
        {
            return $"Base: {baseRetangulo}, Altura: {alturaRetangulo}, Área: {CalcularArea()}, Perímetro: {CalcularPerimetro()}";
        }
    }
}
