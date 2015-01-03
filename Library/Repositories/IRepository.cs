﻿using System;
using System.Linq;
using Library.DomainModel;

namespace Library.Repositories

{
    public interface IRepository<T> where T : Entity
    {
        T Get(Guid id);
        void Add(T entity);
        void Delete(T entity);
        IQueryable<T> AsQueryable();
    }
}
