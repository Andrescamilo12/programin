namespace saldo
{
    public class saldo
    {
        public static void Main()
        {
            double horas, precio, final, impu, iva;
            Console.WriteLine("Digite las horas que trabajo en la semana");
            horas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el precio que se paga por hora ");
            precio = Convert.ToDouble(Console.ReadLine());

            final = horas * precio;

            Console.WriteLine($"En esta semana usted gano:${final}");

            impu = final * 0.19;
            iva = final - impu;

            Console.WriteLine($"la ganacia pagando iva te queda en:{iva}");
        

        }
    }
}