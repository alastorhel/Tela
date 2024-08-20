namespace Coisano.Modelos
{

    public class ControledeEstoque : Registro
    {
    
        public int id { get; set; }
        public int CodigodoProduto { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeTotal { get; set; }

        public string Tempodaentradanoestoque { get; set; }
        public int Quantidadeatualnoestoque { get; set; }
    }




}
