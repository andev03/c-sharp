
using Exchange.Business.Base;

namespace Exchange.Business
{
    public interface IOrderDetailBusiness
    {
        Task<IBusinessResult> GetAll();

    }
}
