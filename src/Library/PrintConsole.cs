namespace Full_GRASP_And_SOLID.Library
{

    using System;

    public class PrintConsole : IPrinter
    {
        public void Print(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}