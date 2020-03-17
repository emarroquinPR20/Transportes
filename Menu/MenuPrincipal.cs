using System;
using static System.Console;

using static EdwinMarroquin.Util.Printer;
using EdwinMarroquin.Model;
using EdwinMarroquin.Controllers;

namespace EdwinMarroquin.Menu
{
    public class MenuPrincipal
    {
        ControllerAvion cAviones = new ControllerAvion();
        ControllerSubMarino cSubmarino = new ControllerSubMarino();
         public void MostrarMenu()
        {
            try
            {
                int opcion = 0;
                do
                {
                    Clear();
                    WriteTiTle("Sistema de Transportes");
                    WriteLine("1. Crear Avion");
                    WriteLine("2. Crear Submarino");
                    WriteLine("3. Mostrar información de los aviones");
                    WriteLine("4. Mostrar información de los submarinos");
                    WriteLine("5. Salir");
                    WriteLine("Ingrese opción");
                    string opcionElegida = ReadLine();
                    opcion = Convert.ToByte(opcionElegida);
                    switch (opcion)
                    {
                        case 0:
                            break;
                        case 1:
                            CrearAvion();
                            break;
                        case 2:
                            CrearSubmarino();
                            break;
                        case 3:
                            MostrarAviones();
                            break;
                        case 4:
                            MostrarSubmarinos();
                            break;
                        case 5:
                            break;
                        default:
                            Clear();
                            WriteTiTle("Sistema de Transportes");
                            WriteLine("Opción Seleccionada NO valida");
                            PrecionarEnter();
                            break;                            
                    }
                } while (opcion != 5);
            }
            catch (Exception e)
            {
                Clear();
                WriteTiTle("Sistema de Transportes");
                WriteLine(e.Message);
                PrecionarEnter();
            }
        }
        private void CrearAvion()
        {
            Clear();
            WriteTiTle("Sistema de Transportes - Avion -");                 
            WriteLine("Velocidad Maxima:");
            double velocidadmaxima = Convert.ToDouble(ReadLine());       
            WriteLine("Valocidad Minima:");
            double velocidadminima = Convert.ToDouble(ReadLine());       
            WriteLine("Marca:");
            string marca = ReadLine();       
            WriteLine("Modelo:");
            string modelo = ReadLine();       
            WriteLine("Altura Maxima:");
            double alturamaxima = Convert.ToDouble(ReadLine());       
            WriteLine("Altura Minima:");
            double alturaminima = Convert.ToDouble(ReadLine());                   
            Avion nwAvion = new Avion(velocidadmaxima,velocidadminima,marca,modelo,alturamaxima,alturaminima);
            cAviones.Agregar(nwAvion);
            PrecionarEnter();
        }
        private void CrearSubmarino()
        {
            Clear();
            WriteTiTle("Sistema de Transportes - Submarino -");                 
            WriteLine("Velocidad Maxima:");
            double velocidadmaxima = Convert.ToDouble(ReadLine());       
            WriteLine("Valocidad Minima:");
            double velocidadminima = Convert.ToDouble(ReadLine());       
            WriteLine("Marca:");
            string marca = ReadLine();       
            WriteLine("Modelo:");
            string modelo = ReadLine();       
            WriteLine("Profundidad Maxima:");
            double profundidadmaxima = Convert.ToDouble(ReadLine());                         
            Submarino nwSubmarino = new Submarino(velocidadmaxima,velocidadminima,marca,modelo,profundidadmaxima);
            cSubmarino.Agregar(nwSubmarino);
            PrecionarEnter();
        }
        private void MostrarAviones()
        {
            Clear();
            WriteTiTle("Sistema de Transportes - Lista de Aviones -"); 
            cAviones.Listar(); 
            PrecionarEnter();
        }
        private void MostrarSubmarinos()
        {
            Clear();
            WriteTiTle("Sistema de Transportes - Lista de Submarinos -");  
            cSubmarino.Listar();
            PrecionarEnter();
        }
    }
}