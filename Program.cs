
Console.WriteLine(@$"

 ---------------------------------
| * Programa de Menu de Bebidas * |
 ---------------------------------

");

Console.WriteLine(@$"

 ----------------
|   1.Coca Cola  |
|   2.Pepsi      |
|   3.Agua       |
|   4.Guarana    |
 ----------------

");

int opcao = int.Parse(Console.ReadLine());

char resposta;


switch (opcao)
{
    case 1:
        
        Console.WriteLine($"Gostaria de adicionar gelo ? s/n");

        
        resposta = char.Parse(Console.ReadLine().ToLower());

        if (resposta == 's')
        {
            Console.WriteLine($"Sua Coca cola será com adicional de gelo.");
        }
        else
        {
            Console.WriteLine($"Sua Coca cola será sem adicional de gelo.");
        }
        break;
    case 2:
        
        Console.WriteLine($"Gostaria de adicionar gelo ? s/n");

        
        resposta = char.Parse(Console.ReadLine().ToLower());

        
        if (resposta == 's')
        {
            Console.WriteLine($"Sua Pepsi será com adicional de gelo.");
        }
        else
        {
            Console.WriteLine($"Sua Pepsi será sem adicional de gelo.");
        }
        break;
    case 3:
        
        Console.WriteLine($"Gostaria de adicionar gelo ? s/n");

  
        resposta = char.Parse(Console.ReadLine().ToLower());


        if (resposta == 's')
        {
            Console.WriteLine($"Sua Agua será com adicional de gelo.");
        }
        else
        {
            Console.WriteLine($"Sua Agua será sem adicional de gelo.");
        }
        
        
        break;
    case 4:
        
        Console.WriteLine($"Gostaria de adicionar gelo ? s/n");

        
        resposta = char.Parse(Console.ReadLine().ToLower());

        
        if (resposta == 's')
        {
            Console.WriteLine($"Seu Guarana  será com adicional de gelo.");
        }
        else
        {
            Console.WriteLine($"Seu Guarana  será sem adicional de gelo.");
        }
        
        
        break;
    default:
        Console.WriteLine($"Opção inválida, digite uma opcao valida");
        break;
}