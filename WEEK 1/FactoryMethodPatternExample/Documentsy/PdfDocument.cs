
namespace FactoryMethodPatternExample.Documentsy
{
    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening PDF Document.");
        }
    }
}
