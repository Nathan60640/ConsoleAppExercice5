namespace ConsoleAppExercice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Consommation initiale (en MWh) : ");
            double initiale = double.Parse(Console.ReadLine());

            double consommation = initiale;
            int annees = 0;

            while (consommation < 2 * initiale)
            {
                consommation = consommation * 1.08;
                annees++;
            }

            Console.WriteLine($"Il faudra {annees} ans pour doubler la consommation.");
            Console.WriteLine($"Consommation au bout de {annees} ans : {consommation:F2} MWh");
        }
    }
}
