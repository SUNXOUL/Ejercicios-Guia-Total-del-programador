using System;
public class Estudiante
{
    public int Matricula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Celular { get; set; }
    public string Telefono {get;set;}
    public string Estado {get;set;}
    public string Direccion { get; set; }
    public DateOnly FechaIngreso { get; set; }
    
    public Estudiante(int matricula, string nombre, string Apellido, string Celular, string telefono, string Estado, string Direccion, DateOnly FechaIngreso )
    {
        this.Matricula=matricula;
        this.Nombre=nombre;
        this.Apellido=Apellido;
        this.Celular=Celular;
        this.Telefono=telefono;
        this.Estado=Estado;
        this.Direccion=Direccion;
        this.FechaIngreso=FechaIngreso;
    }
}