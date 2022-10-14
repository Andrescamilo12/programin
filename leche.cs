namespace leche
{
    public class leche
    {
        public static void Main()
        {
            double litros, galones, dineroporgalon, dineroganado; 

            Console.WriteLine("Digite cuantos litros vendio");
            litros=Convert. ToDouble(Console.ReadLine());

            Console.WriteLine("Digite precio de galón");
            dineroporgalon = Convert.ToDouble(Console.ReadLine());

            galones = litros / 3.785;

            dineroganado = galones * dineroporgalon;

            Console.WriteLine($"la cantidad en galones es:{galones}");
            Console.WriteLine($"El dinero ganado es: {dineroganado} pesos");
        }
    }
}
