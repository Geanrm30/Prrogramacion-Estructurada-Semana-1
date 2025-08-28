int temperatura;
Console.Write("Escribe la temperatura actual: ");
temperatura = int.Parse(Console.ReadLine());
if (temperatura >= 25)
{
    Console.WriteLine("Hace calor");
}
else
{
    Console.WriteLine("No hace calor");
}