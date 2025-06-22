namespace FactoryMethodPatternExample.Documentsy
{
    public class ExcelDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Excel Document.");
        }
    }
}
