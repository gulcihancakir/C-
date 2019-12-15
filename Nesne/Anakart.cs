using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class Anakart:IComponent
    {

        public void anakartKontrolBasla()
        {
            Console.WriteLine("Anakart kontrol ediliyor...");
        }

        public void anakartKontrolBitir()
        {
            Console.WriteLine("Anakart kontrol edildi.");
        }

       

        //public void printdetails(int i)
        //{
        //    Console.WriteLine(new String('-', i) + this.GetType().Name + "MSI");
        //}

        public void printdetails()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
