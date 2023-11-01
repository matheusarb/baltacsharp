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
    // ModifyCulture();
    // UsingTimezone();
    // UsingTimespan();

    var date = DateTime.Now.AddDays(4);
    System.Console.WriteLine(IsWeekend(date.DayOfWeek));
    System.Console.WriteLine(date.DayOfWeek);
    System.Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
  }

  static bool IsWeekend(DayOfWeek today)
  {
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
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

  private static void UsingTimezone()
  {
    // var utcDate = DateTime.UtcNow;
    // var localDate = DateTime.Now;

    // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

    // // System.Console.WriteLine(localDate);
    // // System.Console.WriteLine(utcDate.ToLocalTime());
    // System.Console.WriteLine(utcDate);
    // System.Console.WriteLine(timezoneAustralia);

    // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
    // System.Console.WriteLine(horaAustralia);

    var typeTimezones = TimeZoneInfo.GetSystemTimeZones().GetType();
    var props = typeTimezones.GetProperties();
    
    // foreach(var prop in props){
    //   System.Console.WriteLine(prop.Name);
    //   System.Console.WriteLine("-------");
    // }
    System.Console.WriteLine(props);

    foreach(var item in props)
    {
      System.Console.WriteLine(item);
      // if (timezone.Name.Contains("Salvador"))
      // {
      //   System.Console.WriteLine(timezone);
      // }

      // System.Console.WriteLine(timezone);
      // System.Console.WriteLine("--------");
    }
  }

  private static void UsingTimespan()
  {
    // var today = DateTime.Now;
    var timeSpan = new TimeSpan(13, 06, 00);
    
    System.Console.WriteLine(timeSpan.Hours);
    System.Console.WriteLine();
  }
} 