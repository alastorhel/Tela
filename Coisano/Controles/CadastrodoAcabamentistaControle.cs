using Coisano;
using Coisano.Modelos;

namespace Controles;

public class CadastrodoAcabamentistaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CadastrodoAcabamentistaControle() : base()
  {
    NomeDaTabela = "CadastrodoAcabamentista";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCadastrodoAcabamentista)
  {
    var collection = liteDB.GetCollection<CadastrodoAcabamentista>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCadastrodoAcabamentista);
  }

  //----------------------------------------------------------------------------

  public virtual List<CadastrodoAcabamentista>? LerTodos()
  {
    var tabela = liteDB.GetCollection<CadastrodoAcabamentista>(NomeDaTabela);
    return new List<CadastrodoAcabamentista>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCadastrodoAcabamentista)
  {
    var collection = liteDB.GetCollection<CadastrodoAcabamentista>(NomeDaTabela);
    collection.Delete(idCadastrodoAcabamentista);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(CadastrodoAcabamentista cadastrodoAcabamentista)
  {
    var collection = liteDB.GetCollection<CadastrodoAcabamentista>(NomeDaTabela);
    collection.Upsert(cadastrodoAcabamentista);
  }

    internal void CriarOuAtualizar(CadastrodoAcabamentistaPage c)
    {
        throw new NotImplementedException();
    }

    //----------------------------------------------------------------------------
}