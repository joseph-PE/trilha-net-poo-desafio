namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Tamanho { get; set; }

        public Smartphone(string numero, string modelo, string imei, int tamanho)
        {
        // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo= modelo;
            IMEI = imei;
            Tamanho = tamanho;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}