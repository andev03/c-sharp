

using Exchange.Business.Base;

namespace Exchange.Business
{
    public interface IProductBusiness
    {
        Task<IBusinessResult> GetAll();

    }
}
