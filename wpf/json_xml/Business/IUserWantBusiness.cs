using Exchange.Business.Base;

namespace Exchange.Business
{
    public interface IUserWantBusiness {

        Task<IBusinessResult> GetAll();

    }
}
