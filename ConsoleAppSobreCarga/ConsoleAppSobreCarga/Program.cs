using System;
using SobreCargaMetodos;
namespace ConsoleAppSobreCarga
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Instancias la clase y ejecutas el método
            SobreCarga varSobreCarga = new SobreCarga();
            varSobreCarga.ProbarMetodosSobreCargados();
            varSobreCarga.Cuadrado(8);
            Console.WriteLine("El cuadrado de {0}", varSobreCarga.Cuadrado(9));
        }
    }
}
