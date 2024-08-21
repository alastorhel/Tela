using LiteDB;

namespace Coisano.Modelos
{


 public class EnvioParaCostura : Registro
{
  [BsonId]


      public int Id { get; set; }
        public string Costureira { get; set; }
        public string MateriaPrima { get; set; }
        public string Quantidade { get; set; }
}


}
