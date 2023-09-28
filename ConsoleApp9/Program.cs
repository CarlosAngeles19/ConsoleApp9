using System;

class Program
{
    static void Main()
    {
        int maximoAsistentes = 0;
        int asistentesActuales = 0;
        int vecesLleno = 0;
        int vecesVacio = 0;
        int totalAsistieron = 0;
        int totalSalieron = 0;

        Console.WriteLine("Ingrese un número máximo de personas: ");
        if (int.TryParse(Console.ReadLine(), out maximoAsistentes) && maximoAsistentes > 0)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"El número máximo establecido es de {maximoAsistentes} personas, presione una tecla para comenzar a contar.");
            Console.ReadKey(); // Esperar a que el usuario presione una tecla para comenzar

            do
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine($"| Asistentes actuales | {asistentesActuales}");
                Console.WriteLine($"| Aforo               | {asistentesActuales * 100 / maximoAsistentes}%");
                Console.WriteLine($"| Máximo              | {maximoAsistentes} personas");
                Console.WriteLine("=====================================");
                Console.WriteLine("Presione ");
                Console.WriteLine("[i] si ingresa una persona");
                Console.WriteLine("[s] si sale una persona");
                Console.WriteLine("[x] para terminar");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                string opcion = keyInfo.Key.ToString().ToLower(); // Obtener la tecla presionada en minúsculas

                if (opcion == "i")
                {
                    if (asistentesActuales < maximoAsistentes)
                    {
                        asistentesActuales++;
                        totalAsistieron++;

                        if (asistentesActuales == maximoAsistentes)
                        {
                            vecesLleno++; // Incrementar cuando el local está lleno
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nEl local está lleno. No se puede ingresar más personas.");
                    }
                }
                else if (opcion == "s")
                {
                    if (asistentesActuales > 0)
                    {
                        asistentesActuales--;
                        totalSalieron++;

                        if (asistentesActuales == 0)
                        {
                            vecesVacio++; // Incrementar cuando el local está vacío
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nEl local ya está vacío. No se puede sacar más personas.");
                    }
                }
                else if (opcion == "x")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("\nOpción no válida. Presione [i], [s] o [x].");
                }

                Console.Clear();
            } while (true);

            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("=================================");
            Console.WriteLine("Estadísticas:");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{totalAsistieron} personas ingresaron");
            Console.WriteLine($"{totalSalieron} personas salieron");
            Console.WriteLine($"{vecesLleno} veces se llenó el local");
            Console.WriteLine($"{vecesVacio} veces estuvo vacío el local");
        }
        else
        {
            Console.WriteLine("El número máximo debe ser mayor que cero.");
        }

        Console.ReadKey();
    }
}
