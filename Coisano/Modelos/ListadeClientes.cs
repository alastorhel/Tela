using LiteDB;

namespace Coisano.Modelos
{

 public class ListadeClientes : Registro
 {
    [BsonId]
 
  public int Id { get; set; }
  public string Nome { get; set; }
  public string CNPJ { get; set; }
  public string DatadeCadastro { get; set; }

 }


  
}
