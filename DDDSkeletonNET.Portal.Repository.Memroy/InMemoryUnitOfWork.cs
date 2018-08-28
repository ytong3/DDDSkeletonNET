﻿using System.Collections.Generic;
using System.Transactions;
using DDDSkeletonNET.Infrastructure.Common.Domain;
using DDDSkeletonNET.Portal.Repository.Memroy.UnitOfWork;

namespace DDDSkeletonNET.Portal.Repository.Memroy
{
    public class InMemoryUnitOfWork : IUnitOfWork
    {
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> _insertedAggregates;
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> _updatedAggregates;
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> _deletedAggregates;

        public InMemoryUnitOfWork()
        {
            _insertedAggregates = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            _updatedAggregates = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            _deletedAggregates = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
        }
        public void Commit()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (IAggregateRoot aggregateRoot in _insertedAggregates.Keys)
                {
                    _insertedAggregates[aggregateRoot].PersistInsertion(aggregateRoot);
                }

                foreach (IAggregateRoot aggregateRoot in _updatedAggregates.Keys)
                {
                    _updatedAggregates[aggregateRoot].PersistUpdate(aggregateRoot);
                }

                foreach (IAggregateRoot aggregateRoot in _deletedAggregates.Keys)
                {
                    _deletedAggregates[aggregateRoot].PersistDeletion(aggregateRoot);
                }

                scope.Complete();
            }

        }

        public void RegisterDeletion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository)
        {
            if (!_deletedAggregates.ContainsKey(aggregateRoot))
            {
                _deletedAggregates.Add(aggregateRoot, repository);
            }
        }

        public void RegisterInsertion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository)
        {
            if (!_insertedAggregates.ContainsKey(aggregateRoot))
            {
                _insertedAggregates.Add(aggregateRoot, repository);
            }
        }

        public void RegisterUpdate(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository)
        {
            if (!_updatedAggregates.ContainsKey(aggregateRoot))
            {
                _updatedAggregates.Add(aggregateRoot, repository);
            }
        }
    }
}