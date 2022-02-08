namespace Etapa_Desafio.src.Entities
{
    public abstract class Produtos
    {

        
            public Produtos(string Nome, double Preco, int Qtd){
                this.Nome = Nome;
                this.Preco = Preco;
                this.Qtd = Qtd;

            }

            public Produtos(){

            }
        public string Nome;
        public double Preco;
        public int Qtd; 
            
    }
}