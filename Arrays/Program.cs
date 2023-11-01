using Microsoft.VisualBasic;

namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // CallingArr();
        LoopThroughArr();
        
    }

    static void CallingArr()
    {        
        var arr = new int[5];
        int[] arr2 = {};
        var arr3 = new int[2] {10, 11};
        arr[0] = 1; arr[1] = 2;

        foreach(var n in arr){
            System.Console.WriteLine(n);
        }

        for(var i = 0; i < arr3.Length;i++){
            System.Console.WriteLine(arr3[i]);
        }
    }

    static void LoopThroughArr()
    {
        // var arr = new int[3]{ 12, 2, 3};
        // System.Console.WriteLine(arr.Length);
        
        // for(var i = 0; i < arr.Length; i++){
        //     System.Console.WriteLine(arr[i]);
        // }
        // System.Console.WriteLine("----------");
        
        // foreach(var item in arr)
        // {
        //     if(item == arr.First()){
        //         System.Console.Write($"{{{item} ");
        //     }
        //     if(item == arr.Last()){
        //         System.Console.WriteLine(item+"}");
        //     }
        //     System.Console.Write(item+", ");
        // }
        var alunos = new Aluno[2];
        alunos[0].Name = "Matheus";
        alunos[0] = new Aluno() { Name="dodo" };
        // alunos[0].Name = "dodo2";
        alunos[1].Name = "Luiggi";
        alunos[1].Id=10;
        
        foreach(var item in alunos){
            System.Console.Write(item.Name +" ");
            System.Console.WriteLine(item.Id);
        }
    }

    public struct Aluno {
        public string? Name { get; set; }
        public int Id { get; set; }
    }
}