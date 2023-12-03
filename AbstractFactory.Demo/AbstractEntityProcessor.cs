abstract class AbstractEntityProcessor
{
    public void Process(RequestPayload requestPayload)
    {
        if (!Validate(requestPayload)) return;
        
        ProcessInternal(requestPayload);
    }
    protected abstract bool Validate(RequestPayload requestPayload);
    protected abstract void ProcessInternal(RequestPayload requestPayload);
}