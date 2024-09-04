using LiteDB;

namespace Coisano.Modelos
{

public class CadastroCostureira : Registro
{

  [BsonId]
  
      public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }

        public static implicit operator Page(CadastroCostureira v)
        {
            throw new NotImplementedException();
        }
    }





}