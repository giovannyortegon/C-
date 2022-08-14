/*
 * Ejercicio 1
 *
 * Variables Escribe un programa que reciba datos de una persona y genera un mensaje,
 * usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad,
 * sabe programar, etc.Get data through console with all data types.
 *
*/
Console.WriteLine("EJERCICIO #1\n");
// Declrando Variables
string? name=null, surname = null;
char? ch = 'S';
int edad = 0;


// Solicitando informacion al usuario para cada tipo de Variable
Console.WriteLine("Variables Ejercicio #1");

Console.WriteLine("Ingrese su nombre: ");
name = Console.ReadLine();

Console.WriteLine("Ingrese su apellido: ");
surname = Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");

edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabe Programar [S/N]: ");

ch = Convert.ToChar(Console.ReadLine());

// Imprimiendo informacion obtenida
Console.WriteLine("Hola, {0} {1}, de {2} anios", name, surname, edad);

Console.WriteLine("{0}", ch == 'S'? "Super! Sabes programar. Continua asi" : "Nunca es tarde. Aprovecha Open Bootcamp");
