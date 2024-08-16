using Coisano.Modelos;

namespace Controles;

public class EnvioParaCosturaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EnvioParaCosturaControle() : base()
  {
    NomeDaTabela = "EnvioParaCostura";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idEnvioParaCostura)
  {
    var collection = liteDB.GetCollection<EnvioParaCostura>(NomeDaTabela);
    return collection.FindOne(d => d.id == idEnvioParaCostura);
  }

  //----------------------------------------------------------------------------

  public virtual List<EnvioParaCostura>? LerTodos()
  {
    var tabela = liteDB.GetCollection<EnvioParaCostura>(NomeDaTabela);
    return new List<EnvioParaCostura>(tabela.FindAll().OrderBy(d => d.Costureira));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idEnvioParaCostura)
  {
    var collection = liteDB.GetCollection<EnvioParaCostura>(NomeDaTabela);
    collection.Delete(idEnvioParaCostura);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(EnvioParaCostura envioparacostura)
  {
    var collection = liteDB.GetCollection<EnvioParaCostura>(NomeDaTabela);
    collection.Upsert(envioparacostura);
  }

  //----------------------------------------------------------------------------
}