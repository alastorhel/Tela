using LiteDB;

namespace Coisano.Modelos
{

public class CadastrodoCortador : Registro
{
  [BsonId]
      public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }
  
}





}
    