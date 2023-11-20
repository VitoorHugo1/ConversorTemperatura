namespace Conversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Celcius (C°) para Fahrenheit(F°)");
            Console.WriteLine("2 - Fahrenheit (F°) para Celcius(C°)");
            Console.WriteLine();
            Console.Write("Qual Temperatura você deseja converter ?: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: ConverterParaCelsius(); break;
                case 2: ConverterParaFahrenheit(); break;
                default:
                    Console.WriteLine("Opção Invalida !"); break;
            }
        }
        
        static void ConverterParaCelsius()
        {
            Console.Clear();
            Console.Write("Digite a temperatura em C°: ");
            double temperatura = double.Parse(Console.ReadLine());

            double converter = ((double)temperatura * 1.8 ) + 32;

            Console.WriteLine($"{temperatura} C° para Fahrenheit {converter} F°");

        }

        static void ConverterParaFahrenheit()
        {
            Console.Clear();
            Console.WriteLine("Digite a temperatura em F°: ");
            double temperatura = double.Parse(Console.ReadLine());

            double converter = ((double)temperatura - 32) / 1.8;

            Console.WriteLine($"{temperatura} C° para Fahrenheit {converter} F°");
        }
    }
}
