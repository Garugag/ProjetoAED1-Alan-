using System;
using System.Collections.Generic;
using System.Text;

  class Ficha
  {
      int idade = 18;
      int peso = 85;
      int altura = 190;
      string nome = "Alan";

      public void FicarVelho()
      {
          Console.WriteLine("Qual sua idade atual");
          int I;
          I = int.Parse(Console.ReadLine());
          if (idade < I)
          {
              idade = I;
          }
          Console.WriteLine(idade);
      }
      public void EngordarEmagrescer()
      {
          Console.WriteLine("Qual seu peso atual");
          int P;
          P = int.Parse(Console.ReadLine());
          if (peso != P)
          {
              peso = P;
          }
          Console.WriteLine(peso);
      }
      public void Crescer()
      {
          Console.WriteLine("Quanto cm cresceu?");
          int C;
          C = int.Parse(Console.ReadLine());
          altura = C + altura;
          Console.WriteLine(peso);
      }
      public void Dados()
      {
          Console.WriteLine("seus dados são:");
          Console.Write("Nome: ");
          Console.WriteLine(nome);
          Console.Write("Idade: ");
          Console.Write(idade);
					Console.WriteLine(" anos");
          Console.Write("Altura: ");
          Console.Write(altura);
					Console.WriteLine("cm");
          Console.Write("Peso: ");
          Console.Write(peso);
					Console.WriteLine("Kg");
      }
  }