/* Ejercicio 1 - IF

 * Escribe un programa que:
 * Pida datos a un cliente: Nombre, email, cupón
 * Determine si un cliente tiene un cupon descuento
 * Muestre un precio rebajado en función del descuento
 * Muestre el precio de un producto sin descuento si no hay cupón
 * 
 * Nota: puedes poner un precio fijo de un producto o uno variable.
 */

string line = new string('*', 30);
string [] cupones = {"cup-01", "cup-02"};                       // cupnes de descuento
string[] producto = {"Monitor", "Teclado", "Mouse", "Torre"};   // productos
int [] PrecioProducto = {600000, 50000, 45000, 500000};         // precio de productos


Console.WriteLine(line + " Ejercicio 01 - IF " + line);        // Titulo
Console.WriteLine("Cupones");                                  // Despliega lista de cupones
foreach (var item in cupones) {
    Console.WriteLine("Cupon: {0}", item);
}

// Menu - Solicita informacion al usuario
Console.Write("Ingrese nombre: ");
var name = Console.ReadLine();
Console.Write("Ingrese correo: ");
var mail = Console.ReadLine();
Console.WriteLine("Tienes cupon? S/N: ");
var cuponSN = Console.ReadLine();

// Si el usuario posee cupones aplica descuentos
if (cuponSN == "S" || cuponSN == "s") {
    Console.Write("Ingrese cupon: ");
    var cupon = Console.ReadLine();

    if (cupon == cupones[0]) {              // despliega producto y precios con descuento de 50%
        var descuento = 0.50;
        for (int i = 0; i < producto.Length; i++) {
            Console.Write("Producto: ");
            Console.Write(producto[i]);
            Console.WriteLine("  Precio: $ {0}",PrecioProducto[i]);
            Console.WriteLine("Precio con 50% de descuento: $ {0}",PrecioProducto[i]*descuento);
        }
    } else if( cupon == cupones[1]) {       // despliega productos y precios con descuentos de 25%
        var descuento = 0.25;
        for (int i = 0; i < producto.Length; i++) {
            Console.Write("Producto: ");
            Console.Write(producto[i]);
            Console.WriteLine("  Precio: $ {0}",PrecioProducto[i]);
            Console.WriteLine("Precio con 25% de descuento: $ {0}",PrecioProducto[i]*descuento);
        }
    }
} else {                                    // despliega productos y precios sin descuentos
    for (int i = 0; i < producto.Length; i++) {
        Console.Write("Producto: ");
        Console.Write(producto[i]);
        Console.WriteLine("  Precio:  {0}",PrecioProducto[i]);
    }
}
