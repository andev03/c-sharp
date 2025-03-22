using Exchange.Business.Base;

namespace Exchange.Business {
    public interface ICustomerBusiness
    {
        Task<IBusinessResult> GetAll();
    }
}
