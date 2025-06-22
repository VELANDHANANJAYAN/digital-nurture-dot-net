using FactoryMethodPatternExample.Documentsy;

namespace FactoryMethodPatternExample.Factories
{
    public class WordFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
}
