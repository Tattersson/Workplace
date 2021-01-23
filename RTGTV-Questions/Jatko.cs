using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;



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
            string tvMerkkiValinta = "";
            int tili = 0;
            string tiliKirjoitus = "";
            string url = "https://account.samsung.com/accounts/v1/DCGLFI/signInGate?response_type=code&client_id=b74e1ys3uk&locale=fi_FI&countryCode=FI&redirect_uri=https:%2F%2Fwww.samsung.com%2Faemapi%2Fdata-login%2FafterLogin.fi.json&state=GLBk1iueo17x2p&goBackURL=https:%2F%2Fwww.samsung.com%2Ffi%2Faccount%2Fmyaccount%2F&scope=";


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
                        tvMerkkiValinta = "Samsung";
                        Console.WriteLine(tvMerkkiValinta);
                        break;
                    case 2:
                        tvMerkkiValinta = "Philips";
                        Console.WriteLine(tvMerkkiValinta);
                        break;
                    case 3:
                        tvMerkkiValinta = "LG";
                        Console.WriteLine(tvMerkkiValinta);
                        break;
                    case 4:
                        tvMerkkiValinta = "Sony";
                        Console.WriteLine(tvMerkkiValinta);
                        break;
                    case 5:
                        tvMerkkiValinta = "TCL";
                        Console.WriteLine(tvMerkkiValinta);
                        break;
                }
            } while (tvMerkki < 1 && tvMerkki > 5);

            //KOMMENTOI POIS KUN VALMIS JA TOIMIVA OHJELMA****
            Console.WriteLine();
            Console.WriteLine("**TESTI**");
            Console.Write(tvMerkki);Console.Write(tvMerkkiValinta);
            Console.WriteLine();
            Console.WriteLine("**TESTI**");
            Console.Write(palvelu); Console.Write(palveluValinta);
            Console.WriteLine();
            Console.WriteLine("**TESTI**");
            Console.Write(talous); Console.WriteLine(talousValinta);
            Console.WriteLine();


            string kyleiValinta = string.Empty;
            string kill = string.Empty;
            

            if (tvMerkkiValinta == "Samsung" && palveluValinta == "SATV")
            {
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("*Muistathan käydä tekemässä asiakkaalle Samsung tilin.                  *");
                Console.WriteLine("*Jos asiakkaalla ei ole sähköpostia niin muista tehdä se hänelle.       *");
                Console.WriteLine("*Esimerkiksi       etunimi.sukunimitv@gmail.com                         *");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("\nOnko hänellä jo käytettävissä oleva Samsung tili?");
                Console.WriteLine("k = kyllä / e = ei");
                Console.Write("Valintasi on: ");
                do
                {
                    kyleiValinta = Console.ReadLine().ToLower();
                    if (kyleiValinta == "k")
                    {
                        Console.Write("Kirjoita se tähän: ");
                        tiliKirjoitus = Console.ReadLine().ToLower();
                        break;
                    }
                    else if (kyleiValinta == "e")
                    {
                        Console.WriteLine("\nKopioi tämä ja mene osoitteeseen haluamallasi verkkoselaimella.\n");
                        Console.WriteLine(url);
                        Console.WriteLine();
                        Console.WriteLine("Kopiointi tapahtuu siten että maalaat kyseisen url osoitteen.\nKun olet maalannut kyseisen URL osoitteen paina hiiren oikeata näppäintä.\n");
                        Console.WriteLine("\n**MUISTA TOIMITTAA TILITIEDOT KLINIKALLE.**\n");
                        break;
                        //Jatkokehitykseen!! - Täytyy oppia sulkemaan selain ja jatkamaan tätä ohjelmaa.
                        /*
                        Console.WriteLine("Paina K:ta kun olet valmis.");
                        var prs = new ProcessStartInfo(@"C:\Program Files\Internet Explorer\iexplore.exe");
                        prs.Arguments = url;
                        Process.Start(prs);
                        kill = Console.ReadLine();
                        if (kill == "k")
                        {
                            Process.CloseWindow();
                        }
                        */

                    }
                } while (tvMerkki == 1 && palvelu == 1);
            }
            Console.WriteLine();
            Console.WriteLine("**TESTI**");
            Console.Write(kyleiValinta); Console.WriteLine(tiliKirjoitus);
            Console.WriteLine();
        }
        public void Size()
        {
            int koko = 0;
            string varasto = "Tehdään televisio varaston puolella.";
            string klinikka = "Tehdään televisio klinikan puolella.";

            Console.Write("\nTelevision koko: ");
            bool kokoBool;
            kokoBool = int.TryParse(Console.ReadLine(), out koko);
            Console.WriteLine(koko);

            if (koko >= 65)
            {
                Console.WriteLine(klinikka);
            }
            else
            {
                Console.WriteLine(varasto);
            }
        }
        public void Transport()
        {
            string kuljetus;
            string kuljetusPva;


            Console.WriteLine("Tuleeko tuotteelle kuljetusta?");
            Console.WriteLine("k = kyllä / e = ei");
            Console.Write("Valintasi on: ");
            kuljetus = Console.ReadLine().ToLower();

            if (kuljetus == "k")
            {
                Console.WriteLine("\nMille päivälle kuljetus on tapahtumassa?");
                bool kuljetusPvaBool;
                kuljetusPvaBool = int.TryParse(Console.ReadLine(), out kuljetusPva); //kuljetus on string ei int!!
                kuljetusPva;
            }
        }



    }
}
