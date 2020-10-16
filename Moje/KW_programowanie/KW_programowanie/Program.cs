using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Xml.Schema;
using Timer = System.Timers.Timer;


/*namespace KW_programowanie
{
    
    class Program
    {
        static void Price(string productNone, out decimal netPrice, out decimal grossPrice, out decimal tax)
        {
            switch (productNone)
            {
                case {} when productNone.StartsWith("zupa"):
                    netPrice = 2.30m;
                    tax = 0.05m;
                    grossPrice = netPrice * (1 + tax);
                    break;
                case {} when productNone.StartsWith("e-book"):
                    netPrice = 35m;
                    tax = 0.05m;
                    grossPrice = netPrice * (1 + tax);
                    break;
                case {} when productNone.StartsWith("ciastka"):
                    netPrice = 8.7m;
                    tax = 0.08m;
                    grossPrice = netPrice * (1 + tax);
                    break;
                case {} when productNone.StartsWith("ciastka"):
                    netPrice = 1.5m;
                    tax = 0.23m;
                    grossPrice = netPrice * (1 + tax);
                    break;
                default:
                    netPrice = 0;
                    tax = 0;
                    grossPrice = 0;
                    break;
            }
        }
        static void Main(string[] args)
        {
            var ProductName = "ciastka - owsiane";
            Price(ProductName,out var netPrice, out var tax,out var grossPrice);
            Console.WriteLine("{0}: netto: {1:C}, brutto: {2:C}, Vat: {3:P1}",ProductName,netPrice,grossPrice,tax);
        }
    }
}*/

/*namespace KW_programowanie
{
    struct PriceData
    {
        public decimal netPrice;
        public decimal grossPrice;
        public decimal tax;

        public PriceData(decimal netPrice, decimal tax, decimal grossPrice = 0)
        {
            this.netPrice = netPrice;
            this.tax = tax;
            this.grossPrice = netPrice * (1 + tax);
        }
    }
    class Program
    {
        static PriceData Price(string productNone)
        {
            
            switch (productNone)
            {
                case {} when productNone.StartsWith("zupa"):
                    return new PriceData(2.3m, 0.05m);
                   
                case {} when productNone.StartsWith("e-book"):
                    return new PriceData(35m, 0.05m);
                   
                case {} when productNone.StartsWith("ciastka"):
                    return new PriceData(8.7m, 0.08m);
                   
                case {} when productNone.StartsWith("ciastka"):
                    return new PriceData(1.5m, 0.23m);
                   
                default:
                    return new PriceData(0, 0);
                  
            }
        }
        static void Main(string[] args)
        {
            var ProductName = "ciastka - owsiane";
            var result = Price(ProductName);
            Console.WriteLine("{0}: netto: {1:C}, brutto: {2:C}, Vat: {3:P1}",ProductName,result.netPrice,result.grossPrice,result.tax);
        }
    }
}*/

/*namespace KW_programowanie
{
    struct PriceData
    {
        public decimal netPrice;
        public decimal grossPrice;
        public decimal tax;

        public PriceData(decimal netPrice, decimal tax, decimal grossPrice = 0)
        {
            this.netPrice = netPrice;
            this.tax = tax;
            this.grossPrice = netPrice * (1 + tax);
        }
    }

    class Program
    {
        static PriceData Price(string productNone) => (productNone) switch
        {

            {} when productNone.StartsWith("zupa") => new PriceData(2.3m, 0.05m),
            {} when productNone.StartsWith("e-book") => new PriceData(35m, 0.05m),
            {} when productNone.StartsWith("ciastka") => new PriceData(8.7m, 0.08m),
            {} when productNone.StartsWith("ciastka") => new PriceData(1.5m, 0.23m),

        };
    

    static void Main(string[] args)
        {
            var ProductName = "ciastka - owsiane";
            var result = Price(ProductName);
            Console.WriteLine("{0}: netto: {1:C}, brutto: {2:C}, Vat: {3:P1}",ProductName,result.netPrice,result.grossPrice,result.tax);
        }
    }
}*/

