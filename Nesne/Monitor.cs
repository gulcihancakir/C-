using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class Monitor : IComponent
    {
        public void printDetails()
        {
            Console.WriteLine("Casper");
        }

        public void printdetails(int i)
        {
            //Console.WriteLine("Casper");
            Console.WriteLine(new String('-', i) + this.GetType().Name +"Casper");
        }
    }
}
