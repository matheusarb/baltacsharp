using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace BaltaCSharp;

  class Program
  {
      public static void Main(string[] args)
      {        
        var id = Guid.NewGuid();
        System.Console.WriteLine(id);
        // var product = new Product();
        // product.Price = 29.99;
        // System.Console.WriteLine(product.Id);
        // System.Console.WriteLine(product.Name);
        // System.Console.WriteLine(product.Price);
      }
      
  }

  struct Product{
    public Product(int id, string name, double price, EProductType type){
      Id = id;
      Name = name;
      Price = price;
      Type = type;
    }
    public int Id;
    public string Name = string.Empty;
    public double Price;

    public EProductType Type;
    public double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }
  }
  
  enum EProductType
  {
    Product = 1,
    Service = 2
  } 