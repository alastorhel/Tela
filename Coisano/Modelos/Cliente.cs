using LiteDB;

namespace Coisano.Modelos
{
    public class Cliente : Registro
{
  [BsonId]

    public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public string Email { get; set; }

  public string Cnpj { get; set; }
 
  public string Cpf { get; set; }

  public string Endereço { get; set; }

    }
}