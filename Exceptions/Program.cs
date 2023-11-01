using System;
namespace Exceptions;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var arr = new int[2];

        try
        {
          // for(var i=0; i < 10; i++){
          //   System.Console.WriteLine(arr[i]);

          // }
          Salvar("");
        }
        catch(ArgumentNullException ex) 
        { 
          System.Console.WriteLine(ex.InnerException);
          System.Console.WriteLine($"Arg NV {ex.Message}");
        }
        catch(IndexOutOfRangeException ex){
          System.Console.WriteLine($"O erro 1: {ex.Message}");
        }
        catch(Exception ex){
          System.Console.WriteLine($"O erro 2: {ex.Message}");
        }
        finally{
          System.Console.WriteLine("Chegou ao fim");
        }
    }

    static void Salvar(string texto)
    {
      if(string.IsNullOrEmpty(texto))
      {
        //quando fora do catch, declarar o throw new
        throw new ArgumentNullException("Arg nulo ou vazio");
        throw new Exception("O texto não pode ser nulo ou vazio");
      }
    }
}