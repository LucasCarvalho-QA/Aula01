using System;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "";
            string senha = "";
            int idade = 0;

            Console.WriteLine("Insira o seu usuário");
            usuario = Console.ReadLine();

            Console.WriteLine("Insira a sua senha");
            senha = Console.ReadLine();

            if (usuario == "lucas@auditeste.com.br" || senha == "123456")
            {
                Console.WriteLine("Usuário autenticado");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretas");
            }
        }
    }
}
