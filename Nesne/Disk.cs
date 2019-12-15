using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class Disk:IComponent
    {
        public void DiskKontrolBasla()
        {
            Console.WriteLine("SSD kontrol edilmeye başlanıyor...");
        }
        public void DiskKontrolBitir()
        {
            Console.WriteLine("SSD kontrol edildi.");
        }

       

        public void printdetails(int i)
        {
            Console.WriteLine(new String('-', i) + this.GetType().Name + "256gb SSD");
        }

        public void printdetails()
        {
            throw new NotImplementedException();
        }
    }
}
