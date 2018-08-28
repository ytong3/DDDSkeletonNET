using System;
using DDDSkeletonNET.Portal.Repository.Memroy.UnitOfWork;

namespace DDDSkeletonNET.Portal.ApplicationServices
{
    public abstract class ApplicationServiceBase
    {
        protected readonly IUnitOfWork _unitOfWork;

        public ApplicationServiceBase(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) throw new ArgumentNullException("UnitOfWork");
            _unitOfWork = unitOfWork;
        }
    }
}