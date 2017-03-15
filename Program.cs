using System;
using System.Text;

namespace Zaliczenie
{
    class Program
    {
        static public void zad1(string input)
        {
            string output = "",mid1 = "",mid2 = "";
            int i = 0; bool begin = false,end = false;
            foreach (char c in input)
            {
                if (c != ' ' && begin == false)
                {
                    mid1 += c;
                    begin = true;
                }
                else if(begin == true)
                    mid1 += c;  
            }
            for (int ix = mid1.Length - 1; ix >= 0; ix--)
            {
                if (mid1[ix] != ' ' && end == false)
                {
                    mid2 += mid1[ix];
                    end = true;
                }
                else if(end == true)
                    mid2 += mid1[ix];
            }
            for (int iz = mid2.Length -1; iz >=0;iz--)
            {
                output += mid2[iz];
            }
            Console.WriteLine("Wyczyszczony tekst to : -->" + output + "<--");
        }
        static public void zad2(string input)
        {
            
            string output = "";
            bool wasSpace = false;
            foreach (char c in input)
            {
                if (c != ' ' || !wasSpace)
                    output += c;
                wasSpace = (c == ' ');
                
            }
            Console.WriteLine("Wyczyszczony tekst to : -->" + output + "<--");
        }
        static public string getString()
        {
            string pol = "Wpisz zdanie i wybierz formatowanie\n";
            Console.WriteLine(pol);
            string text = "";
            text = Console.ReadLine();
            return text;
        }
        static public bool showMenu(string txt)
        {
            bool ret = false;
            int sel_men;
            string menu = "Wcisnij 1, aby usunac wszystkie poczatkowe i koncowe spacje,\nWcisnij 2, aby zamienic wielokrotne spacje na pojedyncze\nWcisnij 0, aby zakonczyc.";
            Console.WriteLine(menu);
            sel_men = int.Parse(Console.ReadLine());
            if (sel_men == 1)
                zad1(txt);
            else if (sel_men == 2)
                zad2(txt);
            else if (sel_men == 9)
                txt = getString();
            else if (sel_men == 0)
            {
                ret = true;
                //return ret;
            }
            return ret;
        }
        static void Main(string[] args)
        {
            string txt = "";
            bool ret = false;
            txt = getString();
            while (ret != true)
            {
                ret = showMenu(txt);
            }
            if (ret == true)
            {
                Console.WriteLine("Kliknij aby zakończyć");
                Console.ReadKey();
            }
        }
        
        
    }
}
