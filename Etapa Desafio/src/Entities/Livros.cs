using Etapa_Desafio.src.Interfaces;

namespace Etapa_Desafio.src.Entities
{
    public class Livros :   Produtos, Imposto
    {
        public Livros( string Nome, double Preco, int Qtd, string Autor, string Tema, int QtdPag){
                this.Nome = Nome;
                this.Preco = Preco;
                this.Qtd = Qtd;
                this.Autor = Autor;
                this.Tema = Tema;
                this.QtdPag = QtdPag;
                

            }

                public Livros(){

                }
        public string Autor;
        public string Tema;
        public int QtdPag;

        

        public double CalculaImposto()
        {
            if (this.Tema != "Educativo")
            {
                return this.Preco = this.Preco + (0.1 * this.Preco);
            }

            return 0;
        }

        public override string ToString(){
           return this.Nome + " " + this.Preco + " " + this.Qtd + " " + this.Autor + " " + this.Tema + " " + this.QtdPag;
           }
    }
}