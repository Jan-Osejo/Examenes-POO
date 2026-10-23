namespace ExamenU1.Examen1
{
    /*
    Ejercicio 3 — Control de asistencia a un taller · 11 puntos
Un taller de capacitación tiene 10 participantes. En el código, declare un arreglo de cadenas con los nombres de los
participantes y un arreglo de booleanos con su asistencia (true = asistió, false = faltó). Use datos precargados; no los solicite
al usuario.
El programa debe:
● Mostrar la lista de participantes con la leyenda «Asistió» o «Faltó», usando un ciclo for.
● Contar y mostrar cuántos asistieron y cuántos faltaron.
● Calcular y mostrar el porcentaje de asistencia.
● Mostrar los nombres de quienes faltaron usando un ciclo foreach.
● Solicitar un nombre y buscarlo con un ciclo for. Indicar si se encontró, la posición (empezando en 1) y si asistió. Si no se
encontró, mostrar un mensaje.
● Mostrar los nombres en orden inverso usando un ciclo for que recorra el arreglo desde el último índice hasta el primero.
Página 2 de 4
Requisitos:
● Valide que el nombre ingresado para la búsqueda no esté vacío.
● Usearreglos, for, foreach, condicionales y comparación de cadenas.
● Nouse LINQ ni métodos que oculten el recorrido manual del arreglo
    */
    public class Ejercicio03
    {
        public void ControlDeAsistencia()
        {
            string[] nombres = new string[] { "Juan", "Pedro", "Luis", "Marcos", "Carlos", "Daniel", "Fernando", "José", "Juan Carlos", "Manuel" };
            bool[] asistencia = new bool[] { true, false, true, false, true, false, true, false, true, false };
            int asistentes = 0;
            int faltantes = 0;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (asistencia[i])
                {
                    asistentes++;
                }
                else
                {
                    faltantes++;
                }
            }
            Console.WriteLine($"Asistentes: {asistentes}");
            Console.WriteLine($"Faltantes: {faltantes}");
            Console.WriteLine($"Porcentaje de asistencia: {(asistentes / (double)nombres.Length) * 100:F2}%");
            foreach (string nombre in nombres)
            {
                if (!asistencia[Array.IndexOf(nombres, nombre)])
                {
                    Console.WriteLine(nombre);
                }
            }
            while (true)
            {
                Console.WriteLine("Ingrese el nombre a buscar:");
                string nombre = Console.ReadLine();
                if (nombre == "")
                {
                    Console.WriteLine("El nombre no puede estar vacío");
                }
                else
                {
                    int posición = Array.IndexOf(nombres, nombre);
                    if (posición == -1)
                    {
                        Console.WriteLine("No se encontró");
                    }
                    else
                    {
                        Console.WriteLine($"Se encontró en la posición {posición + 1}");
                        asistencia[posición] = !asistencia[posición];
                        if (asistencia[posición])
                        {
                            asistentes++;
                        }
                        else
                        {
                            faltantes++;
                        }
                        Console.WriteLine($"Asistentes: {asistentes}");
                        Console.WriteLine($"Faltantes: {faltantes}");
                        Console.WriteLine($"Porcentaje de asistencia: {(asistentes / (double)nombres.Length) * 100:F2}%");
                    }
                }
            }  
        }
    }
}