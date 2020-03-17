namespace EdwinMarroquin.Model

{
    public class Vehiculo
    {

        public double VelocidadMaxima { get; set; }
        public double VelocidadMinima { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo()
        {
        } 
        public Vehiculo(double velocidadMaxima, double velocidadMinima, string marca, string modelo)
        {
            VelocidadMaxima = velocidadMaxima;
            VelocidadMinima = velocidadMinima;
            Marca = marca;
            Modelo = modelo;
        }

        public void Encender()
        {
        }
        public void Apagar()
        {            
        }

    }
}