
class AlphaEntityProcessorFactory : IEntityProcessorFactory
{
    public List<AbstractEntityProcessor> GetEntityProcessors()
    {
        return new List<AbstractEntityProcessor>()
        {
            new AlphaCustomerEntityOneWithCustomValidation(),
            new DefaultEntityTwoProcessor(),
            new DefaultEntityThreeProcessor()
        };
    }
}