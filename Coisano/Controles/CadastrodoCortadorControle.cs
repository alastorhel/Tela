using Coisano.Modelos;

namespace Controles;

public class CadastrodoCortadorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CadastrodoCortadorControle() : base()
  {
    NomeDaTabela = "CadastrodoCortador";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCadastrodoCortador)
  {
    var collection = liteDB.GetCollection<CadastrodoCortador>(NomeDaTabela);
    return collection.FindOne(d => d.id == idCadastrodoCortador);
  }

  //----------------------------------------------------------------------------

  public virtual List<CadastrodoCortador>? LerTodos()
  {
    var tabela = liteDB.GetCollection<CadastrodoCortador>(NomeDaTabela);
    return new List<CadastrodoCortador>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCadastrodoCortador)
  {
    var collection = liteDB.GetCollection<CadastrodoCortador>(NomeDaTabela);
    collection.Delete(idCadastrodoCortador);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(CadastrodoCortador cadastrodocortador)
  {
    var collection = liteDB.GetCollection<CadastrodoCortador>(NomeDaTabela);
    collection.Upsert(cadastrodocortador);
  }

  //----------------------------------------------------------------------------
}