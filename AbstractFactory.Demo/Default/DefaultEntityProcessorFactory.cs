
class DefaultEntityProcessorFactory : IEntityProcessorFactory
{
    public List<AbstractEntityProcessor> GetEntityProcessors()
    {
        return new List<AbstractEntityProcessor>()
        {
            new DefaultEntityOneProcessor(),
            new DefaultEntityTwoProcessor(),
            new DefaultEntityThreeProcessor()
        };
    }
}