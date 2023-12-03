class DefaultEntityTwoProcessor : AbstractEntityProcessor
{

    protected override void ProcessInternal(RequestPayload requestPayload)
    {
        //persist EntityTwo to DB and other related logic
    }

    protected override bool Validate(RequestPayload requestPayload)
    {
        if (requestPayload.EntityOne is null) return false;

        //other validation goes here
        return true;
    }
}