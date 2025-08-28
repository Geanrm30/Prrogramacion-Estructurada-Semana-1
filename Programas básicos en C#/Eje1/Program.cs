//Desarrolle un programa que calcule el área total en manzanas de un terreno rectangular 
//en una finca nicaragüense, donde el usuario ingresa la longitud y el ancho en varas 
//(1 manzana = 1,428.8 varas²), utilizando una cantidad fija de 5 varas de ancho y la longitud como entrada.
int longitud;
int ancho = 5; // Ancho fijo en varas
double areaManzanas;
Console.WriteLine("Ingrese la longitud del terreno en varas:");
longitud = int.Parse(Console.ReadLine());
areaManzanas = (longitud * ancho) / 1428.8; // Convertir varas² a manzanas
Console.WriteLine($"El área total del terreno es de {areaManzanas} manzanas.");
