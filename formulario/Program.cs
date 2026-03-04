/*
preenchimento de formulário simples
dicionario com as informações organizadas
nome idade peso altura 
conseguir chamar a informação por nome
*/
using System;
using System.Collections.Generic;
using System.Threading;

internal class Program

{
    private static void Main()
    {   


        //cria o dicionario
        var usuarios = new Dictionary<string, string>();


        //Pedir e atribuir o nome ao dicionario
        Console.WriteLine("Insira seu nome: ");
        string nome = Console.ReadLine();
        usuarios.Add("Nome", nome);

        //idade
        Console.WriteLine("Insira sua idade: ");
        string idade = Console.ReadLine();
        usuarios.Add("Idade", idade);  

        //peso   
        Console.WriteLine("Insira seu peso: ");
        string peso = Console.ReadLine();
        usuarios.Add("Peso", peso); 

        //altura
        Console.WriteLine("Insira sua altura em cm: ");
        string altura = Console.ReadLine();
        usuarios.Add("Altura", altura);                      




        foreach (var i in usuarios)
        {
            Console.WriteLine($"{i.Key}: {i.Value}\n");
        }
    }
}