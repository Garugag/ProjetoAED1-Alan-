using System;

  class MainClass
  {
      static void Main(string[] args)
      {
          string respuesta = "olá prof";
          string muda = "blz?";
          while (respuesta != "nada")
          {
              Console.WriteLine("O quer fazer? pra se exercitar digite a lista de exercicios que deseja usar 'a', 'b' ou 'c'. Para ver sua ficha digite 'ficha', pra mudar sua ficha digite 'mudar' e pra parar digite 'nada'");
              Listas m = new Listas();
              Ficha n = new Ficha();
              respuesta = Console.ReadLine();
              if (respuesta == "ficha")
              {
                  n.Dados();
              }
              if (respuesta == "a")
              {
                  m.Lista1();
              }
              if (respuesta == "b")
              {
                  m.Lista2();
              }
              if (respuesta == "c")
              {
                  m.Lista3();
              }
              if (respuesta == "mudar")
              {
                  Console.WriteLine("Qual dado deseja mudar? 'idade', 'peso' ou 'altura'");
                  muda = Console.ReadLine();
              }
              if (muda == "idade")
              {
                  n.FicarVelho();
              }
              if (muda == "peso")
              {
                  n.EngordarEmagrescer();
              }
              if (muda == "altura")
              {
                  n.Crescer();
              }
            }
          Console.ReadKey();
      }
  }