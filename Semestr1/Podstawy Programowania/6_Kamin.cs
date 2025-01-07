using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Kamin
{

    public static class Tools
    {
        public static double Deg2Rad(this int fi)//zamienia kąt w stopniach na kąt w radianach
        {
            Double degre;
            degre = fi * (Math.PI / 180);
            return degre;


        }
        public static double SinFmDeg(this int fi)//obliczenie Sinusa, funkcja przyjmuje kąt w stopniach, a funkcja przy pomocy innej funkcji oblicza wartośc konta w radianach
        {
            Double sin;
            sin = Math.Sin(Tools.Deg2Rad(fi));
            return sin;


        }
        public static double CosFmDeg(this int fi)//obliczenie Cosinusa, funkcja przyjmuje kąt w stopniach, a funkcja przy pomocy innej funkcji oblicza wartośc konta w radianach
        {
            Double cos;
            cos = Math.Cos(Tools.Deg2Rad(fi));
            return cos;


        }
        public static double Log(this Int32 x, Int32 p) //funkcja oblicza logarytm o podstawie p z liczby x
        {
            double log;
            log = Math.Log10(x) / Math.Log10(p);
            return log;
        }
        public static Double Suma(this Double a, Double b)//Suma liczb a i b
        {
            return a + b;
        }

        public static Double Roznica(this Double a, Double b) //różnica liczb a-b
        {
            return a - b;
        }

        public static Double Iloczyn(this Double a, Double b)//iloczyn liczb a i b
        {
            return a * b;
        }

        public static Double Iloraz(this Double a, Double b) //iloraz liczby a/b
        {
            return a / b;
        }

        public static Int32 NWD(Int32 x, Int32 y)//obliczenie NWD dwóch podanych funkcji liczb
        {
            Int32 reszta;
            while (y != 0)
            {
                reszta = y;
                y = x%y;
                x = reszta;

            }
             return x;
        }

        public static Int32 Silnia(this int a) //oblicza daną silni
        {
            Int32 silnia; 
            if (a == 0)//dla 0 i 1 zwraca 1
            {
                return 1;
            }
            else if (a == 1)
            {
                return 1;
            }
            else
            {
                silnia = 1; //dla innych liczb oblicza silnię
                for (Int32 i = 2; i <= a; i++) 
                {
                    silnia = silnia * i;

                }
                return silnia;
            }

        }
        public static Int32 Fibonacie(int end, int current = 1)  //funkcja oblicza liczby Fibonaciego od current do end, gdzie podać trzeba tylko end,wtedy current = 1
        {
            Int32 fi_2, fi_1, fi_switch;
            fi_1 = 1;
            fi_2 = 1;
            if (current < end)
            {
                if (current == 1)//dla 1 i 2 zwraca 1
                {
                    current++;
                    Console.WriteLine("1 liczba Fibonaciego to 1");
                    return Fibonacie(end, current);


                }
                else if (current == 2)
                {
                    current++;
                    Console.WriteLine("2 liczba Fibonaciego to 1");
                    return Fibonacie(end, current);
                }
                else
                {
                    for (Int32 i = 3; i <= current; i++)  //obliczenie obecnej liczby fi=fi_2
                    {
                        fi_switch = fi_2;
                        fi_2 += fi_1;
                        fi_1 = fi_switch;


                    }
                    Console.WriteLine("{0} liczba Fibonaciego to {1}", current, fi_2);//wypisanie liczby fi
                    current++;
                    return Fibonacie(end, current);


                }

            }
            else
            {
                for (Int32 i = 3; i <= current; i++)  //obliczenie ostatniej liczby fibonaciego
                {
                    fi_switch = fi_2;
                    fi_2 += fi_1;
                    fi_1 = fi_switch;


                }
                Console.Write("{0} liczba Fibonaciego to ", end);//wypisanie liczby fibonaciego
                current++;
                return fi_2;
            }
        }


        public static Int32[] Tablica(Int32 size) //przyjmuje rozmiar, zwraca tabelę o podanej wielkości, wypełnioną liczbami z zakresu od 1 do 3-krotności rozmiaru,
        {
            int[] tab = new Int32[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                tab[i] = rand.Next(0, size*3);
            }
            return tab;

        }

        public static void Wypis(Int32[] tab) //funkcja wypisuje wartości podanej jej tabeli
        {
           for(Int32 i = 0;i < tab.Length; i++)
            {
                Console.WriteLine("{0} element tej tabeli jest równy {1}",i,tab[i]);
            }
        }

        public static bool Posortowanie(Int32[] tab)  //funkcja przyjmuje tablicę i oddaje wartość bool
        {
            for (Int32 i = 0; i < tab.Length-1; i++)
            {

                if (tab[i] <= tab[i + 1])   //sprawdzenie czy tablica jest posortowana
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static Int32[] Gnome(Int32[] tab) { //funkcja sortuję podaną jej tabelę metodą gnoma i oddaje posortowaną tablicę
            Int32 position = 0;
            Int32 change = 0;
            while (position < tab.Length - 1)
            {
                if (tab[position] > tab[position + 1])//sprawdzenie czy element w obecnej pozycji jest wiekszy od elementu w następnej komórce
                {
                    change = tab[position];
                    tab[position] = tab[position + 1];//zamiana miejscami elementów
                    tab[position + 1] = change;
                    if (position > 0) //cofnięcie czapki gnoma w razie niepoprawnego posortowania
                    {
                        position--;
                    }

                }
                else { position++; } //przesunięcie czapki gnoma o jedną pozycję do przodu
            }

            return tab;
        }

        private static void Zamiana(Int32 p,ref Int32[] tab) //zamiana miejscami elementu p i p+1 danej tabeli
        {
            Int32 change;
            change = tab[p];
            tab[p] = tab[p + 1];
            tab[p + 1] = change;
        }

        private static void Krok_w_lewo(ref Int32  p) //przesunięcie czapki w lewo
        {
            p--;
        }

        private static void Krok_w_prawo(ref Int32 p)//przesunięcie czapki w prawo
        {
            p++;
        }
    
     
            private static Int32[] Gnom(this Int32[] tab) //sortowanie gnome z wykorzystaniem wcześniej zdefinowanych funkcji do zamiany elementów i przesuwania czapki
            {
                Int32 p = 0;
                while (p < tab.Length - 1)
                {
                    if (tab[p] > tab[p + 1])
                    {
                        Tools.Zamiana(p, ref tab);
                        if (p > 0)
                        {
                            Tools.Krok_w_lewo(ref p);
                        }
                    }
                    else
                    {
                        Tools.Krok_w_prawo(ref p);
                    }
                }
            return tab;
            }
        
        public static void Calkowanie(ref Double a,ref Double b,ref Double x1, ref Double x2) //funkcja całkuje daną funkcję typu ax^(x1) + bx^(x2)
        {
            x1 = x1 + 1;
            x2 = x2 + 1;
            a = a / x1;
            b = b / x2;
        }


        public static Double Wartosc(Double a, Double b, Double x1, Double x2,Double lewa,Double prawa )  //funkcja przyjmuje dwie liczby double, będące lewą i prawą granicą zakresu, oblicza na podstawie nich całkę oznaczoną
        {
            Double wartosc_calki,lewa_calka,prawa_calka; 
            lewa_calka = a* Math.Pow(lewa, x1)+b*Math.Pow(lewa,x2); //obliczenie wartości całki z lewej strony zakresu
            prawa_calka= a* Math.Pow(prawa, x1) + b* Math.Pow(prawa, x2);//obliczenie wartości całki z prawej strony zakresu
            wartosc_calki = prawa_calka-lewa_calka;//obliczenie finalnej wartości całki
            return wartosc_calki;
        }



    delegate Double Dodawanie(Double i, Double j); //delegacja funkcji z dwoma zmiennymi Int [i] i Int [j]
    class Program
    {
        public static void Tabelka()  //funkcja tworzy tabelkę wartości sinusa i cosinusa
        {
            Console.WriteLine("Kąt        Sin         Cos ");
        }
  

        static void Main(string[] args)
            {


                //Polecenie 1

                //a
                /*
                                Program.Tabelka();//funkcja tworząca tabelkę
                                for (int fi = 0; fi <= 90; fi += 10) //wypisanie wartości sinusa i cosinusa dla danych kątów
                                {
                                    Console.WriteLine(fi + "         " + Math.Round(Math.Sin(fi * (Math.PI / 180)), 3) + "        " + Math.Round(Math.Cos(fi * (Math.PI / 180)), 3));
                                }
                                Console.ReadKey(true);

                                //b

                                Program.Tabelka();
                                for (int fi = 0; fi <= 90; fi += 10) //wypisanie wartości sinusa i cosinusa dla danych kątów z zamianą kąta funkcją
                                {
                                    Console.WriteLine(fi + "         " + Math.Round(Math.Sin(Tools.Deg2Rad(fi)), 3) + "        " + Math.Round(Math.Cos(Tools.Deg2Rad(fi)), 3));
                                }
                                Console.ReadKey(true);

                                //c

                                Program.Tabelka();
                                for (int fi = 0; fi <= 90; fi += 10) //wypisanie wartości sinusa i cosinusa dla danych kątów funkcją własną przyjmującą kąt w stopniach
                                {
                                    Console.WriteLine(fi + "         " + Math.Round(Tools.SinFmDeg(fi),3) + "        " + Math.Round(Tools.CosFmDeg(fi)),3);
                                }
                                Console.ReadKey(true);

                                //d

                                Program.Tabelka();
                                for (int fi = 0; fi <= 90; fi += 10) ////wypisanie wartości sinusa i cosinusa dla danych kątów za pomocą referencji funkcji Cos i Sin FmDeg
                                {
                                    Console.WriteLine(fi + "         " + Math.Round(fi.SinFmDeg(),3) + "        " + Math.Round(fi.CosFmDeg()),3);
                                }
                                Console.ReadKey(true);
                */
                //Polecenie 2

                //a

                /*Int32 podstawa;  //podstawa logarytmu który checemy obliczyć
                Console.WriteLine("Podaj podstawę logarytmu");
                podstawa = Int32.Parse(Console.ReadLine());//ustawienie podstawy logarytmu 
                Console.WriteLine("Wartość         Logarytm z tej wartości");
                for (Int32 i = 16; i <= 256; i += 16) //obliczenie logarytmów o danej podstawie z liczb od 16 do 256 ++16
                {
                    Console.WriteLine(i + "              " + Math.Log10(i) / Math.Log10(podstawa));
                }

                //b

                Console.WriteLine("Wartość         Logarytm z tej wartości");
                for (Int32 i = 16; i <= 256; i += 16)//to samo co wcześniej tylko za pomocą funkcji własnej
                {
                    Console.WriteLine(i + "              " + Tools.Log(i, podstawa));//wypisanie logarytmu
                }

                //c
                Console.WriteLine("Wartość         Logarytm z tej wartości");
                for (Int32 i = 16; i <= 256; i += 16)//to samo co wcześniej tylko za pomocą referencji funkcji własnej
                {
                    Console.WriteLine(i + "              " + i.Log(podstawa));
                }
                Console.ReadKey(true);*/

                //Polecenie 3
/*
                Double a, b, suma; //definicja zmiennych a i b - liczby do zliczenia oraz suma - suma liczb
                Console.WriteLine("Podaj liczbę a");
                a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj liczbę b");
                b = Double.Parse(Console.ReadLine());

                //a  obliczenie różnych funkcji liczb a i b

                suma = Tools.Suma(2 * a, 3 * b);
                Console.WriteLine("Suma 2a + 3b tych liczb to {0}", suma);

                //b

                suma = Tools.Suma(a * b, 7);
                Console.WriteLine("Suma ab + 7 tych liczb to {0}", suma);

                //c

                suma = Tools.Suma(Math.Sqrt(a), Math.Pow(b, 2));
                Console.WriteLine("Suma sqrt(2) + b^2 tych liczb to {0}", suma);

                //d

                suma = Tools.Suma(a, Tools.Suma(b, 1));
                Console.WriteLine("Suma a+b+1 tych liczb to {0}", suma);
                Console.ReadKey(true);

                //Polecenie 4

                Double a, b, c, delta; //deklaracja współczynników funkcji a-przy x^2 b-przy x oraz c jako resztę
                Console.WriteLine("Podaj  a");
                a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj  b");
                b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj  c");
                c = Double.Parse(Console.ReadLine());
                delta = Tools.Roznica(Tools.Iloczyn(b, b), Tools.Iloczyn(Tools.Iloczyn(4, a), c)); //obliczenie delty
                Console.WriteLine("Delta jest równa {0}", delta);
                if (delta >= 0)
                {
                    double x, y;
                    x = (Tools.Roznica(Tools.Iloczyn(b, -1), Math.Sqrt(delta))).Iloraz(a.Suma(a)); //obliczenie pierwszego pierwiastka
                    y = (Tools.Suma(Tools.Iloczyn(b, -1), Math.Sqrt(delta))).Iloraz(a.Suma(a)); //obliczenie drugiego pierwiastka
                    Console.WriteLine("Pierwszy pierwiastek {0}, drugi pierwiastek {1}", x, y);
                }
                else
                {
                    Console.WriteLine("Funkcja nie ma pierwiastków"); //wrazie gdzy delta jest mniejsza niz 0 to wypisuje brak pierwiastków
                }

                Console.ReadKey(true);
*/
            /*    //Polecenie 5
                 Double a, b, c, delta; //deklaracja współczynników funkcji a-przy x^2 b-przy x oraz c jako resztę
                 Console.WriteLine("Podaj  a");
                 a = Double.Parse(Console.ReadLine());
                 Console.WriteLine("Podaj  b");
                 b = Double.Parse(Console.ReadLine());
                 Console.WriteLine("Podaj  c");
                 c = Double.Parse(Console.ReadLine());
                 delta = (b.Iloczyn(b)).Roznica((a.Iloczyn(c)).Iloczyn(4)); //obliczenie delty
                 Console.WriteLine("Delta jest równa {0}", delta);
                 if (delta >= 0)
                 {
                     double x, y;
                     x = ((b.Iloczyn(-1)).Roznica(Math.Sqrt(delta))).Iloraz(a.Iloczyn(2)); //obliczenie pierwszego pierwiastka
                     y = ((b.Iloczyn(-1)).Suma(Math.Sqrt(delta))).Iloraz(a.Iloczyn(2)); //obliczenie drugiego pierwiastka
                     Console.WriteLine("Pierwszy pierwiastek {0}, drugi pierwiastek {1}", x, y);
                 }
                 else
                 {
                     Console.WriteLine("Funkcja nie ma pierwiastków"); //wrazie gdzy delta jest mniejsza niz 0 to wypisuje brak pierwiastków
                 }

                 Console.ReadKey(true);*/
                /*
                               //Polecenie 6

                                                               Random rand = new Random();
                                               Int32 granica;//granica zakresu liczb losowych
                                               Int32 z, j;//z i j liczby losowe do sprawdzenia
                                               z = 0;
                                               j = 0;
                                               Console.WriteLine("Podaj granicę zakresu sprawdzanych liczb");
                                               granica = Int32.Parse(Console.ReadLine());
                                               do
                                               {
                                                   z = rand.Next(1, granica);
                                                   j = rand.Next(1, granica); //losowanie liczb
                                                   Tools.NWD(z, j);
                                               }
                                               while (Tools.NWD(z, j) != 1); //funkcka wykonuje się aż znajdzie dwie liczby względnie pierwsze
                                               Console.WriteLine("Liczby {0} i {1} są względem siebie pierwsze", z, j);
                                               Console.ReadKey(true);

                                               //Polecenie 9

                                               Int32 lewa, prawa;

                                               Console.WriteLine("Podaj lewą granicę zakresu");
                                               lewa = Int32.Parse(Console.ReadLine());
                                               Console.WriteLine("Podaj prawą granicę zakresu");
                                               prawa = Int32.Parse(Console.ReadLine());
                                               if (lewa > prawa)
                                               {
                                                   Console.WriteLine("Źle podałeś zakres");
                                               }
                                               else
                                               {
                                                   for (int i = lewa; i <= prawa; i++)
                                                   {
                                                       Console.WriteLine("Silnia {0} jest równa {1} ", i, i.Silnia());
                                                   }
                                               }
                                               Console.ReadKey(true);

                                               //Polecenie 12

                                               Console.WriteLine(Tools.Fibonacie(10)); //funkcja oblicza oraz wypisuje wartości liczb fibonaciego do podanej granicy [end] od podanej granicy [current](jeżeli nie jest podana to od 1)
                                               Console.ReadKey(true);

                                               //Polecenie 15
                                               //a

                                               Int32 a, b;
                                               Console.WriteLine("Podaj pierwszą liczbę");
                                               a = Int32.Parse(Console.ReadLine());
                                               Console.WriteLine("Podaj drugą liczbę");
                                               b = Int32.Parse(Console.ReadLine());
                                               Dodawanie Wynik = new Dodawanie(Tools.Suma);
                                               Console.WriteLine("Wynikiem dodawania jest {0}", Wynik(a, b));  //dodawanie za pomocą delegacji
                                               Console.ReadKey(true);

                                               //b

                                               Func<double, double, double> suma_lambda = Tools.Suma;  //dodawanie za pomocą funkcji lambda
                                               Console.WriteLine("Wynikiem dodawania jest {0}", suma_lambda(a, b));
                                               Console.ReadKey(true);

                                               //Polecenie 17

                                               Int32 size;
                                               Console.WriteLine("Podaj rozmiar tabeli");
                                               size = Int32.Parse(Console.ReadLine());
                                               Int32[] tabelka = Tools.Tablica(size);//stworzenie tabelki przez funkcję Tablica o rozmiarze [size]
                                               Tools.Wypis(tabelka);//wypisanie wartości tabelki
                                               Console.WriteLine("Tabelka przed posortowaniem " + Tools.Posortowanie(tabelka));//Sprawdzenie czy tabelka jest posortowana przed sortowaniem metodą gnom
                                               tabelka = Tools.Gnome(tabelka);//posortwanie tabelki
                                               Tools.Wypis(tabelka);//wypisanie wartości tabelki po posortowaniu
                                               Console.WriteLine("Tabelka po posortowaniu " + Tools.Posortowanie(tabelka));//Sprawdzenie czy tabelka jest posortowana po sortowaniu metodą gnom
                                               Console.ReadKey(true);
                               */
               /* //Polecenie 18

                Int32 size;
                Console.WriteLine("Podaj rozmiar tabeli");
                size = Int32.Parse(Console.ReadLine());
                Int32[] tabelka = Tools.Tablica(size);//stworzenie tabelki przez funkcję Tablica o rozmiarze [size]
                Tools.Wypis(tabelka);
                Console.WriteLine("Tabelka przed posortowaniem " + Tools.Posortowanie(tabelka));
                Gnom(tabelka);//posortwanie tabelki funkcją rozszerzającą
                Tools.Wypis(tabelka);
                Console.WriteLine("Tabelka po posortowaniu " + Tools.Posortowanie(tabelka));
                Console.ReadKey(true);

                //Polecenie 19

                Console.WriteLine("Podaj rozmiar tabeli");
                size = Int32.Parse(Console.ReadLine());
                Int32[] t = Tools.Tablica(size);//stworzenie tabelki przez funkcję Tablica o rozmiarze [size]
                Tools.Wypis(t);
                Console.WriteLine("Tabelka przed posortowaniem " + Tools.Posortowanie(t));
                t.Gnom();//posortwanie tabelki referęcją funkcji
                Tools.Wypis(t);
                Console.WriteLine("Tabelka po posortowaniu " + Tools.Posortowanie(t));
                Console.ReadKey(true);
*/
                //Polecenie 21

                Double lewa, prawa, a, b, x1, x2;//definicja lewej i prawej granicy przedziału w którym obliczamy całkę oznaczoną, oraz współczynników oraz potęg funkcji
                a = 10;
                x1 = 3;
                b = 2;
                x2 = 2;
                Console.WriteLine("Funkcja z której będzie liczona całka oznaczona: {0}x^{1} + {2}x^{3}", a, x1, b, x2);
                Console.WriteLine("Podaj wartość lewej strony zakresu");
                lewa = Double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartość prawej strony zakresu");  //ustawienie granic całki oznaczonej
                prawa = Double.Parse(Console.ReadLine());
                Tools.Calkowanie(ref a, ref b, ref x1, ref x2); //wykonanie całkowania funkcji
                Console.WriteLine("Całka z funkcji to: {0}x^{1} + {2}x^{3}", a, x1, b, x2);
                Console.WriteLine("Wartość tej całki oznaczonej to: " + Tools.Wartosc(a, b, x1, x2, lewa, prawa)); //obliczenie wartości całki oznaczonej
                Console.ReadKey(true);
            }


        }

    }


}



