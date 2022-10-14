namespace ejercicios
{
    public class lotes
    {

        public static void Main()
        {

            decimal a1, a2, a3, a, b, c;

            Console.WriteLine("ingrese el valor de A ");
            a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de B ");
            b = decimal.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de C ");
            c = decimal.Parse(Console.ReadLine());



            a1 = b * c;
            a2 = ((a - c) * b) / 2;
            a3 = a1 + a2;

            Console.WriteLine($"El area es de:{a3}");

        }
    }
}