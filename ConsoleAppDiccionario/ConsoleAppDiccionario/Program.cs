using System;
using System.Collections.Generic;

namespace PruebasSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Pruebas del Código de Conexión */
            Dictionary<string, object> datosInventario = new Dictionary<string, object>
            {
                { "Nombre", "Laptop HP Envy" },
                { "Precio", 850.99m },
                { "Cantidad", 15 }
            };

            var setParts = new List<string>();
            foreach (var key in datosInventario.Keys)
            {
                setParts.Add($"{key} = @{key}");
            }
            string setClause = string.Join(", ", setParts);

            // Imprimimos el resultado en consola para verificar cómo se armó
            Console.WriteLine($"Cláusula SET generada: {setClause}");

            var columns = string.Join(", ", datosInventario.Keys);
            var placeholders = "@" + string.Join(", @", datosInventario.Keys);

            string sql = $"INSERT INTO productos ({columns}) VALUES ({placeholders})";

            Console.WriteLine($"la cadena sql es: {sql}");

            // Pausa para que la consola no se cierre inmediatamente al terminar
            Console.ReadLine();
        }
    }
}
