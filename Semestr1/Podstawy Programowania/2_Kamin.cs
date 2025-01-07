using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kamin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polecenie 2
           /* Double a, b, c, delta, x_0, x_1, x_2;
            Console.WriteLine("Podaj wartość współczynnik a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość współczynnik b");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość współczynnik c");
            c = Double.Parse(Console.ReadLine());
            delta = (Math.Pow(b, 2)-(4*a*c));
            if(delta < 0)
            {
                Console.WriteLine("Funkcja ta nie posiada x0,x1,x2");
                Console.ReadKey(true);
            }
            else if(delta == 0){
                x_0=(-b/(2*a));
                Console.WriteLine("Funkcja ta przecina się z linią 0X w punkcie 0,{0:#.###} w tym samym miejscu występuje wierzchołek x0",x_0);
                Console.ReadKey(true);
            }
            else if(delta > 0)
            {
                x_0 = (-b / (2 * a));
                x_1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x_2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Funkcja ta przecina się z linią 0X w punktach 0,{0:#.###} oraz 0,{1:#.###} . Wierzchołek tej funkcji wystepuje w punkcie {2:#.###},0",x_1,x_2,x_0);
                Console.ReadKey(true);
            };*/
           //Polecenie 3
            Int32 a;
            Console.WriteLine("Podaj liczbę");
            a = Int32.Parse(Console.ReadLine());//W zależnośc od podanej liczby od 0 do 2 zostanie wykonany inny case od 0 do 2, przy podaniu innej wartości wypisane zostanie Nie wiem, przy podaniu wartości nie lczbowej pojawi się błąd
            switch (a)
            {
                case 0:
                    {
                        Console.WriteLine("Zero");
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("Jeden");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Dwa");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Nie wiem");
                    }
                    break;
            };
            Console.ReadKey(true);
            //Polecenie 4

        }
    }
}
