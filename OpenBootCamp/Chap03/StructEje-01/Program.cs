// See https://aka.ms/new-console-template for more information


DatosCliente cliente1 = new DatosCliente("Giovanny Ortegon", 3243456745, "Calle 21 d # 234 - 45", "fsdfsd@htomail.com", false);
Console.WriteLine("Datos de Cliente: {0}", cliente1.ToString());

DatosCliente cliente2 = new DatosCliente("Paula Ortegon", 3223452345, "Calle 32 d # 24 - 08", "oaidfs@htomail.com", true);
Console.WriteLine("\nDatos de Cliente: {0}", cliente2.ToString());

public struct DatosCliente {
    public DatosCliente (string nom, uint tel, string dir, string mail, bool nuevo ){
        Nombre = nom;
        Telefono = tel;
        Direccion = dir;
        Email = mail;
        ClienteNuevo = nuevo;
    }

    public string Nombre {get;}
    public uint Telefono {get;}
    public string Direccion {get;}
    public string Email {get;}
    public bool ClienteNuevo {get;}

    public override string ToString() {
        string Estado = ClienteNuevo == true ? "Nuevo": "Antiguo";
        string Cliente = $"\nNombre: {Nombre}\nTelefono: {Telefono}\nDireccion: {Direccion}\nEmail: {Email}\nCliente: {Estado}"; 
        
        return Cliente;
    }
}