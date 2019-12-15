using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class SoundCard : IComponent
    {


        public void SoundCardKontrolBasla()
        {
            Console.WriteLine("SoundCard kontrol ediliyor...");
        }
        public void SoundCardKontrolBitir()
        {
            Console.WriteLine("SoundCard kontrol edildi.");

        }
        public void printdetails(int i)
        {
            Console.WriteLine(new String('-', i) + this.GetType().Name);
        }

        public void printdetails()
        {
            throw new NotImplementedException();
        }
    }
}
