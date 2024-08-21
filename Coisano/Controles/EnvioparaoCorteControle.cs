using Coisano.Modelos;

namespace Controles;

public class EnvioparaoCorteControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EnvioparaoCorteControle () : base()
  {
    NomeDaTabela = "EnvioparaoCorte";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idEnvioparaoCorte)
  {
    var collection = liteDB.GetCollection<EnvioparaoCorte>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idEnvioparaoCorte);
  }

  //----------------------------------------------------------------------------

  public virtual List<EnvioparaoCorte>? LerTodos()
  {
    var tabela = liteDB.GetCollection<EnvioparaoCorte>(NomeDaTabela);
    return new List<EnvioparaoCorte>(tabela.FindAll().OrderBy(d => d.Cortadora));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idEnvioparaoCorte)
  {
    var collection = liteDB.GetCollection<EnvioparaoCorte>(NomeDaTabela);
    collection.Delete(idEnvioparaoCorte);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(EnvioparaoCorte envioparaocorte)
  {
    var collection = liteDB.GetCollection<EnvioparaoCorte>(NomeDaTabela);
    collection.Upsert(envioparaocorte);
  }

  //----------------------------------------------------------------------------
}