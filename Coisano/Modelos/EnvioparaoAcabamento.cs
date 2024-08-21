using LiteDB;

namespace Coisano.Modelos
{


  public class EnvioparaoAcabamento : Registro
  {
    [BsonId]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Identificaçãodoproduto { get; set; }
    public string Quantidade { get; set; }
  }


}


