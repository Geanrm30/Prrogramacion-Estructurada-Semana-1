//Evaluar la calificación de un estudiante y mostrar si aprobó (≥70), recuperación (50–69) o reprobó (<50) con if.
int calificacion;
Console.WriteLine("Ingrese la calificación del estudiante (0-100):");
calificacion = int.Parse(Console.ReadLine());
if (calificacion >= 70)
{
Console.WriteLine("El estudiante Aprobó.");
}
else if (calificacion >= 50)
{
 Console.WriteLine("El estudiante está en Recuperación.");
}
else
{
Console.WriteLine("El estudiante Reprobó.");
}
