
using System.Reflection.Metadata;
using System.Collections.Generic;
public struct Mascota
{
    public int MascotaID { get; set; }
    public string Nombre { get; set; }
    public string Raza { get; set; }
    public DateOnly FechaNacimiento { get; set;}
    public Propietario Propietario{get;set;} 


    
    public Mascota(int MascotaID, string Nombre, string Raza, DateOnly FechaNacimiento, int PropietarioID, string NombrePropietario,long cedula, string NumeroTelefonico )
    {
        this.MascotaID=MascotaID;
        this.Nombre=Nombre;
        this.Raza=Raza;
        this.FechaNacimiento=FechaNacimiento;
        Propietario = new Propietario(PropietarioID,NombrePropietario,cedula,NumeroTelefonico);
    }

}
    public struct Propietario
    {
        public int PropietarioID { get; set; }
        public string Nombre { get; set; }
        public long cedula{get;set;}
        public string NumeroTelefonico{get;set;}
        

        public Propietario (int PropietarioID, string Nombre,long cedula, string NumeroTelefonico)
        {
            this.PropietarioID= PropietarioID;
            this.Nombre=Nombre;
            this.cedula=cedula;
            this.NumeroTelefonico=NumeroTelefonico;
        }

    }