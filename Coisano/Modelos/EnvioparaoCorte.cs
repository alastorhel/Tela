using LiteDB;

namespace Coisano.Modelos
{
 public class EnvioparaoCorte : Registro
{
    [BsonId]
     public int Id { get; set; }
        public string Cortadora { get; set; }
        public string MateriaPrima { get; set; }

          public string Quantidade { get; set; }
}

}




