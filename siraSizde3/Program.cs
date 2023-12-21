using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siraSizde3
{
    public interface IOkunabilir
    {
        void Oku();
    }

    
    public class Kitap : IOkunabilir
    {
        public string KitapAdi { get; set; }

        public Kitap(string kitapAdi)
        {
            KitapAdi = kitapAdi;
        }

        public void Oku()
        {
            Console.WriteLine(KitapAdi+ "adlı kitap okunuyor");
        }
    }

    
    public class Dergi : IOkunabilir
    {
        public string DergiAdi { get; set; }

        public Dergi(string dergiAdi)
        {
            DergiAdi = dergiAdi;
        }

        public void Oku()
        {
            Console.WriteLine(DergiAdi + "adlı dergi okunuyor");
        }
    }

    
    public class Ansiklopedi : IOkunabilir
    {
        public string AnsiklopediAdi { get; set; }

        public Ansiklopedi(string ansiklopediAdi)
        {
            AnsiklopediAdi = ansiklopediAdi;
        }

        public void Oku()
        {
            Console.WriteLine(AnsiklopediAdi + "adlı ansiklopedi okunuyor");
        }
    }

    class Program
    {
        static void Main()
        {
            
            Kitap kitap = new Kitap("Leventin kitabı ");
            Dergi dergi = new Dergi("Efe'nin dergisi ");
            Ansiklopedi ansiklopedi = new Ansiklopedi("Kadir'in ansiklopedisi ");

            kitap.Oku();
            dergi.Oku();
            ansiklopedi.Oku();
        }
    }
}