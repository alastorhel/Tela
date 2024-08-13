namespace Coisano.Modelos
{

public class Produto : Registro
{
    public int id { get; set; }
  public string Nome { get; set; }
  public string Descrição { get; set; }
  public int codIdentificaçao { get; set; }

  public string Categoria { get; set; }
 
  public string PreçoUnidade { get; set; }

  
}

}
    
