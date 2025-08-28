int calificacion;
Console.Write("Escribe tu calificación: ");
calificacion = int.Parse(Console.ReadLine());
if (calificacion >= 90)
{
    Console.WriteLine("Excelente");
}
else if (calificacion >= 80)
{
    Console.WriteLine("Muy bien");
}
else if (calificacion >= 70)
{
    Console.WriteLine("Bien");
}
else if (calificacion >= 60)
{
    Console.WriteLine("Necesita mejorar");
}
else
{
    Console.WriteLine("Insuficiente");
}