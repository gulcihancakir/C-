using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne
{
    class ControlFacade 
    {
       

        RAM ram;
        Islemci islemci;
        Disk disk;
        Anakart anakart;
        EkranKarti ekranKarti;
        Speaker speaker;
        SoundCard SoundCard;

        public ControlFacade(RAM ram, Islemci islemci, Disk disk, Anakart anakart, EkranKarti ekranKarti, Speaker speaker,SoundCard soundCard)
            
        {
            this.ram = ram;
            this.islemci = islemci;
            this.disk = disk;
            this.anakart = anakart;
            this.ekranKarti = ekranKarti;
            this.speaker = speaker;
            this.SoundCard = soundCard;
          

           

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
            SoundCard.SoundCardKontrolBasla();
            
            

        } 

        public void kontrolBitir(int i)
        {
            Console.WriteLine("...Kontrol Tamamlanıyor...");
            ram.ramKontrolBitir();
            islemci.islemciKontrolBitir();
            disk.DiskKontrolBitir();
            anakart.anakartKontrolBitir();
            ekranKarti.ekranKartiKontrolBitir();
            speaker.speakerKontrolBitir();
            SoundCard.SoundCardKontrolBitir();
            

            Console.WriteLine("bilgisayar özellikleri yazılıyor...");
            

        }

        
    }

    
}
