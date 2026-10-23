namespace ExamenU1.Examen1
{

    /*
Ejercicio 1 — Cotizador de envíos · 10 puntos
Una empresa de mensajería cobra el envío según la zona de destino, el peso del paquete, el tipo de servicio y el valor
declarado. Escriba un programa de consola que solicite el nombre del cliente, la zona (1 = local, 2 = departamental, 3 =
nacional), el pesoenkilogramos,eltipodeservicio(1=estándar,2=express,3=mismodía)yelvalordeclaradodelpaquete.
Tarifas:
● Zona 1(local): L. 60.00; zona 2 (departamental): L. 100.00; zona 3 (nacional): L. 150.00.
● Recargoporpeso:hasta1kg,L.0.00;másde1yhasta5kg,L.40.00;másde5yhasta10kg,L.80.00;másde10kg,L.140.00.
● Servicio: estándar +0%; express +25%; mismo día +50% sobre la suma de la base y el recargo por peso.
● Seguro: si el valor declarado supera L. 5,000.00, agregue el 2% de ese valor.
● Descuento: si el subtotal supera L. 700.00, aplique 5%.
Requisitos:
● Valide la zona (1 a 3), el peso (mayor que cero), el tipo de servicio (1 a 3) y el valor declarado (mayor o igual que cero).
● Use decimal para todos los montos, switch para la zona y el servicio, y if/else para el peso, el seguro y el descuento.
● Use el operador ternario para mostrar «Envío asegurado» o «Envío sin seguro».
● Muestre un recibo con el detalle de cada concepto y el total a pagar, con dos decimales y formato de moneda

    */
    public class Ejercicio01
    {
        public void CotizadorDeEnvios()
        {
            Console.WriteLine("Cotizador de envios");
            Console.WriteLine("Ingrese el número de clientes:");
            int numClientes = int.TryParse(Console.ReadLine(), out int resultado) ? resultado : 0;
            for (int i = 0; i < numClientes; i++)
            {
                Console.WriteLine($"Cliente {i + 1}");
            }
            for (int i = 0; i < numClientes; i++)
            {
                // Ingresamos los datos del cliente
                Console.WriteLine($"Cliente {i + 1}");
                Console.WriteLine("Ingrese la zona (1 = local, 2 = departamental, 3 = nacional):");
                int zona = int.TryParse(Console.ReadLine(), out int zone) ? zone : 0;
                Console.WriteLine("Ingrese el peso del paquete (kg):");
                double peso = double.TryParse(Console.ReadLine(), out double weight) ? weight : 0;
                Console.WriteLine("Ingrese el tipo de servicio (1 = estándar, 2 = express, 3 = mismo día):");
                int tipoServicio = int.TryParse(Console.ReadLine(), out int service) ? service : 0;
                Console.WriteLine("Ingrese el valor declarado del paquete (Lempiras):");
                double valorDeclarado = double.TryParse(Console.ReadLine(), out double Lempiras) ? Lempiras : 0;
                // Validamos la zona 
                if (zona < 1 || zona > 3)
                {
                    Console.WriteLine("Zona no válida");
                    break;
                }
                // Validamos el peso
                if (peso <= 0)
                {
                    Console.WriteLine("El peso no puede ser menor o igual a cero");
                    break;
                }
                // Validamos el tipo de servicio
                if (tipoServicio < 1 || tipoServicio > 3)
                {
                    Console.WriteLine("Tipo de servicio no válido");
                    break;
                }
                // Validamos el valor declarado
                if (valorDeclarado <= 0)
                {
                    Console.WriteLine("El valor declarado no puede ser menor o igual a cero");
                    break;
                }

                // Calculamos el subtotal
                double subtotal = 0;
                switch (zona)
                {
                    case 1:
                        subtotal = peso * 0.15;
                        break;
                    case 2:
                        subtotal = peso * 0.10;
                        break;
                    case 3:
                        subtotal = peso * 0.15;
                        break;
                    default:
                        Console.WriteLine("Zona no válida");
                        break;
                    }
                    // Calculamos el seguro
                    double seguro = 0;
                    if (valorDeclarado >= 1000)
                    {
                        seguro = valorDeclarado * 0.05;
                    }
                    else
                    {
                        seguro = 0;
                    }
                    // Calculamos el descuento
                    double descuento = 0;
                    if (subtotal >= 1500)
                    {
                        descuento = subtotal * 0.05;
                    }
                    if (subtotal >= 1000)
                    {
                        descuento = subtotal * 0.03;
                    }
                    else
                    {
                        descuento = 0;
                    }
                    // Calculamos el total a pagar
                    double totalAPagar = subtotal + seguro + descuento;
                    Console.WriteLine($"Subtotal: {subtotal:F2}");
                    Console.WriteLine($"Descuento: {descuento:F2}");
                    Console.WriteLine($"Seguridad: {seguro:F2}");
                    Console.WriteLine($"Total a pagar: {totalAPagar:F2}");
                    Console.WriteLine($"Envío {i} asegurado");
                }
            }
        }
    } 
