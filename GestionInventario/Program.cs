using System;

namespace GestionInventario {

    public class Program
    {
        public static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            // Ingreso de productos
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del producto (o 'salir' para terminar):");
                string nombre = Console.ReadLine();
                if (nombre.ToLower() == "salir") return;
             
                Console.WriteLine("Ingrese el precio del producto:");
                if (decimal.TryParse(Console.ReadLine(), out decimal precio) && precio > 0)
                {
                    inventario.AgregarProducto(new Producto(nombre, precio));
                }
                else
                {
                    Console.WriteLine("Precio inválido. Intente nuevamente.");
                    break;
                }
                
                // Filtrado y ordenación de productos
                Console.WriteLine("Ingrese el precio mínimo para filtrar:");
                if (decimal.TryParse(Console.ReadLine(), out decimal precioMinimo))
                {
                    inventario.FiltrarYOrdenar(precioMinimo);
                }

                // Funciones adicionales
                inventario.ActualizarPrecio("ProductoEjemplo", 150); // Ejemplo de actualización de precio
                inventario.EliminarProducto("ProductoEjemplo");      // Ejemplo de eliminación de producto
                inventario.ContarYAgruparProductos();                 // Agrupación por rangos de precio
                inventario.GenerarReporte();                          // Generar reporte

                Console.WriteLine("Programa ha terminado.");
            }
        }
    }
}