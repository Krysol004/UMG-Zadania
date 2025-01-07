using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Kamin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polecenie 1
            /* Int32 i;
             Int32[] tab1 = new Int32[20];
             Random rand = new Random();

             for (i = 0;i < 20; i++)
             {
                 tab1[i] = rand.Next(0,9);//losowanie liczby
                 Console.WriteLine("Element " + i + " tabeli jest równy " + tab1[i]);//Wypisywanie wartości tabeli
             };
             Console.ReadKey(true);*/

            //Polecenie 2
            /*Int32 i,tab_length;
            Int32[] tab1 = new Int32[10];
           tab_length = tab1.Length - 1;
           for (i = 0;i < 10; i++)
            {
                tab1[i] = (tab_length-i);
                Console.WriteLine("Element " + i + " tabeli jest równy " + tab1[i]);
            };
            Console.ReadKey(true);*/
            //Polecenie 3
            /* Int32 a, b;
             for (a = 0; a <= 3; a++) //pętla z zmienną a wykona się 4 krotnie
             {
                 Console.Write(a + ": ");
                 for (b = 0; b <= 2; b++) //pętla z zmienną b wykona się 4*3=12 krotnie, z każdym wykonaniem pętli pierwszej wykona się 3 krotnie pętla druga
                 {
                     Console.Write(b + " ");
                 };
                 Console.WriteLine();
             };
             Console.ReadKey(true);//Przejście funkcji to: 4 krotnie (pętla 1, 3 krotnie pętla 2)
 */
            //Polecenie 4
            /* Int32[,] tab1 = new Int32[4, 6]; //deklaracja tabel 4x6
             Random rand = new Random();
             Int32 a, b;
             for (a = 0; a < 4; a++)
             {
                 for (b = 0; b < 6; b++) //przypisywanie wartości danej komórce tabeli
                 {
                     tab1[a, b] = rand.Next(100, 999);
                     Console.Write(tab1[a, b] + " ");
                 };
                 Console.WriteLine();
             };
             Console.ReadKey(true);*/
            //Polecenie 5
            Int32[,] tab1 = new Int32[4, 6]; //deklaracja tabeli 4x6
            Random rand = new Random();
            Int32 a, b, sum, max, max_x, max_y, min, min_x, min_y; //deklaracja zmiennych
            sum = 0;
            max = 0;
            max_x = 0;
            max_y = 0;
            min_y = 0;
            min_x = 0;
            for (a = 0; a < 4; a++)
            {
                for (b = 0; b < 6; b++) //przypisywanie wartości danej komórce tabeli
                {
                    tab1[a, b] = rand.Next(100, 999);
                    sum += tab1[a, b];
                    if (max < tab1[a, b]) // jeżeli liczba [max] jest mniejsza od komórki na której jeteśmy to ustaw [max] jako wartośc tej komórki
                    {
                        max = tab1[a, b];
                        max_x = a + 1;
                        max_y = b + 1;

                    };

                    Console.Write(tab1[a, b] + " "); //wypisanie wartośći danej komórki
                };
                Console.WriteLine(); //break line
            };
            min = tab1[1, 1];//przypisanie do [min] wartości komórki[1,1]
            for (a = 0; a < 4; a++)
            {  //pętla przechodząca po każdej komórce tabeli i sprawdzająca czy jest ona mniejsza od [min]
                for (b = 0; b < 6; b++)
                {
                    if (min > tab1[a, b])
                    {
                        min = tab1[a, b];
                        min_x = a + 1;
                        min_y = b + 1;
                    };
                };
            };
            Console.WriteLine("Suma wszyskich pól to {0}", sum);//Wypisanie sumy

            Console.WriteLine("Największa liczba występująca w tabeli to {0} która znajduje się na pozycji ({1}, {2})", max, max_x, max_y);//Wypisanie wartości [max] i jej pozycji

            Console.WriteLine("Najmniejsza liczba występująca w tabeli to {0} która znajduje się na pozycji ({1}, {2})", min, min_x, min_y);//Wypisane wartości [min] i jej pozycji

            Int32[,] tab2 = new Int32[6, 4];
            for (a = 0; a < 6; a++) //transpozycja i wypisanie [tab2]
            {
                for (b = 0; b < 4; b++)
                {
                    tab2[a, b] = tab1[b, a]; //transpozycja komórek [b,a] tabeli 1 na komórki [a,b] tabeli 2
                    Console.Write(tab1[b, a] + " ");//wypisanie wartości komórki
                };
                Console.WriteLine();//break line
            };
            Console.ReadKey(true);
            //Polecenie 6
            /* Int32[,] tab1 = new Int32[10, 10];
             Random rand = new Random();
             Int32 a,b;
             for (a = 0; a < 10;a++) 
             {
                 for (b = 0; b < 10; b++)
                 {
                     tab1[a, b] = rand.Next(0, 999);
                     if (tab1[a, b] >= 100 && tab1[a, b] <= 999)
                     {
                         Console.Write(tab1[a, b] + " ");//wypisanie wartości komórek jeżeli jest 3 cyfrowa
                     }
                     else if (tab1[a, b] >= 10 && tab1[a, b] <= 99) //wypisanie wartości komórek jeżeli jest 2 cyfrowa
                     {
                         Console.Write(tab1[a, b] + "  ");
                     }
                     else if (tab1[a, b] >= 0 && tab1[a, b] <= 9) //wypisanie wartości komórek jeżeli jest 1 cyfrowa
                     {
                         Console.Write(tab1[a, b] + "   ");
                     };

                 };
                 Console.WriteLine();

             };
             Console.ReadKey(true); */




        }  
    }
}
