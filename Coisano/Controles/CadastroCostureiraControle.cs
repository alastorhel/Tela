using Coisano.Modelos;

namespace Controles;

public class CadastroCostureiraControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CadastroCostureiraControle() : base()
  {
    NomeDaTabela = "CadastroCostureira";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCadastroCostureira)
  {
    var collection = liteDB.GetCollection<CadastroCostureira>(NomeDaTabela);
    return collection.FindOne(d => d.id == idCadastroCostureira);
  }

  //----------------------------------------------------------------------------

  public virtual List<CadastroCostureira>? LerTodos()
  {
    var tabela = liteDB.GetCollection<CadastroCostureira>(NomeDaTabela);
    return new List<CadastroCostureira>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCadastroCostureira)
  {
    var collection = liteDB.GetCollection<CadastroCostureira>(NomeDaTabela);
    collection.Delete(idCadastroCostureira);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(CadastroCostureira cadastrocostureira)
  {
    var collection = liteDB.GetCollection<CadastroCostureira>(NomeDaTabela);
    collection.Upsert(cadastrocostureira);
  }

  //----------------------------------------------------------------------------
}