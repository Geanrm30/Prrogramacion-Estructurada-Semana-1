/*Desarrolle un programa que calcule la distancia total recorrida en kilómetros
 por un ciclista en el malecón de San Juan del Sur, utilizando como entradas la velocidad promedio
  en kilómetros por hora y el tiempo recorrido, ambos proporcionados por el usuario.
*/
Console.Write("Ingrese la velocidad promedio en km/h: ");
double velocidadCiclista = double.Parse(Console.ReadLine());

Console.Write("Ingrese el tiempo recorrido en horas: ");
double tiempoCiclista = double.Parse(Console.ReadLine());

double distancia = velocidadCiclista * tiempoCiclista;

Console.WriteLine($"La distancia total recorrida es {distancia} km.");
