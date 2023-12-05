using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParametersSayiIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiIslemleri si= new SayiIslemleri();
            //int toplam = si.Topla(5,10,15);
            int toplam = si.Topla(sayi2: 10, sayi3: 15, sayi1: 5);
            Console.WriteLine("toplam:{0}",toplam);
        }
    }
    class SayiIslemleri
    {
        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
    }
}
