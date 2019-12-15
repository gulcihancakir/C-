using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class RAM : IComponent
    {
        
        public void ramKontrolBasla()
        {
            Console.WriteLine("Ram kontrol ediliyor...");
        }
        public void ramKontrolBitir()
        {
            Console.WriteLine("Ram kontrol edildi.");

        }
        
       
       

        

        public void printdetails(int i)
        {
            Console.WriteLine(new String('-', i) + this.GetType().Name + "4 gb");
        }
    }
}
