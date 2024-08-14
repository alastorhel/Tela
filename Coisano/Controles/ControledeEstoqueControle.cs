using Coisano.Modelos;

namespace Controles;

public class ControledeEstoqueControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ControledeEstoqueControle() : base()
  {
    NomeDaTabela = "ControledeEstoque";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idControledeEstoque)
  {
    var collection = liteDB.GetCollection<ControledeEstoque>(NomeDaTabela);
    return collection.FindOne(d => d.id == idControledeEstoque);
  }

  //----------------------------------------------------------------------------

  public virtual List<ControledeEstoque>? LerTodos()
  {
    var tabela = liteDB.GetCollection<ControledeEstoque>(NomeDaTabela);
    return new List<ControledeEstoque>(tabela.FindAll().OrderBy(d => d.CodigodoProduto));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idControledeEstoque)
  {
    var collection = liteDB.GetCollection<ControledeEstoque>(NomeDaTabela);
    collection.Delete(idControledeEstoque);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(ControledeEstoque controledeestoque)
  {
    var collection = liteDB.GetCollection<ControledeEstoque>(NomeDaTabela);
    collection.Upsert(controledeestoque);
  }

  //----------------------------------------------------------------------------
}