using LiteDB;

namespace Coisano.Modelos
{

public class CadastroMatériaPrima : Registro
{
  [BsonId]

      public int Id { get; set; }
  public string Nome { get; set; }
  public string Unidadedemedida { get; set; }
  
}





}
    