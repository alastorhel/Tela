using Coisano.Modelos;

namespace Controles;

public class CadastroMatériaPrimaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CadastroMatériaPrimaControle() : base()
  {
    NomeDaTabela = "CadastroMatériaPrima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCadastroMatériaPrima)
  {
    var collection = liteDB.GetCollection<CadastroMatériaPrima>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCadastroMatériaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual List<CadastroMatériaPrima>? LerTodos()
  {
    var tabela = liteDB.GetCollection<CadastroMatériaPrima>(NomeDaTabela);
    return new List<CadastroMatériaPrima>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCadastroMatériaPrima)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    collection.Delete(idCadastroMatériaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(CadastroMatériaPrima cadastromatériaprima)
  {
    var collection = liteDB.GetCollection<CadastroMatériaPrima>(NomeDaTabela);
    collection.Upsert(cadastromatériaprima);
  }

  //----------------------------------------------------------------------------
}