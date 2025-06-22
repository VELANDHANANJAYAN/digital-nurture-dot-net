using FactoryMethodPatternExample.Documentsy;

namespace FactoryMethodPatternExample.Factories
{
    public class PdfFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
