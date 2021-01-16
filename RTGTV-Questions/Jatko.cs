using System;
using System.Collections.Generic;
using System.Text;

namespace RTGTV_Questions
{
    class Jatko
    {
        public int isOrder;
        public string isService;
        public string isBrand;
        public int isSize;
        public string isDelivery;
        public string isDate;
        public string isContinue;


        public Jatko()
        {
            this.isOrder = 0;
            this.isService = "";
            this.isBrand = "";
            this.isSize = 0;
            this.isDelivery = "";
            this.isDate = "";
            this.isContinue = "";
        }
        public void Order(int isOrder)
        {
            //Kuitti numero on 9 numeroa pitkä
            Console.WriteLine("Muista antaa myös 4070 alle.");
            Console.Write("Anna ElGuidesta tilausnumero: ");
            Console.ReadLine();

        }
        public void Service(string isService)
        {

        }
        public void Brand(string isBrand)
        {

        }
        public void Size(int isSize)
        {

        }
        public void Delivery(string isDelivery)
        {

        }
        public void Date(string isDate)
        {

        }
        public void Continue(string isContinue)
        {

        }
    }
}
