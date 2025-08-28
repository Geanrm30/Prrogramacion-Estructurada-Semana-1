/*Desarrolle un programa que calcule el volumen total en metros cúbicos de agua recolectada 
en un tanque en una finca de Masaya, utilizando como entradas la longitud, el ancho y la altura del tanque, 
todos proporcionados por el usuario.
*/
Console.Write("Ingrese la longitud del tanque en metros: ");
double longitudTanque = double.Parse(Console.ReadLine());

Console.Write("Ingrese el ancho del tanque en metros: ");
double anchoTanque = double.Parse(Console.ReadLine());

Console.Write("Ingrese la altura del tanque en metros: ");
double alturaTanque = double.Parse(Console.ReadLine());

double volumen = longitudTanque * anchoTanque * alturaTanque;

Console.WriteLine($"El volumen total de agua es {volumen} m³.");
