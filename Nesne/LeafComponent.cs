using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
     class LeafComponent : IComponent
    {
        IComponent name;
        string description;
        public LeafComponent(IComponent name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void printDetails()
        {
            
            //Console.WriteLine("----" + this.GetType().Name);
        

        }

        public void printdetails(int i)
        {
            

            Console.WriteLine(new String('-', i) + " " + name + " " +description);
        }

        public void printdetails()
        {
            Console.WriteLine( name + " " + description);
        }
    }
}
