//Determinar si un número ingresado es positivo, negativo o cero usando if.
int numero;
Console.WriteLine("Ingrese un número:");
numero = int.Parse(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine("El número es positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("El número es negativo.");
}
else
{
    Console.WriteLine("El número es cero.");
}
