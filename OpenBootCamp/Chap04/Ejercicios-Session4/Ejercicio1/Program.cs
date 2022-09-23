// See https://aka.ms/new-console-template for more information
Console.WriteLine("************** Ejercicio 1 **************");
int mul, mdr, prod;

Console.WriteLine("Tabla de Multiplicar");
Console.WriteLine("Escriba un numero entero: ");

var input = Console.ReadLine();
mul = Convert.ToInt32(input);

mdr = 1;
while (mdr <= 10) {
    prod = mul * mdr;
    Console.WriteLine("{0} x {1} = {2}", mul, mdr, prod);
    mdr++;
}
