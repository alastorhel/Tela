using Coisano.Modelos;

namespace Controles;

public class EnvioparaAcabamentoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EnvioparaAcabamentoControle() : base()
  {
    NomeDaTabela = "EnvioparaAcabamento";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idEnvioparaAcabamento)
  {
    var collection = liteDB.GetCollection<EnvioparaAcabamento>(NomeDaTabela);
    return collection.FindOne(d => d.id == idEnvioparaAcabamento);
  }

  //----------------------------------------------------------------------------

  public virtual List<EnvioparaAcabamento>? LerTodos()
  {
    var tabela = liteDB.GetCollection<EnvioparaAcabamento>(NomeDaTabela);
    return new List<EnvioparaAcabamento>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int EnvioparaAcabamento)
  {
    var collection = liteDB.GetCollection<EnvioparaAcabamento>(NomeDaTabela);
    collection.Delete(EnvioparaAcabamento);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(EnvioparaAcabamento EnvioparaAcabamento)
  {
    var collection = liteDB.GetCollection<EnvioparaAcabamento>(NomeDaTabela);
    collection.Upsert(EnvioparaAcabamento);
  }

  //----------------------------------------------------------------------------
}