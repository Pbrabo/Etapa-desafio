using System;
using Etapa_Desafio.src.Interfaces;

namespace Etapa_Desafio.src.Entities
{
    public class VideoGames : Produtos, Imposto
    {
            public VideoGames(string Nome, double Preco, int Qtd, string Marca, string Modelo, bool IsUsado){
                this.Nome = Nome;
                this.Preco = Preco;
                this.Qtd = Qtd;
                this.Marca = Marca;
                this.Modelo = Modelo;
                this.IsUsado = IsUsado;

            }

        public string Marca;
        public string Modelo;
        public bool IsUsado;

        //public override double CalculaImposto()
        {
            
            if (this.IsUsado)
            {
                return this.Preco = this.Preco + (0.25 * this.Preco);
            }
            else
            {
                return this.Preco = this.Preco + (0.45 * this.Preco);
            }
            
            }

            public override string ToString(){
           return this.Nome + " " + this.Preco + " " + this.Qtd + " " + this.Marca + " " + this.Modelo + " " + this.IsUsado;
           }
    }
}