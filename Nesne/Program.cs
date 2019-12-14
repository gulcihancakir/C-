using System;

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

            Mainboard mainboard = new Mainboard("abc");
            ControlFacade controlFacade = new ControlFacade(ram,islemci,disk,anakart,ekranKarti,speaker);
            controlFacade.kontrolbasla();
            controlFacade.kontrolBitir();

        }
    }
}