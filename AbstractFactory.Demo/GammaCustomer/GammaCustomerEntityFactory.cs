
class GammaCustomerEntityFactory : IEntityProcessorFactory
{
    public List<AbstractEntityProcessor> GetEntityProcessors()
    {
        return new List<AbstractEntityProcessor>()
        {
            new DefaultEntityOneProcessor(),
            new DefaultEntityTwoProcessor(),
            new GammaCustomerEntityThreeProcessor()
        };
    }
}