namespace Coisano.Modelos
{

public class Vendas : Registro
{
    public int id { get; set; }
  public string Cliente { get; set; }
  public string DatadoPedido { get; set; }
  public int Total { get; set; }

  public int Desconto { get; set; }
 
  public string DatadeEntrega { get; set; }

  
}

}