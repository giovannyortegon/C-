/*
* Ejercicio 2
*
* Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
* Coche: puertas, ruedas, marca, ITV vigente
* Mesa: peso, largo, material, color
*
* Nota: puedes escribir estos datos por consola si prefieres verlos.
* La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/
// Declarando variables
int puertas, ruedas; 
string marca, ITV;
char vigente;

// Titulo del Ejercicio
Console.WriteLine("EJERCICIO #2\n");

// Inicializando variables y mostrando el contenido.
Console.WriteLine("Coche: ");
marca = "Mazda";
Console.WriteLine("Marca: {0}", marca);
puertas = 4;
Console.WriteLine("Puertas: {0}", puertas);
ruedas = 4;
Console.WriteLine("Ruedas: {0}", ruedas);
ITV = "ZAD0364";
Console.WriteLine("ITV: {0}", ITV);
vigente = 'S';
Console.WriteLine("Vigente: {0}", vigente == 'S'? "SI" : "NO");
