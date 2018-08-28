﻿using System.Collections.Generic;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeletonNET.Infrastructure.Common
{
    public abstract class EntityBase<IdType>
    {
        public IdType Id { get; set; }

        public override bool Equals(object entity)
        {
            return entity != null
                   && entity is EntityBase<IdType>
                   && this == (EntityBase<IdType>)entity;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public static bool operator ==(EntityBase<IdType> entity1, EntityBase<IdType> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
            {
                return true;
            }

            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }

            if (entity1.Id.ToString() == entity2.Id.ToString())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(EntityBase<IdType> entity1, EntityBase<IdType> entity2)
        {
            return (!(entity1 == entity2));
        }

        protected abstract void Validate();

        private List<BusinessRule> _brokenRules = new List<BusinessRule>();

        protected void AddBrokenRules(BusinessRule businessRule)
        {
            _brokenRules.Add(businessRule);
        }

        public IEnumerable<BusinessRule> GetBrokenRules()
        {
            _brokenRules.Clear();
            Validate();

            return _brokenRules;
        }
    }
}