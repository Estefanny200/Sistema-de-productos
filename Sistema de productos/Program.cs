using System;
class VentasWalmart
{
    static void Main(string[] args)
    {
        string[] categorias = { "Electronica", "Hogar" };
        string[,] productos = { { "TV Samsung 50 pulgadas", "500" }, { "Laptop HP", "700" }, { "Aspiradora", "150" }, { "Microondas", "120" } };

        double impuestosElectronica = 0.10;
        double impuestosHogar = 0.15;
        

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Bienvenidos a Walmart. Seleccione una categoria de productos:");
            Console.WriteLine("1.Electronica");
            Console.WriteLine("2.Hogar");
            Console.WriteLine("0.Salir");
            string opcion = Console.ReadLine();

            if (opcion == "0")
            {
                continuar = false;
                Console.WriteLine("Gracias por comprar en Walmart. Hasta luego!");
            }
            else if (opcion == "1" || opcion == "2")
            {
                int categoriaSeleccionada = int.Parse(opcion);
                string categoria = categorias[categoriaSeleccionada - 1];
                double impuesto = categoriaSeleccionada == 1 ? impuestosElectronica : impuestosHogar;


                Console.WriteLine($"Productos de la categoria {categoria} en Walmart:");
                for ( int i = 0; i  < productos.GetLength(0); i++)
                {
                    if (categoriaSeleccionada == 1 && i < 2 || categoriaSeleccionada == 2 && i >= 2)
                    {
                        Console.WriteLine($"{i + 1}. {productos[i,0]} - ${productos[i, 1]}");
                    }
                }

                Console.WriteLine("Seleccione un producto:");
                string productosSeleccionados = Console.ReadLine();
                int indiceProducto = int.Parse(productosSeleccionados) - 1;
                double precio = double.Parse(productos[indiceProducto, 1]);

                double precioConImpuesto = precio + (precio * impuesto);


                Console.WriteLine($"Ingrese la cantidad de {productos[indiceProducto, 0]} que desea comprar:");
                string CantidadInput = Console.ReadLine();
                int Cantidad = int.Parse(CantidadInput);


                double descuento = Cantidad > 100 ? 0.10 : Cantidad * 0.01;
                double precioFinal = precioConImpuesto * Cantidad * (1 - descuento);


                Console.WriteLine($"Total a pagar por {Cantidad} {productos[indiceProducto, 0]} en Walmart: ${precioFinal:F2}");
                Console.WriteLine("Desea seguir comprando en Walmart? (s/n)");
                string continuarComprando = Console.ReadLine();
                if (continuarComprando.ToLower() != "S")

                    if (continuarComprando == "n")
                {
                    continuar = false;
                    Console.WriteLine("Gracias por comprar en Walmart. Hasta luego!");
                }

                else
                {
                    Console.WriteLine("Opcion no valida. Intente de nuevo.");
                }

            }

        }
    }
}