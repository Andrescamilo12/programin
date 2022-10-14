namespace picina
{
    public class Picina
    {

        public static void Main()
        {

            double alto,ancho, largo, volumen, precio, final;

            Console.WriteLine("ingrese el valor de alto");
            alto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el valor de ancho ");
            ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el valor de largo ");
            largo = Convert.ToDouble(Console.ReadLine());

            volumen = alto * ancho * largo; 


            Console.WriteLine($"El area es de:{volumen}");

            Console.WriteLine("Digite el valor por cada metro cubico");
            precio = Convert.ToDouble(Console.ReadLine()); 

            final=volumen * precio;

            Console.WriteLine($"el precio total a pagar es:{final}");

        }
    }
}