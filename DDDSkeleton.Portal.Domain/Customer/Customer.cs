using DDDSkeletonNET.Infrastructure.Common;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.Customer
{
    public class Customer : EntityBase<int>, IAggregateRoot
    {
        public string Name { get; set; }
        public Address.Address CustomerAddress { get; set; }

        protected override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                AddBrokenRules(CustomerBusinessRule.CustomerNameRequired);
            }
            CustomerAddress.ThrowExceptionIfInvalid();
        }
    }
}