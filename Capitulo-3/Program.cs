class Capitulo3
{
    public static void Ejercicio1()
    {
        Console.WriteLine("\n  DETERMINAR PARIEDAD \n");
        Console.WriteLine("NUMERO A EVALUAR:");
        double numero = Convert.ToDouble(Console.ReadLine());
        string Pariedad = numero % 2 == 0 ? "Par" : "Impar";
        Console.WriteLine($"el numero {numero} es {Pariedad} ");
    }
    public static void Ejercicio4()
    {
        string[] dias = new string[]{"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};
        Console.WriteLine("\n  DIA DE LA SEMANA \n");
        Console.WriteLine("DIA(numero de orden 1-7):");
        int numero;
        while(true){
            numero= Convert.ToInt32(Console.ReadLine());
            if(numero <=7 && numero>=1){break;}
        }
        Console.WriteLine($"El dia seleccionado fue el {dias[numero-1]}");
    }

    public static void Main(string[] args)
    {
        Ejercicio4();
    }
}