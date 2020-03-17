using static System.Console;
using EdwinMarroquin.Model;
using EdwinMarroquin.Interfaz;
using System.Collections.Generic;

namespace EdwinMarroquin.Controllers
{
    public class ControllerSubMarino : IBitacora
    {
        List<Submarino> ListaSubMarinos = new List<Submarino>();
        public void Agregar(Submarino elemento)
        {
            ListaSubMarinos.Add(elemento);
        }
        public void Listar()
        {
            foreach (Submarino item in ListaSubMarinos)
            {
                WriteLine(item.ToString());
            }
        }
        public void MostrarDetalle()
        {
            foreach (Submarino item in ListaSubMarinos)
            {
                WriteLine($"{{ \"Profundidad Maxima\": {item.ProfundidadMaxima} }}");
            }

        }
    }
}