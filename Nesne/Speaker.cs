using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class Speaker : IComponent
    {
       

        public void printdetails(int i)
        {
            Console.WriteLine(new String('-', i) + this.GetType().Name  );
           
        }

        public void speakerKontrolBasla()
        {
            Console.WriteLine("Speaker kontrol ediliyor...");
        }

        
        public void speakerKontrolBitir()
        {
            Console.WriteLine("Speaker kontrol edildi.");
        }
    }
}
