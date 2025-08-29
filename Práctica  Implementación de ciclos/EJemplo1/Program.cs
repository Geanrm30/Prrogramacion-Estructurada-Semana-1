string entrada = string.Empty;
bool entradaValida = false;

while (!entradaValida)
{
    Console.Write("Introduce un número entero positivo: ");
    entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int numero) && numero > 0)
    {
        entradaValida = true;
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, inténtalo de nuevo.");
    }
}
Console.WriteLine($"Has introducido el número: {entrada}");