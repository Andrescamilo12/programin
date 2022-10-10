namespace romanos
{
    public class programin
    {


        public static void Main()
        {
            double u, d, c, m, vold;



            Console.WriteLine("digite un numero entre 1 a 3999");

            vold = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));
            m = Math.Truncate(vold / 1000) % 10;
            c = Math.Truncate(vold / 100) % 10;
            d = Math.Truncate(vold / 10) % 10;
            u = Math.Truncate(vold / 1) % 10;


            if (m > 3)
            {
                Console.WriteLine("El numero no se puede calcular");
            }
            else
            {
                switch (m)
                {
                    case 1:
                        Console.Write("M");
                        break;
                    case 2:
                        Console.Write("MM");
                        break;
                    case 3:
                        Console.Write("MMM");
                        break;
                }
                switch (c)
                {
                    case 1:
                        Console.Write("C");
                        break;
                    case 2:
                        Console.Write("CC");
                        break;
                    case 3:
                        Console.Write("CCC");
                        break;
                    case 4:
                        Console.Write("CD");
                        break;
                    case 5:
                        Console.Write("D");
                        break;
                    case 6:
                        Console.Write("DC");
                        break;
                    case 7:
                        Console.Write("DCC");
                        break;
                    case 8:
                        Console.Write("DCCC");
                        break;
                    case 9:
                        Console.Write("CM");
                        break;
                }
                switch (d)
                {
                    case 1:
                        Console.Write("X");
                        break;
                    case 2:
                        Console.Write("XX");
                        break;
                    case 3:
                        Console.Write("XXX");
                        break;
                    case 4:
                        Console.Write("XL");
                        break;
                    case 5:
                        Console.Write("L");
                        break;
                    case 6:
                        Console.Write("LX");
                        break;
                    case 7:
                        Console.Write("LXX");
                        break;
                    case 8:
                        Console.Write("LXXX");
                        break;
                    case 9:
                        Console.Write("XC");
                        break;
                }
                switch (u)
                {
                    case 1:
                        Console.WriteLine("I");
                        break;
                    case 2:
                        Console.WriteLine("II");
                        break;
                    case 3:
                        Console.WriteLine("III");
                        break;
                    case 4:
                        Console.WriteLine("IV");
                        break;
                    case 5:
                        Console.WriteLine("V");
                        break;
                    case 6:
                        Console.WriteLine("VI");
                        break;
                    case 7:
                        Console.WriteLine("VII");
                        break;
                    case 8:
                        Console.WriteLine("VIII");
                        break;
                    case 9:
                        Console.WriteLine("IX");
                        break;




                }

            }


        }
    }
}

