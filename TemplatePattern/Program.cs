using System;

namespace TemplatePattern
{
    internal static class Program
    {
        static void Main()
        {
            var tea = new Tea();
            var coffee = new Coffee();
            tea.WantsCondiments = true;
            tea.AddSugar = 5;
            tea.Prepare();

            Console.WriteLine();
            coffee.WantsCondiments = true;
            coffee.Prepare();
        }
    }
}
