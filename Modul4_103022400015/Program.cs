using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePaket k = new KodePaket();
            Console.WriteLine("Kode Paket Basic: " + k.getKodePaket("Basic"));
            Console.WriteLine("Kode Paket Standard: " + k.getKodePaket("Standard"));
            Console.WriteLine("Kode Paket Premium: " + k.getKodePaket("Premium"));
            Console.WriteLine("Kode Paket Unlimited: " + k.getKodePaket("Unlimited"));
            Console.WriteLine("Kode Paket Gaming: " + k.getKodePaket("Gaming"));
            Console.WriteLine("Kode Paket Streaming: " + k.getKodePaket("Streaming"));
            Console.WriteLine("Kode Paket Family: " + k.getKodePaket("Family"));
            Console.WriteLine("Kode Paket Business: " + k.getKodePaket("Business"));
            Console.WriteLine("Kode Paket Student: " + k.getKodePaket("Student"));
            Console.WriteLine("Kode Paket Traveler: " + k.getKodePaket("Traveler"));

            Console.WriteLine(" ");

            MesinKopi m = new MesinKopi();
            m.standBy();
            m.brewing();
            m.stand();
            m.maintenance();
            m.standy();
            m.off();
            m.brewing();
        }
    }
}
