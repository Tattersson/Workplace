using System;
using System.IO;

namespace RTGTV_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Workplace\";

            Jatko jatko = new Jatko();
            

            Console.WriteLine("TV/AV - Kysely.\n");
            //Kysy kuitin numero - Order();
            jatko.Order();

            //Kysy palvelu
            jatko.Service();
            //Kysy television merkki. Jos Samsung niin kysy jatko kysymykset.


            //Television koko.

            //Jos tulee kuljetus niin kysy kuljetuksen päivämäärä ja onko Lilli vai Koppo.

            //Toimitus päivän tarkastelu.

            //Tähän Kirjoita kaikki tiedot ja kysytään kirjoittajalta onko kaikki tiedot oikein.
            //Jonka jälkeen ohjelma kirjoittaa kaikki tiedot .txt tiedostoon ja formatoi nimen.
            //Esimerkiksi: 40702652652 - SATV36M - 25-01-2021


            //TM RTGTV-Ohjelma - Tatu-Topias Paski - 2021


        }

        
        
    }
}
