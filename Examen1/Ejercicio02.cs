namespace ExamenU1.Examen1
{
    /*
    Ejercicio 2 — Simulador de carga de combustible · 10 puntos
    Una estación de servicio desea simular la carga de combustible de un vehículo. El programa debe solicitar el tipo de
    combustible (1 = regular, 2 = premium, 3 = diésel) y la cantidad de litros solicitada (máximo 60).
    Precios por litro:
    ● Regular: L. 28.50. Premium: L. 32.00. Diésel: L. 26.75.
    ● La bomba carga en bloques de 5 litros. Use un ciclo while para acumular los litros hasta alcanzar la cantidad solicitada; el
    último bloque puede ser parcial.
    ● En cada iteración muestre cuántos litros se han cargado.
    Al finalizar:
    ●   Calcule el subtotal multiplicando los litros cargados por el precio del combustible.
    ● Aplique un descuento del 5% si el subtotal es mayor o igual a L. 1,500.00; del 3% si es mayor o igual a L. 1,000.00; en caso
    contrario, no aplique descuento.
    ● Muestre el total de litros, el subtotal, el descuento y el total a pagar.
    Requisitos:
    ● Valide el tipo de combustible (1 a 3) y la cantidad de litros (mayor que cero y menor o igual que 60).
    ● Use switch para el tipo de combustible, while para la carga y if/else para el descuento.
    */
    public class Ejercicio02
    {
        public void SimuladorDeCargaDeCombustible()
        {
            // Solicitamos el tipo de combustible usando switch
            Console.WriteLine("Seleccione el tipo de combustible:");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Premium");
            Console.WriteLine("3. Diésel");
            Console.WriteLine("Ingrese el tipo de combustible: ");

            // Validamos el tipo de combustible usando switch
            string tipoCombustible = Console.ReadLine().ToLower();
            switch(tipoCombustible)
            {
                case "1":
                    tipoCombustible = "1";
                    break;
                case "2":
                tipoCombustible = "2";
                break;
            case "3":
                tipoCombustible = "3";
                break;
            default:
                Console.WriteLine("No es un tipo de combustible válido");
                break;
            }

            // Solicitamos la cantidad de litros a cargar en bloques de 5 litros usando while
            Console.WriteLine("Ingrese la cantidad de litros a cargar: ");
            int cantidadLitros = int.TryParse(Console.ReadLine(), out int resultado) ? resultado : 0;
            while (cantidadLitros > 0 && cantidadLitros <= 60)
            {
                // Calculamos el precio del combustible
                double precioCombustible = 0;
                switch (tipoCombustible)
                {
                    case "1":
                        precioCombustible = 28.5;
                        break;
                    case "2":
                        precioCombustible = 32;
                        break;
                    case "3":
                        precioCombustible = 26.75;
                        break;
                }
                // Calculamos el total de litros cargados con while
                int totalLitrosCargados = 0;
                while (cantidadLitros > 0)
                {
                    if (cantidadLitros >= 5)
                    {
                        totalLitrosCargados += 5;
                        cantidadLitros -= 5;
                    }
                    else
                    {
                        totalLitrosCargados += cantidadLitros;
                        cantidadLitros = 0;
                    }
                }
            
                // Calculamos el descuento
                double subtotal = totalLitrosCargados * precioCombustible;
                double descuento = subtotal * 0.05;
                if (descuento >= 1500)
                {
                    descuento = subtotal * 0.03;
                }
                else
                {
                    descuento = 0;
                }

                // Calculamos el subtotal
                Console.WriteLine($"Litros cargados: {totalLitrosCargados}");
                Console.WriteLine($"Precio del combustible: {precioCombustible}");
                Console.WriteLine($"Subtotal: {subtotal:F2}");
                Console.WriteLine($"Descuento: {descuento:F2}");
            }
        }
    }
}
