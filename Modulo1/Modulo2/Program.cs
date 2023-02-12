namespace Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int numeroSuperGrande = int.MaxValue;
            Console.WriteLine(numeroSuperGrande);

            //Float
            float altura = 180.123456789f;//ocupa 4 bytes
            double anchura = 45.123456789;//ocupa 8 bytes y es mas usado
            decimal monto = 9.99m;//usa mas bytes y es mas preciso, se usa en contabilidades:)

            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;
            decimal maxDecimal = decimal.MaxValue;

            Console.WriteLine(maxFloat);
            Console.WriteLine(maxDouble);
            Console.WriteLine(maxDecimal);


        }
    }
}