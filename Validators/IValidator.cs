namespace FuturumCampaign.Validators
{
    public interface IValidator<T>
    {
        bool Validate(T value);
    }
}