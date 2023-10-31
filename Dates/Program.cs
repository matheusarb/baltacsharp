using System;
using System.Globalization;

namespace Dates;

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();

    // ObterDatas();
    // FormatarData();
    // AdicionarValoresData();
    // CompararDatas();
    ModifyCulture();
  }

  private static void ObterDatas()
  {
    var data = new DateTime(2023, 10, 31, 10, 15, 02);
    // var dataHoje = DateTime.Now;
    System.Console.WriteLine(data.ToString());
    System.Console.WriteLine(data.DayOfWeek);
    System.Console.WriteLine((int)data.DayOfYear);
    // System.Console.WriteLine(data);
    // System.Console.WriteLine(data);
    // System.Console.WriteLine(data);
  }

  private static void FormatarData()
  {
    var data = DateTime.Now;

    var dataFormatada = String.Format("{0:D}", data);
    var dataFormatada1 = String.Format("{0:dd/MM/yy ff z}", data);
    var dataFormatada2 = String.Format("{0:r}", data);
    var dataFormatada3 = String.Format("{0:s}", data); //padrão para JSON pra enviar pro frontend
    var dataFormatada4 = String.Format("{0:u}", data); //padrão usado em NOSql MongoDB
    System.Console.WriteLine(dataFormatada2);
  }

  private static void AdicionarValoresData()
  {
    var data = DateTime.Now;

    System.Console.WriteLine(data.AddDays(10));
    System.Console.WriteLine(data.AddMonths(2));
    System.Console.WriteLine(data.AddHours(3));
  }

  private static void CompararDatas()
  {
    var data = DateTime.Now;

    if(data.Date == DateTime.Now.Date)
      System.Console.WriteLine($"é igual - {data.Date.ToShortDateString()}");

    // System.Console.WriteLine(data.Date);
  }

  private static void ModifyCulture()
  {
    var pt = new CultureInfo("pt-BR");
    var en = new CultureInfo("en-US");
    var atual = CultureInfo.CurrentCulture;
    var data = DateTime.Now;

    System.Console.WriteLine(data.Date.ToString("D", en));
  }
} 