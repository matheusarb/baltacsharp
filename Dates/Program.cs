using System;

namespace Dates;

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();

    // ObterDatas();
    FormatarData();
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

    var dataFormatada = String.Format("{0:y}", data);
    System.Console.WriteLine(dataFormatada);
  }

} 
