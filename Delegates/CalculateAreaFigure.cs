using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Delegates
{

    public class CalculateAreaFigure
    {
        delegate decimal? AreaRectangle(decimal ? Base, decimal ? Heigth);
        delegate double AreaCircule(double radio);
        delegate bool IsPar(int number);
        delegate bool IsImpar(int number);
        private static decimal ? CalculateAreaRectangle(decimal ? Base ,decimal ? Heigth) => (Base != Heigth) ? Base* Heigth : null ;
        private static double CalculateAreaCircule(double radio) => Math.PI * Math.Pow(radio, 2) ;
        private static bool ExistsNumbersPares(int number) => number % 2 == 0;
      
        public static  void Execute()
        {
            AreaRectangle oRectangle = new(CalculateAreaRectangle);
            decimal ? result = oRectangle(6, 15);

            Console.WriteLine(result != null ? "Area : " + result : "Es null");

            IsPar oPar = new(ExistsNumbersPares);
            Console.WriteLine(oPar(4) ? "Es par" : " No es par");

            AreaCircule oCircule = new(CalculateAreaCircule);
            Console.WriteLine("Area : " + oCircule(4));

            Predicate<int> NumbersPares = new(ExistsNumbersPares);
            List<int> List = new() { 23, 11, 44, 56, 12, 31 };
            var newlist = List.FindAll(NumbersPares);
            foreach (int number in newlist)
            {
                Console.WriteLine(number);
            }

            IsImpar oImpar = delegate (int number)
            {
                return number % 2 != 0 ;
            };

        }

   

    }
}
