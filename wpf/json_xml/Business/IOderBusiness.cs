

using Exchange.Business.Base;

namespace Exchange.Business
{
    public interface IOderBusiness
    {
        Task<IBusinessResult> GetAll();

    }
}
