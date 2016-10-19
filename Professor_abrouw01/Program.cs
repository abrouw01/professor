using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor_abrouw01
{
    class Rater
    {
        public static int IDTrack = 1;
        private double clarity, helpful, easiness;
        public int ID
        {
            get;
            private set;
        }

        public Rater(double clar, double help, double easy)
        {
            clarity = clar;
            helpful = help;
            easiness = easy;

            ID = IDTrack++;
        }

       

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rater r1 = new Rater(12, 26, 45);
            Rater r2 = new Rater(14, 25, 45);

           
        }
    }
}
