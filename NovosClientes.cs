using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<string> clientes = new List<string>();

        while (true)
        {
            string nome = Console.ReadLine();
            string email = Console.ReadLine();
            string telefone = Console.ReadLine();

            string clienteInfo = $"{nome}, {email}, {telefone}";
            clientes.Add(clienteInfo);

            string continuar = Console.ReadLine();

            if (continuar == "S")
            {
              continue;
            }
            else if (continuar ==  "N")
            {
              break;
            }
        
        }
        
         foreach(string dadosCliente in clientes){

          Console.WriteLine(dadosCliente);
            
        }
    }
}