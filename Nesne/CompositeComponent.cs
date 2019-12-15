using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Nesne
{
    class CompositeComponent:IComponent
    {
        

        List<IComponent> components; 
        //ArrayList components = new ArrayList();

        IComponent name;
        string description;
        public CompositeComponent(IComponent name,string description) 
        {
            this.description = description;
           this.name=  name;
            components= new List<IComponent>();

        }



        public void add(IComponent component)
        {
            
            components.Add(component);
            
            

        }

        public void printdetails(int i)
        {
            Console.WriteLine(new String('-', i) + "+" + name + " " +description);
            //name.printdetails(i);
            foreach (var number in components)
            {
                number.printdetails(i + 2);
                
                
            }
            Console.WriteLine("ürün paketleniyor...");
        }
    }
}
