using Coisano.Modelos;

namespace Controles;

public class CadastroMateriaPrimaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CadastroMateriaPrimaControle() : base()
  {
    NomeDaTabela = "CadastroMateriaPrima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCadastroMatériaPrima)
  {
    var collection = liteDB.GetCollection<CadastroMateriaPrima>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCadastroMatériaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual List<CadastroMateriaPrima>? LerTodos()
  {
    var tabela = liteDB.GetCollection<CadastroMateriaPrima>(NomeDaTabela);
    return new List<CadastroMateriaPrima>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCadastroMatériaPrima)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    collection.Delete(idCadastroMatériaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(CadastroMateriaPrima cadastromateriaprima)
  {
    var collection = liteDB.GetCollection<CadastroMateriaPrima>(NomeDaTabela);
    collection.Upsert(cadastromateriaprima);
  }

  //----------------------------------------------------------------------------
}