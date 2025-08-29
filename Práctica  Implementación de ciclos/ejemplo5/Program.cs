int numero;

Console.WriteLine("Ingrese un numer(o entero positivo: ");
numero = int.Parse(Console.ReadLine());

int factorial = 1;
for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}
Console.WriteLine($"El factorial de numero {numero} es: {factorial}");
