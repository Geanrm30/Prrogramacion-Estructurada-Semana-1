// Calcular la suma de todos los numeros pares entre 1 y N usando while

Console.Write("Ingrese un número limite: ");
int limite = Convert.ToInt32(Console.ReadLine());

int suma = 0;
int contador = 2;

while (contador <= limite)
{
    suma += contador;
    contador += 2;
}
Console.WriteLine($"La suma de los números pares entre 1 y {limite} es: {suma}");