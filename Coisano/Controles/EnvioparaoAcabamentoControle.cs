using Coisano;
using Coisano.Modelos;
using EnvioparaoAcabamento = Coisano.EnvioparaoAcabamentoPage;

namespace Controles;

public class EnvioparaoAcabamentoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EnvioparaoAcabamentoControle() : base()
  {
    NomeDaTabela = "EnvioparaoAcabamento";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idEnvioparaoAcabamento)
  {
    var collection = liteDB.GetCollection<EnvioparaoAcabamento>(NomeDaTabela);
    return collection.FindOne(d => d.id == idEnvioparaoAcabamento);
  }

  //----------------------------------------------------------------------------

  public virtual List<EnvioparaoAcabamento>? LerTodos()
  {
    var tabela = liteDB.GetCollection<EnvioparaoAcabamento>(NomeDaTabela);
    return new List<EnvioparaoAcabamento>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int EnvioparaAcabamento)
  {
    var collection = liteDB.GetCollection<EnvioparaoAcabamento>(NomeDaTabela);
    collection.Delete(EnvioparaoAcabamento);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(EnvioparaoAcabamento EnvioparaoAcabamento)
  {
    var collection = liteDB.GetCollection<EnvioparaoAcabamento>(NomeDaTabela);
    collection.Upsert(EnvioparaoAcabamento);
  }

    

    //----------------------------------------------------------------------------
}