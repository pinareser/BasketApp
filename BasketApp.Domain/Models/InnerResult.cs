using BasketApp.Domain.Models.Responses;
namespace BasketApp.Domain.Models
{
    public class InnerResult<T> : ServiceResponseBase<T>
    {
        public InnerResultTypes InnerResultType { get; set; }
    }

    public enum InnerResultTypes
    {
        None,
        Success,
        NoCustomerFound,
        NoProductFound,
        IsBasketEmpty,
        InvalidCountValue,
        NotEnoughStock,
        CannotBeAddedToBasket,
        SuccessfullyAddedToBasket,
    }
}
