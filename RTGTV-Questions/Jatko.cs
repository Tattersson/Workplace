using System;
using System.Collections.Generic;
using System.Text;

namespace RTGTV_Questions
{
    enum service
    {
        SATV = 1,
        RTGTV = 2
    }
    class Jatko
    {
        public string isOrder;
        public string isService;
        public string isBrand;
        public int isSize;
        public string isDelivery;
        public string isDate;
        public string isContinue;


        public Jatko()
        {
            this.isOrder = "";
            this.isService = "";
            this.isBrand = "";
            this.isSize = 0;
            this.isDelivery = "";
            this.isDate = "";
            this.isContinue = "";
        }

        public void Order()
        {
            int pituus = 11;
            string isOrder = string.Empty;

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
            
            int valinta;
            Console.WriteLine("\nValitse oikea numero joka vastaa myymääsi palvelua.");
            Console.WriteLine("\n1. SATV");
            Console.WriteLine("\n2. RTGTV");
            Console.Write("\nValintasi on: ");
            valinta = Int32.Parse(Console.ReadLine());
            //Tarkista miksi tämä ei toimi!!
            switch (valinta)
            {
                case 1:
                    Console.WriteLine("\nSATV");
                    break;
                case 2:
                    Console.WriteLine("\nRTGTV");
                    break;
                default:
                    Console.WriteLine("Valintasi on väärin! \nValitse uudelleen.");
                    break;
            }
        }
    }
}
