/*Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus desde Managua a Granada, 
donde el usuario ingresa la velocidad promedio en kilómetros por hora como entrada, 
asumiendo una distancia fija de 40 kilómetros.
*/

Console.Write("Ingrese la velocidad promedio del bus en km/h: ");
double velocidad = double.Parse(Console.ReadLine());

double distancia = 40; // km
double tiempo = distancia / velocidad;

Console.WriteLine($"El tiempo total de viaje es {tiempo} horas.");
