using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        // FormatCurrency();
        RoundValues();
    }

    static void FormatCurrency()
    {
      //para formatar um valor, devemos passar um .ToString() no decimal/float
      //exemplos a seguir
      var valor = 10.25m;
      System.Console.WriteLine(
        valor.ToString("C", CultureInfo.CreateSpecificCulture("es-es")
        ));
      System.Console.WriteLine(
        valor.ToString("E04", CultureInfo.CreateSpecificCulture("es-es")
        ));
      System.Console.WriteLine(
        valor.ToString("G", CultureInfo.CreateSpecificCulture("es-es")
        ));
      System.Console.WriteLine(
        valor.ToString("F", CultureInfo.CreateSpecificCulture("es-es")
        ));
    }

    static void RoundValues()
    {
      var valor = 1034.227m;
      System.Console.WriteLine(valor);  
      System.Console.WriteLine(Math.Round(valor));  
      System.Console.WriteLine(Math.Floor(valor));  
      System.Console.WriteLine(Math.Ceiling(valor));  
    }
}