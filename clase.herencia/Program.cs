using System;

namespace clase.herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            empleado emple = new empleado();
            producto prod = new producto();
            inventario inv = new inventario();
            ventas vent = new ventas();

            Console.WriteLine("Ingrese Los datos pedidos a continuacion... ");
            Console.WriteLine();
            emple.Datos();

            Console.WriteLine();
            prod.tipoProducto();

            prod.precioProducto();

            inv.precioDeVenta();
            inv.proveedor();
            inv.localidad();
            inv.cantidadDisponible();

            vent.Producto();
            vent.empleadoVendedor();
            vent.cantidadDisponible();
        }

        class empleado
        {

            public void Datos()
            {

                string nombre;
                int edad;
                String cargo;

                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Cargo en el que esta: ");
                cargo = Console.ReadLine();

            }

        }

        class producto
        {

            public void tipoProducto()
            {
                Console.WriteLine("Tipos de Productos");
                Console.WriteLine();
                Console.WriteLine("1. Manzana");
                Console.WriteLine("2. Pera");
                Console.WriteLine("3. Mandarina");
                Console.WriteLine("4. Guineo");
                Console.WriteLine("5. Arroz");
                Console.WriteLine("6. Aceite");
                Console.WriteLine("7. Carne de res");
                Console.WriteLine("8. Mango");
                Console.WriteLine("9. Refrescos");
                Console.WriteLine("10. Botellas de agua ");
                Console.WriteLine();

            }

            public void precioProducto()
            {
                int[] precioprod = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" EL precio de Producto para vendedores: " + i);
                    precioprod[i] = int.Parse(Console.ReadLine());
                }

                for (int f = 0; f < 10; f++)
                {
                    Console.WriteLine("Los precios de los Producto son: " + precioprod[f]);

                }
                Console.WriteLine();
            }
        }
        class inventario
        {
            public void precioCompra()
            {


            }

            public void precioDeVenta()
            {
                int[] venta = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" EL costo de Venta es: " + i);
                    venta[i] = int.Parse(Console.ReadLine());
                }

                for (int f = 0; f < 10; f++)
                {
                    Console.WriteLine("Los precios de venta son: " + venta[f]);

                }
                Console.WriteLine();

            }
            public void proveedor()
            {

                Console.WriteLine("El proveedor es: " + "Ventas Express");
                Console.WriteLine();
            }
            public void localidad()
            {

                Console.WriteLine("estamos hubicados en la calle: " + "Pedro A. Lluveres #53/La Romana");
                Console.WriteLine();

            }
            public void cantidadDisponible()
            {
                int[] producto = { 60, 50, 70, 40, 5, 10, 5 / 6, 55, 12, 30 };

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Cantidad de producto disponible: " + producto[i]);

                }

            }

        }
        class ventas
        {
            public void Producto()
            {
                producto prod = new producto();
                prod.tipoProducto();
            }

            public void empleadoVendedor()
            {
                empleado vendedor = new empleado();
                vendedor.Datos();
            }

            public void cantidadDisponible()
            {
                inventario invt = new inventario();
                invt.cantidadDisponible();


            }

        }
    }
}




