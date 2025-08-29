// Pedir al usuario un numero y mostrar su tabal de multiplar del 1 al 10
// usando un bucle for

Console.Write("Ingrese un número: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Tabla de multiplicar del {numero}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}