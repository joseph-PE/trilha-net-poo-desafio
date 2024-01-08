namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int tamanho) : base(numero, modelo, imei, tamanho)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write($"Instalando o aplicatvo \"{nomeApp}\"no Iphone");
        }
    }
}