using EdwinMarroquin.Model;
namespace EdwinMarroquin.Model
{
    public class Submarino : Vehiculo
    {

        public double ProfundidadMaxima { get; set; }

        public Submarino()
        {
        }

        public Submarino(double velocidadMaxima, double velocidadMinima, string marca, string modelo, double profundidadMaxima) 
        : base(velocidadMaxima, velocidadMinima, marca, modelo)
        {
            ProfundidadMaxima = profundidadMaxima;
        }
        public void Sumergir()
        {            
        }

        public override string  ToString()
        {
            return $"{{ \"Modelo \" : \"{this.Modelo}\",  \"Marca\" : \"{this.Marca}\", \"Profundidad Maxima \" {this.ProfundidadMaxima} }}";
        }

    }
}