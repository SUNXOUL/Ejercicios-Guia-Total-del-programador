using System.Collections.Generic;
public class Inventario
{
    public List<Articulo> Almacen { get; private set; }
    
    public Inventario()
    {
        this.Almacen = new List<Articulo>();
    }
}