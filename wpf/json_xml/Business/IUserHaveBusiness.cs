
using Exchange.Business.Base;

namespace Exchange.Business
{
    public interface IUserHaveBusiness
    {
        Task<IBusinessResult> GetAll();

    }
}
