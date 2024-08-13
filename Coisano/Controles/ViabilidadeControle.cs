using Coisano.Modelos;

namespace Controles;

public class ViabilidadeControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ViabilidadeControle() : base()
  {
    NomeDaTabela = "Viabilidade";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idViabilidade)
  {
    var collection = liteDB.GetCollection<Viabilidade>(NomeDaTabela);
    return collection.FindOne(d => d.id == idViabilidade);
  }

  //----------------------------------------------------------------------------

  public virtual List<Viabilidade>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Viabilidade>(NomeDaTabela);
    return new List<Viabilidade>(tabela.FindAll().OrderBy(d => d.Produto));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idViabilidade)
  {
    var collection = liteDB.GetCollection<Viabilidade>(NomeDaTabela);
    collection.Delete(idViabilidade);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Viabilidade viabilidade)
  {
    var collection = liteDB.GetCollection<Viabilidade>(NomeDaTabela);
    collection.Upsert(viabilidade);
  }

  //----------------------------------------------------------------------------
}