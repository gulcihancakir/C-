using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class Monitor : IComponent
    {

       

        //public void printdetails(int i)
        //{
        //    Console.WriteLine(new String('-', i) + this.GetType().Name +"Casper");
        //}

        public void printdetails()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
