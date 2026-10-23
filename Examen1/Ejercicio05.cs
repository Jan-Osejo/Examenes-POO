namespace ExamenU1.Examen1
{
    /*
    Ejercicio 5 — Inventario de una papelería · 16 puntos
Una papelería desea controlar su inventario. Implemente un programa con tres listas paralelas: nombres de productos,
existencias y precios unitarios. El programa debe mostrar un menú que se repita hasta que el usuario elija salir.
Opciones del menú:
● Registrar producto: solicite nombre, existencia inicial y precio unitario. Valide que el nombre no esté vacío ni repetido, que
la existencia sea mayor o igual que cero y que el precio sea mayor que cero.
● Vender producto: solicite nombre y cantidad. Valide que el producto exista y que haya suficiente existencia. Descuente la
cantidad y muestre el total de la venta (cantidad por precio). Si no hay suficiente, muestre la existencia disponible.
● Abastecer producto: solicite nombre y cantidad. Valide que el producto exista y que la cantidad sea mayor que cero. Sume
la cantidad a la existencia.
● Mostrar inventario: para cada producto muestre nombre, existencia, precio y valor total en inventario (existencia por
precio). Al final, muestre el valor total del inventario.
● Mostraralertas:muestrelosproductosconexistenciamenoroiguala5yelproductoconelmayorvalortotaleninventario.
● Salir.
Requisitos:
● UseList<string>, List<int> y List<decimal>; recorra las listas con for o foreach.
● Use Contains e IndexOf para buscar productos y valide todas las entradas.
● Muestre los montos con dos decimales y formato de moneda

    */
    public class Ejercicio05
    {
        public void InventarioDeUnaPapeleria()
        {
            List<string> nombres = new List<string>();
            List<int> existencias = new List<int>();
            List<decimal> precios = new List<decimal>();
            while (true)
            {
                // Mostramos el menú con while requerido
                Console.WriteLine("Ingrese la opción:");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Vender producto");
                Console.WriteLine("3. Abastecer producto");
                Console.WriteLine("4. Mostrar inventario");
                Console.WriteLine("5. Mostrar alertas");
                Console.WriteLine("6. Salir");
                string opción = Console.ReadLine();

                // Validamos las opciones con switch requerido
                switch (opción)
                {
                    // Registramos un producto
                    case "1":
                        Console.WriteLine("Ingrese el nombre del producto:");
                        string nombre = Console.ReadLine();
                        if (nombre == "" || nombre == null)
                        {
                            Console.WriteLine("El nombre no puede estar vacío");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese la existencia inicial:");
                            int existencia = int.TryParse(Console.ReadLine(), out int resultado) ? resultado : 0;
                            if (existencia < 0)
                            {
                                Console.WriteLine("La existencia no puede ser menor a cero");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el precio unitario:");
                                decimal precio = decimal.TryParse(Console.ReadLine(), out decimal results) ? results : 0;
                                if (precio <= 0)
                                {
                                    Console.WriteLine("El precio no puede ser menor o igual a cero");
                                }
                                else
                                {
                                    nombres.Add(nombre);
                                    existencias.Add(existencia);
                                    precios.Add(precio);
                                }
                            }
                        } 
                        break;

                        //  Vender producto
                    case "2":
                        Console.WriteLine("Nombre\tPrecio\tExistencia");
                        foreach (string name in nombres)
                        {
                            Console.WriteLine($"{name}\t{precios[nombres.IndexOf(name)]:F2}\t{existencias[nombres.IndexOf(name)]}");
                        }
                        break;

                        // Abastecer producto
                    case "3":
                        Console.WriteLine("Ingrese el nombre del producto:");
                        string nombreProducto = Console.ReadLine();
                        if (nombreProducto == "" || nombreProducto == null)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese la cantidad:");
                            int cantidad = int.TryParse(Console.ReadLine(), out int resultado) ? resultado : 0;
                            if (cantidad < 0)
                            {
                                Console.WriteLine("La cantidad no puede ser menor a cero");
                            }
                            else
                            {
                                if (existencias[nombres.IndexOf(nombreProducto)] >= cantidad)
                                {
                                    existencias[nombres.IndexOf(nombreProducto)] -= cantidad;
                                }
                                else
                                {
                                    existencias[nombres.IndexOf(nombreProducto)] = 0;
                                }
                            }
                        }
                        break;

                        // Mostrar inventario
                    case "4":
                        Console.WriteLine("Nombre\tPrecio\tExistencia");
                        foreach (string name in nombres)
                        {
                            Console.WriteLine($"{name}\t{precios[nombres.IndexOf(name)]:F2}\t{existencias[nombres.IndexOf(name)]}");
                        }   
                        Console.WriteLine("Total:");
                        foreach (decimal precio in precios)
                        {
                            Console.WriteLine($"{existencias.Sum() * precio:F2}");
                        }  
                        break;

                        // Muestra las alertas
                    case "5":
                        Console.WriteLine("Alertas:");
                        foreach (string name in nombres)
                        {
                            if (existencias[nombres.IndexOf(name)] < 5)
                            {
                                Console.WriteLine($"El producto {name} tiene menos de 5 unidades");
                            }
                            else if (existencias[nombres.IndexOf(name)] > 10)
                            {
                                Console.WriteLine($"El producto {name} tiene más de 10 unidades");
                            }
                        }
                        break;

                        // Salimos del programa
                    case "6":
                        Console.WriteLine("Adiós");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}