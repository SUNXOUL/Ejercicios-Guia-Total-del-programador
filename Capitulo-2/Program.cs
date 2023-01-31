using System;
class Capitulo2
{
    public static int perimetro(int lados,int longitud)=>lados*longitud;
    public static double GradToRad(int rad)=>(rad*Math.PI)/180;
    public static double CelsToFahr(double Cels) => ((9/5)*Cels)+32;
    public static double ConvertirMoneda(double monto, double cambio) => monto*cambio; 


    public static void Ejercicio1()
    {
        Console.WriteLine("\nPERIMETRO DE UN POLIOGONO\n");
        Console.WriteLine("cantidad de lados:");
        int lados = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Longitud de los lados (m):");
        int longitud = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Perimetro :"+ perimetro(lados,longitud)+" m");
    }

    public static void Ejercicio2()
    {
        Console.WriteLine("\n  DE GRADOS A RADIANES \n");
        Console.WriteLine("cantidad de Grados:");
        int grad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Radianes : "+ Math.Round(GradToRad(grad),4)+"rad");
    }

    public static void Ejercicio3()
    {
        Console.WriteLine("\n  de celsius a fahrenheit \n");
        Console.WriteLine("cantidad de Grados Celcius:");
        double cels = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("grados fahrenheit : "+ Math.Round(CelsToFahr(cels))+" F");
    }

    public static void Ejercicio4()
    {
        string[] moneda = new string[]{"EUR","USD"};
        
        int seleccion;
        while(true){ 
            Console.WriteLine("INSERTE 1 PARA CONVERTIR DE DOLAR A EURO Y 2 PARA CONVETIR DE EURO A DOLAR");
            seleccion=Convert.ToInt32(Console.ReadLine());
            if(seleccion == 1 || seleccion == 2)
            {
                break;
            }
            Console. Clear();
            }
        Console.WriteLine("INGRESE EL CAMBIO DEL DIA");
        double cambio =Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("INGRESE MONTO A CAMBIAR");
        double monto =Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("SU CONVERSION SERIA :"+ConvertirMoneda(monto,cambio)+" "+moneda[seleccion-1]);
    }
    public static void Main(string[] args)
    {   
        Ejercicio4();
        

    }
}