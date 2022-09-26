/* Ejercicio 02 - Switch
 *
 * Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++.
 * Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. 
 * Presenta el resultado en consola.
 *
 * Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
 */
string line = new string('*', 30);
bool salir = true;
string[] lenguajes = {"C#", "Java", "C++", "Salir"};                // Lista de lenguajes
Console.WriteLine("{0} Ejercicio 02 - Switch {1}", line, line);     // Titulo

// Depliega Menu de seleccion de Lenguaje
while (salir) {
    Console.WriteLine("***** MENU *****");
    for(int i = 0; i < lenguajes.Length; i++) {
        Console.WriteLine("{0}. {1}", i +1, lenguajes[i]);
    }
    Console.Write("Ingrese numero: ");
    var input = Console.ReadLine();
    int select = Convert.ToInt32(input);

// seleccion de lenguaje con SWITCH
    switch (select)
    {
        case 1:
            Console.WriteLine("\nLenguaje {0}\n",lenguajes[0]);
            break;
        case 2:
            Console.WriteLine("\nLenguaje {0}\n",lenguajes[1]);
            break;
        case 3:
            Console.WriteLine("\nLenguaje {0}\n",lenguajes[2]);
            break;
        case 4:
            Console.WriteLine("\n[-] Hasta la proxima!!\n");
            salir = false;
            break;
        default:
            Console.WriteLine("\n[x] Error! Opcion NO valida.\n");
            break;
    }
}