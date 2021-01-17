using System;
using System.IO;

namespace RTGTV_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\WriteToFile";

            Console.WriteLine("TV/AV - Kysely.");
            Console.Write("Anna kuitin tilausnumero: ");
            //Kysy tilausnumero
            Console.Write("Mikä palvelu: ");
            //Kysy palvelu
            Console.Write("Television merkki: ");
            //Kysy television merkki. Jos Samsung niin kysy jatko kysymykset.
            Console.Write("Television koko: ");
            //Television koko.
            Console.Write("Onko kuljetusta? (Y = Yes/ N = No)");
            //Jos tulee kuljetus niin kysy kuljetuksen päivämäärä ja onko Lilli vai Koppo.
            Console.Write("Toimistuspäivä: ");
            //Toimitus päivän tarkastelu.
            
            //Tähän Kirjoita kaikki tiedot ja kysytään kirjoittajalta onko kaikki tiedot oikein.
            //Jonka jälkeen ohjelma kirjoittaa kaikki tiedot .txt tiedostoon ja formatoi nimen.
            //Esimerkiksi: 40702652652 - SATV36M - 25-01-2021


            //TM RTGTV-Ohjelma - Tatu-Topias Paski - 2021


        }
        
    }
}
