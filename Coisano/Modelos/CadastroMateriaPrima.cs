using LiteDB;

namespace Coisano.Modelos
{

public class CadastroMateriaPrima : Registro
{
  [BsonId]

      public int Id { get; set; }
  public string Nome { get; set; }
  public string Unidadedemedida { get; set; }

        public static implicit operator Page(CadastroMateriaPrima v)
        {
            throw new NotImplementedException();
        }
    }





}
    