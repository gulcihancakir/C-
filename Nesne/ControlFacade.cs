using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class ControlFacade
    {
        IComponent component;

        RAM ram;
        Islemci islemci;
        Disk disk;
        Anakart anakart;
        EkranKarti ekranKarti;
        Speaker speaker;
        


        public ControlFacade(RAM ram,Islemci islemci,Disk disk,Anakart anakart,EkranKarti ekranKarti,Speaker speaker)
        {
            this.ram = ram;
            this.islemci = islemci;
            this.disk = disk;
            this.anakart = anakart;
            this.ekranKarti = ekranKarti;
            this.speaker = speaker;

        }

        public void kontrolbasla()
        {
            Console.WriteLine("...Kontrol Edilmeye Başlanıyor...");
            ram.ramKontrolBasla();
            islemci.islemciKontrolBasla();
            disk.DiskKontrolBasla();
            anakart.anakartKontrolBasla();
            ekranKarti.ekranKartiKontrolBasla();
            speaker.speakerKontrolBasla();
            
            

        } 

        public void kontrolBitir()
        {
            Console.WriteLine("...Kontrol Tamamlanıyor...");
            ram.ramKontrolBitir();
            islemci.islemciKontrolBitir();
            disk.DiskKontrolBitir();
            anakart.anakartKontrolBitir();
            ekranKarti.ekranKartiKontrolBitir();
            speaker.speakerKontrolBitir();
        }
    }

    
}
