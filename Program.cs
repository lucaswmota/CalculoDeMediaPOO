namespace CalculoDeMediaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Media media = new Media();

            media.inserirNota();

            media.calcularMedia();

            media.exibirMedia();

            Console.ReadKey();

        }
    }
}