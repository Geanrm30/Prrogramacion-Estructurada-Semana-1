//Crear un programa que determine si un año es bisiesto usando if y operadores lógicos.
int año;
Console.WriteLine("Ingrese un año:");
año = int.Parse(Console.ReadLine());

if (año % 400 == 0)
{
    Console.WriteLine($"{año} es un año bisiesto.");
}
else if (año % 100 == 0)
{
    Console.WriteLine($"{año} no es un año bisiesto.");
}
else if (año % 4 == 0)
{
    Console.WriteLine($"{año} es un año bisiesto.");
}
else
{
    Console.WriteLine($"{año} no es un año bisiesto.");
}