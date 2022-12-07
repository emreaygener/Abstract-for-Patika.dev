using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFocus newFocus = new();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());

            NewCivic newCivic = new();
            Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());
            
            NewCorolla newCorolla = new();
            Console.WriteLine(newCorolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCorolla.KacTekerlektenOlusur());
            Console.WriteLine(newCorolla.StandartRengiNe().ToString());
        }
    }
}
