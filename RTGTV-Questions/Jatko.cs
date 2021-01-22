using System;
using System.Collections.Generic;
using System.Text;

namespace RTGTV_Questions
{

    class Jatko
    {
      
        public void Order()
        {
            int pituus = 11;
            string isOrder;
            

            Console.Write("Kuitin numero: ");
            do
            {
                isOrder = Console.ReadLine();
                if (isOrder.Length == pituus)
                {
                    Console.WriteLine(isOrder);
                    
                }
                else
                {
                    Console.WriteLine("\nError!");
                    Console.WriteLine("Tarkista tilausnumero.\n");
                    Console.Write("Anna tilausnumero uudelleen: ");
                }
            } while (isOrder.Length != pituus);
           
        }
        public void Service()
        {
            
            int palvelu = 0;
            string palveluValinta = "";
            int talous = 0;
            string talousValinta = "";
            int tvMerkki = 0;
            string isBrand = "";

            Console.WriteLine("\nValitse oikea numero joka vastaa myymääsi palvelua.");
            Console.WriteLine("\n1. SATV");
            Console.WriteLine("2. RTGTV");
            Console.Write("\nValintasi on: ");
            
          //Kysytään onko kumpi palvelu kyseessä. RTGTV Jätetään huomioimatta mutta kirjotetaan tiedostoon.
            do
            {
                bool palveluBool;
                palveluBool = int.TryParse(Console.ReadLine(), out palvelu);
                if (palvelu == 1 || palvelu == 2)
                {
                    switch (palvelu)
                    {
                        case 1:
                            palveluValinta = "SATV";
                            Console.WriteLine(palveluValinta);
                            break;
                        case 2:
                            palveluValinta = "RTGTV";
                            Console.WriteLine(palveluValinta);
                            break;
                    }                    
                }
                
            } while (palvelu != 1 && palvelu != 2);
            //Jos SATV niin kysytään palveluun tarvittavat lisäkysymykset.
            if(palvelu == 1)
            {
                Console.WriteLine("\nMikä talous asiakkaalla on?");
                Console.WriteLine("\n1. Antenni");
                Console.WriteLine("2. Kaapeli");
                Console.Write("\nValitse toinen: ");
                do
                {
                    bool talousBool;
                    talousBool = int.TryParse(Console.ReadLine(), out talous);
                    if (talous == 1 || talous == 2)
                    {
                        switch (talous)
                        {
                            case 1:
                                talousValinta = "Antenni";
                                Console.WriteLine(talousValinta);
                                break;

                            case 2:
                                talousValinta = "Kaapeli";
                                Console.WriteLine(talousValinta);
                                break;

                        }
                    }
                } while (talous != 1 && talous != 2);
            }
            Console.WriteLine("\nMinkä merkkinen telkkari on?");
            Console.WriteLine("\n1. Samsung");
            Console.WriteLine("2. Philips");
            Console.WriteLine("3. LG");
            Console.WriteLine("4. Sony");
            Console.WriteLine("5. TCL");

            Console.Write("\nValintasi on: ");
            do
            {
                bool tvMerkkiBool;
                tvMerkkiBool = int.TryParse(Console.ReadLine(), out tvMerkki);

                switch (tvMerkki)
                {
                    case 1:
                        isBrand = "Samsung";
                        Console.WriteLine(isBrand);
                        break;
                    case 2:
                        isBrand = "Philips";
                        Console.WriteLine(isBrand);
                        break;
                    case 3:
                        isBrand = "LG";
                        Console.WriteLine(isBrand);
                        break;
                    case 4:
                        isBrand = "Sony";
                        Console.WriteLine(isBrand);
                        break;
                    case 5:
                        isBrand = "TCL";
                        Console.WriteLine(isBrand);
                        break;
                }
            } while (tvMerkki < 1 && tvMerkki > 5);
            Console.WriteLine();
            Console.WriteLine("**TESTI**");
            Console.Write(tvMerkki);Console.Write(isBrand);
            Console.WriteLine();
            Console.WriteLine("**TESTI**");
            Console.Write(palvelu); Console.Write(palveluValinta);
            Console.WriteLine();
            Console.WriteLine("**TESTI**");
            Console.Write(talous); Console.WriteLine(talousValinta);
            Console.WriteLine();

            if (tvMerkki == 1 && palvelu == 1)
            {
                Console.WriteLine("Muistathan käydä tekemässä asiakkaalle Samsung tilin.");
                Console.WriteLine("Jos asiakkaalla ei ole sähköpostia niin muista tehdä hänelle se.");
            }

        }



    }
}
