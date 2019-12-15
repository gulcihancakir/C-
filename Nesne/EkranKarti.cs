using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class EkranKarti :IComponent
    {
        public void ekranKartiKontrolBasla()
        {
            Console.WriteLine("Ekran karti kontrol ediliyor...");
        }

        public void ekranKartiKontrolBitir()
        {
            Console.WriteLine("Ekran karti kontrol edildi.");
        }

       

       

        public void printdetails(int i)
        {
            Console.WriteLine(new String('-', i) + this.GetType().Name + "4gb");
        }
    }
}
