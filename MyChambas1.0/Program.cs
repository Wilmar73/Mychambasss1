// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//1.Declarar variable de los diferentes tipos, asignarles valor e imprimir el valor. /
decimal precio = 19.99m;
int cantidad = 5;
float descuento = 0.15f;
string producto = "Camiseta";
bool estaDisponible = true;

//inprimir los valores de las variables
Console.WriteLine("Valor del precio" + precio);
Console.WriteLine("Valor de la cantidad: " + cantidad);
Console.WriteLine("Valor del descuento: " + descuento);
Console.WriteLine("Valor del producto: " + producto);
Console.WriteLine("¿Está disponible? " + estaDisponible);


//2.Buscar cómo se declara una constante en C# e imprimir el valor. Probar de cambiar su valor luego y ver que es lo que pasa.

const double PI = 3.14159; // Declaración de una constante  
Console.WriteLine("Valor de PI: " + PI);
// Imprimir el valor de la constante PI


// Intentar cambiar el valor de la constante (esto generará un error de compilación)
// PI = 3.14; // Descomentar esta línea generará un error de compilación porque PI es una constante
// Console.WriteLine("Nuevo valor de PI: " + PI); // Esto no se ejecutará porque la línea anterior generará un error

//3.Declara un entero, incrementarlo, decrementarlo, hacer operaciones con el. 
int numero = 10; // Declaración de un entero
Console.WriteLine("Valor inicial del número: " + numero);
// Incrementar el número
numero++; // Incrementar el número en 1
Console.WriteLine("Valor después de incrementar: " + numero);
// Decrementar el número
numero--; // Decrementar el número en 1
Console.WriteLine("Valor después de decrementar: " + numero);
// Realizar operaciones con el número
int otroNumero = 5; // Otro entero para realizar operaciones
int suma = numero + otroNumero; // Sumar
int resta = numero - otroNumero; // Restar
int multiplicacion = numero * otroNumero; // Multiplicar
int division = numero / otroNumero; // Dividir
Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicación: " + multiplicacion);
Console.WriteLine("División: " + division);


//Declarar un float con valor=10152466.25. Declara un byte que es igual a 5 + el float. 
float valorFloat = 10152466.25f; // Declaración de un float
byte valorByte = (byte)(5 + valorFloat); // Declaración de un byte que es igual a 5 + el float
Console.WriteLine("Valor del float: " + valorFloat);
Console.WriteLine("Valor del byte: " + valorByte); // Imprimir el valor del byte




//Adjuntar comentario de una y de varias líneas un su código.  Imprimir la fecha y hora del sistema. 

/*const double PI = 3.14159; // Declaración de una constante  
Console.WriteLine("Valor de PI: " + PI);
// Imprimir el valor de la constante PI..

//inprimir los valores de las variables
Console.WriteLine("Valor del precio" + precio);
Console.WriteLine("Valor de la cantidad: " + cantidad);
Console.WriteLine("Valor del descuento: " + descuento);
Console.WriteLine("Valor del producto: " + producto);
Console.WriteLine("¿Está disponible? " + estaDisponible);

*/


Console.WriteLine("Fecha y hora del sistema: " + DateTime.Now); // Imprimir la fecha y hora del sistema








