using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IImprimible toPrint)
        {
            Console.WriteLine(toPrint.GetTextToPrint());
        }
    }
}