using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MENTORIAPOTTENCIAL.Entities
{
  public class Jogador
  {
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Selecao { get; set; }
    public string Posicao { get; set; }

    public string Sexo { get; set; }

    public Jogador(string nome, int idade, string selecao, string posicao)
    {
      this.Nome = nome;
      this.Idade = idade;
      this.Selecao = selecao;
      this.Posicao = posicao;
      Sexo = "masculino";

    }
    public Jogador(string nome, int idade, string selecao)
    {
      this.Nome = nome;
      this.Idade = idade;
      this.Selecao = selecao;


    }

    public override string ToString()
    {
      return "\nJogador: " + Nome + "\n"
      + "Seleção: " + Selecao + "\n"
      + "Idade: " + Idade + "\n"
      + "Posição: " + Posicao + "\n"
      + "Sexo: " + Sexo;
    }

  }
}