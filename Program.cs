using Solucion.Clases;

Calculadora calculadora = new Calculadora();
Console.WriteLine("---------- Solucion ----------");
Console.WriteLine("Ingrese numero 1");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese numero 2");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");

Console.WriteLine("Ingrese una Opcion");
string operacion = Console.ReadLine();

if (operacion == "1")
{
    int resultado = calculadora.sumar(numero1, numero2);
    Console.WriteLine($"Su resulatdo es: {resultado}");
}

else if (operacion == "2")
{
    int resultado = calculadora.restar(numero1, numero2);
    Console.WriteLine($"Su resulatdo es: {resultado}");
}

else if (operacion == "3")
{
    int resultado = calculadora.multiplicar(numero1, numero2);
    Console.WriteLine($"Su resulatdo es: {resultado}");
}
else if (operacion == "4")
{
    if (numero2 == 0)
    {
        Console.WriteLine("No se puede dividir por cero");
    }
    else
    {
        int resultado = calculadora.dividir(numero1, numero2);
        Console.WriteLine($"Su resulatdo es: {resultado}");
    }}
else
{
    Console.WriteLine("Opcion no valida");
}