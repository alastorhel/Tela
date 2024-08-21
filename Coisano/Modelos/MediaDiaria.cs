using LiteDB;

namespace Coisano.Modelos
{

public class MediaDiaria : Registro
{
  [BsonId]
    public int Id { get; set; }
  public string Cliente { get; set; }
  public string mediadiaria { get; set; }
  

  
}

}
    