/*namespace KW_programowanie
{
    class Program
    {
        static double MathFunction(double x) => Math.Sin(x) * Math.Cos(2 * x);
        
        static void Main(string[] args)
        {
            var filename = "data.txt";
            File.WriteAllText(filename,string.Format("#{0,25}{1,25}\n","x","y"));
            
            for (double x = 0; x <= 2 * Math.PI; x += Math.PI / 50)
            {
                File.AppendAllText(filename,string.Format("{0,25}{1,25}\n",x,MathFunction(x)));
            }
        }
    }
}*/

/*namespace KW_programowanie
{
    class Program
    {
        private static int state = 0;

        static string GetState()
        {
            var result = state switch
            {
                0 => "Idzie",
                1 => "Stoi",
                2 => "Biegnie",
                3 => "Dyszy",
                _ => string.Empty,
            };
            state++;

            if (state > 3)
                state = 0;

            return result;
        }

        static void Print(object state,ElapsedEventArgs a)
        {
            Console.WriteLine(GetState());
        }
        static void Main(string[] args)
        {
            var timer = new Timer(TimeSpan.FromSeconds(2).TotalMilliseconds);
            timer.Elapsed += Print;
            timer.Start();
            

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(2000);
            }
            
            Console.ReadLine();
        }
    }
}*/

/*namespace KW_programowanie
{
    class Program
    {
        

       

        
        static void Main(string[] args)
        {
            try
            {
                Method();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.WriteLine("Finaly in Main"); //nie pojawi sie 
            }
        }

        static void Method()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Finaly in Method"); //pojawi sie 
            }
            
        }
    }
}*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////
/*namespace KW_programowanie
{
    class Program
    {
        private static int[] M()
        {
            return new[] {3, 4, 6};
        }
        static void Main(string[] args)
        {
            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] {1, 3, 5, 7, 9};

            // Alternative syntax.
            int[] array3 = {1, 2, 3, 4, 5, 6};

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = {{1, 2, 3}, {4, 5, 6}};
            // Declare a jagged array.

            //Tablica jest kolekcja
            //Definicje,deklacje:
            int[] e1 = new[] {3, 4, 2}; //standardowa definicja
            int[] e2 = {1, 2, 3}; // okrojona 
            var e3 = new int[] {1, 2, 3}; //var zamiast int 
            var e4 = new[] {1, 2, 3}; //okrojona z var
            //taka różnica że nawiasy przy typie danych
            
            //Tablica poszarpana
            int[][] t =new int[podajemy tylko to][];

            //Metody:
            var z = e4.Length; // dlugosc tablicy
            var z2 = e4.Rank; //podaje ilsoc wymiarow
            var z3 = e4.GetLength(0); //Podaje ilosc w wymiarze 
            /*Array.Clear();
            Array.Copy();
            Array.ForEach();#1#
            String.Format()
            String.Join()
              string.builder            
            var z = $"asdasd {obliczenia,lub zmienne} dsfsdf" - string interpulejszyn
                        var z = $"sadasd {t} asdas";
            var k = @"dasd\nasdsf
            sdd" - surowy string nie uzględnia znaków specjalnych, jest wielelinijowy 
            
          
            
            /*int[,] dwu = new int[5, 5]; //dwuymiarowa tablica
            var trzy = new int[5, 6, 7]; //prosciej
            
            
            
            
            
            Console.WriteLine("0: {0} ",trzy.GetLength(0));
            Console.WriteLine("1: {0} ",trzy.GetLength(1));
            Console.WriteLine("2: {0} ",trzy.GetLength(2));#1#

            // tablica[0][0] c++
            // tablica[0,0] c#

            /*
            for (int i = 0; i < trzy.GetLength(0); i++)
            {
                for (int j = 0; j < trzy.GetLength(1); j++)
                {
                    for (int k = 0; k < trzy.GetLength(2); k++)
                    {
                        Console.Write("{0} ", trzy[i, j, k]);
                    }
                }
            }

            string s = Console.ReadLine();
            try
            {
                int size = int.Parse(s);
                long[] row = new long [size];
                Console.WriteLine(row.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            #1#

            foreach (var i in e1)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}*/

