namespace IFigura
{
    internal class Program
    {
        internal interface IFigura1
        {
            int Tamanho { get; set; }

            double CalcularArea();
            double CalcularPerimetro();
        }
    }
}