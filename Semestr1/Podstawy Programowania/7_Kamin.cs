using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7_Kamin
{
    class Zadania
    {
        public static void Zad_1()
        {
            Console.WriteLine("Podaj ciąg liter i liczb");
            String tekst = Console.ReadLine();//przypisanie ciągu
            for (Int32 i = 0; i < tekst.Length; i++)
            {
                if (Char.IsDigit(tekst, i))//pętla sprawdza pokolei każdy znak tekstu i jeżeli jest on cyfrą to ją wypisuje
                {
                    Console.Write(tekst[i]);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Wypisano wszystkie cyfry z ciągu");
            Console.ReadKey();
        }




        public static void Zad_2()
        {
            Console.WriteLine("Podaj ciąg liter i liczb");
            String tekst = Console.ReadLine();//przypisanie ciągu
            string liczba = string.Empty; //stworzenie string przechwujący liczbę
            Console.WriteLine("Liczby wystepujące w tym stringu");
            for (Int32 i = 0; i < tekst.Length; i++) //pętla przechodzi przez każdy znak i 
            {
                if (Char.IsDigit(tekst, i))// jeżeli jest liczbą to konkatenuje ją do zmiennej liczba
                {
                    liczba += tekst[i];
                    if (i == 0) //po czym jeżeli jest 0 znakiem w ciągu to nic nie robi,
                    {

                    }
                    if (i != 0 && Char.IsDigit(tekst, i - 1))// jeżeli nie jest 0 znakiem ciągu i wcześniejszy znak też był cyfrą robi nic
                    {

                    }
                    if (i != tekst.Length - 1 && Char.IsDigit(tekst, i + 1))// jeżeli nie jest ostatnim znakiem ciągu i następny znak też jest cyfrą robi nic
                    {

                    }
                    else
                    {
                        Console.WriteLine(liczba);// w innym przypadku wypisuje powstałą liczbę i zeruje zmienną liczba
                        liczba = string.Empty;
                    }
                }


            }
            Console.WriteLine();
            Console.ReadKey();
        }
        

        public static void Zad_5()
        {
            Console.WriteLine("Podaj łańcuch liczb rozdzielnych przecinkami");
            String tekst = Console.ReadLine();//przypisanie ciągu do tekst
            String sub_tekst;// przechowuje wyciętą liczbę z ciągu jako string
            Int32 przecinek, i,sub_tekst_liczba;//deklaracja przecinek-pozycja przecinka w ciągu, i - numer liczby w ciągu, sub_tekst_liczba - przechowuje wyciętą liczbę z ciągu jako Int
            i = 0;
            while (tekst.Length > 1)// pętla wykonuje się aż cały ciąg nie zostanie wycięty
            {

                przecinek = tekst.IndexOf(","); //przypisanie pozycji przecinka 
                if (przecinek == 0)// jeżeli ktoś postawił go jako pierwszy znak to zostaje on usunięty
                {
                    tekst = tekst.Remove(0,1);
                }
                else if (przecinek == -1)// jeżeli w ciągu nie ma już przecinków to oznacza to,że pozostała zawartośc tekstu to ostatnia liczba, zostaje ona wypisana i tekst zostaje pusty
                {
                    sub_tekst = (tekst);
                    sub_tekst_liczba = Int32.Parse(sub_tekst);
                    tekst = string.Empty;
                    Console.WriteLine(i + " liczba w łańcuchu to " + sub_tekst_liczba);
                    Console.WriteLine("Kwadrat tej liczby jest równy " + Math.Pow(sub_tekst_liczba, 2));
                }
                else // w innym przypadku liczba zostaje wycięta, od 0 elementu ciągu do przecnika 
                {
                    
                    sub_tekst = tekst.Substring(0, przecinek);
                    sub_tekst_liczba = Int32.Parse(sub_tekst);//potem zostaje zamieniona na Int
                    tekst = tekst.Remove(0, przecinek + 1);//zostaje usunięta z ciągu
                    Console.WriteLine(i + " liczba w łańcuchu to " + sub_tekst_liczba);//zostaje wypisana
                    Console.WriteLine("Kwadrat tej liczby jest równy " + Math.Pow(sub_tekst_liczba, 2));// podniesiona do kwadratu i wypisana
                    i++;// Ilość liczb zostaje zwiększona o jeden
                }



            }
            Console.ReadKey();
        }
        public static void Zad_6()
        {
            Console.WriteLine("Podaj łańcuch liczb rozdzielnych przecinkami");
            String tekst = Console.ReadLine();//przypisanie ciągu do tekst
            String[] lancuchy = tekst.Split(',');//ciąg jest podzielony i przypisany do tablicy
            Int32[] lancuchy_liczb = lancuchy.Select(s => Int32.Parse(s)).ToArray();//wartości z tablicy stringów zostaje przepisana do tablicy intów
            Double[] lancuchy_liczb_kwadrat = lancuchy.Select(s => Math.Pow(Double.Parse(s), 2)).ToArray();// wartości zostają podniesione do kwadratu i przepisane do tablicy doublei

            for (int i = 0; i < lancuchy.Length; i++)//wartości z tablic intów i tablicy doubli zostają wypisane
            {
                Console.WriteLine(i + " liczba w podanym łańcuchu to " + lancuchy_liczb[i]);
                Console.WriteLine("Kwadarat tej liczby to " + lancuchy_liczb_kwadrat[i]);
            }


            Console.ReadKey();
        }
        public static void Zad_7()
        {
            Console.WriteLine("Podaj łańcuch liczb rozdzielnych przecinkami");
            String tekst = Console.ReadLine();//przypisanie ciągu do tekst
            String[] lancuchy = tekst.Split(',');//ciąg jest podzielony i przypisany do tablicy
            lancuchy = lancuchy.Select(s => string.IsNullOrWhiteSpace(s) ? "0" : s).ToArray();//wartości są przepisane ponownie do tej samej tablicy, a jeżeli dany odcinek ciągu był pusty to jest zamieniamy na 0
            Int32[] lancuchy_liczb = lancuchy.Select(s => Int32.Parse(s)).ToArray();//wartości z tablicy stringów zostaje przepisana do tablicy intów
            Double[] lancuchy_liczb_kwadrat = lancuchy.Select(s => Math.Pow(Double.Parse(s), 2)).ToArray();// wartości zostają podniesione do kwadratu i przepisane do tablicy doublei

            for (int i = 0; i < lancuchy.Length; i++)//wartości z tablic intów i tablicy doubli zostają wypisane
            {
                Console.WriteLine(i + " liczba w podanym łańcuchu to " + lancuchy_liczb[i]);
                Console.WriteLine("Kwadarat tej liczby to " + lancuchy_liczb_kwadrat[i]);
            }


            Console.ReadKey();
        }

        public static void Zad_8()
        {
            Double liczba = 1234.5678; //liczba do formatowania typu double
            String liczba_str; //zformatowana liczba, którą będziemy widzieć w locals
            CultureInfo[] kultury = new CultureInfo[] //tablica kultur
        {
            new CultureInfo("pl-PL"),  // Polska
            new CultureInfo("en-GB"),  // Wielka Brytania
            new CultureInfo("en-US"),  // USA
            new CultureInfo("he-IL"),  // Izrael
            new CultureInfo("ar-SA"),  // Arabia Saudyjska
            new CultureInfo("zh-CN"),  // Chiny
            new CultureInfo("ja-JP"),  // Japonia
            new CultureInfo("fr-Fr"),  // Francja
            new CultureInfo("de-De"),  // Niemcy
            new CultureInfo("ru-Ru"),  // Rosja 
        };
            foreach (var kultura in kultury) //pętla formatuje liczbę według każdego formatu kulturowego
            {
                 liczba_str = string.Format(kultura, "{0:C}", liczba);     
            }

        }
        public static void Zad_9()
        {
            DateTime data = DateTime.Now; //obecna data i czas typu DateTime
            String data_str; //zformatowana data, którą będziemy widzieć w locals
            CultureInfo[] kultury = new CultureInfo[] //tablica kultur
        {
            new CultureInfo("pl-PL"),  // Polska
            new CultureInfo("en-GB"),  // Wielka Brytania
            new CultureInfo("en-US"),  // USA
            new CultureInfo("he-IL"),  // Izrael
            new CultureInfo("ar-SA"),  // Arabia Saudyjska
            new CultureInfo("zh-CN"),  // Chiny
            new CultureInfo("ja-JP"),  // Japonia
            new CultureInfo("fr-Fr"),  // Francja
            new CultureInfo("de-De"),  // Niemcy
            new CultureInfo("ru-Ru"),  // Rosja 
        };
            foreach (var kultura in kultury) //pętla formatuje date i czas według każdego formatu kulturowego, co można zobaczyć w locals
            {
                data_str = string.Format(kultura, "{0:F}", data);
            }

        }
        public static void Zad_10()
        {
            Console.WriteLine("Podaj CTRL+END aby zatrzymać program");
            while (1==1)
            {
                
                ConsoleKeyInfo klawisze = Console.ReadKey(intercept: true);//przypisanie danych o wciśniętych klawiszach
                Console.WriteLine("Wciśnięto klawisz: {0}",klawisze.Key);
                Console.WriteLine("Znak: {0}",klawisze.KeyChar);//wypisanie klawisza
                Console.WriteLine("Ctrl: {0}",klawisze.Modifiers.HasFlag(ConsoleModifiers.Control));//wypisanie czy został wypisany ctrl
                Console.WriteLine("Shift: {0}", klawisze.Modifiers.HasFlag(ConsoleModifiers.Shift));//wypisanie czy został wypisany shift
                Console.WriteLine("Alt: {0}", klawisze.Modifiers.HasFlag(ConsoleModifiers.Alt));//wypisanie czy został wypisany alt


                if (klawisze.Modifiers.HasFlag(ConsoleModifiers.Control) && klawisze.Key == ConsoleKey.End)//jeżeli ctrl i end zostanie wciśniety pętla się kończy
                {
                    break;
                }
            }
        }
            public static void Zad_11()
        {
            Console.WriteLine("Podaj komendę, podaj ? by wyświetlić menu");//wypisanie początkowego tekstu
            String komenda;//zmienna string przechowująca podaną programowi komendę
            Double a, b, suma;//deklaracja a, b oraz ich sumy
            a = 0;
            b = 0;
            suma = 0;
            while (1 == 1)//pętla wykouje się w nieskończonośc, chyba że podane zostanie x 
            {
                komenda = Console.ReadLine();//przypisanie popdanej komendy
                if (komenda.Equals("?"))//jezeli podane zostanie "?", wypisane są wszystkie komendy 
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("a-przypisuje wartość a");
                    Console.WriteLine("b-przypisuje wartość b");
                    Console.WriteLine("+-wypisuje sumę a i b");
                    Console.WriteLine("x-kończy działanie programu");
                }
                if (komenda.Equals("a"))//jeżeli podamy a program poprosi nas o podanie wartości a
                {
                    Console.WriteLine("Podaj wartość a");
                    a = Double.Parse(Console.ReadLine());
                }
                if (komenda.Equals("b"))//jeżeli podamy a program poprosi nas o podanie wartości b
                {
                    Console.WriteLine("Podaj wartość b");
                    b = Double.Parse(Console.ReadLine());
                }
                if (komenda.Equals("+"))//jeżeli podamy + program obliczy i wypisznę nam sumę a oraz b
                {
                    suma = a + b;
                    Console.WriteLine("Suma a i b wynosi " + suma);

                }
                if (komenda.Equals("x"))//jeżeli podamy x opuścimy pętlę i program się wyłączy
                {
                    break;
                }
                komenda = String.Empty;//po każdym przejściu pętli zmienna komenda staje się pusta
            }
        }


        class Program
        {

            static void Main(string[] args)
            {
               /* Zadania.Zad_1();*/
                Zadania.Zad_10();
            }
        }
    }
}
