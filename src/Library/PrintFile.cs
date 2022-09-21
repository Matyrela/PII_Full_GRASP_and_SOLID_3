namespace Full_GRASP_And_SOLID.Library
{
    using System.IO;

    public class PrintFile : IPrinter
    {
        public void Print(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}