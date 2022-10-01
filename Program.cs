//Pregrama que muestra en pantala el año, el mes, y el dia que el usuario digite 
//pregramador encargado: Camilo Andres Pulistar Lopez 

namespace dates
{
    public class program
    {
        static void Main()
        {
            int anyo;
            int mes;
            int dia;
            int dia1;

            Console.WriteLine("Digite el año");
            anyo = Convert.ToInt32(Console.ReadLine());

            if (anyo % 4 == 0 || anyo % 100 != 0 || anyo % 400 == 0)
            {

                Console.WriteLine("");
                Console.WriteLine("Año biciesto");
                Console.WriteLine("Digite el mes");
                mes = Convert.ToInt32(Console.ReadLine());

                if (mes <=12 )
                {
                    Console.WriteLine("Digite el dia");
                    dia = Convert.ToInt32(Console.ReadLine());
                    if (dia <= 31)
                    {
                        dia = dia + 0;
                        dia1 = dia + 1;
                        

                        Console.WriteLine("El dia que digito  es: " + dia + ":" + mes + ":" + anyo);
                        Console.WriteLine("y");
                        Console.WriteLine("El dia siguente es: " + dia1+ ":" + mes + ":" + anyo);

                    }
                    else
                    {
                        Console.WriteLine("Este dia no fue encontrado");
                    }
                }
                else
                {
                    Console.WriteLine("Este Mes no fue encontrado");
                }
            }
            else
            {
                Console.WriteLine("Año no biciesto");
                Console.WriteLine("Digite el mes");
                mes = Convert.ToInt32(Console.ReadLine());

                if (mes <= 12)
                {
                    Console.WriteLine("Digite el dia");
                    dia = Convert.ToInt32(Console.ReadLine());
                    if (dia <=31)
                    {
                        dia = dia + 0;
                        dia1 = dia + 1;


                        Console.WriteLine("El dia que digito  es: " + dia + ":" + mes + ":" + anyo);
                        Console.WriteLine("y");
                        Console.WriteLine("El dia siguente es: " + dia1 + ":" + mes + ":" + anyo);

                       
                    }
                    else
                    {
                        Console.WriteLine("Este dia no fue  encontrado");
                    }
                }
                else
                {
                    Console.WriteLine("Este mes no fue  encontrado");
                }
            }
        }
    }

}
