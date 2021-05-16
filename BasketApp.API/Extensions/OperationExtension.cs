using BasketApp.Domain.Models;

namespace BasketApp.API.Extensions
{
    public static class OperationExtension
    {
        public static string Message(this InnerResultTypes statusTypes)
        {
            return statusTypes switch
            {
                InnerResultTypes.NoCustomerFound => "No customer information for this id could be reached!",
                InnerResultTypes.NoProductFound => "Product information for this id could not be reached!",
                InnerResultTypes.IsBasketEmpty => "There are no items in the basket!",
                InnerResultTypes.InvalidCountValue => "Invalid count value!",
                InnerResultTypes.NotEnoughStock => "Not enough stock found!",
                InnerResultTypes.CannotBeAddedToBasket => "The product cannot be added to the basket!",
                InnerResultTypes.SuccessfullyAddedToBasket => "The item has been successfully added to the basket!",
                _ => string.Empty,
            };
        }
    }
}
