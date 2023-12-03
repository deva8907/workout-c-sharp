class EntitiesOrchestrator
{
    private readonly Dictionary<string, IEntityProcessorFactory> _factories;
    public EntitiesOrchestrator(Dictionary<string, IEntityProcessorFactory> factories)
    {
        _factories =factories;
    }

    public void Start(RequestPayload requestPayload)
    {
        var factory = GetFactory(requestPayload);
        var entityProcessors = factory.GetEntityProcessors();
        entityProcessors.ForEach(entity => entity.Process(requestPayload));
    }
    private IEntityProcessorFactory GetFactory(RequestPayload requestPayload)
    {
        if (requestPayload.OrgId is null || !_factories.ContainsKey(requestPayload.OrgId)) return _factories["Default"];
        
        return _factories[requestPayload.OrgId];
    }
}