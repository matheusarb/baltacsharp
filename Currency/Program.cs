using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        FormatCurrency();
        
    }

    static void FormatCurrency()
    {
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
}