using LiteDB;

namespace Coisano.Modelos
{

public class CadastrodoAcabamentista : Registro
{

  [BsonId]
  
      public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }

        public static implicit operator Page(CadastrodoAcabamentista v)
        {
            throw new NotImplementedException();
        }
    }





}