class GammaCustomerEntityThreeProcessor : AbstractEntityProcessor
{
    protected override bool Validate(RequestPayload requestPayload)
    {
        //code that writes entirely different validation than the default one, for Gamma customer
        return true;
    }
    protected override void ProcessInternal(RequestPayload requestPayload)
    {
        //code that writes entirely different implementation than the default one, for Gamma customer
    }
}