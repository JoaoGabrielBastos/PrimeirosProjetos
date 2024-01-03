internal class Program
{
    private static void Main(string[] args)
    {
       Menu();
    }
    static void Soma()
       {
        
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor; ");
        float v2 = float.Parse(Console.ReadLine());
        float soma = v1 + v2;
        Console.WriteLine("Total da soma = " + soma);
        Console.ReadKey();
        Menu();

       }
       static void Subtracao() 
       {

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor; ");
        float v2 = float.Parse(Console.ReadLine());
        float Subtracao = v1 - v2;
        Console.WriteLine("Total da soma = " + Subtracao);

        Console.ReadKey();
        Menu();
       }
       static void Multiplicacao()
       {
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor; ");
        float v2 = float.Parse(Console.ReadLine());
        float Multiplicacao = v1 * v2;
        Console.WriteLine("Total da soma = " + Multiplicacao);

        Console.ReadKey();
        Menu();

       }
       static void Divisao()
       {
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor; ");
        float v2 = float.Parse(Console.ReadLine());
        float divisao = v1 / v2;
        Console.WriteLine("Total da soma = " + divisao);

        Console.ReadKey();
        Menu();

       }
       static void Menu()
       {

        Console.Clear();
       
        Console.WriteLine("Escolha uma das opções:");
        Console.WriteLine("---------------------------");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao"); 
        Console.WriteLine("3 - Multiplicacao"); 
        Console.WriteLine("4 - Divisao"); 
        Console.WriteLine("5 - Sair");
        Console.ReadKey();
        var opcao = Console.ReadLine();
        switch(opcao)
      {
      case"1": Soma(); break;
      case"2": Subtracao(); break;
      case"3": Multiplicacao(); break;
      case"4": Divisao(); break;
      case"5": System.Environment.Exit(0); break;
      default: Menu(); break;

       }

       }

    }
    

    
    

