using Coisano.Modelos;

namespace Controles;

public class MediaDiáriaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MediaDiáriaControle () : base()
  {
    NomeDaTabela = "MediaDiária ";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMediaDiária)
  {
    var collection = liteDB.GetCollection<MediaDiária>(NomeDaTabela);
    return collection.FindOne(d => d.id == idMediaDiária);
  }

  //----------------------------------------------------------------------------

  public virtual List<MediaDiária>? LerTodos()
  {
    var tabela = liteDB.GetCollection<MediaDiária>(NomeDaTabela);
    return new List<MediaDiária>(tabela.FindAll().OrderBy(d => d.Cliente));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMediaDiária)
  {
    var collection = liteDB.GetCollection<MediaDiária>(NomeDaTabela);
    collection.Delete(idMediaDiária);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(MediaDiária mediadiária)
  {
    var collection = liteDB.GetCollection<MediaDiária>(NomeDaTabela);
    collection.Upsert(mediadiária);
  }

  //----------------------------------------------------------------------------
}