using FactoryMethodPatternExample.Documentsy;

namespace FactoryMethodPatternExample.Factories
{
    public abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }
}
