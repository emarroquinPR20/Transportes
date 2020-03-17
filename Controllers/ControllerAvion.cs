using static System.Console;
using EdwinMarroquin.Model;
using EdwinMarroquin.Interfaz;
using System.Collections.Generic;

namespace EdwinMarroquin.Controllers
{
    public class ControllerAvion : IBitacora
    {
        List<Avion> ListaAviones = new List<Avion>();
        public void Agregar(Avion elemento)
        {
            ListaAviones.Add((Avion)elemento);
        }
        public void Listar()
        {
            foreach (Avion item in ListaAviones)
            {                
                WriteLine(item.ToString());
            }
        }
        public void MostrarDetalle()
        {
            foreach (Avion item in ListaAviones)
            {
                WriteLine($"{{ \"Altura Maxima\" : {item.AlturaMaxima} }}");               
            }
        }
    }
}