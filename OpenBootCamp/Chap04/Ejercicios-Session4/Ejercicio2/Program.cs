// See https://aka.ms/new-console-template for more information
Console.WriteLine("*********** Ejercicio 2 **********");
Console.WriteLine("Determine si el numero es positivo o negativo.");
Console.WriteLine("Ingrese numero: (0 para salir del programa.)");

long num;
int cont_pos, cont_neg;

num = cont_pos = cont_neg = 0;

do {
    var input = Console.ReadLine();
    num = Convert.ToInt64(input);

    if (num < 0) {
        Console.WriteLine("El numero es Negativo.");
        cont_neg++;
    } else if (num > 0) {
        Console.WriteLine("El numero es Positivo");
        cont_pos++;
    }

} while (num != 0);

Console.WriteLine("Numeros positivos: {0}", cont_pos);
Console.WriteLine("Numeros negativos: {0}", cont_neg);