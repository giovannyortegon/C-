/*
* Ejercicio 3
* 
* Operadores Determina los operadores para verificar las siguientes condiciones:
* Un número es mayor o igual a 18
* Un char es ‘a’
* Se cumplen dos conciones a la vez (ambas verdaderas)
* Se cumple una de dos condiciones a la vez (una true y otra false)
* 
* Nota: puedes escribir estos datos por consola si prefieres verlos.
* La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*
*/
Console.WriteLine("EJERCICIO #3\n");

// Declarando varibles
int num = 0;
char ch = ' ';

Console.Write("Ingrese un numero: ");
// Solicitando informacion al usuario
num = Convert.ToInt32(Console.ReadLine());
// Mostran respuesta del dato obtenido
Console.WriteLine("Respuesta: {0}", (num >= 18));

Console.Write("Ingrese caracter: ");
// Solicitando informacion al usuario
ch = Convert.ToChar(Console.ReadLine());
// Mostran respuesta del dato obtenido
Console.WriteLine("Respuesta: {0}", (ch == 'a'));
