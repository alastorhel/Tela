using Coisano.Modelos;

namespace Controles;

public class MediaDiariaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MediaDiariaControle () : base()
  {
    NomeDaTabela = "MediaDiaria";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMediaDiaria)
  {
    var collection = liteDB.GetCollection<MediaDiaria>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idMediaDiaria);
  }

  //----------------------------------------------------------------------------

  public virtual List<MediaDiaria>? LerTodos()
  {
    var tabela = liteDB.GetCollection<MediaDiaria>(NomeDaTabela);
    return new List<MediaDiaria>(tabela.FindAll().OrderBy(d => d.Cliente));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMediaDiaria)
  {
    var collection = liteDB.GetCollection<MediaDiaria>(NomeDaTabela);
    collection.Delete(idMediaDiaria);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(MediaDiaria Mediadiaria)
  {
    var collection = liteDB.GetCollection<MediaDiaria>(NomeDaTabela);
    collection.Upsert(Mediadiaria);
  }

  //----------------------------------------------------------------------------
}