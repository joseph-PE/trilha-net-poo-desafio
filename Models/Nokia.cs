namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
         public Nokia(string numero, string modelo, string imei, int tamanho) : base(numero, modelo, imei, tamanho)
         {
            
         }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
        }
    }
}