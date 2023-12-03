class AlphaCustomerEntityOneWithCustomValidation : DefaultEntityOneProcessor
{
    protected override bool Validate(RequestPayload requestPayload)
    {
        bool passesBasicValidation = base.Validate(requestPayload);
        if (!passesBasicValidation) return false;
        
        //custom validation for alpha customer
        //need not call base method if the entire validation in base class has to be overwritten
        return true;
    }
}