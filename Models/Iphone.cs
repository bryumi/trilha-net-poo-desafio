namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
  public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }  
        public override void InstalarAplicativo(string nomeApp)
        {
            
            Console.WriteLine($"Instalando {nomeApp} na App Store do iPhone...");
        }
    }
}