/*namespace KW_programowanie
{
    class Program
    {
        private static int[] M()
        {
            return new[] {3, 4, 6}; //Zwraca jeden elemtent ale tym elementem jest tablica
        }

        private static void M2(int[] tab)
        {
            tab[0] = 10; //tryb referencyjny
        }

        private static int[] M3(int[] tab)
        {
            return tab;
        }
        static void Main(string[] args) 
        {

            var t1 = M();
            foreach (var i in t1)
            {
                Console.WriteLine(i);
            }
            M2(t1);
            Console.WriteLine(t1[0]);

            var tablica1 = M3(new int[] {1, 2, 3});
            Console.WriteLine(tablica1[0]);

        }
    }
}*/

/*//GENERATOR LICZ LOSOWYCH
namespace KW_programowanie
{
    class Program
    {
        private static string[] Metod2(int size)
        {
            string[] sentences = new string[size];
            for (int i = 0; i < size; i++)
            {
                sentences[i] = GenerateRandomSentences();
            }

            return sentences;
        }
        
        static void Main(string[] args)
        {
            var sentences = 10;
            var tab = Metod2(sentences);
            //foreach (var s in tab)
            
                Console.WriteLine(string.Join(Environment.NewLine,tab)); //funkcja pojdzie na kazdym srodowisku /n
            
        }
        static Random ran = new Random();

        string[] tab1 = {"pies ", "Kot ", "dziewczyna ", "chlopak ", "lozko ", "stal ", "basen ", "kino "};
        string[] tab2 = {"je ","widzi ","biega ","spi ","czyta ","pisze ","lata "};
        string[] tab3 = {"na ","pod ","obok ","w ","za ","przed "};

        private static string GenerateRandomSentences()
        {

            /*var z1 = tab1[ran.Next(tab1.Length)];
            var z2 = tab1[ran.Next(tab2.Length)];
            var z3 = tab1[ran.Next(tab3.Length)];
            var z4 = tab1[ran.Next(tab1.Length)];#1#
            // return $" {z1} {z2} {z3} {z4}.";

            string[] koleckja = new string[]{
                tab1[ran.Next(tab1.Length)],
                tab2[ran.Next(tab2.Length)],
                tab3[ran.Next(tab3.Length)],
                tab1[ran.Next(tab1.Length)]};

            return $"{string.Join(" ", koleckja)}.";
            // return string.Format("{0} {1} {2} {3}." ,tab1[ran.Next(tab1.Length)], tab2[ran.Next(tab2.Length)],tab3[ran.Next(tab3.Length)],tab1[ran.Next(tab1.Length)]);
        }
    }
} */
/*namespace KW_programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            //tablica poszarpana czyli tablica zawierajaca tablice 

            int[][][] tab = new int[10][][];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = new int[4 + i][]; //!!!!!!

                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = new int[j + 8];
                }
            }

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    for (int k = 0; k < tab[i][j].Length; k++)
                    {
                        tab[i][j][k] = i + j + k;
                    }
                }
            }

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    for (int k = 0; k < tab[i][j].Length; k++)
                    {
                        Console.WriteLine(tab[i][j][k]);
                    }
                }
            }
        }
    }
}*/

/*
namespace KW_programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            //string z = "";

            //var t = new Stopwatch();
            //t.Start();

            var sw = Stopwatch.StartNew();
            string z = string.Empty; //pusty string
            
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    z += "string";
                }
            }
            
            Console.WriteLine(sw.Elapsed);
            
            sw.Restart();
            
            var sb = new StringBuilder();
            
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    sb.Append("string");
                }
            }

            string r = sb.ToString();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            
            //Dlaczego tak długo ? 
            //+= oraz $ - do niczego bo jest tworzona nowa instancja obiektu string
            // lepszy string.builder
      
        }
    }
}*/

