namespace BasketApp.Domain.Models.Responses
{
    public class ServiceResponseBase<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
