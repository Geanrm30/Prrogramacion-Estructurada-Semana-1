//Repetir el ejercicio anterior usando switch con rangos aproximados.
int calificacion;
Console.WriteLine("Ingrese la calificación del estudiante (0-100):");
calificacion = int.Parse(Console.ReadLine());
switch (calificacion / 10) // Dividir por 10 para obtener el rango de decenas
{
    case 10: // 100
    case 9:  // 90-99
    case 8:  // 80-89
    case 7:  // 70-79
        Console.WriteLine("El estudiante Aprobó.");
        break;
    case 6:  // 60-69
    case 5:  // 50-59
        Console.WriteLine("El estudiante está en Recuperación.");
        break;
    default: // 0-49
        Console.WriteLine("El estudiante Reprobó.");
        break;
}