/*namespace KW_programowanie
{
    class Program
    {
        /*static void Main(string[] args)
        {
            var names = GetRandomNames(4); //?? new string[0];
          foreach (var item in names)
          {
              Console.WriteLine(item);
          }
        }

        private static string[] GetRandomNames(ushort i)
        {
            return new[] {"Ala", "Grzegorz", "Michal", "Sabina", "Dawid", "Tomasz", "Jabuk"}
                .OrderBy(x => Guid.NewGuid())
                .Take(i) 
                .ToArray(); //do stringa
        }#1#
        /*static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            var names = GetRandomNames(4);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static string[] GetRandomNames(ushort i)
        {
            var names = new[] {"Ala", "Grzegorz", "Michal", "Sabina", "Dawid", "Tomasz", "Jabuk"};

            if (i > names.Length)
            {
                return null; //jesli przekroczymy zakres tablicy czyli 4 to program sie zatrzymie
            }
            
            var resoult = new string[i]; // tablica string 4
            
            Array.Sort(names,ArraySort); //sortowanie

            for (int j = 0; j < i; j++)
            {
                resoult[j] = names[j];
            }

            return resoult;
        }

        private static int ArraySort(string item1, string item2)
        {
            return rnd.Next(-5,6);
        }#1#
    }
}*/


/*namespace bleble
{
    class Hehe
    {
        static void Main(string[] args)
        {
            var matrix = GetRandomMatrix(); //Generowanie tablica matrix
            var resoult = GetMatrixStatistics(matrix); //Liczenie Wartosci: dodatnie,ujemne,zero

            Print(matrix); //Wyswietlenie tablicy
            
            
            //wyswietlenie wynikow
            Console.WriteLine(resoult.ToString());
            //Lub
            //Console.WriteLine(resoult.PositiveCount); 
           // Console.WriteLine(resoult.NegativeCount);
          //  Console.WriteLine(resoult.ZeroCount);
        }
        static Random rnd = new Random(); //Statyczne liczby losowe dla klas
        private static int[,] GetRandomMatrix()
        {
            int[,] matrix = new int[3,4]; //macierz 3 wierzsze na 4 kolumny
            for (int i = 0; i < matrix.GetLength(0); i++) //pozyskanie dlugosci pierwszego wymiaru
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //pozyskanie dlugosc drugiego wymiaru
                {
                    matrix[i,j] = rnd.Next(-5,11); //wypelnienie liczbami losowymi
                }
            }

            return matrix; //zwracanie tablicy 
        }

        private static MatrixStacisticsResoult GetMatrixStatistics(int[,] matrix) // funkcja zwracajaca strukture i przujmujaca tablice dwu. typu int 
        {
            MatrixStacisticsResoult resoult = new MatrixStacisticsResoult(); //stworzenie obkietu skrutktury

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        resoult.NegativeCount++;
                    }
                    else if (matrix[i,j] > 0)
                    {
                        resoult.PositiveCount++;
                    }
                    
                }
            }

            resoult.ZeroCount = matrix.Length - resoult.PositiveCount - resoult.NegativeCount; //wyliczanie zera 
            
            return resoult; //zwracanie struktury
        }

        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]); //wyswietalnie macierzy kazda liczba na 4 pozycji 
                }

                Console.WriteLine();
            }
        }

        struct MatrixStacisticsResoult
        {
            public int PositiveCount;
            public int NegativeCount;
            public int ZeroCount;

            public override string ToString()
            {
                return $"{nameof(PositiveCount)}: {PositiveCount}, {nameof(NegativeCount)}: {NegativeCount}, {nameof(ZeroCount)}: {ZeroCount}";
            }
        }
    }
}*/

