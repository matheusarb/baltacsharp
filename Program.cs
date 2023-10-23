using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace BaltaCSharp;

  class Program
  {
      public static void Main(string[] args)
      {
        var text = "testando";
        var text2 = "Testando";
        // System.Console.WriteLine(text.Contains(text2, StringComparison.OrdinalIgnoreCase));
        // Console.WriteLine(text.Equals(text2));

        // Console.WriteLine(texto.LastIndexOf("e"));
        // Console.WriteLine(texto.IndexOf("um"));
        // Console.WriteLine(texto.Insert(5, "AQUI"));
        // Console.WriteLine(texto.Length);
        // Console.WriteLine(texto.Replace("Este", "Isto"));
        // var divisao = texto.Split(",");
        // Console.WriteLine(divisao[0]);
        // Console.WriteLine(divisao[1]);
        
        var texto = new StringBuilder();
        texto.Append("Este texto é um teste ");
        texto.ToString();
        System.Console.WriteLine(texto);

        // var result = texto.Substring(5, texto.LastIndexOf("teste"));
        // System.Console.WriteLine(result);
        // var trim = texto.Trim();
        // Console.WriteLine(trim);

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