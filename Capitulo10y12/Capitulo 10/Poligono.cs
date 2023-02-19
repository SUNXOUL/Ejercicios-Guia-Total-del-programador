public class Poligono
{
    public int Lados
    {
        set
        {
            if (value >= 1)
            {
                Lados = value;
            }
        }
        get
        {
            return Lados;
        }
    }

    public int LongitudA
    {
        get
        {
            return LongitudA;
        }
        set
        {
            if (value >= 1)
            {
                Lados = value;
            }
        }
    }
    public int LongitudB
    {
        get
        {
            return LongitudB;
        }
        set
        {
            if (value >= 1)
            {
                LongitudB = value;
            }
        }
    }

    public Poligono(int lados, int LongitudA)
    {
        this.Lados = lados;
        this.LongitudA = LongitudA;

    }
    public Poligono(int lados, int LongitudA, int LongitudB)
    {
        this.Lados = 4;
        this.LongitudA = LongitudA;
        this.LongitudB = LongitudB;

    }

    public override string ToString()
    {
        if (LongitudB !=0 )
        {
            return $" Lados : {this.Lados}  // Longitud : {this.LongitudA}";
        }
        else
        {
            return $" Lados : {this.Lados}  // Longitud : {this.LongitudA}  // Longitud 2 : {this.LongitudB}";
        }
    }
}