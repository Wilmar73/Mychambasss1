// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Usando los conocimientos adquiridos, usted debe desarrollar un programa que le solicite al usuario un numero y el programa indique si es par o impar.

Console.WriteLine("Ingrese un número para verificar si es par o impar:");
int numeroUsuario;
if (int.TryParse(Console.ReadLine(), out numeroUsuario))
{
    if (numeroUsuario % 2 == 0)
    {
        Console.WriteLine($"El número {numeroUsuario} es par.");
    }
    else
    {
        Console.WriteLine($"El número {numeroUsuario} es impar.");
    }
}
else
{
    Console.WriteLine("Por favor, ingrese un número válido.");
}
// Imprimir la fecha y hora del sistema
Console.WriteLine("Fecha y hora actual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
// Imprimir un mensaje de despedida
Console.WriteLine("¡Gracias por usar el programa! Hasta luego.");
// Fin del programa
// Este programa solicita un número al usuario y determina si es par o impar.
// También imprime la fecha y hora actual al final.

