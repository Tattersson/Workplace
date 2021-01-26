using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;



namespace RTGTV_Questions
{

    class Jatko
    {
        DateTime timeNow = DateTime.Now;
        public DateTime kuljetusPva;
        public DateTime RTGDate;
        public const int pituus = 11;
        public const string varasto = "Tehdään televisio varaston puolella.";
        public const string klinikka = "Tehdään televisio klinikan puolella.";
        public string isOrder;
        public int palvelu;
        public string palveluValinta;
        public int talous;
        public string talousValinta;
        public int tvMerkki;
        public string tvMerkkiValinta;
        public int tili;
        public string tiliKirjoitus;
        public string url;
        public string kyleiValinta;
        public string kill;
        public int koko;
        public string kuljetus;


        public Jatko()
        {
            this.isOrder = string.Empty;
            this.tvMerkkiValinta = string.Empty;
            this.palvelu = 0;
            this.palveluValinta = string.Empty;
            this.talous = 0;
            this.talousValinta = string.Empty;
            this.tvMerkki = 0;
            this.tvMerkkiValinta = string.Empty;
            this.tili = 0;
            this.tiliKirjoitus = string.Empty;
            this.url = string.Empty;
            this.kyleiValinta = string.Empty;
            this.kill = string.Empty; 
            this.koko = 0;
            this.kuljetus = string.Empty;
            


        }

       
        public void Order()
        { 
            Console.Write("Kuitin numero: ");
            do
            {
                this.isOrder = Console.ReadLine();
                if (this.isOrder.Length == pituus)
                {
                    Console.WriteLine("Hyväksytty");
                }
                else
                {
                    Console.WriteLine("\nError!");
                    Console.WriteLine("Tarkista tilausnumero.\n");
                    Console.Write("Anna tilausnumero uudelleen: ");
                }
            } while (this.isOrder.Length != pituus);
           
        }
        public void Service()
        {
            string url = "https://account.samsung.com/accounts/v1/DCGLFI/signInGate?response_type=code&client_id=b74e1ys3uk&locale=fi_FI&countryCode=FI&redirect_uri=https:%2F%2Fwww.samsung.com%2Faemapi%2Fdata-login%2FafterLogin.fi.json&state=GLBk1iueo17x2p&goBackURL=https:%2F%2Fwww.samsung.com%2Ffi%2Faccount%2Fmyaccount%2F&scope=";


            Console.WriteLine("\nValitse oikea numero joka vastaa myymääsi palvelua.");
            Console.WriteLine("\n1. SATV");
            Console.WriteLine("2. RTGTV");
            Console.Write("\nValintasi on: ");
            
          //Kysytään onko kumpi palvelu kyseessä. RTGTV Jätetään huomioimatta mutta kirjotetaan tiedostoon.
            do
            {
                bool palveluBool;
                palveluBool = int.TryParse(Console.ReadLine(), out this.palvelu);
                if (this.palvelu == 1 || this.palvelu == 2)
                {
                    switch (this.palvelu)
                    {
                        case 1:
                            this.palveluValinta = "SATV";
                            Console.WriteLine("Hyväksytty");
                            break;
                        case 2:
                            palveluValinta = "Hyväksytty";
                            Console.WriteLine(this.palveluValinta);
                            break;
                    }                    
                }
                else
                {
                    Console.WriteLine("Error!");
                    Console.Write("Yritä uudelleen: ");
                }
                
            } while (this.palvelu != 1 && this.palvelu != 2);
            //Jos SATV niin kysytään palveluun tarvittavat lisäkysymykset.
            if(this.palvelu == 1)
            {
                Console.WriteLine("\nMikä talous asiakkaalla on?");
                Console.WriteLine("\n1. Antenni");
                Console.WriteLine("2. Kaapeli");
                Console.Write("\nValitse toinen: ");
                do
                {
                    bool talousBool;
                    talousBool = int.TryParse(Console.ReadLine(), out this.talous);
                    if (this.talous == 1 || this.talous == 2)
                    {
                        switch (this.talous)
                        {
                            case 1:
                                this.talousValinta = "Antenni";
                                Console.WriteLine("Hyväksytty");
                                break;

                            case 2:
                                this.talousValinta = "Kaapeli";
                                Console.WriteLine("Hyväksytty");
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        Console.Write("Yritä uudelleen: ");
                    }
                } while (this.talous != 1 && this.talous != 2);
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
                tvMerkkiBool = int.TryParse(Console.ReadLine(), out this.tvMerkki);

                switch (this.tvMerkki)
                {
                    case 1:
                        this.tvMerkkiValinta = "Samsung";
                        Console.WriteLine(this.tvMerkkiValinta);
                        break;
                    case 2:
                        this.tvMerkkiValinta = "Philips";
                        Console.WriteLine(this.tvMerkkiValinta);
                        break;
                    case 3:
                        this.tvMerkkiValinta = "LG";
                        Console.WriteLine(this.tvMerkkiValinta);
                        break;
                    case 4:
                        this.tvMerkkiValinta = "Sony";
                        Console.WriteLine(this.tvMerkkiValinta);
                        break;
                    case 5:
                        this.tvMerkkiValinta = "TCL";
                        Console.WriteLine(this.tvMerkkiValinta);
                        break;
                }
            } while (this.tvMerkki < 1 && this.tvMerkki > 5);

            


            
            

            if (this.tvMerkkiValinta == "Samsung" && this.palveluValinta == "SATV")
            {
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("*Muistathan käydä tekemässä asiakkaalle Samsung tilin.                  *");
                Console.WriteLine("*Jos asiakkaalla ei ole sähköpostia niin muista tehdä se hänelle.       *");
                Console.WriteLine("*Esimerkiksi       etunimi.sukunimitv@gmail.com                         *");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("\nOnko hänellä jo käytettävissä oleva Samsung tili?");
                Console.WriteLine("k = kyllä / e = ei");
                Console.Write("\nValintasi on: ");
                do
                {
                    this.kyleiValinta = Console.ReadLine().ToLower();
                    if (this.kyleiValinta == "k")
                    {
                        Console.Write("\nKirjoita se tähän: ");
                        this.tiliKirjoitus = Console.ReadLine().ToLower();
                        break;
                    }
                    else if (this.kyleiValinta == "e")
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
                    else
                    {
                        Console.WriteLine("Yritä uudelleen:");
                        Console.WriteLine("Valinnat on!\n k = Kyllä\n e = Ei");
                        Console.Write("\nValitse uudelleen: ");
                    }
                } while (this.tvMerkki == 1 && this.palvelu == 1);
            }
           
        }
        public void Size()
        {
            
            Console.Write("\nTelevision koko: ");
            bool kokoBool;
            kokoBool = int.TryParse(Console.ReadLine(), out this.koko);
            Console.WriteLine(this.koko);

        }
        public void Transport()
        {
            Console.WriteLine($"\nAika nyt: {timeNow}\n");
            Console.WriteLine("Tuleeko tuotteelle kuljetusta?");
            Console.WriteLine("k = kyllä / e = ei");
            Console.Write("\nValintasi on: ");
            do
            {

                this.kuljetus = Console.ReadLine().ToLower();

                if (this.kuljetus == "k")
                {
                    Console.WriteLine("\nMille päivälle kuljetus on tapahtumassa?");
                    kuljetusPva = DateTime.Parse(Console.ReadLine());
                    break;
                }
                else if (this.kuljetus == "e")
                {
                    Console.WriteLine("Tuotteelle ei tule kuljetusta.");
                }
                else
                {
                    Console.WriteLine("Yritä uudelleen:");
                    Console.WriteLine("Valinnat on!\n k = Kyllä\n e = Ei");
                    Console.Write("\nValitse uudelleen: ");
                    
                }
            } while (this.kuljetus != "k"  && this.kuljetus != "e");
        }
        
        public void RTG()
        {
            
            Console.WriteLine("\nMille päivälle asennus valmiiksi?\n");
            Console.WriteLine($"Aika nyt: {timeNow}");
            Console.Write("\nPäivämäärä ja aika: ");
            RTGDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(RTGDate);  

            // Tähän jatketaan vielä se ehto että myyjä ei voi merkata samalle päivälle asennusta.

            //Kalenteri myös joka lukee kaikki tiedostot mitä kansiosta löytyy ja etsii tiedosto nimestä päivämäärän ja se kirjoitetaan konsoliin jotta nähdään kuinka monta asennusta on päivässä.
        }
        public void WriteToConsole()
        {
            Console.WriteLine();
            Console.WriteLine("Tältä näyttää kirjotettu tiedosto".ToUpper());
            Console.WriteLine();
            Console.WriteLine($"Tiedoston nimeksi tulee: {isOrder} - {palveluValinta} - {RTGDate.Date}\n");
            Console.WriteLine($"Asiakkaalle tulee:\t {talousValinta}talous");
            Console.WriteLine($"Television merkki:\t {tvMerkkiValinta}");
            if (this.kyleiValinta == "k")
            {
                Console.WriteLine($"Asiakkaan samsung tilin sposti:\t{tiliKirjoitus}");
            }
            //Telkkarin koko ja asennus paikka.
            if (this.koko >= 65)
            {
                Console.WriteLine(varasto);
            }
            else
            {
                Console.WriteLine(klinikka);
            }
            //Kuljetus ja oikean linen tulostus.
            if (this.kuljetus == "k")
            {
                Console.WriteLine($"Tuotteen kuljetus päivä on:\t {kuljetusPva}");
            }
            else
            {
                Console.WriteLine("Tuotteelle ei tule kuljetusta");
            }

            //Yllä olevat tiedostot kirjoitetaan tiedostoon! Tätä ei ole vielä tehty vaan tämä näkyy vasta vain ohjelmassa. 
            //Kysytään vielä että onko tiedot varmasti oikeat. Jos ei aloitetaan uudelleen ohjelma. 
        }
        public void WriteToTXT()
        {
            //Tähän kirjoitetaan kaikki WriteToConsole() arvot TXT tiedostoon. 
        }
    }
}