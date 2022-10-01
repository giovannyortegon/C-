// See https://aka.ms/new-console-template for more information
using Extension ;

Console.WriteLine("********** Metodos **********");


Motos m1 = new Motos("Auteco","Cross");
m1.Arrancar(); 
Console.WriteLine("m1: " + m1.ToString());


class Motos {

    private string? name;
    private string? marca;

    public Motos() {}
    public Motos(string name, string marca) {
        this.name = name;
        this.marca = marca;
    }

    public void Arrancar(){
        Console.WriteLine("Arrancando...");
    }

    public override string ToString() {
        return $"Nombre: {this.name} Marca {this.marca} \n";
    }
}