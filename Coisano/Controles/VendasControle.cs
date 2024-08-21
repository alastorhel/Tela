using Coisano.Modelos;

namespace Controles;

public class VendasControle : BaseControle
{
  //----------------------------------------------------------------------------

  public VendasControle() : base()
  {
    NomeDaTabela = "Vendas";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idVendas)
  {
    var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idVendas);
  }

  //----------------------------------------------------------------------------

  public virtual List<Vendas>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Vendas>(NomeDaTabela);
    return new List<Vendas>(tabela.FindAll().OrderBy(d => d.Cliente));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idVendas)
  {
    var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
    collection.Delete(idVendas);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Vendas vendas)
  {
    var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
    collection.Upsert(vendas);
  }

  //----------------------------------------------------------------------------
}