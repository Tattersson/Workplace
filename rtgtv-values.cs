using System;

namespace rtgtv-values {
    public static class program {
        public static void Main(string[]args){

            string message = "";
                if (args.Lenght < 1){
                    message = "RTGTV Value printer";
                }
                else {
                    foreach (string item in args)
                    {
                        message += item;
                    }
                }

        }
    }
}