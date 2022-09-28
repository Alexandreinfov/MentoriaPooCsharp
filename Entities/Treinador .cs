using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MENTORIAPOTTENCIAL.Entities
{
  public class Treinador : Jogador
  {
    public Treinador(string nome, int idade, string selecao) : base(nome, idade, selecao)
    {
      this.Nome = nome;
      this.Idade = idade;
      this.Selecao = selecao;
    }

    public override string ToString()
    {
      return "\nTécnico: " + Nome + "\n"
      + "Seleção: " + Selecao + "\n"
      + "Idade: " + Idade + "\n";
    }
  }
}