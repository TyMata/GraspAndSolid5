using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IImprimible toPrint )
        {
            File.WriteAllText("Recipe.txt", toPrint.GetTextToPrint());
        }
    }
}