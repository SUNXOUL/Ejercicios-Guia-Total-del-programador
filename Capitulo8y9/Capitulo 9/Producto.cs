
using System.Collections.Immutable;
public struct Producto{
    public int ID {get;set;}
    public string Nombre{get;set;}
    public double Precio{get;set;}
    public int Cantidad{get;set;}

    public Producto(int ID, string Nombre, double Precio, int Cantidad)
    {
        this.ID=ID;
        this.Nombre=Nombre;
        this.Precio=Precio;
        this.Cantidad=Cantidad;
    }
    
}