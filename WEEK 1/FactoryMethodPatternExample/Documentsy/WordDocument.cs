namespace FactoryMethodPatternExample.Documentsy
{
    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Word Document.");
        }
    }
}
