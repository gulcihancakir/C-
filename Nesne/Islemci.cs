using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class Islemci : IComponent
    {

        public void islemciKontrolBasla()
        {
            Console.WriteLine("İşlemci Kontrol ediliyor...");
        }

        public void islemciKontrolBitir()
        {
            Console.WriteLine("İşlemci Kontrol edildi.");
        }

        

        //public void printdetails(int i)
        //{
        //    Console.WriteLine(new String('-', i) + this.GetType().Name +"i7");
        //}

        public void printdetails()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
