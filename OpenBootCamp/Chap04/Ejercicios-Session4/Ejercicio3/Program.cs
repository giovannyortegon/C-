
Console.WriteLine("********** Ejercicio 3 ***********\n\n");
int alto, ancho, rep;
bool relleno = false;

while (true)
{

    Console.WriteLine("\n\tVamos a dibujar un cuadro\n");
    Console.Write("Ingrese el <alto>,<ancho>,<numero de repeticiones>: ");
    string? input = Console.ReadLine();
    string[] sub = input.Split(',', ' ');
    if (sub.Length != 3)
    {
        Console.WriteLine("[!] Error: ingrese 3 Valores. <alto> <ancho> <repeticiones>\n\n\tEj: 2,3,4 ó 1 2 3\n");
        continue;
    }
    alto = Convert.ToInt32(sub[0]);
    ancho = Convert.ToInt32(sub[1]);

    if (alto == 0 || alto == 1)
        alto = ancho;
    else if (ancho == 0 || alto == 1)
        ancho = alto;

    if (alto == 0 && ancho == 0 || alto == 1 && ancho == 1)
    {
        Console.WriteLine("<alto> y <ancho> deben ser mayor a 0 y 1.");
        break;
    }

    rep = Convert.ToInt32(sub[2]);
    if (rep == 0)
        rep = 1;
    Console.WriteLine("relleno: S/N");
    input = Console.ReadLine();
    if (input == "S" || input == "s")
    {
        relleno = true;
    }
    else if (input == "N" || input == "n")
        relleno = false;
    else
    {
        Console.WriteLine("Entrada no valida");
        continue;
    }
    Console.WriteLine("\n");

    for (int i = 1; i <= alto; i++)
    {
        for (int r = 1; r <= rep; r++)
        {
            for (int j = 1; j <= ancho; j++)
            {
                if (!relleno)
                {
                    if (i != 1 && i != alto && j != 1 && j != ancho)
                        Console.Write("   ");
                    else Console.Write(" * ");
                }
                else
                {
                    Console.Write(" * ");
                }
                if (j == ancho)
                    Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
    Console.Write("\n\nDesea continuar?\nPara continuar 'Enter' o para Salir presionq 'q' ó 'Q': ");
    input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        Console.WriteLine("\nHasta la proxima!!");
        break;
    }

}
