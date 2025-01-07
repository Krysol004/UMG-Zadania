using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _4_Kamin
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Polecenie1 NWD-odejmowanie i dzielenie*/
            /* Int32 a, b,NWD,r;  //a i b to podane przez użytkownika liczby, r to reszta z dzielenia, NWD to NWD  tych liczb
             Console.WriteLine("Podaj pierwszą zmienną");
             a = Int32.Parse(Console.ReadLine());   //ustawieneie liczb
             Console.WriteLine("Podaj drugą zmienną");
             b = Int32.Parse(Console.ReadLine());
            while (a != b)  //NW za pomocą odejmowania od siebie a i b
             {
                 if (a > b)
                 {
                     a = a - b;
                 }
                 else
                 {
                     b = b - a;
                 }
             };
           
            NWD = a;
            Console.WriteLine("");
            Console.WriteLine(NWD);//wypisanie wartości
             Console.ReadKey(true);
            Console.WriteLine("");

            Console.WriteLine("Podaj pierwszą zmienną"); 
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą zmienną");
            b = Int32.Parse(Console.ReadLine());
            while (b != 0) //NWD za pomocą reszty z dzielenia
            {
                r = a % b;
                a = b;
                b = r;
            };
            NWD = a;
            Console.WriteLine("");
            Console.WriteLine(NWD);
            Console.ReadKey(true);*/

            /*Polecenie 2*/
            /* Int32 a, b, NWD, r;  //definicja zmiennych tak samo jak w 1 poleceniu
             Stopwatch watch = new Stopwatch(); //stworzenie nowego obiektu watch typy stopwatch
             Console.WriteLine("Podaj pierwszą zmienną");
             a = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Podaj drugą zmienną");
             b = Int32.Parse(Console.ReadLine());
             watch.Start(); //aktywacja pomiaru czasu działania programu
             while (a != b)
             {
                 if (a > b)
                 {
                     a = a - b;
                 }
                 else
                 {
                     b = b - a;
                 }
             };
             watch.Stop(); //dezaktywacja pomiaru czasu działania programu
             Console.WriteLine("Czas NWD z odejmowaniem: {0}", watch.Elapsed);//wypisanie czasu działania operacji
             NWD = a;
             Console.WriteLine("");
             Console.WriteLine(NWD);
             Console.ReadKey(true);
             Console.WriteLine("");

             Console.WriteLine("Podaj pierwszą zmienną");
             a = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Podaj drugą zmienną");
             b = Int32.Parse(Console.ReadLine());
             watch.Start();
             while (b != 0)
             {
                 r = a % b;
                 a = b;
                 b = r;
             };
             watch.Stop();
             Console.WriteLine("Czas NWD reszta z dzielenia: {0}", watch.Elapsed);
             NWD = a;
             Console.WriteLine("");
             Console.WriteLine(NWD);
             Console.ReadKey(true);*/  //Wynik drugiej metody-reszty z dzielenia jest szybsza

            //Polecenie 5
            /* Int32 n,fi,fa,fb,i; //n to ilość znaków fibonaciego, fi to liczba fibonaciego, fa i fb to wcześniejsze liczby fibonaciego f(n-2) i f(n-1)
             fi = 0;
             fb = 0;
             Console.WriteLine("Podaj n");
             n=Int32.Parse(Console.ReadLine());
             if (n == 0)  // 0 liczba fibonaciego to 0
             {
                 fi = 0;
             }
             else if (n == 1) // 1 liczba fibonaciego to 1
             {
                 fi = 1;
             }
             else if(n>1) // dla innych liczb fibonaciego, są one równa fa+fb=fi
             {
                 fa = 0;
                 fb = 1;
                 for (i=2;i<=n;i++)
                 {
                     fi = fa + fb;
                     fa = fb;
                     fb = fi;
                 } 
             };
             Console.WriteLine(fi);
             Console.ReadKey(true);*/
            /*Polecenie6*/
            /*  Int32 n; // definicja n- ostatnia wartość fibonaciego
              Console.WriteLine("Podaj n");
              n = Int32.Parse(Console.ReadLine()); //ustawienie liczby n
              Int32[] tab_fi = new Int32[n];//stworzenie tabeli o długości n
              if (n >= 2) //przy n>=2 tworzy 0 i 1 element
              {
                  tab_fi[0] = 0;
                  tab_fi[1] = 1;
              }
              else if (n >= 1)//przy n>=1 tworzy 0 element
              {
                  tab_fi[0] = 0;
              };
              for (Int32 i = 2; i < n; i++) //tworzenie kolejnych liczb fi przez dodanie liczby fi n-1 i fi n-2
              {
                  tab_fi[i] = tab_fi[i-1] + tab_fi[i-2];
              };

              for (Int32 i= 0; i < n; i++) //wypisanie w kolejności liczb fi
              {
                  Console.Write(i+": fi to "+tab_fi[i]+" ");
              }
              Console.ReadKey(true);*/
            //Polecenie7
            /* Int32 num, d, i; // definicja zmiennych num-liczba podana przez użytkownika, d-ilość dzielników, i
             Boolean prime;
             prime = true; //stworzenie zmiennej bool, gdzie true-liczba jest pierwsza i false - liczba nie jest pierwsza
             d = 0;
             Console.WriteLine("Podaj liczbę");
             num = Int32.Parse(Console.ReadLine()); //ustawienie wartości zmiennej num
             for (i = 1; i <= num; i++)//sprawdzenie czy liczba jest liczbą pierwszą
             {
                 if (num % i == 0)
                 {
                     d += 1;
                 }

             }
             if (d == 2 | d==1)//jeżeli ilość dzielników to 1 lub 2 to jest pierwsza
             {
                 prime = true;
             }
             else //w innym przypadku nie jest pierwsza
             {
                 prime = false;
             }

             if (prime == true) //Wypisanie liczby i tego czy jest pierwsza
             {
                Console.WriteLine(num+" jest pierwsza");
             }
             else
             {
                 Console.WriteLine(num+" nie jest pierwsza");
             }
             Console.ReadKey(true);
 */
            /*Polecenie8*/
            /* Int32 End,i,num,d; //End - granica zakresu od[0 do End], num - liczba podana przez użytkownika, d-ilość dzielników
             num = 0;
             d = 0;
             Console.WriteLine("Podaj granicę przedziału");
             End = Int32.Parse(Console.ReadLine());
             for (Int32 Start = 1; Start <= End; Start++)
             {
                 d = 0;
                 num = Start;
                 for (i = 1; i <= num; i++)//sprawdzenie czy liczba jest liczbą pierwszą
                 {
                     if (num % i == 0)
                     {
                         d += 1;
                     }                 
                 }
                 if (d == 2 | d == 1) //jeżeli liczba ma 1 lub 2 dzielniki to jest pierwsza
                 {
                     Console.WriteLine(num);
                 }

             }
             Console.ReadKey(true);*/
            //    Polecenie9
            Int32 End, num, dividers,primes; //End to koniec zakresu, num to liczba sprawdzana czy jest pierwszą, dividers to ilośc dzielników liczby, primes to ilośc liczb pierwszych
            primes = 0;
            num = 0; //ustawienie potrzebnych zmiennych na 0
            dividers = 0;
            Console.WriteLine("Podaj granicę zakresu");
            End = Int32.Parse(Console.ReadLine());
            for (Int32 Start = 1; Start <= End; Start++) //sprawdza liczby od Start=1 do End
            {
                dividers = 0;
                num = Start;
                for (Int32 i = 1; i <= num; i++)//sprawdzenie czy liczba jest liczbą pierwszą
                {
                    if (num % i == 0)
                    {
                        dividers += 1;
                    }
                }
                if (dividers == 2 | dividers == 1)
                {
                    Console.WriteLine(num); // wypisanie liczby pierwszej i zwiększenie ilości liczb pierwszych o 1
                    primes++;
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Ilość liczb pierwszych w zakresie od 1 do " + End + " to " + primes);
            Console.ReadKey(true);
            /*Polecenie10*//*
            Int32 End, num, dividers,primes; //End to koniec zakresu, num to liczba sprawdzana czy jest pierwsza, dividers to ilośc dzielników liczby, primes to ilośc liczb pierwszych
            primes = 0;
            num = 0; //ustawienie potrzebnych zmiennych
            dividers = 0;
            Console.WriteLine("Podaj granicę zakresu");
            End = Int32.Parse(Console.ReadLine());
            for (Int32 Start = 1; Start <= End; Start++)
            {
                dividers = 0;
                num = Start;
                for (Int32 i = 2; i < num; i++)//sprawdzenie czy liczba jest liczbą pierwszą
                {
                    if (num % i == 0)
                    {
                        dividers += 1;
                    }
                }
                if (dividers ==0)
                {
                    Console.WriteLine(num); // wypisanie liczby pierwszej i zwiększenie liczby liczb pierwszych o 1
                    primes++;
                }

            }*/

            Console.ReadKey(true);



        }
    }
}