/*namespace bleble
{
    class Hehe
    {
        static void Main(string[] args)
        {
            var matrix = GetRandomMatrix(); //Generowanie tablica matrix
            var resoult = GetMatrixStatistics(matrix); //Liczenie Wartosci: dodatnie,ujemne,zero

            Print(matrix); //Wyswietlenie tablicy

            //wyswietlenie wynikow
            Console.WriteLine(resoult.PositiveCount); 
            Console.WriteLine(resoult.NegativeCount);
            Console.WriteLine(resoult.ZeroCount);
        }
        static Random rnd = new Random(); //Statyczne liczby losowe dla klas
        private static int[,] GetRandomMatrix()
        {
            int[,] matrix = new int[3,4]; //macierz 3 wierzsze na 4 kolumny
            for (int i = 0; i < matrix.GetLength(0); i++) //pozyskanie dlugosci pierwszego wymiaru
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //pozyskanie dlugosc drugiego wymiaru
                {
                    matrix[i,j] = rnd.Next(-5,11); //wypelnienie liczbami losowymi
                }
            }

            return matrix; //zwracanie tablicy 
        }

        private static MatrixStacisticsResoult GetMatrixStatistics(int[,] matrix) // funkcja zwracajaca strukture i przujmujaca tablice dwu. typu int 
        {
            MatrixStacisticsResoult resoult = new MatrixStacisticsResoult(); //stworzenie obkietu skrutktury

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        resoult.NegativeCount++;
                    }
                    else if (matrix[i,j] > 0)
                    {
                        resoult.PositiveCount++;
                    }
                    
                }
            }

            resoult.ZeroCount = matrix.Length - resoult.PositiveCount - resoult.NegativeCount; //wyliczanie zera 
            
            return resoult; //zwracanie struktury
        }

        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]); //wyswietalnie macierzy kazda liczba na 4 pozycji 
                }

                Console.WriteLine();
            }
        }

        struct MatrixStacisticsResoult
        {
            public int PositiveCount;
            public int NegativeCount;
            public int ZeroCount;
        }
    }
}*/

namespace kosiarka
{
    public class Program
    {
        class Pozycja
        {
            public int X;
            public int Y;
            public int Penetly;

         
        }
        /*
        struct Pozycja
        {
            
        }
        */

        static void Main(string[] args)
        {
            var dzialka = CreatorFild();
            for (;;)
            {
                CutTheGrass(dzialka); //kosi dzialke na punktach pozycji
                var emptyDzialka = CheckEmpty(dzialka); //srpawdz ile pustych
                if (emptyDzialka == true) break;
            }

            Print(dzialka);
        }

        private static bool CheckEmpty(string[,] dzialka)
        {
            var iloscE = 0;
            for (int i = 0; i < dzialka.GetLength(0); i++)
            {
                for (int j = 0; j < dzialka.GetLength(1); j++)
                {
                    if (dzialka[i, j] == "e")
                    {
                        iloscE++;
                        if (iloscE == dzialka.Length)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        static Pozycja pozycja = new Pozycja();
        static Random rnd = new Random();

        private static void CutTheGrass(string[,] dzialka)
        {
            var w = dzialka.GetLength(0);
            var z = dzialka.GetLength(1);

            pozycja.X = rnd.Next(0,w);
            pozycja.Y = rnd.Next(0,z);


            if (dzialka[pozycja.X, pozycja.Y] == "e")
            {
                pozycja.Penetly++;
            }
            else
            {
                dzialka[pozycja.X, pozycja.Y] = "e";
            }


            Console.Write(pozycja.X);
            Console.WriteLine(pozycja.Y);
        }

        private static void Print(string[,] dzialka)
        {
            for (int i = 0; i < dzialka.GetLength(0); i++)
            {
                for (int j = 0; j < dzialka.GetLength(1); j++)
                {
                    Console.Write("{0,2}", dzialka[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Faule: {0}", pozycja.Penetly);
        }

        private static string[,] CreatorFild()
        {
            string[,] fild = new string[10, 10];
            for (int i = 0; i < fild.GetLength(0); i++)
            {
                for (int j = 0; j < fild.GetLength(1); j++)
                {
                    Console.WriteLine("{0},{1}", i, j);
                    fild[i, j] = "g";
                }
            }

            return fild;
        }
    }
}