using Coisano;
using Coisano.Modelos;


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
    return collection.FindOne(d => d.Id == idEnvioparaoAcabamento);
  }

  //----------------------------------------------------------------------------

  public virtual List<EnvioparaoAcabamento>? LerTodos()
  {
    var tabela = liteDB.GetCollection<EnvioparaoAcabamento>(NomeDaTabela);
    return new List<EnvioparaoAcabamento>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int envioparaoAcabamento)
  {
    var collection = liteDB.GetCollection<EnvioparaoAcabamento>(NomeDaTabela);
    collection.Delete(envioparaoAcabamento);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(EnvioparaoAcabamento envioparaoAcabamento)
  {
    var collection = liteDB.GetCollection<EnvioparaoAcabamento>(NomeDaTabela);
    collection.Upsert(envioparaoAcabamento);
  }

    

    //----------------------------------------------------------------------------
}