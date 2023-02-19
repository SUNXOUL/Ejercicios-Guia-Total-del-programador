public class Articulo
{
    public int ArticuloID{ get; set; }
    public string NombreArticulo { get; set; }
    public string Descripcion { get; set; }
    public int Precio{get;set;}
    public string Familia{get;set;}
    public string SubFamilia { get; set; }
    public string Marca{get;set;}

    public Articulo(int Id, string nombre, string descripcion,int Precio, string familia, string subfamilia, string marca)
    {
        this.ArticuloID=Id;
        this.NombreArticulo=nombre;
        this.Descripcion=descripcion;
        this.Precio=Precio;
        this.Familia=familia;
        this.SubFamilia=subfamilia;
        this.Marca=marca;
    }

}