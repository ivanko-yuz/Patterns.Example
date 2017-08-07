using Patterns.Example.FactoryMethod.Models;

namespace Patterns.Example.FactoryMethod
{
    public class ClothProviderFactory
    {
        public static IClothes GetClothesPrinter(ClotheProviders providers)
        {
            switch (providers)
            {
                case ClotheProviders.Shirt:
                    return new Shirt();
                case ClotheProviders.Trousers:
                    return new Trousers();
                default:
                    return null;
            }
        }
    }
}
