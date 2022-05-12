using System;
using Projetos.src.Entities;

namespace Projetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", 469);
            WhiteWizard white = new WhiteWizard("Jennica", 42, "White Wizard", 325);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 292);
            BlackWizard black = new BlackWizard("Topapa", 42, "Black Wizard", 106);

            Console.WriteLine(arus.ToString());
            Console.WriteLine(white.Defense());
            Console.WriteLine(ninja.ToString());
            Console.WriteLine(black.Attack());
            

        }
    }
}
