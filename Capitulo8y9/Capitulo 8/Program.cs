class Program
{
    public static void Main(string[] args)
    {

        string s = String.Format("{0:hh t dddd / yyyy /  M}",DateTime.Now);
        Console.WriteLine(s);
    }
}