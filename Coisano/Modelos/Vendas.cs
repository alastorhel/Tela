using LiteDB;

namespace Coisano.Modelos
{

public class Vendas : Registro
{
  [BsonId]
    public int Id { get; set; }
  public string Cliente { get; set; }
  public string DatadoPedido { get; set; }
  public int Total { get; set; }

  public string Desconto { get; set; }
 
  public string DatadeEntrega { get; set; }

  
}

}