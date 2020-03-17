using EdwinMarroquin.Model;

namespace EdwinMarroquin.Model
{
    public class Avion : Vehiculo
    {

        public double AlturaMaxima { get; set; }
        public double AlturaMinima { get; set; }

        public Avion()
        {
        }

        public Avion(double velocidadMaxima, double velocidadMinima, string marca, string modelo,double alturaMaxima, double alturaMinima) 
        : base(velocidadMaxima, velocidadMinima, marca, modelo)
        {
            AlturaMaxima = alturaMaxima;
            AlturaMinima = alturaMinima;
        }

        public void Despegar()
        {
        }
        public void Aterrizar ()
        {            
        }
        public override string  ToString()
        {
            return $" {{ \"Modelo\": \"{this.Modelo}\",  \"Marca\": \"{this.Marca}\", \"Altura Maxima\": {this.AlturaMaxima}, \"Altura Minima\": {this.AlturaMinima} }}";
        }
    }
}