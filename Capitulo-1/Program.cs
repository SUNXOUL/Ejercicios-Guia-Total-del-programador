class Capitulo1
{
    public static void Main(string[] args)
    {
        //1
        string nombre = "Kevin Duran bruno";
        Console.WriteLine("\n"+nombre+"\n");
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //5
        string[] frases = new string[] 
        {
            "“No cuentes los días, haz que los días cuenten.” Muhammad Ali",
            "“El amor no tiene cura, pero es la cura para todos los males.” Leonard Cohen",
            "“El mejor momento del día es ahora.” Pierre Bonnard",
            "“Sé el cambio que quieres ver en el mundo.” Mahatma Gandhi",
            "“Piensa, sueña, cree y atrévete.” Walt Disney",
            "El sentido de la vida es tener valores, no cosas de valor.",
            "“Cree que puedes y casi lo habrás logrado.” Theodore Roosevelt",
            "“Vayas donde vayas, ve con todo tu corazón.” Confucio",
            "“La mejor forma de predecir el futuro es creándolo.” Abraham Lincoln",
            "“Solo imagina lo precioso que puede ser arriesgarse y que todo salga bien.” Mario Benedetti",
            "“El que tiene un porqué para vivir, puede soportar casi cualquier cómo.” Viktor Frankl",
            "“Si quieres cambiar el mundo, cámbiate a ti mismo.” Mahatma Ghandi",
            "“La vida no se trata de encontrarte a ti mismo, sino de crearte a ti mismo.” Bernard Shaw",
            "“Alguien se sienta en una sombra hoy porque alguien plantó un árbol hace mucho tiempo.” Warren Buffet"
            };

            foreach(string frase in frases)
            {
                Console.WriteLine(frase+"\n");

            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}

