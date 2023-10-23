using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace BaltaCSharp;

  class Program
  {
      public static void Main(string[] args)
      { 

        var text = "testando";
        var text2 = "Testando";
        System.Console.WriteLine(text.Contains(text2, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(text.Equals(text2));

        var texto = "Este texto é um teste";
        Console.WriteLine(texto.LastIndexOf("e"));
        Console.WriteLine(texto.IndexOf("um"));
        // var price = 10.2;
        // var price2 = 11.6;
        // var text = string.Format("O preço do produto é {0} apenas na promoção, ou {1}", price, price2);
        // var text2 = $"O preço do produto é {price}";
        // System.Console.WriteLine(text2);

        // var id = Guid.NewGuid();
        // System.Console.WriteLine(id);

        // var product = new Product();
        // product.Price = 29.99;
        // System.Console.WriteLine(product.Id);
        // System.Console.WriteLine(product.Name);
        // System.Console.WriteLine(product.Price);
      }
      
  }

  // struct Product{
  //   public Product(int id, string name, double price, EProductType type){
  //     Id = id;
  //     Name = name;
  //     Price = price;
  //     Type = type;
  //   }
  //   public int Id;
  //   public string Name = string.Empty;
  //   public double Price;

  //   public EProductType Type;
  //   public double PriceInDolar(double dolar)
  //   {
  //     return Price * dolar;
  //   }
  // }
  
  // enum EProductType
  // {
  //   Product = 1,
  //   Service = 2
  // } 