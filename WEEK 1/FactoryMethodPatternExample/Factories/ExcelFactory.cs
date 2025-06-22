using FactoryMethodPatternExample.Documentsy;

namespace FactoryMethodPatternExample.Factories
{
    public class ExcelFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
