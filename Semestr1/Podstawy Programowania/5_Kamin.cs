using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _5_Kamin
{
    class Program
    {
        static void Main(string[] args)
        {
            //polecenie 1
            /*  Int32 size, range,change; //deklaracja zmiennych wielkości tabeli, zakresu liczb, zmiennej pomocniczej w zamianie
              bool ordered;//wartość bool poprawności posortowania
              ordered = true;
              Random rand = new Random(); //stworzenie nowej instancji klasy Random
              Console.WriteLine("Podaj rozmiar tablicy");
              size = Int32.Parse(Console.ReadLine()); //ustawienie rozmiaru tablicy
              Int32 [] tab = new Int32[size];
              range = 5 * size; //ustawienie zasięgu liczb na 5 krotność rozmiaru
              for (Int32 i = 0; i < size; i++)
              {
                  tab[i] = rand.Next(0, range); //przypisanie każdemu elementowi losowej wartości 
              }

              Console.WriteLine("");
              Console.WriteLine("Tabela nieposortowana"); 
              Console.WriteLine("");

              for (Int32 i = 0; i < size; i++)
              {
                  Console.WriteLine("Element {0} tabeli jest równy {1}", i, tab[i]); //wypisanie liczb nie posortowanych
              }*/

            //Polecenie 2
            /*
                        for (Int32 n = 0; n < size-1; n++)  
                        {
                            for (Int32 i = 0; i < size-1; i++)
                            {
                                if (tab[i] > tab[i + 1])  //sprawdzenie czy wartości komórki i jest większy od komórki i+1
                                {
                                    change = tab[i];
                                    tab[i] = tab[i + 1]; //jeżeli tak, to zamieniamy miejscami wartości komórek, przy pomocy zmiennej pomocniczej change
                                    tab[i + 1] = change;

                                };


                            }

                        }

                        Console.WriteLine("");
                        Console.WriteLine("Tabela posortowana");
                        Console.WriteLine("");

                        for (Int32  i=0;i<size;i++)  
                        {
                            Console.WriteLine("Element {0} tabeli jest równy {1}",i,tab[i]);//wypisanie posortowanej tablicy
                        }


                        for (Int32 i = 0; i < size-1; i++) 
                        { 
                            if (tab[i] <= tab[i + 1])   //sprawdzenie czy tablica jest posortowana
                            {
                                ordered = true;
                            }
                            else 
                            {
                                ordered = false;
                                break; 
                            }
                        }

                        if (ordered == true) { Console.WriteLine("Tablica jest posortowana"); }
                        else { Console.WriteLine("Tablica nie jest posortowana"); }

            Console.ReadKey(true);*/

            //Polecenie 3 -bubble
            /* Int32 size, range, change; //deklaracja zmiennych wielkości tabeli, zakresu liczb, zmiennej pomocniczej w zamianie
             bool ordered;//wartość bool poprawności posortowania
             ordered = true;
             Random rand = new Random(); //stworzenie nowej instancji klasy Random
             Console.WriteLine("Podaj rozmiar tablicy");
             size = Int32.Parse(Console.ReadLine()); //ustawienie rozmiaru tablicy
             Int32[] tab = new Int32[size];
             range = 5 * size; //ustawienie zasięgu liczb na 5 krotność rozmiaru
             Stopwatch watch = new Stopwatch();

             for (Int32 i = 0; i < size; i++)
             {
                 tab[i] = rand.Next(0, range); //przypisanie każdemu elementowi losowej wartości 
             }


             watch.Start();
             for (Int32 n = 0; n < size - 1; n++)
             {
                 for (Int32 i = 0; i < size - 1; i++)
                 {
                     if (tab[i] > tab[i + 1])  //sprawdzenie czy wartości komórki i jest większy od komórki i+1
                     {
                         change = tab[i];
                         tab[i] = tab[i + 1]; //jeżeli tak, to zamieniamy miejscami wartości komórek, przy pomocy zmiennej pomocniczej change
                         tab[i + 1] = change;

                     };


                 }

             }

             watch.Stop();
             Console.WriteLine("Sortowanie tablicy rozmiaru {0} zajeło {1}", size, watch.Elapsed);

             for (Int32 i = 0; i < size - 1; i++)
             {
                 if (tab[i] <= tab[i + 1])   //sprawdzenie czy tablica jest posortowana
                 {
                     ordered = true;
                 }
                 else
                 {
                     ordered = false;
                     break;
                 }
             }

            *//* for (Int32 i = 0; i < size; i++)
             {
                 Console.WriteLine("Element {0} tablicy jest równy {1}", i, tab[i]);//wypisanie posortowanej tablicy
             }*//*

             if (ordered == true) { Console.WriteLine("Tablica jest posortowana"); }
             else { Console.WriteLine("Tablica nie jest posortowana"); }

             Console.ReadKey(true);*/

            //sortowanie to  ma złożoność n^2

            //Polecenie 5 -Gnome

            /*  Int32 size, range, change,position; //deklaracja zmiennych wielkości tabeli, zakresu liczb, zmiennej [change] pomocniczej  w zamianie, i pozycji gnoma
              bool ordered;//wartość bool poprawności posortowania
              ordered = true;
              position = 0;
              Random rand = new Random(); //stworzenie nowej instancji klasy Random
              Console.WriteLine("Podaj rozmiar tablicy");
              size = Int32.Parse(Console.ReadLine()); //ustawienie rozmiaru tablicy
              Int32[] tab = new Int32[size];
              range = 5 * size; //ustawienie zasięgu liczb na 5 krotność rozmiaru
              Stopwatch watch = new Stopwatch();

              for (Int32 i = 0; i < size; i++)
              {
                  tab[i] = rand.Next(0, range); //przypisanie każdemu elementowi losowej wartości 
              }


              watch.Start();

              while (position < size - 1)
              {
                  if(tab[position] > tab[position + 1])//sprawdzenie czy element w obecnej pozycji nie jest wiekszy od elementu w następnej komórce
                  {
                      change = tab[position];
                      tab[position] = tab[position + 1];//zamiana miejscami elementów
                      tab[position + 1] = change;
                      if (position > 0) //cofnięcie czapki gnoma w razie niepoprawnego posortowania
                      {
                          position--;
                      }

                  }
                  else { position++; } //przesunięcie czapki gnoma o jedną pozycję
              }

              watch.Stop();
              Console.WriteLine("Sortowanie tablicy rozmiaru {0} zajeło {1}", size, watch.Elapsed);

              for (Int32 i = 0; i < size - 1; i++)
              {
                  if (tab[i] <= tab[i + 1])   //sprawdzenie czy tablica jest posortowana
                  {
                      ordered = true;
                  }
                  else
                  {
                      ordered = false;
                      break;
                  }
              }

              *//*for (Int32 i = 0; i < size; i++)
              {
                  Console.WriteLine("Element {0} tablicy jest równy {1}", i, tab[i]);//wypisanie posortowanej tablicy
              }*//*

              if (ordered == true) { Console.WriteLine("Tablica jest posortowana"); }
              else { Console.WriteLine("Tablica nie jest posortowana"); }

              Console.ReadKey(true);*/
            //Polecenie 7 - wybierania
            /*  Int32 size, range, change; //deklaracja zmiennych wielkości tabeli, zakresu liczb, zmiennej pomocniczej w zamianie
              bool ordered;//wartość bool poprawności posortowania
              ordered = true;
              Random rand = new Random(); //stworzenie nowej instancji klasy Random
              Console.WriteLine("Podaj rozmiar tablicy");
              size = Int32.Parse(Console.ReadLine()); //ustawienie rozmiaru tablicy
              Int32[] tab = new Int32[size];
              range = 5 * size; //ustawienie zasięgu liczb na 5 krotność rozmiaru
              Stopwatch watch = new Stopwatch();

              for (Int32 i = 0; i < size; i++)
              {
                  tab[i] = rand.Next(0, range); //przypisanie każdemu elementowi losowej wartości 
              }


              watch.Start();

              for (Int32 n = 0; n < size; n++)
              {
                  for (Int32 i = 0; i < size; i++)
                  {
                      if (tab[i] > tab[n])  //sortowanie wybierania przez zamianę pozycji [i] z pozycją [n]
                      {
                          change = tab[i];
                          tab[i] = tab[n];
                          tab[n] = change;
                      }
                  }
              }


              watch.Stop();
              Console.WriteLine("Sortowanie tablicy rozmiaru {0} zajeło {1}", size, watch.Elapsed);

              for (Int32 i = 0; i < size - 1; i++)
              {
                  if (tab[i] <= tab[i + 1])   //sprawdzenie czy tablica jest posortowana
                  {
                      ordered = true;
                  }
                  else
                  {
                      ordered = false;
                      break;
                  }
              }

              if (ordered == true) { Console.WriteLine("Tablica jest posortowana"); }
              else { Console.WriteLine("Tablica nie jest posortowana"); }
  */
            /*Console.ReadKey(true);*/
            //Polecenie 9 -bogosort 
            Int32 size, range, change, random,times; //deklaracja zmiennych wielkości tabeli, zakresu liczb, zmiennej pomocniczej w zamianie change, oraz losowej pozycji do zamiany random
            bool ordered, gotowe;//wartość bool poprawności posortowania dla funckji sprawadzającej i dla bogosorta
            ordered = true;
            times = 0;


            Random rand = new Random(); //stworzenie nowej instancji klasy Random
            Console.WriteLine("Podaj rozmiar tablicy");
            size = Int32.Parse(Console.ReadLine()); //ustawienie rozmiaru tablicy
            Int32[] tab = new Int32[size];
            range = 5 * size; //ustawienie zasięgu liczb na 5 krotność rozmiaru
            Stopwatch watch = new Stopwatch();

            for (Int32 i = 0; i < size; i++)
            {
                tab[i] = rand.Next(0, range); //przypisanie każdemu elementowi losowej wartości od 0 do wartości range
            }



            while (true)  //funkcja wykonuje do momentu wywołania break;
            {
                times++;
                gotowe = true;
                for (Int32 i = 0; i < size-1; i++)  //sprawdzenie czy tablica jest posortowana
                {
                    if (tab[i] > tab[i + 1])
                    {
                        gotowe = false;
                        break;
                    }
                }
                if (gotowe == true) { break; }  //jeżeli tablica jest posortowana, kończy działanie funkcji
                for (Int32 i = size-1; i > 0; i--)//zamiana każdego elementu tablicy, z innym losowym elementem 
                {
                    change = tab[i];
                    random = rand.Next(0, size - 1);//losowanie elementu do zamiany
                    tab[i] = tab[random];
                    tab[random] = change;

                }
            }



            for (Int32 i = 0; i < size; i++)
            {
                Console.WriteLine("Element {0} tablicy jest równy {1}", i, tab[i]);//wypisanie posortowanej tablicy
            }
            for (Int32 i = 0; i < size - 1; i++)
            {
                if (tab[i] <= tab[i + 1])   //sprawdzenie czy tablica jest posortowana
                {
                    ordered = true;
                }
                else
                {
                    ordered = false;
                    break;
                }
            }

            if (ordered == true) { Console.WriteLine("Tablica jest posortowana"); }
            else { Console.WriteLine("Tablica nie jest posortowana"); }
            Console.WriteLine("Tablica została posortowana po {0} iteracjach funkcji", times);//wypisuje ilość iteracji funkcji sortującej wykonanych podczas sortowania
            Console.ReadKey(true);


        }
    }
}
