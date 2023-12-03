
class BetaEntityProcessorFactory : IEntityProcessorFactory
{
    public List<AbstractEntityProcessor> GetEntityProcessors()
    {
        return new List<AbstractEntityProcessor>()
        {
            new DefaultEntityOneProcessor(),
            new BetaCustomerEntityTwoWithCustomProcess(),
            new DefaultEntityThreeProcessor()
        };
    }
}