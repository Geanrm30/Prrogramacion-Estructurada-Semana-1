/*Desarrolle un programa que calcule la cantidad total de baldes de leche producida 
en un día en una lechería de Estelí, utilizando como entradas el volumen promedio por vaca 
en litros y el número total de vacas ordeñadas, ambos proporcionados por el usuario (1 balde = 20 litros).
*/
Console.Write("Ingrese el volumen promedio de leche por vaca (litros): ");
double litrosPorVaca = double.Parse(Console.ReadLine());

Console.Write("Ingrese el número de vacas ordeñadas: ");
int vacas = int.Parse(Console.ReadLine());

double litrosTotales = litrosPorVaca * vacas;
double baldes = litrosTotales / 20;

Console.WriteLine($"La producción total es de {baldes} baldes de leche.");
