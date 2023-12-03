class EntityOrchestratorClient
{
    public static void Start()
    {
        RequestPayload requestPayload = new()
        {
            OrgId = "Alpha",
            EntityOne = new EntityOnePayload(),
            EntityTwo = new EntityTwoPayload(),
            EntityThree = new EntityThreePayload()
        };
        Dictionary<string, IEntityProcessorFactory> factories = new()
        {
            {"Default", new DefaultEntityProcessorFactory()},
            {"Alpha", new AlphaEntityProcessorFactory()},
            {"Beta", new BetaEntityProcessorFactory()},
            {"Gamma", new GammaCustomerEntityFactory()}
        };
        EntitiesOrchestrator orchestrator = new(factories);
        orchestrator.Start(requestPayload);
    }
}