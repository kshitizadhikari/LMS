namespace LMS.Core.Interfaces
{
    public interface IRepositoryWrapper
    {
        public ICustomerRepository CustomerRepository { get; }
        public IFoodRepository FoodRepository { get; }
    }
}
