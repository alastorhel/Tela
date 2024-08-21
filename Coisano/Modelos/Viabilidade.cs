using LiteDB;

namespace Coisano.Modelos
{
    public class Viabilidade : Registro
{
    [BsonId]
    public int Id { get; set; }
  public string Produto { get; set; }
  public string viabilidade { get; set; }
  public string Quantidade { get; set; }


    }
}