using LiteDB;

namespace Coisano.Modelos
{

public class Produto : Registro
{
  [BsonId]
  
    public int Id { get; set; }
  public string Nome { get; set; }
  public string Descrição { get; set; }
  public string codIdentificaçao { get; set; }

  public string Categoria { get; set; }
 
  public string PreçoUnidade { get; set; }

  
}

}
    
