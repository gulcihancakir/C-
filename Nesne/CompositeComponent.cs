using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Nesne
{
    class CompositeComponent:IComponent
    {
        

        

        List<IComponent> subcomponents;
        //ArrayList components = new ArrayList();

        IComponent name;
        string description;
        public CompositeComponent(IComponent name,string description) 
        {
            this.description = description;
           this.name=  name;
            subcomponents = new List<IComponent>();

        }


        public void add(IComponent component)
        {

            subcomponents.Add(component);
             
        }
        public void remove(IComponent component)
        {
            subcomponents.Remove(component);
        }
        public List<IComponent> getSubordinates()
        {
            return subcomponents;
        }
        public void printdetails()
        {
            
            Console.WriteLine(name + description);
            {

                foreach (var number in subcomponents)
                {
                    number.printdetails();
                }
            }
        }

        //public void printdetails(int i)
        //{
        //    Console.WriteLine(new String('-', i) + "+" + name + " " +description);
        //    //name.printdetails(i);
        //    foreach (var number in components)
        //    {
        //        number.printdetails(i);


        //    }

        //}
    }
}
