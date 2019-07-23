using System;

namespace Exemplo_poo_matheus
{
    class Program
    {
        static void Main(string[] args)
        {
           var op = "";
           Aranha aranha = new Marrom(8,"Pequeno",8,2,300);; 
           Console.WriteLine("escolha o tipo da aranha 1 marrom 2 tarantula");
           var tipo = Console.ReadLine();

            if (tipo == "2")
            {
                aranha = new Tarantula(3,"grande",4,2,100);
            }

            while (op != "5")
            {   
                Console.Clear();
                Console.WriteLine("Escolha um comportamento para aranha ");
                Console.WriteLine("1 - Enjetar veneno ");
                Console.WriteLine("2 - Coçar ");
                Console.WriteLine("3 - Pular ");
                Console.WriteLine("4 - Nadar ");
                Console.WriteLine("5 - Morrer ");
                op = Console.ReadLine();
                
                if (op == "1"){
                    Console.Clear();
                    Console.WriteLine("Quanto tempo de mordida");
                    var tempo = Console.ReadLine();
                    aranha.InjetarVeneno(int.Parse(tempo));
                }
                
                if (op == "2"){
                    Console.Clear();
                    Console.WriteLine("Qual pata");
                    var pata = Console.ReadLine();
                    aranha.Cocar(int.Parse(pata));
                }

                if (op == "3")
                {
                    if (aranha is Tarantula)
                    {
                        Console.Clear();
                        Console.WriteLine("Quanta pressao para o pulo");
                        var tempo = Console.ReadLine();
                        Tarantula tarantula = (Tarantula) aranha;
                        tarantula.Pular(int.Parse(tempo));
                    } else {
                        Console.WriteLine("Aranha nao pode pular");
                    }
                }   

                if (op == "4")
                {                    
                    Console.Clear();
                    if (aranha is Marrom)
                    {
                        Console.WriteLine("O tempo de nado ");
                        var tempo = Console.ReadLine();
                        Marrom marrom = (Marrom) aranha;
                        marrom.Nadar(int.Parse(tempo));
                    }
                    else{
                        Console.WriteLine("aranha nao nada");
                    }

                }
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("A aranha morreu ela tinha");
            Console.WriteLine("Patas " + aranha.Patas);
            Console.WriteLine("Corpo " + aranha.Corpo);
            Console.WriteLine("Olhos " + aranha.Olhos);
            Console.WriteLine("Prezas " + aranha.Prezas);
            Console.WriteLine("Veneno " + aranha.Veneno);
            Console.ReadKey();
        }
    }
}
