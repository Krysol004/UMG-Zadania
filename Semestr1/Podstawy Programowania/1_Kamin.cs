using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Kamin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polecenie 4 i 5
            /*
                Console.ReadKey(true);  //Program oczekuje na wciśnięcie jakiegoś klawisza przez użytkownika
                Console.ReadKey(true);
                Console.ReadKey(true);
            */
            //Polecenie 6
            /*
               Console.WriteLine("Tekst liniowy");
               Console.Write("Tekst zwykły");
               Console.ReadKey(true);  //Tekst możę wyświetlić wszystkie znaki polskie
           */
            //Polecenie 7
            /*
                Console.WriteLine("TEKST 1ĄĘŻŹ");  //Po wypisanym tekście występuje break line 
                Console.WriteLine("TEKST 2ĄĘŻŹ");  //Ten tekst pojawi się już w nowej lini
                Console.Write("Tekst zwykły pierwszy raz, ta sama linia");  //Tekst pojawia się w tej samej lini,chyba że tekst zawiera znak nowej lini \n
                Console.Write("Tekst zwykly drugi raz, ta sama linia");
                Console.ReadKey(true);
            */
            //Polecenie 8

            /*
            Int32 a, b;
            a = 130;
            b = 15;
            Console.WriteLine("Wartość a i b wynosi odpowiednio: " + a + " oraz " + b + " i są to liczby całkowite.");
            Console.ReadKey(true); //Zmniennymi są a oraz b, są typu Int32(liczby całkowite zawarte w wartosći o rozmiarze 32bit)
            //  Aby wypisać wartość zmiennej wraz z tekstem należy konkatynować zmienne do tekst przez użycie znaka +: >"Tekst"+zmienna+"Tekst"
            //  Przypisanie przy deklaracji
            Int32 c = 130, d = 15;
            */
            //Polecenie 9
            /*
            Double a, b;//Rodzajem użytym do zapisywania liczb rzeczywistych jest Float i Double
            a = 12.34;
            b = 56.78;
            Console.WriteLine("Wartość a i b wynosi odpowiednio: " + a + " oraz " + b + " i są to liczby rzeczywiste.");
            Console.ReadKey(true);
            */
            //Polecenie 10
           /* 
            Console.WriteLine("Podaj wartość boka a");
            Double a,b,pole;
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość boka b");
            b = Double.Parse(Console.ReadLine());
            pole = a * b;
            Console.WriteLine("Pole tego prostokąta jest równe " + pole);
            Console.ReadKey(true); //W razie podania przez użytkownika czegoś innego od liczby rzeczywistej pojawi się wyjątek
            */
            //Polecenie 11

            /*
            Double wynik;
            wynik = (Math.Sqrt(Math.PI) + Math.E) / (Math.Log10(Math.PI) + Math.Log(Math.E));
            Console.WriteLine("{0:#.####}",wynik);
            Console.ReadKey(true); //Console.WriteLine("{0:#.######}",x);w tym przypadku wypisana liczba wyświetli się z 6 liczbami po przecinku, a reszta zostanie pominięta 
            */


        }
    }
}
