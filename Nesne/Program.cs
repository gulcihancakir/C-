using System;
using System.Text;

namespace Nesne
{
    class Program
    {



        static void Main(string[] args)
        {



            RAM ram = new RAM();
            Islemci islemci = new Islemci();
            Disk disk = new Disk();
            Anakart anakart = new Anakart();
            EkranKarti ekranKarti = new EkranKarti();
            Speaker speaker = new Speaker();
            Monitor monitor = new Monitor();
            SoundCard soundCard = new SoundCard();


            ControlFacade controlFacade = new ControlFacade(ram, islemci, disk, anakart, ekranKarti, speaker,soundCard);
            controlFacade.kontrolbasla();
            controlFacade.kontrolBitir(1);

            


            
            CompositeComponent root = new CompositeComponent(anakart,"MSI");
            CompositeComponent component = new CompositeComponent(ekranKarti,"4GB");
            component.add(new LeafComponent(monitor,"Casper"));
            root.add(new LeafComponent(ram,"8gb"));
            root.add(new LeafComponent(islemci,"i7"));
            root.add(new LeafComponent(disk,"256gb SSD"));
            root.add(new LeafComponent(speaker,"-"));
            root.add(component);
            root.printdetails();
            


           
            
            




        }




    
    }
}