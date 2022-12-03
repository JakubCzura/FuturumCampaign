namespace FuturumCampaign.Validators
{
    /// <summary>
    /// Interface for validate data
    /// </summary>
    /// <typeparam name="T">object to be validated</typeparam>
    public interface IValidator<T>
    {
        /// <summary>
        /// Method to validate object's data
        /// </summary>
        /// <param name="value">Objects to validate</param>
        /// <returns>True if object's data is alright, otherwise false</returns>
        bool Validate(T value);
    }
}