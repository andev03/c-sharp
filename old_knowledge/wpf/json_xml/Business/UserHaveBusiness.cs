﻿

using Exchange.Business.Base;
using Exchange.Common;
using Exchange.Data;

namespace Exchange.Business
{
    public class UserHaveBusiness : IUserHaveBusiness
    {
        private readonly UnitOfWork _unitOfWork;

        public UserHaveBusiness() {
            _unitOfWork = new UnitOfWork();
        }

        public async Task<IBusinessResult> GetAll() {
            try {
                #region Business rule
                #endregion

                var custommer = await _unitOfWork.userHaveRepository.GetAll();

                if (custommer == null) {
                    return new BusinessResult(Const.WARNING_NO_DATA_CODE, Const.WARNING_NO_DATA__MSG);
                } else {
                    return new BusinessResult(Const.SUCCESS_READ_CODE, Const.SUCCESS_CREATE_MSG, custommer);
                }

            } catch (Exception ex) {
                return new BusinessResult(Const.ERROR_EXCEPTION, ex.Message);

            }
        }
    }
}
