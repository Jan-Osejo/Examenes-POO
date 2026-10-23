namespace ExamenU1.Examen1
{
    /*

    Ejercicio 4 — Fila de atención de una clínica · 13 puntos
Una clínica atiende pacientes por orden de llegada, pero primero atiende los casos urgentes. Implemente un programa con
dos listas: una para pacientes urgentes y otra para pacientes normales. El programa debe mostrar un menú que se repita
hasta que el usuario elija salir.
Opciones del menú:
● Registrar paciente: solicite el nombre y la prioridad (1 = urgente, 2 = normal). Valide que el nombre no esté vacío y que no
exista en ninguna de las dos listas. Agregue el paciente al final de la lista correspondiente.
● Atender siguiente: si hay pacientes urgentes, atienda al primero de esa lista; si no, atienda al primero de la lista normal.
Muestre el nombre atendido y la prioridad. Si no hay pacientes, muestre un mensaje.
● Mostrarfila: muestre los pacientes urgentes numerados, luego los normales numerados y el total de pacientes en espera.
● Buscar paciente: solicite un nombre e indique si está en la fila urgente o normal, su posición (empezando en 1) y cuántos
pacientes hay delante.
● Mostrarcantidad: indique cuántos pacientes urgentes, cuántos normales y cuántos hay en total.
● Salir.
Requisitos:
● Use List<string> para las dos filas, un ciclo while para el menú y switch para las opciones.
● Use los métodosAdd, RemoveAt(0), Contains, IndexOf y la propiedad Count.
● Valide la opción del menú y todos los datos ingresados.

    */
    public class Ejercicio04
    {
        public void FilaDeAtencionDeUnaClinica()
        {
            List<string> urgentes = new List<string>();
            List<string> normales = new List<string>();
            while (true)
            {
                // Mostramos el menú con while requerido
                Console.WriteLine("Ingrese la opción:");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Atender siguiente");
                Console.WriteLine("3. Mostrar fila");
                Console.WriteLine("4. Buscar paciente");
                Console.WriteLine("5. Mostrar cantidad");
                Console.WriteLine("6. Salir");
                string opción = Console.ReadLine();

                // Validamos las opciones con switch requerido
                switch (opción)
                {
                    // Registramos un paciente
                    case "1":
                        Console.WriteLine("Ingrese el nombre del paciente:");
                        string nombre = Console.ReadLine();
                        if (nombre == "" || nombre == null)
                        {
                            Console.WriteLine("El nombre no puede estar vacío");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese la prioridad (1 = urgente, 2 = normal):");
                            int prioridad = int.TryParse(Console.ReadLine(), out int resultado) ? resultado : 0;
                            if (prioridad == 1)
                            {
                                urgentes.Add(nombre);
                            }
                            else
                            {
                                normales.Add(nombre);
                            }
                        }
                        break;
                        // Atiende al siguiente paciente
                    case "2":
                        if (urgentes.Count > 0)
                        {
                            Console.WriteLine($"Atiende al paciente {urgentes[0]}");
                            urgentes.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("No hay pacientes urgentes");
                        }
                        break;

                        // Muestra la fila
                    case "3":
                        Console.WriteLine("Nombre\tPrioridad");
                        foreach (string paciente in urgentes)
                        {
                            Console.WriteLine($"{paciente}\t1");
                        }
                        foreach (string paciente in normales)
                        {
                            Console.WriteLine($"{paciente}\t2");
                        }
                        Console.WriteLine($"Total de pacientes: {urgentes.Count + normales.Count}");
                        break;

                        // Buscamos un paciente
                    case "4":
                        string nombrePaciente = "";
                        Console.WriteLine("Ingrese el nombre del paciente (o presione enter para salir):");
                        nombrePaciente = Console.ReadLine();
                        if (nombrePaciente == "" || nombrePaciente == null)
                        {
                            break;
                        }
                        else
                        {
                            if (urgentes.Contains(nombrePaciente))
                            {
                                Console.WriteLine($"El paciente {nombrePaciente} está en la fila urgente");
                            }
                            else
                            {
                                Console.WriteLine($"El paciente {nombrePaciente} está en la fila normal");
                            }
                            Console.WriteLine($"Posición: {urgentes.IndexOf(nombrePaciente) + 1}");
                            Console.WriteLine($"Cantidad de pacientes: {urgentes.Count + normales.Count}");
                        }
                        break;

                        // Mostramos la cantidad de pacientes
                    case "5":
                        Console.WriteLine($"Cantidad de pacientes urgentes: {urgentes.Count}");
                        Console.WriteLine($"Cantidad de pacientes normales: {normales.Count}");
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